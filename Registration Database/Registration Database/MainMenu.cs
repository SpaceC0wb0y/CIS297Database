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

        private void MainMenu_Enter(object sender, EventArgs e) {

            BindCourseList();
        }

        private void BindCourseList() {

            try {
                CourseListBox.DataSource = RegistrationDatabase.Courses.ToList();
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
            
            CourseListBox.DisplayMember = "Name";
            CourseListBox.ValueMember = "Id";
        }

        private void AddCourseButton_Click(object sender, EventArgs e) {

            AddingCourse();
        }

        private void UpdateCourseButton_Click(object sender, EventArgs e) {

            UpdatingCourse();
        }

        private void DeleteCourseButton_Click(object sender, EventArgs e) {

            DeleteCourse();
        }

        private void ClearCourseFieldsButton_Click(object sender, EventArgs e) {

            courseIdTextBox.Text = courseDepartmentTextBox.Text = courseNumberTextBox.Text = courseNameTextBox.Text = courseCreditsTextBox.Text = "";
        }

        private void DeleteCourse() {

            if (!String.IsNullOrEmpty(courseIdTextBox.Text)) {

                Course selectedcourse = CourseListBox.SelectedItem as Course;

                RegistrationDatabase.Courses.Remove(selectedcourse);

                try {

                    RegistrationDatabase.SaveChanges();
                }
                catch (DbUpdateException ex) {

                    MessageBox.Show(ex.ToString());
                }

                BindCourseList();
            }
        }

        private void UpdatingCourse() {

            if (!String.IsNullOrEmpty(courseIdTextBox.Text)) {

                Course selectedcourse = CourseListBox.SelectedItem as Course;

                selectedcourse.Department = courseDepartmentTextBox.Text;
                selectedcourse.Number = courseNumberTextBox.Text;
                selectedcourse.Name = courseNameTextBox.Text;
                selectedcourse.Credits = Convert.ToInt32(courseCreditsTextBox.Text);

                try {

                    RegistrationDatabase.SaveChanges();
                }
                catch (DbUpdateException ex) {

                    MessageBox.Show(ex.ToString());
                }

                BindCourseList();
            }
        }

        private void AddingCourse() {

            if (!String.IsNullOrWhiteSpace(courseDepartmentTextBox.Text) &&
                !String.IsNullOrWhiteSpace(courseNumberTextBox.Text) &&
                !String.IsNullOrWhiteSpace(courseNameTextBox.Text) &&
                !String.IsNullOrWhiteSpace(courseCreditsTextBox.Text)) {

                Course newCourse = new Course {

                    Department = courseDepartmentTextBox.Text,
                    Number = courseNumberTextBox.Text,
                    Name = courseNameTextBox.Text
                };

                try {

                    newCourse.Credits = Convert.ToInt32(courseCreditsTextBox.Text);
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
        }

        private void CourseListBox_SelectedIndexChanged(object sender, EventArgs e) {

            Course selectedCourse = CourseListBox.SelectedItem as Course;

            courseIdTextBox.Text = selectedCourse.Id.ToString();
            courseDepartmentTextBox.Text = selectedCourse.Department;
            courseNumberTextBox.Text = selectedCourse.Number;
            courseNameTextBox.Text = selectedCourse.Name;
            courseCreditsTextBox.Text = selectedCourse.Credits.ToString();
        }
    }
}
