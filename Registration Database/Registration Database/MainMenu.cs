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

            UpdateCourseList();

            CourseListBox.DataSource = RegistrationDatabase.Courses.ToList();
            CourseListBox.DisplayMember = "Name";
            CourseListBox.ValueMember = "Id";
        }

        private void UpdateCourseList() {

            CoursesLabel.Text = $"Courses: {Environment.NewLine}";
            foreach (var course in RegistrationDatabase.Courses) {

                CoursesLabel.Text += $"{course.Department} {course.Number} {Environment.NewLine}";
            }
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
            UpdateCourseList();
            CourseListBox.Update();
        }

        private void CourseListBox_SelectedIndexChanged(object sender, EventArgs e) {

            Course selectedcourse = CourseListBox.SelectedItem as Course;
            SelectedCourselabel.Text = $"{selectedcourse.Department} {selectedcourse.Number} {selectedcourse.Name} {selectedcourse.Credits}";
        }
    }
}
