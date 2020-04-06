namespace Registration_Database {
    partial class SectionsMenu {
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
            this.daysBox = new System.Windows.Forms.CheckedListBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.courseIDTextBox = new System.Windows.Forms.TextBox();
            this.facultyIDTextBox = new System.Windows.Forms.TextBox();
            this.facultyID = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.semesterTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sectionListBox = new System.Windows.Forms.ListBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.courseListBox = new System.Windows.Forms.ListBox();
            this.facultyListBox = new System.Windows.Forms.ListBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.sectionSemesterFilterTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // daysBox
            // 
            this.daysBox.FormattingEnabled = true;
            this.daysBox.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.daysBox.Location = new System.Drawing.Point(51, 165);
            this.daysBox.Name = "daysBox";
            this.daysBox.Size = new System.Drawing.Size(120, 79);
            this.daysBox.TabIndex = 0;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(92, 117);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course ID";
            // 
            // courseIDTextBox
            // 
            this.courseIDTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.courseIDTextBox.Location = new System.Drawing.Point(91, 54);
            this.courseIDTextBox.Name = "courseIDTextBox";
            this.courseIDTextBox.ReadOnly = true;
            this.courseIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.courseIDTextBox.TabIndex = 4;
            // 
            // facultyIDTextBox
            // 
            this.facultyIDTextBox.Location = new System.Drawing.Point(92, 84);
            this.facultyIDTextBox.Name = "facultyIDTextBox";
            this.facultyIDTextBox.ReadOnly = true;
            this.facultyIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.facultyIDTextBox.TabIndex = 5;
            // 
            // facultyID
            // 
            this.facultyID.AutoSize = true;
            this.facultyID.Location = new System.Drawing.Point(15, 87);
            this.facultyID.Name = "facultyID";
            this.facultyID.Size = new System.Drawing.Size(55, 13);
            this.facultyID.TabIndex = 6;
            this.facultyID.Text = "Faculty ID";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(453, 314);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.idTextBox.Location = new System.Drawing.Point(92, 21);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(14, 24);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 9;
            this.ID.Text = "ID";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(92, 272);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(100, 20);
            this.timeTextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Time";
            // 
            // semesterTextBox
            // 
            this.semesterTextBox.Location = new System.Drawing.Point(92, 307);
            this.semesterTextBox.Name = "semesterTextBox";
            this.semesterTextBox.Size = new System.Drawing.Size(100, 20);
            this.semesterTextBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Semester";
            // 
            // sectionListBox
            // 
            this.sectionListBox.FormattingEnabled = true;
            this.sectionListBox.Location = new System.Drawing.Point(445, 61);
            this.sectionListBox.Name = "sectionListBox";
            this.sectionListBox.Size = new System.Drawing.Size(146, 199);
            this.sectionListBox.TabIndex = 14;
            this.sectionListBox.SelectedIndexChanged += new System.EventHandler(this.sectionListBox_SelectedIndexChanged);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(534, 314);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 15;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(615, 313);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // courseListBox
            // 
            this.courseListBox.FormattingEnabled = true;
            this.courseListBox.Location = new System.Drawing.Point(270, 61);
            this.courseListBox.Name = "courseListBox";
            this.courseListBox.Size = new System.Drawing.Size(146, 199);
            this.courseListBox.TabIndex = 17;
            this.courseListBox.SelectedIndexChanged += new System.EventHandler(this.courseListBox_SelectedIndexChanged);
            // 
            // facultyListBox
            // 
            this.facultyListBox.FormattingEnabled = true;
            this.facultyListBox.Location = new System.Drawing.Point(625, 61);
            this.facultyListBox.Name = "facultyListBox";
            this.facultyListBox.Size = new System.Drawing.Size(146, 199);
            this.facultyListBox.TabIndex = 18;
            this.facultyListBox.SelectedIndexChanged += new System.EventHandler(this.facultyListBox_SelectedIndexChanged);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(696, 314);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 19;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // sectionSemesterFilterTextBox
            // 
            this.sectionSemesterFilterTextBox.Location = new System.Drawing.Point(270, 293);
            this.sectionSemesterFilterTextBox.Name = "sectionSemesterFilterTextBox";
            this.sectionSemesterFilterTextBox.Size = new System.Drawing.Size(146, 20);
            this.sectionSemesterFilterTextBox.TabIndex = 20;
            this.sectionSemesterFilterTextBox.TextChanged += new System.EventHandler(this.sectionSemesterFilterTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Filter By Semester";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Course";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(442, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Section";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(622, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Faculty";
            // 
            // SectionsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 376);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sectionSemesterFilterTextBox);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.facultyListBox);
            this.Controls.Add(this.courseListBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.sectionListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.semesterTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.facultyID);
            this.Controls.Add(this.facultyIDTextBox);
            this.Controls.Add(this.courseIDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.daysBox);
            this.Name = "SectionsMenu";
            this.Text = "SectionsMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SectionsMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox daysBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox courseIDTextBox;
        private System.Windows.Forms.TextBox facultyIDTextBox;
        private System.Windows.Forms.Label facultyID;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox semesterTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox sectionListBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListBox courseListBox;
        private System.Windows.Forms.ListBox facultyListBox;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.TextBox sectionSemesterFilterTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}