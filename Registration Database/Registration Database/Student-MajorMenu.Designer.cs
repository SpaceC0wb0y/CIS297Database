namespace Registration_Database {
    partial class Student_MajorMenu {
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
            this.declarationListBox = new System.Windows.Forms.ListBox();
            this.majorListBox = new System.Windows.Forms.ListBox();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.declarationIDTextBox = new System.Windows.Forms.TextBox();
            this.majorIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // declarationListBox
            // 
            this.declarationListBox.FormattingEnabled = true;
            this.declarationListBox.Location = new System.Drawing.Point(184, 20);
            this.declarationListBox.Name = "declarationListBox";
            this.declarationListBox.Size = new System.Drawing.Size(130, 212);
            this.declarationListBox.TabIndex = 0;
            this.declarationListBox.SelectedIndexChanged += new System.EventHandler(this.DeclarationListBox_SelectedIndexChanged);
            // 
            // majorListBox
            // 
            this.majorListBox.FormattingEnabled = true;
            this.majorListBox.Location = new System.Drawing.Point(334, 20);
            this.majorListBox.Name = "majorListBox";
            this.majorListBox.Size = new System.Drawing.Size(130, 212);
            this.majorListBox.TabIndex = 1;
            this.majorListBox.SelectedIndexChanged += new System.EventHandler(this.MajorListBox_SelectedIndexChanged);
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.Location = new System.Drawing.Point(24, 25);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.ReadOnly = true;
            this.studentIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentIDTextBox.TabIndex = 2;
            // 
            // declarationIDTextBox
            // 
            this.declarationIDTextBox.Location = new System.Drawing.Point(24, 143);
            this.declarationIDTextBox.Name = "declarationIDTextBox";
            this.declarationIDTextBox.ReadOnly = true;
            this.declarationIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.declarationIDTextBox.TabIndex = 4;
            // 
            // majorIDTextBox
            // 
            this.majorIDTextBox.Location = new System.Drawing.Point(24, 74);
            this.majorIDTextBox.Name = "majorIDTextBox";
            this.majorIDTextBox.ReadOnly = true;
            this.majorIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.majorIDTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Student ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Major ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Declaration ID";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(24, 264);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddDeclarationButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(127, 264);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteDeclarationButton_Click);
            // 
            // studentListBox
            // 
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.Location = new System.Drawing.Point(483, 20);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(130, 212);
            this.studentListBox.TabIndex = 13;
            this.studentListBox.SelectedIndexChanged += new System.EventHandler(this.StudentListBox_SelectedIndexChanged);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(538, 264);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 14;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // Student_MajorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 306);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.studentListBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.majorIDTextBox);
            this.Controls.Add(this.declarationIDTextBox);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(this.majorListBox);
            this.Controls.Add(this.declarationListBox);
            this.Name = "Student_MajorMenu";
            this.Text = "Student_MajorMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Student_MajorMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox declarationListBox;
        private System.Windows.Forms.ListBox majorListBox;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.TextBox declarationIDTextBox;
        private System.Windows.Forms.TextBox majorIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListBox studentListBox;
        private System.Windows.Forms.Button returnButton;
    }
}