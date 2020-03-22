namespace Registration_Database {
    partial class FacultyMenu {
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
            this.FacultyListBox = new System.Windows.Forms.ListBox();
            this.ClearFieldsButton = new System.Windows.Forms.Button();
            this.UpdateFacultyButton = new System.Windows.Forms.Button();
            this.DeleteFacultyButton = new System.Windows.Forms.Button();
            this.AddFacultyButton = new System.Windows.Forms.Button();
            this.facultyNameTextBox = new System.Windows.Forms.TextBox();
            this.facultyIDTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.facultyPhoneTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.facultyOfficeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FacultyListBox
            // 
            this.FacultyListBox.FormattingEnabled = true;
            this.FacultyListBox.Location = new System.Drawing.Point(12, 12);
            this.FacultyListBox.Name = "FacultyListBox";
            this.FacultyListBox.Size = new System.Drawing.Size(328, 251);
            this.FacultyListBox.TabIndex = 53;
            this.FacultyListBox.SelectedIndexChanged += new System.EventHandler(this.FacultyListBox_SelectedIndexChanged);
            // 
            // ClearFieldsButton
            // 
            this.ClearFieldsButton.Location = new System.Drawing.Point(590, 22);
            this.ClearFieldsButton.Name = "ClearFieldsButton";
            this.ClearFieldsButton.Size = new System.Drawing.Size(102, 30);
            this.ClearFieldsButton.TabIndex = 52;
            this.ClearFieldsButton.Text = "Clear Fields";
            this.ClearFieldsButton.UseVisualStyleBackColor = true;
            this.ClearFieldsButton.Click += new System.EventHandler(this.ClearFieldsButton_Click);
            // 
            // UpdateFacultyButton
            // 
            this.UpdateFacultyButton.Location = new System.Drawing.Point(465, 215);
            this.UpdateFacultyButton.Name = "UpdateFacultyButton";
            this.UpdateFacultyButton.Size = new System.Drawing.Size(109, 30);
            this.UpdateFacultyButton.TabIndex = 51;
            this.UpdateFacultyButton.Text = "Update Faculty";
            this.UpdateFacultyButton.UseVisualStyleBackColor = true;
            this.UpdateFacultyButton.Click += new System.EventHandler(this.UpdateFacultyButton_Click);
            // 
            // DeleteFacultyButton
            // 
            this.DeleteFacultyButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteFacultyButton.Location = new System.Drawing.Point(589, 215);
            this.DeleteFacultyButton.Name = "DeleteFacultyButton";
            this.DeleteFacultyButton.Size = new System.Drawing.Size(103, 30);
            this.DeleteFacultyButton.TabIndex = 50;
            this.DeleteFacultyButton.Text = "Delete Faculty";
            this.DeleteFacultyButton.UseVisualStyleBackColor = false;
            this.DeleteFacultyButton.Click += new System.EventHandler(this.DeleteFacultyButton_Click);
            // 
            // AddFacultyButton
            // 
            this.AddFacultyButton.BackColor = System.Drawing.Color.Transparent;
            this.AddFacultyButton.Location = new System.Drawing.Point(361, 215);
            this.AddFacultyButton.Name = "AddFacultyButton";
            this.AddFacultyButton.Size = new System.Drawing.Size(89, 30);
            this.AddFacultyButton.TabIndex = 49;
            this.AddFacultyButton.Text = "Add Faculty";
            this.AddFacultyButton.UseVisualStyleBackColor = false;
            this.AddFacultyButton.Click += new System.EventHandler(this.AddFacultyButton_Click);
            // 
            // facultyNameTextBox
            // 
            this.facultyNameTextBox.Location = new System.Drawing.Point(432, 68);
            this.facultyNameTextBox.Name = "facultyNameTextBox";
            this.facultyNameTextBox.Size = new System.Drawing.Size(260, 20);
            this.facultyNameTextBox.TabIndex = 48;
            // 
            // facultyIDTextBox
            // 
            this.facultyIDTextBox.Location = new System.Drawing.Point(432, 28);
            this.facultyIDTextBox.Name = "facultyIDTextBox";
            this.facultyIDTextBox.ReadOnly = true;
            this.facultyIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.facultyIDTextBox.TabIndex = 47;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(358, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(358, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "ID:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(346, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(372, 251);
            this.textBox1.TabIndex = 54;
            // 
            // facultyPhoneTextBox
            // 
            this.facultyPhoneTextBox.Location = new System.Drawing.Point(432, 107);
            this.facultyPhoneTextBox.Name = "facultyPhoneTextBox";
            this.facultyPhoneTextBox.Size = new System.Drawing.Size(260, 20);
            this.facultyPhoneTextBox.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(358, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Phone:";
            // 
            // facultyOfficeTextBox
            // 
            this.facultyOfficeTextBox.Location = new System.Drawing.Point(432, 145);
            this.facultyOfficeTextBox.Name = "facultyOfficeTextBox";
            this.facultyOfficeTextBox.Size = new System.Drawing.Size(260, 20);
            this.facultyOfficeTextBox.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(358, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Office:";
            // 
            // FacultyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 277);
            this.Controls.Add(this.facultyOfficeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.facultyPhoneTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FacultyListBox);
            this.Controls.Add(this.ClearFieldsButton);
            this.Controls.Add(this.UpdateFacultyButton);
            this.Controls.Add(this.DeleteFacultyButton);
            this.Controls.Add(this.AddFacultyButton);
            this.Controls.Add(this.facultyNameTextBox);
            this.Controls.Add(this.facultyIDTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FacultyMenu";
            this.Text = "FacultyMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FacultyListBox;
        private System.Windows.Forms.Button ClearFieldsButton;
        private System.Windows.Forms.Button UpdateFacultyButton;
        private System.Windows.Forms.Button DeleteFacultyButton;
        private System.Windows.Forms.Button AddFacultyButton;
        private System.Windows.Forms.TextBox facultyNameTextBox;
        private System.Windows.Forms.TextBox facultyIDTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox facultyPhoneTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox facultyOfficeTextBox;
        private System.Windows.Forms.Label label2;
    }
}