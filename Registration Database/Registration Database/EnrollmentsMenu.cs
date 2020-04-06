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

namespace Registration_Database
{
    public partial class EnrollmentsMenu : Form
    {
        RegistrationDatabaseProjectEntities RegistrationDatabase;
        public EnrollmentsMenu()
        {
            InitializeComponent();

            RegistrationDatabase = new RegistrationDatabaseProjectEntities();

            BindEnrollmentsList();
            BindStudentList();
            BindSectionList();
        }

        private void BindEnrollmentsList(string enrollmentStudentFilter = "")
        {

            try {

                if (String.IsNullOrWhiteSpace(enrollmentStudentFilter)) {

                    enrollmentsListBox.DataSource = RegistrationDatabase.Enrollments.ToList();
                }
                else {
                    enrollmentsListBox.DataSource = RegistrationDatabase.Enrollments.Where(s => s.Student.Name.StartsWith(enrollmentStudentFilter)).ToList();
                }
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }

            enrollmentsListBox.DisplayMember = "Id";
            enrollmentsListBox.ValueMember = "Id";
        }

        private void BindStudentList() {

            studentListBox.DataSource = RegistrationDatabase.Students.ToList();
            studentListBox.DisplayMember = "Name";
            studentListBox.ValueMember = "Id";
        }

        private void BindSectionList() {

            sectionListBox.DataSource = RegistrationDatabase.Sections.ToList();
            sectionListBox.DisplayMember = "Id";
            sectionListBox.ValueMember = "Id";
        }

        private void AddEnrollment()
        {
            if (!String.IsNullOrEmpty(sectionIDTextBox.Text) && !String.IsNullOrEmpty(studentIDTextBox.Text))
            {

                Enrollment newEnrollment = new Enrollment
                {
                    Section_Id = Convert.ToInt32(sectionIDTextBox.Text),
                    Student_Id = Convert.ToInt32(studentIDTextBox.Text)

                };

                RegistrationDatabase.Enrollments.Add(newEnrollment);

                try
                {

                    RegistrationDatabase.SaveChanges();
                }
                catch (DbUpdateException ex)
                {

                    MessageBox.Show(ex.Message);
                }

                BindEnrollmentsList();
            }
        }

        private void UpdateEnrollment()
        {
            if (!String.IsNullOrEmpty(idTextBox.Text) && !String.IsNullOrEmpty(sectionIDTextBox.Text) && !String.IsNullOrEmpty(studentIDTextBox.Text))
            {
                Enrollment selectedEnrollment = enrollmentsListBox.SelectedItem as Enrollment;
                selectedEnrollment.Section_Id = Convert.ToInt32(sectionIDTextBox.Text);
                selectedEnrollment.Student_Id = Convert.ToInt32(sectionIDTextBox.Text);

                try
                {

                    RegistrationDatabase.SaveChanges();
                }
                catch (DbUpdateException ex)
                {

                    MessageBox.Show(ex.Message);
                }

                BindEnrollmentsList();
            }
        }

        private void DeleteEnrollment()
        {

            if (!String.IsNullOrEmpty(idTextBox.Text) && !String.IsNullOrEmpty(sectionIDTextBox.Text) && !String.IsNullOrEmpty(studentIDTextBox.Text))
            {

                Enrollment selectedEnrollment = enrollmentsListBox.SelectedItem as Enrollment;

                RegistrationDatabase.Enrollments.Remove(selectedEnrollment);

                try
                {

                    RegistrationDatabase.SaveChanges();
                }
                catch (DbUpdateException ex)
                {

                    MessageBox.Show(ex.Message);
                }

                BindEnrollmentsList();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddEnrollment();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateEnrollment();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteEnrollment();
        }

        private void enrollmentsListBox_SelectedIndexChanged(object sender, EventArgs e) {

            Enrollment selectedEnrollment = enrollmentsListBox.SelectedItem as Enrollment;

            idTextBox.Text = selectedEnrollment.Id.ToString();
            sectionIDTextBox.Text = selectedEnrollment.Section_Id.ToString();
            studentIDTextBox.Text = selectedEnrollment.Student_Id.ToString();
        }

        private void sectionListBox_SelectedIndexChanged(object sender, EventArgs e) {

            Section selectedSection = sectionListBox.SelectedItem as Section;

            sectionIDTextBox.Text = selectedSection.Id.ToString();
        }

        private void studentListBox_SelectedIndexChanged(object sender, EventArgs e) {
            
            Student selectedSudent = studentListBox.SelectedItem as Student;

            studentIDTextBox.Text = selectedSudent.Id.ToString();
        }

        private void returnButton_Click(object sender, EventArgs e) {

            this.Close();
        }

        private void EnrollmentsMenu_FormClosed(object sender, FormClosedEventArgs e) {

            Return();
        }

        private void Return() {
            
            MainMenu mainMenu = new MainMenu();

            mainMenu.Show();
        }

        private void EnrollmentStudentFilterTextBox_TextChanged(object sender, EventArgs e) {

            BindEnrollmentsList(enrollmentStudentFilterTextBox.Text);
        }
    }
}
