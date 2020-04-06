using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_Database {

    public partial class SectionsMenu : Form {

        RegistrationDatabaseProjectEntities RegistrationDatabase;

        public SectionsMenu() {

            InitializeComponent();

            RegistrationDatabase = new RegistrationDatabaseProjectEntities();

            BindSectionList();
            BindCourseList();
            BindFacultyList();
        }

        private void BindSectionList(string sectionSemesterFilter = "")
        {

            try {

                if (String.IsNullOrWhiteSpace(sectionSemesterFilter)) {

                    sectionListBox.DataSource = RegistrationDatabase.Sections.ToList();
                }
                else {

                    sectionListBox.DataSource = RegistrationDatabase.Sections.Where(s => s.Semester.StartsWith(sectionSemesterFilter)).ToList();
                }
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }

            sectionListBox.DisplayMember = "Number";
            sectionListBox.ValueMember = "Id";
        }

        private void BindFacultyList() {

            try {

                facultyListBox.DataSource = RegistrationDatabase.Faculties.ToList();
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }

            facultyListBox.DisplayMember = "Name";
            facultyListBox.ValueMember = "Id";
        }

        private void BindCourseList() {

            try {

                courseListBox.DataSource = RegistrationDatabase.Courses.ToList();
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }

            courseListBox.DisplayMember = "Name";
            courseListBox.ValueMember = "Id";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddSection();
        }

        private void AddSection()
        {
            if (!String.IsNullOrEmpty(facultyIDTextBox.Text) && !String.IsNullOrEmpty(numberTextBox.Text) && !String.IsNullOrEmpty(courseIDTextBox.Text))
            {
                
                Section newSection = new Section {

                    Number = Convert.ToInt32(numberTextBox.Text),
                    Course_Id = Convert.ToInt32(courseIDTextBox.Text),
                    Faculty_Id = Convert.ToInt32(facultyIDTextBox.Text),
                    Monday = daysBox.GetItemChecked(0),
                    Tuesday = daysBox.GetItemChecked(1),
                    Wednesday = daysBox.GetItemChecked(2),
                    Thursday = daysBox.GetItemChecked(3),
                    Friday = daysBox.GetItemChecked(4),
                    Time = timeTextBox.Text,
                    Semester = semesterTextBox.Text
                };


                RegistrationDatabase.Sections.Add(newSection);

                try
                {

                    RegistrationDatabase.SaveChanges();
                }
                catch (DbUpdateException ex)
                {

                    MessageBox.Show(ex.Message);
                }

                BindSectionList();
            }
        }

        private void DeleteSection()
        {

            if (!String.IsNullOrEmpty(facultyIDTextBox.Text))
            {

                Section selectedSection = sectionListBox.SelectedItem as Section;

                RegistrationDatabase.Sections.Remove(selectedSection);

                try
                {

                    RegistrationDatabase.SaveChanges();
                }
                catch (DbUpdateException ex)
                {

                    MessageBox.Show(ex.Message);
                }

                BindSectionList();
            }
        }

        private void UpdateSection()
        {
            if (!String.IsNullOrEmpty(facultyIDTextBox.Text) && !String.IsNullOrEmpty(numberTextBox.Text) && !String.IsNullOrEmpty(courseIDTextBox.Text))
            {

                Section selectedSection = sectionListBox.SelectedItem as Section;

                selectedSection.Number = Convert.ToInt32(numberTextBox.Text);
                selectedSection.Course_Id = Convert.ToInt32(courseIDTextBox.Text);
                selectedSection.Faculty_Id = Convert.ToInt32(facultyIDTextBox.Text);

                selectedSection.Monday = daysBox.GetItemChecked(0);
                selectedSection.Tuesday = daysBox.GetItemChecked(1);
                selectedSection.Wednesday = daysBox.GetItemChecked(2);
                selectedSection.Thursday = daysBox.GetItemChecked(3);
                selectedSection.Friday = daysBox.GetItemChecked(4);
                selectedSection.Time = timeTextBox.Text;
                selectedSection.Semester = semesterTextBox.Text;

                try
                {

                    RegistrationDatabase.SaveChanges();
                }
                catch (DbUpdateException ex)
                {

                    MessageBox.Show(ex.Message);
                }

                BindSectionList();

            }


        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateSection();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteSection();
        }

        private void courseListBox_SelectedIndexChanged(object sender, EventArgs e) {

            Course selectedCourse = courseListBox.SelectedItem as Course;

            courseIDTextBox.Text = selectedCourse.Id.ToString();
        }

        private void sectionListBox_SelectedIndexChanged(object sender, EventArgs e) {

            Section selectedSection = sectionListBox.SelectedItem as Section;

            idTextBox.Text = selectedSection.Id.ToString();
            courseIDTextBox.Text = selectedSection.Course_Id.ToString();
            facultyIDTextBox.Text = selectedSection.Faculty_Id.ToString();
            numberTextBox.Text = selectedSection.Number.ToString();

            semesterTextBox.Text = selectedSection.Semester;
            timeTextBox.Text = selectedSection.Time;

            daysBox.SetItemChecked(0, selectedSection.Monday);
            daysBox.SetItemChecked(1, selectedSection.Tuesday);
            daysBox.SetItemChecked(2, selectedSection.Wednesday);
            daysBox.SetItemChecked(3, selectedSection.Thursday);
            daysBox.SetItemChecked(4, selectedSection.Friday);
        }

        private void facultyListBox_SelectedIndexChanged(object sender, EventArgs e) {

            Faculty selectedFaculty = facultyListBox.SelectedItem as Faculty;

            facultyIDTextBox.Text = selectedFaculty.Id.ToString();
        }

        private void returnButton_Click(object sender, EventArgs e) {
            
            this.Close();
        }

        private void Return() {

            MainMenu mainMenu = new MainMenu();

            mainMenu.Show();
        }

        private void SectionsMenu_FormClosed(object sender, FormClosedEventArgs e) {

            Return();
        }

        private void sectionSemesterFilterTextBox_TextChanged(object sender, EventArgs e) {

            BindSectionList(sectionSemesterFilterTextBox.Text);
        }
    }
}
