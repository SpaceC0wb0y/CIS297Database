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
            this.components = new System.ComponentModel.Container();
            this.AddCourseButton = new System.Windows.Forms.Button();
            this.courseDepartmentTextBox = new System.Windows.Forms.TextBox();
            this.courseNumberTextBox = new System.Windows.Forms.TextBox();
            this.courseNameTextBox = new System.Windows.Forms.TextBox();
            this.courseCreditsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CourseListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UpdateCourseButton = new System.Windows.Forms.Button();
            this.DeleteCourseButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.courseIdTextBox = new System.Windows.Forms.TextBox();
            this.ClearCourseFieldsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Location = new System.Drawing.Point(335, 180);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(75, 23);
            this.AddCourseButton.TabIndex = 1;
            this.AddCourseButton.Text = "Add";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            this.AddCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // courseDepartmentTextBox
            // 
            this.courseDepartmentTextBox.Location = new System.Drawing.Point(373, 52);
            this.courseDepartmentTextBox.Name = "courseDepartmentTextBox";
            this.courseDepartmentTextBox.Size = new System.Drawing.Size(100, 20);
            this.courseDepartmentTextBox.TabIndex = 2;
            // 
            // courseNumberTextBox
            // 
            this.courseNumberTextBox.Location = new System.Drawing.Point(373, 78);
            this.courseNumberTextBox.Name = "courseNumberTextBox";
            this.courseNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.courseNumberTextBox.TabIndex = 3;
            // 
            // courseNameTextBox
            // 
            this.courseNameTextBox.Location = new System.Drawing.Point(373, 104);
            this.courseNameTextBox.Name = "courseNameTextBox";
            this.courseNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.courseNameTextBox.TabIndex = 4;
            // 
            // courseCreditsTextBox
            // 
            this.courseCreditsTextBox.Location = new System.Drawing.Point(373, 130);
            this.courseCreditsTextBox.Name = "courseCreditsTextBox";
            this.courseCreditsTextBox.Size = new System.Drawing.Size(100, 20);
            this.courseCreditsTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Credits";
            // 
            // CourseListBox
            // 
            this.CourseListBox.FormattingEnabled = true;
            this.CourseListBox.Location = new System.Drawing.Point(22, 27);
            this.CourseListBox.Name = "CourseListBox";
            this.CourseListBox.Size = new System.Drawing.Size(249, 199);
            this.CourseListBox.TabIndex = 10;
            this.CourseListBox.SelectedIndexChanged += new System.EventHandler(this.CourseListBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Course Names:";
            // 
            // UpdateCourseButton
            // 
            this.UpdateCourseButton.Location = new System.Drawing.Point(416, 180);
            this.UpdateCourseButton.Name = "UpdateCourseButton";
            this.UpdateCourseButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateCourseButton.TabIndex = 14;
            this.UpdateCourseButton.Text = "Update";
            this.UpdateCourseButton.UseVisualStyleBackColor = true;
            this.UpdateCourseButton.Click += new System.EventHandler(this.UpdateCourseButton_Click);
            // 
            // DeleteCourseButton
            // 
            this.DeleteCourseButton.Location = new System.Drawing.Point(497, 180);
            this.DeleteCourseButton.Name = "DeleteCourseButton";
            this.DeleteCourseButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteCourseButton.TabIndex = 15;
            this.DeleteCourseButton.Text = "Delete";
            this.DeleteCourseButton.UseVisualStyleBackColor = true;
            this.DeleteCourseButton.Click += new System.EventHandler(this.DeleteCourseButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID";
            // 
            // courseIdTextBox
            // 
            this.courseIdTextBox.Location = new System.Drawing.Point(373, 27);
            this.courseIdTextBox.Name = "courseIdTextBox";
            this.courseIdTextBox.ReadOnly = true;
            this.courseIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.courseIdTextBox.TabIndex = 17;
            // 
            // ClearCourseFieldsButton
            // 
            this.ClearCourseFieldsButton.Location = new System.Drawing.Point(497, 25);
            this.ClearCourseFieldsButton.Name = "ClearCourseFieldsButton";
            this.ClearCourseFieldsButton.Size = new System.Drawing.Size(75, 23);
            this.ClearCourseFieldsButton.TabIndex = 18;
            this.ClearCourseFieldsButton.Text = "Clear Fields";
            this.ClearCourseFieldsButton.UseVisualStyleBackColor = true;
            this.ClearCourseFieldsButton.Click += new System.EventHandler(this.ClearCourseFieldsButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearCourseFieldsButton);
            this.Controls.Add(this.courseIdTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DeleteCourseButton);
            this.Controls.Add(this.UpdateCourseButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CourseListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courseCreditsTextBox);
            this.Controls.Add(this.courseNameTextBox);
            this.Controls.Add(this.courseNumberTextBox);
            this.Controls.Add(this.courseDepartmentTextBox);
            this.Controls.Add(this.AddCourseButton);
            this.Name = "MainMenu";
            this.Enter += new System.EventHandler(this.MainMenu_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddCourseButton;
        private System.Windows.Forms.TextBox courseDepartmentTextBox;
        private System.Windows.Forms.TextBox courseNumberTextBox;
        private System.Windows.Forms.TextBox courseNameTextBox;
        private System.Windows.Forms.TextBox courseCreditsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox CourseListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.Button UpdateCourseButton;
        private System.Windows.Forms.Button DeleteCourseButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox courseIdTextBox;
        private System.Windows.Forms.Button ClearCourseFieldsButton;
    }
}

