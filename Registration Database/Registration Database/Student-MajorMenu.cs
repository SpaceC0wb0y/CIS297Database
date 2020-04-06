using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_Database {

    public partial class Student_MajorMenu : Form {

        RegistrationDatabaseProjectEntities RegistrationDatabase;

        public Student_MajorMenu() {

            InitializeComponent();

            RegistrationDatabase = new RegistrationDatabaseProjectEntities();

            BindStudentList();
            BindMajorList();
            BindDeclarationList();
        }

        private void AddDeclarationButton_Click(object sender, EventArgs e) {

            AddDeclaration();
        }

        private void DeleteDeclarationButton_Click(object sender, EventArgs e) {

            DeleteDeclaration();
        }

        private void AddDeclaration() {

            if (!String.IsNullOrWhiteSpace(majorIDTextBox.Text) 
                && !String.IsNullOrWhiteSpace(studentIDTextBox.Text)) {

                Student_Major newDeclaration = new Student_Major {

                    Major_Id = Convert.ToInt32(majorIDTextBox.Text),
                    Student_Id = Convert.ToInt32(studentIDTextBox.Text)
                };

                RegistrationDatabase.Student_Major.Add(newDeclaration);

                try {

                    RegistrationDatabase.SaveChanges();
                }
                catch (Exception ex) {

                    MessageBox.Show(ex.Message);
                }

                BindDeclarationList();
            }
        }

        private void DeleteDeclaration() {

            if (!String.IsNullOrWhiteSpace(declarationIDTextBox.Text)) {

                Student_Major selectedDeclaration = declarationListBox.SelectedItem as Student_Major;

                RegistrationDatabase.Student_Major.Remove(selectedDeclaration);

                try {

                    RegistrationDatabase.SaveChanges();
                }
                catch (Exception ex) {

                    MessageBox.Show(ex.Message);
                }

                BindDeclarationList();
            }
        }

        private void DeclarationListBox_SelectedIndexChanged(object sender, EventArgs e) {

            Student_Major selectedDeclaration = declarationListBox.SelectedItem as Student_Major;

            declarationIDTextBox.Text = selectedDeclaration.Id.ToString();
        }

        private void MajorListBox_SelectedIndexChanged(object sender, EventArgs e) {

            Major selecetedMajor = majorListBox.SelectedItem as Major;

            majorIDTextBox.Text = selecetedMajor.Id.ToString();
        }

        private void StudentListBox_SelectedIndexChanged(object sender, EventArgs e) {

            Student selectedStudent = studentListBox.SelectedItem as Student;

            studentIDTextBox.Text = selectedStudent.Id.ToString();
        }
        
        private void BindStudentList() {

            try {

                studentListBox.DataSource = RegistrationDatabase.Students.ToList();
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }

            studentListBox.DisplayMember = "Name";
            studentListBox.ValueMember = "Id";
        }

        private void BindMajorList() {

            try {

                majorListBox.DataSource = RegistrationDatabase.Majors.ToList();
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }

            majorListBox.DisplayMember = "Name";
            majorListBox.ValueMember = "Id";
        }

        private void BindDeclarationList() {

            try {

                declarationListBox.DataSource = RegistrationDatabase.Student_Major.ToList();
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }

            declarationListBox.DisplayMember = "Id";
            declarationListBox.ValueMember = "Id";
        }

        private void ReturnButton_Click(object sender, EventArgs e) {

            this.Close();
        }

        private void Return() {

            MainMenu menu = new MainMenu();

            menu.Show();
        }

        private void Student_MajorMenu_FormClosed(object sender, FormClosedEventArgs e) {

            Return();
        }
    }
}
