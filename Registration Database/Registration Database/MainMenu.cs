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

    public partial class MainMenu : Form {

        RegistrationDatabaseProjectEntities RegistrationDatabase;

        public MainMenu() {

            InitializeComponent();

            RegistrationDatabase = new RegistrationDatabaseProjectEntities();

            BindCourseList();
        }

        private void BindCourseList() {

            CourseListBox.DataSource = RegistrationDatabase.Courses.ToList();
            CourseListBox.DisplayMember = "Name";
            CourseListBox.ValueMember = "Id";
        }

        private void AddCourseButton_Click(object sender, EventArgs e) {

            AddingACourse();
        }

        private void AddingACourse() {

            Course newCourse = new Course {

                Department = DepartmentTextBox.Text,
                Number = NumberTextBox.Text,
                Name = NameTextBox.Text
            };

            try {

                newCourse.Credits = Convert.ToInt32(CreditsTextBox.Text);
            }
            catch (Exception) {

                MessageBox.Show("Course Credits Input is INVALID\nMust be number!!");
            }

            RegistrationDatabase.Courses.Add(newCourse);

            try {

                RegistrationDatabase.SaveChanges();
            }
            catch (DbUpdateException ex) {

                MessageBox.Show(ex.ToString());
            }

            BindCourseList();
        }

        private void CourseListBox_SelectedIndexChanged(object sender, EventArgs e) {

            Course selectedcourse = CourseListBox.SelectedItem as Course;
            SelectedCourselabel.Text = $"Department: {selectedcourse.Department} \n" +
                $"Number: {selectedcourse.Number}\n" +
                $"Name: {selectedcourse.Name}\n" +
                $"Credits: {selectedcourse.Credits}";
        }

        private void MainMenu_Enter(object sender, EventArgs e) {

            BindCourseList();
        }
    }
}
