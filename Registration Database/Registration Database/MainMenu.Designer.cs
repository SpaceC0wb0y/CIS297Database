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
            this.DepartmentTextBox = new System.Windows.Forms.TextBox();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CreditsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CourseListBox = new System.Windows.Forms.ListBox();
            this.CoursesLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SelectedCourselabel = new System.Windows.Forms.Label();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Location = new System.Drawing.Point(558, 100);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(75, 23);
            this.AddCourseButton.TabIndex = 1;
            this.AddCourseButton.Text = "Add Course";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            this.AddCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // DepartmentTextBox
            // 
            this.DepartmentTextBox.Location = new System.Drawing.Point(409, 24);
            this.DepartmentTextBox.Name = "DepartmentTextBox";
            this.DepartmentTextBox.Size = new System.Drawing.Size(100, 20);
            this.DepartmentTextBox.TabIndex = 2;
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(409, 50);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumberTextBox.TabIndex = 3;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(409, 76);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 4;
            // 
            // CreditsTextBox
            // 
            this.CreditsTextBox.Location = new System.Drawing.Point(409, 102);
            this.CreditsTextBox.Name = "CreditsTextBox";
            this.CreditsTextBox.Size = new System.Drawing.Size(100, 20);
            this.CreditsTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 105);
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
            // CoursesLabel
            // 
            this.CoursesLabel.AutoSize = true;
            this.CoursesLabel.Location = new System.Drawing.Point(334, 161);
            this.CoursesLabel.Name = "CoursesLabel";
            this.CoursesLabel.Size = new System.Drawing.Size(13, 13);
            this.CoursesLabel.TabIndex = 11;
            this.CoursesLabel.Text = "..";
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
            // SelectedCourselabel
            // 
            this.SelectedCourselabel.AutoSize = true;
            this.SelectedCourselabel.Location = new System.Drawing.Point(141, 277);
            this.SelectedCourselabel.Name = "SelectedCourselabel";
            this.SelectedCourselabel.Size = new System.Drawing.Size(35, 13);
            this.SelectedCourselabel.TabIndex = 13;
            this.SelectedCourselabel.Text = "label6";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelectedCourselabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CoursesLabel);
            this.Controls.Add(this.CourseListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreditsTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.DepartmentTextBox);
            this.Controls.Add(this.AddCourseButton);
            this.Name = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddCourseButton;
        private System.Windows.Forms.TextBox DepartmentTextBox;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox CreditsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox CourseListBox;
        private System.Windows.Forms.Label CoursesLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label SelectedCourselabel;
        private System.Windows.Forms.BindingSource courseBindingSource;
    }
}

