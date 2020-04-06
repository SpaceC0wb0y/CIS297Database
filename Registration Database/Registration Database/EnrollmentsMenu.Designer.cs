namespace Registration_Database
{
    partial class EnrollmentsMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enrollmentsListBox = new System.Windows.Forms.ListBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sectionIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.sectionListBox = new System.Windows.Forms.ListBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.enrollmentStudentFilterTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enrollmentsListBox
            // 
            this.enrollmentsListBox.FormattingEnabled = true;
            this.enrollmentsListBox.Location = new System.Drawing.Point(622, 42);
            this.enrollmentsListBox.Name = "enrollmentsListBox";
            this.enrollmentsListBox.Size = new System.Drawing.Size(154, 121);
            this.enrollmentsListBox.TabIndex = 0;
            this.enrollmentsListBox.SelectedIndexChanged += new System.EventHandler(this.enrollmentsListBox_SelectedIndexChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.idTextBox.Location = new System.Drawing.Point(91, 54);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID";
            // 
            // sectionIDTextBox
            // 
            this.sectionIDTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.sectionIDTextBox.Location = new System.Drawing.Point(91, 93);
            this.sectionIDTextBox.Name = "sectionIDTextBox";
            this.sectionIDTextBox.ReadOnly = true;
            this.sectionIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.sectionIDTextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Section ID";
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.studentIDTextBox.Location = new System.Drawing.Point(91, 129);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.ReadOnly = true;
            this.studentIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentIDTextBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Student ID";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(457, 190);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(538, 190);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 19;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(619, 190);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // studentListBox
            // 
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.Location = new System.Drawing.Point(233, 42);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(154, 121);
            this.studentListBox.TabIndex = 21;
            this.studentListBox.SelectedIndexChanged += new System.EventHandler(this.studentListBox_SelectedIndexChanged);
            // 
            // sectionListBox
            // 
            this.sectionListBox.FormattingEnabled = true;
            this.sectionListBox.Location = new System.Drawing.Point(427, 42);
            this.sectionListBox.Name = "sectionListBox";
            this.sectionListBox.Size = new System.Drawing.Size(154, 121);
            this.sectionListBox.TabIndex = 22;
            this.sectionListBox.SelectedIndexChanged += new System.EventHandler(this.sectionListBox_SelectedIndexChanged);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(700, 190);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 23;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // enrollmentStudentFilterTextBox
            // 
            this.enrollmentStudentFilterTextBox.Location = new System.Drawing.Point(34, 202);
            this.enrollmentStudentFilterTextBox.Name = "enrollmentStudentFilterTextBox";
            this.enrollmentStudentFilterTextBox.Size = new System.Drawing.Size(157, 20);
            this.enrollmentStudentFilterTextBox.TabIndex = 24;
            this.enrollmentStudentFilterTextBox.TextChanged += new System.EventHandler(this.EnrollmentStudentFilterTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Filter By Student";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Student List";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Section List";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(619, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Enrollment List";
            // 
            // EnrollmentsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 256);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enrollmentStudentFilterTextBox);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.sectionListBox);
            this.Controls.Add(this.studentListBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sectionIDTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.enrollmentsListBox);
            this.Name = "EnrollmentsMenu";
            this.Text = "EnrollmentsMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnrollmentsMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox enrollmentsListBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sectionIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListBox studentListBox;
        private System.Windows.Forms.ListBox sectionListBox;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.TextBox enrollmentStudentFilterTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}