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

    public partial class GradeMenu : Form {

        RegistrationDatabaseProjectEntities RegistrationDatabase;

        public GradeMenu() {

            InitializeComponent();

            RegistrationDatabase = new RegistrationDatabaseProjectEntities();

            BindSectionList();
        }

        private void BindGradeList(int givenSectionId) {

            gradeListBox.DataSource = RegistrationDatabase.Grades.Where(s => s.Section_Id.Equals(givenSectionId)).ToList();
            gradeListBox.DisplayMember = "Section_Id";
            gradeListBox.ValueMember = "Id";
        }

        private void BindSectionList() {

            sectionListBox.DataSource = RegistrationDatabase.Sections.ToList();
            sectionListBox.DisplayMember = "Number";
            sectionListBox.ValueMember = "Id";
        }

        private void AddGrade() {

            if (!String.IsNullOrEmpty(sectionIDTextBox.Text)) {

                Grade newGrade = new Grade {

                    Section_Id = Convert.ToInt32(sectionIDTextBox.Text),
                    A_Grade = Convert.ToInt32(ATextBox.Text),
                    Aminus_Grade = Convert.ToInt32(AMinusTextBox.Text),
                    Bplus_Grade = Convert.ToInt32(BPlusTextBox.Text),
                    B_Grade = Convert.ToInt32(BTextBox.Text),
                    Bminus_Grade = Convert.ToInt32(BMinusTextBox.Text),
                    Cplus_Grade = Convert.ToInt32(CPlusTextBox.Text),
                    C_Grade = Convert.ToInt32(CTextBox.Text),
                    Cminus_Grade = Convert.ToInt32(CMinusTextBox.Text),
                    F_Grade = Convert.ToInt32(FTextBox.Text)
                };

                RegistrationDatabase.Grades.Add(newGrade);

                try {

                    RegistrationDatabase.SaveChanges();
                }
                catch (Exception ex) {

                    MessageBox.Show(ex.ToString());
                }

                BindGradeList(Convert.ToInt32(sectionIDTextBox.Text));
            }
        }

        private void UpdateGrade() {

            if (!String.IsNullOrEmpty(idTextBox.Text) &&
                !String.IsNullOrEmpty(sectionIDTextBox.Text)) {

                Grade selectedGrade = gradeListBox.SelectedItem as Grade;

                try {

                    selectedGrade.A_Grade = Convert.ToInt32(ATextBox.Text);
                    selectedGrade.Aminus_Grade = Convert.ToInt32(AMinusTextBox.Text);
                    selectedGrade.Bplus_Grade = Convert.ToInt32(BPlusTextBox.Text);
                    selectedGrade.B_Grade = Convert.ToInt32(BTextBox.Text);
                    selectedGrade.Bminus_Grade = Convert.ToInt32(BMinusTextBox.Text);
                    selectedGrade.Cplus_Grade = Convert.ToInt32(CPlusTextBox.Text);
                    selectedGrade.C_Grade = Convert.ToInt32(CTextBox.Text);
                    selectedGrade.Cminus_Grade = Convert.ToInt32(CMinusTextBox.Text);
                    selectedGrade.F_Grade = Convert.ToInt32(FTextBox.Text);
                }
                catch (Exception ex) {

                    MessageBox.Show(ex.Message);
                }
                
                try {

                    RegistrationDatabase.SaveChanges();
                }
                catch (DbUpdateException ex) {

                    MessageBox.Show(ex.Message);
                }

                BindGradeList(Convert.ToInt32(sectionIDTextBox.Text));
            }
        }

        private void DeleteGrade() {

            if (!String.IsNullOrEmpty(idTextBox.Text) && !String.IsNullOrEmpty(sectionIDTextBox.Text)) {

                Grade selectedGrade = gradeListBox.SelectedItem as Grade;

                RegistrationDatabase.Grades.Remove(selectedGrade);

                try {

                    RegistrationDatabase.SaveChanges();
                }
                catch (DbUpdateException ex) {

                    MessageBox.Show(ex.Message);
                }

                BindGradeList(Convert.ToInt32(sectionIDTextBox.Text));
            }
        }

        private void AddButton_Click(object sender, EventArgs e) {

            AddGrade();
        }

        private void DeleteButton_Click(object sender, EventArgs e) {

            DeleteGrade();
        }

        private void UpdateButton_Click(object sender, EventArgs e) {

            UpdateGrade();
        }

        private void sectionListBox_SelectedIndexChanged(object sender, EventArgs e) {

            Section selectedSection = sectionListBox.SelectedItem as Section;

            sectionIDTextBox.Text = selectedSection.Id.ToString();

            BindGradeList(selectedSection.Id);
        }

        private void gradeListBox_SelectedIndexChanged(object sender, EventArgs e) {

            Grade selectedGrade = gradeListBox.SelectedItem as Grade;

            idTextBox.Text = selectedGrade.Id.ToString();

            ATextBox.Text = selectedGrade.A_Grade.ToString();
            AMinusTextBox.Text = selectedGrade.Aminus_Grade.ToString();
            BPlusTextBox.Text = selectedGrade.Bplus_Grade.ToString();
            BTextBox.Text = selectedGrade.B_Grade.ToString();
            BMinusTextBox.Text = selectedGrade.Bminus_Grade.ToString();
            CPlusTextBox.Text = selectedGrade.Cplus_Grade.ToString();
            CTextBox.Text = selectedGrade.C_Grade.ToString();
            CMinusTextBox.Text = selectedGrade.Cminus_Grade.ToString();
            FTextBox.Text = selectedGrade.F_Grade.ToString();
        }

        private void returnButton_Click(object sender, EventArgs e) {

            this.Close();
        }

        private void GradeMenu_FormClosed(object sender, FormClosedEventArgs e) {

            Return();
        }

        private static void Return() {

            MainMenu mainMenu = new MainMenu();

            mainMenu.Show();
        }
    }
}
