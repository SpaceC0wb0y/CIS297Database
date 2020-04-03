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
            this.SuspendLayout();
            // 
            // enrollmentsListBox
            // 
            this.enrollmentsListBox.FormattingEnabled = true;
            this.enrollmentsListBox.Location = new System.Drawing.Point(91, 141);
            this.enrollmentsListBox.Name = "enrollmentsListBox";
            this.enrollmentsListBox.Size = new System.Drawing.Size(120, 95);
            this.enrollmentsListBox.TabIndex = 0;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(91, 26);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID";
            // 
            // sectionIDTextBox
            // 
            this.sectionIDTextBox.Location = new System.Drawing.Point(91, 65);
            this.sectionIDTextBox.Name = "sectionIDTextBox";
            this.sectionIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.sectionIDTextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Section ID";
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.Location = new System.Drawing.Point(91, 101);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentIDTextBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Student ID";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(91, 328);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(172, 328);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 19;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(253, 328);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // EnrollmentsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Text = "Form1";
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
    }
}