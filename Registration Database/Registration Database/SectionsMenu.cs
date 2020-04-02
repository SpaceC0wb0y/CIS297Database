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
        }

        private void BindSectionList()
        {

            sectionListBox.DataSource = RegistrationDatabase.Sections.ToList();
            sectionListBox.DisplayMember = "Id";
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
                    Id = Convert.ToInt32(idTextBox.Text),
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

                RegistrationDatabase.Faculties.Remove(selectedSection);

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
    }
}
