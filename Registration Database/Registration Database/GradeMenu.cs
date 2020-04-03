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
    public partial class GradeMenu : Form
    {
        RegistrationDatabaseProjectEntities RegistrationDatabase;
        public GradeMenu()
        {
            InitializeComponent();

            RegistrationDatabase = new RegistrationDatabaseProjectEntities();

            BindGradeList();
        }
        private void BindGradeList()
        {

            gradeListBox.DataSource = RegistrationDatabase.Grades.ToList();
            gradeListBox.DisplayMember = "Id";
        }
        private void AddGrade()
        {
            if (!String.IsNullOrEmpty(idTextBox.Text) && !String.IsNullOrEmpty(sectionIDTextBox.Text))
            {

                Grade newGrade = new Grade
                {
                    Id = Convert.ToInt32(idTextBox.Text),
                    Section_Id = Convert.ToInt32(sectionIDTextBox.Text),
                    A_Grade = Convert.ToInt32(gradeCheckedListBox.GetItemChecked(0)),
                    Aminus_Grade = Convert.ToInt32(gradeCheckedListBox.GetItemChecked(1)),
                    Bplus_Grade = Convert.ToInt32(gradeCheckedListBox.GetItemChecked(2)),
                    B_Grade = Convert.ToInt32(gradeCheckedListBox.GetItemChecked(3)),
                    Bminus_Grade = Convert.ToInt32(gradeCheckedListBox.GetItemChecked(3)),
                    Cplus_Grade = Convert.ToInt32(gradeCheckedListBox.GetItemChecked(4)),
                    C_Grade = Convert.ToInt32(gradeCheckedListBox.GetItemChecked(5)),
                    Cminus_Grade = Convert.ToInt32(gradeCheckedListBox.GetItemChecked(6)),
                    F_Grade = Convert.ToInt32(gradeCheckedListBox.GetItemChecked(6))

                };


                RegistrationDatabase.Grades.Add(newGrade);

                try
                {

                    RegistrationDatabase.SaveChanges();
                }
                catch (DbUpdateException ex)
                {

                    MessageBox.Show(ex.Message);
                }

                BindGradeList();

            }


        }

        private void UpdateGrade()
        {
            if (!String.IsNullOrEmpty(idTextBox.Text) && !String.IsNullOrEmpty(sectionIDTextBox.Text))
            {
                Grade selectedGrade = gradeListBox.SelectedItem as Grade;
                selectedGrade.Section_Id = Convert.ToInt32(sectionIDTextBox.Text);
                selectedGrade.A_Grade = Convert.ToInt32(gradeCheckedListBox.GetItemChecked(0));
                selectedGrade.Aminus_Grade = Convert.ToInt32(gradeCheckedListBox.GetItemChecked(1));
                selectedGrade.Bplus_Grade = Convert.ToInt32(gradeCheckedListBox.GetItemChecked(2));
                selectedGrade.B_Grade = Convert.ToInt32(gradeCheckedListBox.GetItemChecked(3));
                selectedGrade.Bminus_Grade = Convert.ToInt32(gradeCheckedListBox.GetItemChecked(3));
                selectedGrade.Cplus_Grade = Convert.ToInt32(gradeCheckedListBox.GetItemChecked(4));
                selectedGrade.C_Grade = Convert.ToInt32(gradeCheckedListBox.GetItemChecked(5));
                selectedGrade.Cminus_Grade = Convert.ToInt32(gradeCheckedListBox.GetItemChecked(6));
                selectedGrade.F_Grade = Convert.ToInt32(gradeCheckedListBox.GetItemChecked(6));


                try
                {

                    RegistrationDatabase.SaveChanges();
                }
                catch (DbUpdateException ex)
                {

                    MessageBox.Show(ex.Message);
                }

                BindGradeList();
            }
        }

        private void DeleteGrade()
        {

            if (!String.IsNullOrEmpty(idTextBox.Text) && !String.IsNullOrEmpty(sectionIDTextBox.Text))
            {

                Grade selectedGrade = gradeListBox.SelectedItem as Grade;

                RegistrationDatabase.Grades.Remove(selectedGrade);

                try
                {

                    RegistrationDatabase.SaveChanges();
                }
                catch (DbUpdateException ex)
                {

                    MessageBox.Show(ex.Message);
                }

                BindGradeList();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddGrade();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteGrade();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateGrade();
        }
    }
}
