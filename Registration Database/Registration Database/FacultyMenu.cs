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

    public partial class FacultyMenu : Form {

        RegistrationDatabaseProjectEntities RegistrationDatabase;

        public FacultyMenu() {

            InitializeComponent();

            RegistrationDatabase = new RegistrationDatabaseProjectEntities();

            BindFacultyList();
        }

        private void BindFacultyList() {

            FacultyListBox.DataSource = RegistrationDatabase.Faculties.ToList();
            FacultyListBox.DisplayMember = "Name";
            FacultyListBox.ValueMember = "Id";
        }

        private void ClearFacultyFieldsButton_Click(object sender, EventArgs e) {

            facultyIDTextBox.Text = facultyNameTextBox.Text = facultyPhoneTextBox.Text = facultyOfficeTextBox.Text = "";
        }

        private void AddFacultyButton_Click(object sender, EventArgs e) {

            AddFaculty();
        }

        private void UpdateFacultyButton_Click(object sender, EventArgs e) {

            UpdateFaculty();
        }

        private void DeleteFacultyButton_Click(object sender, EventArgs e) {

            DeleteFaculty();
        }

        private void AddFaculty() {

            if (!String.IsNullOrEmpty(facultyNameTextBox.Text) 
                && !String.IsNullOrEmpty(facultyPhoneTextBox.Text) 
                && !String.IsNullOrEmpty(facultyOfficeTextBox.Text)) {

                Faculty newFaculty = new Faculty {

                    Name = facultyNameTextBox.Text,
                    Phone = facultyPhoneTextBox.Text,
                    Office = facultyOfficeTextBox.Text
                };

                RegistrationDatabase.Faculties.Add(newFaculty);

                try {

                    RegistrationDatabase.SaveChanges();
                }
                catch (DbUpdateException ex) {

                    MessageBox.Show(ex.Message);
                }

                BindFacultyList();
            }
        }

        private void UpdateFaculty() {

            if (!String.IsNullOrEmpty(facultyIDTextBox.Text) &&
                !String.IsNullOrWhiteSpace(facultyNameTextBox.Text) &&
                !String.IsNullOrWhiteSpace(facultyPhoneTextBox.Text) &&
                !String.IsNullOrWhiteSpace(facultyOfficeTextBox.Text)) {

                Faculty selectedFaculty = FacultyListBox.SelectedItem as Faculty;

                selectedFaculty.Name = facultyNameTextBox.Text;
                selectedFaculty.Phone = facultyPhoneTextBox.Text;
                selectedFaculty.Office = facultyOfficeTextBox.Text;

                try {

                    RegistrationDatabase.SaveChanges();
                }
                catch (DbUpdateException ex) {

                    MessageBox.Show(ex.Message);
                }

                BindFacultyList();
            }
        }

        private void DeleteFaculty() {

            if (!String.IsNullOrEmpty(facultyIDTextBox.Text)) {

                Faculty selectedFaculty = FacultyListBox.SelectedItem as Faculty;

                RegistrationDatabase.Faculties.Remove(selectedFaculty);

                try {

                    RegistrationDatabase.SaveChanges();
                }
                catch (DbUpdateException ex) {

                    MessageBox.Show(ex.Message);
                }

                BindFacultyList();
            }
        }

        private void FacultyListBox_SelectedIndexChanged(object sender, EventArgs e) {

            Faculty selectedFaculty = FacultyListBox.SelectedItem as Faculty;

            facultyIDTextBox.Text = selectedFaculty.Id.ToString();
            facultyNameTextBox.Text = selectedFaculty.Name;
            facultyPhoneTextBox.Text = selectedFaculty.Phone;
            facultyOfficeTextBox.Text = selectedFaculty.Office;
        }

        private void returnButton_Click(object sender, EventArgs e) {

            this.Close();
        }

        private void FacultyMenu_FormClosed(object sender, FormClosedEventArgs e) {

            Return();
        }

        private void Return() {

            MainMenu mainMenu = new MainMenu();

            mainMenu.Show();
        }
    }
}
