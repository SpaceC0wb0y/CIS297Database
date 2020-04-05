namespace Registration_Database {
    partial class MajorMenu {
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
            this.MajorListBox = new System.Windows.Forms.ListBox();
            this.ClearMajorFieldsButton = new System.Windows.Forms.Button();
            this.UpdateMajorButton = new System.Windows.Forms.Button();
            this.DeleteMajorButton = new System.Windows.Forms.Button();
            this.AddMajorButton = new System.Windows.Forms.Button();
            this.majorNameTextBox = new System.Windows.Forms.TextBox();
            this.majorIDTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MajorListBox
            // 
            this.MajorListBox.FormattingEnabled = true;
            this.MajorListBox.Location = new System.Drawing.Point(393, 12);
            this.MajorListBox.Name = "MajorListBox";
            this.MajorListBox.Size = new System.Drawing.Size(328, 251);
            this.MajorListBox.TabIndex = 43;
            this.MajorListBox.SelectedIndexChanged += new System.EventHandler(this.MajorListBox_SelectedIndexChanged);
            // 
            // ClearMajorFieldsButton
            // 
            this.ClearMajorFieldsButton.Location = new System.Drawing.Point(256, 99);
            this.ClearMajorFieldsButton.Name = "ClearMajorFieldsButton";
            this.ClearMajorFieldsButton.Size = new System.Drawing.Size(102, 30);
            this.ClearMajorFieldsButton.TabIndex = 42;
            this.ClearMajorFieldsButton.Text = "Clear Fields";
            this.ClearMajorFieldsButton.UseVisualStyleBackColor = true;
            this.ClearMajorFieldsButton.Click += new System.EventHandler(this.ClearMajorFieldsButton_Click);
            // 
            // UpdateMajorButton
            // 
            this.UpdateMajorButton.Location = new System.Drawing.Point(131, 215);
            this.UpdateMajorButton.Name = "UpdateMajorButton";
            this.UpdateMajorButton.Size = new System.Drawing.Size(109, 30);
            this.UpdateMajorButton.TabIndex = 41;
            this.UpdateMajorButton.Text = "Update Major";
            this.UpdateMajorButton.UseVisualStyleBackColor = true;
            this.UpdateMajorButton.Click += new System.EventHandler(this.UpdateMajorButton_Click);
            // 
            // DeleteMajorButton
            // 
            this.DeleteMajorButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteMajorButton.Location = new System.Drawing.Point(255, 215);
            this.DeleteMajorButton.Name = "DeleteMajorButton";
            this.DeleteMajorButton.Size = new System.Drawing.Size(103, 30);
            this.DeleteMajorButton.TabIndex = 40;
            this.DeleteMajorButton.Text = "Delete Major";
            this.DeleteMajorButton.UseVisualStyleBackColor = false;
            this.DeleteMajorButton.Click += new System.EventHandler(this.DeleteMajorButton_Click);
            // 
            // AddMajorButton
            // 
            this.AddMajorButton.BackColor = System.Drawing.Color.Transparent;
            this.AddMajorButton.Location = new System.Drawing.Point(27, 215);
            this.AddMajorButton.Name = "AddMajorButton";
            this.AddMajorButton.Size = new System.Drawing.Size(89, 30);
            this.AddMajorButton.TabIndex = 39;
            this.AddMajorButton.Text = "Add Major";
            this.AddMajorButton.UseVisualStyleBackColor = false;
            this.AddMajorButton.Click += new System.EventHandler(this.AddMajorButton_Click);
            // 
            // majorNameTextBox
            // 
            this.majorNameTextBox.Location = new System.Drawing.Point(98, 68);
            this.majorNameTextBox.Name = "majorNameTextBox";
            this.majorNameTextBox.Size = new System.Drawing.Size(260, 20);
            this.majorNameTextBox.TabIndex = 37;
            // 
            // majorIDTextBox
            // 
            this.majorIDTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.majorIDTextBox.Location = new System.Drawing.Point(98, 28);
            this.majorIDTextBox.Name = "majorIDTextBox";
            this.majorIDTextBox.ReadOnly = true;
            this.majorIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.majorIDTextBox.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(24, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(24, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Major ID:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(372, 251);
            this.textBox1.TabIndex = 44;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(309, 270);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 45;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // MajorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 305);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.MajorListBox);
            this.Controls.Add(this.ClearMajorFieldsButton);
            this.Controls.Add(this.UpdateMajorButton);
            this.Controls.Add(this.DeleteMajorButton);
            this.Controls.Add(this.AddMajorButton);
            this.Controls.Add(this.majorNameTextBox);
            this.Controls.Add(this.majorIDTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MajorMenu";
            this.Text = "MajorMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MajorMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox MajorListBox;
        private System.Windows.Forms.Button ClearMajorFieldsButton;
        private System.Windows.Forms.Button UpdateMajorButton;
        private System.Windows.Forms.Button DeleteMajorButton;
        private System.Windows.Forms.Button AddMajorButton;
        private System.Windows.Forms.TextBox majorNameTextBox;
        private System.Windows.Forms.TextBox majorIDTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button returnButton;
    }
}