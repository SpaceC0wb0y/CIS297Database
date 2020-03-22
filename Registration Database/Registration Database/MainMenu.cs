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

            CourseListBox.DataSource = RegistrationDatabase.Courses.ToList();
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

        private void ClearFeildsButton_Click(object sender, EventArgs e) {

            IdTextBox.Text = DepartmentTextBox.Text = NumberTextBox.Text = NameTextBox.Text = CreditsTextBox.Text = "";
        }

        private void DeleteCourse() {

            if (!String.IsNullOrEmpty(IdTextBox.Text)) {

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

            if (!String.IsNullOrEmpty(IdTextBox.Text)) {

                Course selectedcourse = CourseListBox.SelectedItem as Course;

                selectedcourse.Department = DepartmentTextBox.Text;
                selectedcourse.Number = NumberTextBox.Text;
                selectedcourse.Name = NameTextBox.Text;
                selectedcourse.Credits = Convert.ToInt32(CreditsTextBox.Text);

                BindCourseList();
            }
        }

        private void AddingCourse() {

            if (!String.IsNullOrEmpty(DepartmentTextBox.Text) &&
                !String.IsNullOrEmpty(NumberTextBox.Text) &&
                !String.IsNullOrEmpty(NameTextBox.Text) &&
                !String.IsNullOrEmpty(CreditsTextBox.Text)) {

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
        }

        private void CourseListBox_SelectedIndexChanged(object sender, EventArgs e) {

            Course selectedCourse = CourseListBox.SelectedItem as Course;

            IdTextBox.Text = selectedCourse.Id.ToString();
            DepartmentTextBox.Text = selectedCourse.Department;
            NumberTextBox.Text = selectedCourse.Number;
            NameTextBox.Text = selectedCourse.Name;
            CreditsTextBox.Text = selectedCourse.Credits.ToString();
        }
    }
}
