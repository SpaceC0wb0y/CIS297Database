using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_Database {

    public partial class MainMenu : Form {

        public MainMenu() {

            InitializeComponent();
        }

        private void CoursesButton_Click(object sender, EventArgs e) {

            this.Hide();

            CourseMenu coursesMenu = new CourseMenu();
            
            coursesMenu.Show();
        }

        private void SectionsButton_Click(object sender, EventArgs e) {

            this.Hide();

            SectionsMenu sectionMenu = new SectionsMenu();
            
            sectionMenu.Show();
        }

        private void FacultyButton_Click(object sender, EventArgs e) {

            this.Hide();

            FacultyMenu facultyMenu = new FacultyMenu();
            
            facultyMenu.Show();
        }

        private void StudentsButton_Click(object sender, EventArgs e) {

            this.Hide();

            StudentMenu studentMenu = new StudentMenu();
            
            studentMenu.Show();
        }

        private void MajorsButton_Click(object sender, EventArgs e) {

            this.Hide();

            MajorMenu majorMenu = new MajorMenu();
            
            majorMenu.Show();
        }

        private void EnrollmentButton_Click(object sender, EventArgs e) {

            this.Hide();

            EnrollmentsMenu enrollmentMenu = new EnrollmentsMenu();
            
            enrollmentMenu.Show();
        }

        private void GradesButton_Click(object sender, EventArgs e) {

            this.Hide();

            GradeMenu gradeMenu = new GradeMenu();
            
            gradeMenu.Show();
        }

        private void majorDeclarationButton_Click(object sender, EventArgs e) {

            this.Hide();

            Student_MajorMenu studentMajorMenu = new Student_MajorMenu();

            studentMajorMenu.Show();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e) {

            if (System.Windows.Forms.Application.MessageLoop) {

                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else {

                // Console app
                System.Environment.Exit(1);
            }
        }
    }
}
