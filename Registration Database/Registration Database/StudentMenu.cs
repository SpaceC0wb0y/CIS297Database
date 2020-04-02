﻿using System;
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
    public partial class StudentMenu : Form {
        RegistrationDatabaseProjectEntities RegistrationDatabase;
        public StudentMenu() {
            InitializeComponent();

            RegistrationDatabase = new RegistrationDatabaseProjectEntities();

            BindStudentList();
        }

        private void BindStudentList()
        {

            studentListBox.DataSource = RegistrationDatabase.Students.ToList();
            studentListBox.DisplayMember = "Name";
        }

        private void AddStudent()
        {
            if (!String.IsNullOrEmpty(idTextBox.Text) && !String.IsNullOrEmpty(nameTextBox.Text))
            {

                Student newStudent = new Student
                {
                    Id = Convert.ToInt32(idTextBox.Text),
                    Name = nameTextBox.Text,
                };


                RegistrationDatabase.Students.Add(newStudent);

                try
                {

                    RegistrationDatabase.SaveChanges();
                }
                catch (DbUpdateException ex)
                {

                    MessageBox.Show(ex.Message);
                }

                BindStudentList();


            }


        }
        private void DeleteStudent()
        {

            if (!String.IsNullOrEmpty(idTextBox.Text))
            {

                Student selectedStudent = studentListBox.SelectedItem as Student;

                RegistrationDatabase.Students.Remove(selectedStudent);

                try
                {

                    RegistrationDatabase.SaveChanges();
                }
                catch (DbUpdateException ex)
                {

                    MessageBox.Show(ex.Message);
                }

                BindStudentList();
            }
        }

        private void UpdateStudent()
        {
            if (!String.IsNullOrEmpty(idTextBox.Text) && !String.IsNullOrEmpty(nameTextBox.Text))
            {

                Student selectedStudent = studentListBox.SelectedItem as Student;

                selectedStudent.Id = Convert.ToInt32(idTextBox.Text);
                selectedStudent.Name = nameTextBox.Text;

                try
                {

                    RegistrationDatabase.SaveChanges();
                }
                catch (DbUpdateException ex)
                {

                    MessageBox.Show(ex.Message);
                }

                BindStudentList();

            }


        }

        private void StudentMenu_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddStudent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteStudent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateStudent();
        }
    }
}
