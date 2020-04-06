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

    public partial class MajorMenu : Form {

        RegistrationDatabaseProjectEntities RegistrationDatabase;

        public MajorMenu() {

            InitializeComponent();

            RegistrationDatabase = new RegistrationDatabaseProjectEntities();

            BindMajorList();
        }

        private void BindMajorList() {

            MajorListBox.DataSource = RegistrationDatabase.Majors.ToList();
            MajorListBox.DisplayMember = "Name";
            MajorListBox.ValueMember = "Id";
        }

        private void ClearMajorFieldsButton_Click(object sender, EventArgs e) {

            majorIDTextBox.Text = majorNameTextBox.Text = "";
        }

        private void AddMajorButton_Click(object sender, EventArgs e) {

            AddMajor();
        }

        private void UpdateMajorButton_Click(object sender, EventArgs e) {

            UpdateMajor();
        }

        private void DeleteMajorButton_Click(object sender, EventArgs e) {

            DeleteMajor();
        }

        private void AddMajor() {

            if (!String.IsNullOrEmpty(majorNameTextBox.Text)) {

                Major newMajor = new Major {

                    Name = majorNameTextBox.Text
                };

                RegistrationDatabase.Majors.Add(newMajor);

                try {

                    RegistrationDatabase.SaveChanges();
                }
                catch (DbUpdateException ex) {

                    MessageBox.Show(ex.Message);
                }

                BindMajorList();
            }
        }

        private void UpdateMajor() {

            if (!String.IsNullOrEmpty(majorIDTextBox.Text)) {

                Major selectedMajor = MajorListBox.SelectedItem as Major;

                selectedMajor.Name = majorNameTextBox.Text;

                try {

                    RegistrationDatabase.SaveChanges();
                }
                catch (DbUpdateException ex) {

                    MessageBox.Show(ex.ToString());
                }

                BindMajorList();
            }
        }

        private void DeleteMajor() {

            if (!String.IsNullOrEmpty(majorIDTextBox.Text)) {

                Major selectedMajor = MajorListBox.SelectedItem as Major;

                RegistrationDatabase.Majors.Remove(selectedMajor);

                try {

                    RegistrationDatabase.SaveChanges();
                }
                catch (DbUpdateException ex) {

                    MessageBox.Show(ex.ToString());
                }

                BindMajorList();
            }
        }

        private void MajorListBox_SelectedIndexChanged(object sender, EventArgs e) {

            Major selectedMajor = MajorListBox.SelectedItem as Major;

            majorIDTextBox.Text = selectedMajor.Id.ToString();
            majorNameTextBox.Text = selectedMajor.Name;
        }

        private void returnButton_Click(object sender, EventArgs e) {

            this.Close();
        }

        private void MajorMenu_FormClosed(object sender, FormClosedEventArgs e) {

            Return();
        }

        private static void Return() {

            MainMenu mainMenu = new MainMenu();

            mainMenu.Show();
        }
    }
}
