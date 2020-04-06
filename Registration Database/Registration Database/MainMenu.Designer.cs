namespace Registration_Database {
    partial class MainMenu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.coursesButton = new System.Windows.Forms.Button();
            this.sectionsButton = new System.Windows.Forms.Button();
            this.facultyButton = new System.Windows.Forms.Button();
            this.studentsButton = new System.Windows.Forms.Button();
            this.majorsButton = new System.Windows.Forms.Button();
            this.EnrollmentButton = new System.Windows.Forms.Button();
            this.gradesButton = new System.Windows.Forms.Button();
            this.majorDeclarationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coursesButton
            // 
            this.coursesButton.Location = new System.Drawing.Point(71, 32);
            this.coursesButton.Name = "coursesButton";
            this.coursesButton.Size = new System.Drawing.Size(117, 36);
            this.coursesButton.TabIndex = 0;
            this.coursesButton.Text = "Courses";
            this.coursesButton.UseVisualStyleBackColor = true;
            this.coursesButton.Click += new System.EventHandler(this.CoursesButton_Click);
            // 
            // sectionsButton
            // 
            this.sectionsButton.Location = new System.Drawing.Point(71, 74);
            this.sectionsButton.Name = "sectionsButton";
            this.sectionsButton.Size = new System.Drawing.Size(117, 36);
            this.sectionsButton.TabIndex = 1;
            this.sectionsButton.Text = "Sections";
            this.sectionsButton.UseVisualStyleBackColor = true;
            this.sectionsButton.Click += new System.EventHandler(this.SectionsButton_Click);
            // 
            // facultyButton
            // 
            this.facultyButton.Location = new System.Drawing.Point(71, 116);
            this.facultyButton.Name = "facultyButton";
            this.facultyButton.Size = new System.Drawing.Size(117, 36);
            this.facultyButton.TabIndex = 2;
            this.facultyButton.Text = "Faculty";
            this.facultyButton.UseVisualStyleBackColor = true;
            this.facultyButton.Click += new System.EventHandler(this.FacultyButton_Click);
            // 
            // studentsButton
            // 
            this.studentsButton.Location = new System.Drawing.Point(71, 158);
            this.studentsButton.Name = "studentsButton";
            this.studentsButton.Size = new System.Drawing.Size(117, 36);
            this.studentsButton.TabIndex = 3;
            this.studentsButton.Text = "Students";
            this.studentsButton.UseVisualStyleBackColor = true;
            this.studentsButton.Click += new System.EventHandler(this.StudentsButton_Click);
            // 
            // majorsButton
            // 
            this.majorsButton.Location = new System.Drawing.Point(71, 200);
            this.majorsButton.Name = "majorsButton";
            this.majorsButton.Size = new System.Drawing.Size(117, 36);
            this.majorsButton.TabIndex = 4;
            this.majorsButton.Text = "Majors";
            this.majorsButton.UseVisualStyleBackColor = true;
            this.majorsButton.Click += new System.EventHandler(this.MajorsButton_Click);
            // 
            // EnrollmentButton
            // 
            this.EnrollmentButton.Location = new System.Drawing.Point(71, 242);
            this.EnrollmentButton.Name = "EnrollmentButton";
            this.EnrollmentButton.Size = new System.Drawing.Size(117, 36);
            this.EnrollmentButton.TabIndex = 5;
            this.EnrollmentButton.Text = "Enrollment";
            this.EnrollmentButton.UseVisualStyleBackColor = true;
            this.EnrollmentButton.Click += new System.EventHandler(this.EnrollmentButton_Click);
            // 
            // gradesButton
            // 
            this.gradesButton.Location = new System.Drawing.Point(71, 284);
            this.gradesButton.Name = "gradesButton";
            this.gradesButton.Size = new System.Drawing.Size(117, 36);
            this.gradesButton.TabIndex = 6;
            this.gradesButton.Text = "Grades";
            this.gradesButton.UseVisualStyleBackColor = true;
            this.gradesButton.Click += new System.EventHandler(this.GradesButton_Click);
            // 
            // majorDeclarationButton
            // 
            this.majorDeclarationButton.Location = new System.Drawing.Point(71, 326);
            this.majorDeclarationButton.Name = "majorDeclarationButton";
            this.majorDeclarationButton.Size = new System.Drawing.Size(117, 36);
            this.majorDeclarationButton.TabIndex = 7;
            this.majorDeclarationButton.Text = "Major Declaration";
            this.majorDeclarationButton.UseVisualStyleBackColor = true;
            this.majorDeclarationButton.Click += new System.EventHandler(this.majorDeclarationButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 404);
            this.Controls.Add(this.majorDeclarationButton);
            this.Controls.Add(this.gradesButton);
            this.Controls.Add(this.EnrollmentButton);
            this.Controls.Add(this.majorsButton);
            this.Controls.Add(this.studentsButton);
            this.Controls.Add(this.facultyButton);
            this.Controls.Add(this.sectionsButton);
            this.Controls.Add(this.coursesButton);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button coursesButton;
        private System.Windows.Forms.Button sectionsButton;
        private System.Windows.Forms.Button facultyButton;
        private System.Windows.Forms.Button studentsButton;
        private System.Windows.Forms.Button majorsButton;
        private System.Windows.Forms.Button EnrollmentButton;
        private System.Windows.Forms.Button gradesButton;
        private System.Windows.Forms.Button majorDeclarationButton;
    }
}