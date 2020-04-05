namespace Registration_Database
{
    partial class GradeMenu
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sectionIDTextBox = new System.Windows.Forms.TextBox();
            this.gradeListBox = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.sectionListBox = new System.Windows.Forms.ListBox();
            this.ATextBox = new System.Windows.Forms.MaskedTextBox();
            this.AMinusTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BPlusTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BMinusTextBox = new System.Windows.Forms.MaskedTextBox();
            this.FTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CMinusTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CPlusTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.idTextBox.Location = new System.Drawing.Point(76, 105);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 10;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(19, 108);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(50, 13);
            this.ID.TabIndex = 11;
            this.ID.Text = "Grade ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Section ID";
            // 
            // sectionIDTextBox
            // 
            this.sectionIDTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.sectionIDTextBox.Location = new System.Drawing.Point(76, 140);
            this.sectionIDTextBox.Name = "sectionIDTextBox";
            this.sectionIDTextBox.ReadOnly = true;
            this.sectionIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.sectionIDTextBox.TabIndex = 13;
            // 
            // gradeListBox
            // 
            this.gradeListBox.FormattingEnabled = true;
            this.gradeListBox.Location = new System.Drawing.Point(557, 77);
            this.gradeListBox.Name = "gradeListBox";
            this.gradeListBox.Size = new System.Drawing.Size(180, 95);
            this.gradeListBox.TabIndex = 14;
            this.gradeListBox.SelectedIndexChanged += new System.EventHandler(this.gradeListBox_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(417, 230);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 15;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(498, 230);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(579, 230);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 17;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // sectionListBox
            // 
            this.sectionListBox.FormattingEnabled = true;
            this.sectionListBox.Location = new System.Drawing.Point(333, 77);
            this.sectionListBox.Name = "sectionListBox";
            this.sectionListBox.Size = new System.Drawing.Size(180, 95);
            this.sectionListBox.TabIndex = 18;
            this.sectionListBox.SelectedIndexChanged += new System.EventHandler(this.sectionListBox_SelectedIndexChanged);
            // 
            // ATextBox
            // 
            this.ATextBox.Location = new System.Drawing.Point(232, 24);
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.Size = new System.Drawing.Size(48, 20);
            this.ATextBox.TabIndex = 19;
            // 
            // AMinusTextBox
            // 
            this.AMinusTextBox.Location = new System.Drawing.Point(232, 50);
            this.AMinusTextBox.Name = "AMinusTextBox";
            this.AMinusTextBox.Size = new System.Drawing.Size(48, 20);
            this.AMinusTextBox.TabIndex = 20;
            // 
            // BPlusTextBox
            // 
            this.BPlusTextBox.Location = new System.Drawing.Point(232, 76);
            this.BPlusTextBox.Name = "BPlusTextBox";
            this.BPlusTextBox.Size = new System.Drawing.Size(48, 20);
            this.BPlusTextBox.TabIndex = 21;
            // 
            // BTextBox
            // 
            this.BTextBox.Location = new System.Drawing.Point(232, 102);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(48, 20);
            this.BTextBox.TabIndex = 22;
            // 
            // BMinusTextBox
            // 
            this.BMinusTextBox.Location = new System.Drawing.Point(232, 128);
            this.BMinusTextBox.Name = "BMinusTextBox";
            this.BMinusTextBox.Size = new System.Drawing.Size(48, 20);
            this.BMinusTextBox.TabIndex = 23;
            // 
            // FTextBox
            // 
            this.FTextBox.Location = new System.Drawing.Point(232, 232);
            this.FTextBox.Name = "FTextBox";
            this.FTextBox.Size = new System.Drawing.Size(48, 20);
            this.FTextBox.TabIndex = 27;
            // 
            // CMinusTextBox
            // 
            this.CMinusTextBox.Location = new System.Drawing.Point(232, 206);
            this.CMinusTextBox.Name = "CMinusTextBox";
            this.CMinusTextBox.Size = new System.Drawing.Size(48, 20);
            this.CMinusTextBox.TabIndex = 26;
            // 
            // CTextBox
            // 
            this.CTextBox.Location = new System.Drawing.Point(232, 180);
            this.CTextBox.Name = "CTextBox";
            this.CTextBox.Size = new System.Drawing.Size(48, 20);
            this.CTextBox.TabIndex = 25;
            // 
            // CPlusTextBox
            // 
            this.CPlusTextBox.Location = new System.Drawing.Point(232, 154);
            this.CPlusTextBox.Name = "CPlusTextBox";
            this.CPlusTextBox.Size = new System.Drawing.Size(48, 20);
            this.CPlusTextBox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "A-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "B+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "C+";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "B-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(206, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "C";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(206, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "C-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(206, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "F";
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(660, 230);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 37;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // GradeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 288);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FTextBox);
            this.Controls.Add(this.CMinusTextBox);
            this.Controls.Add(this.CTextBox);
            this.Controls.Add(this.CPlusTextBox);
            this.Controls.Add(this.BMinusTextBox);
            this.Controls.Add(this.BTextBox);
            this.Controls.Add(this.BPlusTextBox);
            this.Controls.Add(this.AMinusTextBox);
            this.Controls.Add(this.ATextBox);
            this.Controls.Add(this.sectionListBox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.gradeListBox);
            this.Controls.Add(this.sectionIDTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.idTextBox);
            this.Name = "GradeMenu";
            this.Text = "GradeMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GradeMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sectionIDTextBox;
        private System.Windows.Forms.ListBox gradeListBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.ListBox sectionListBox;
        private System.Windows.Forms.MaskedTextBox ATextBox;
        private System.Windows.Forms.MaskedTextBox AMinusTextBox;
        private System.Windows.Forms.MaskedTextBox BPlusTextBox;
        private System.Windows.Forms.MaskedTextBox BTextBox;
        private System.Windows.Forms.MaskedTextBox BMinusTextBox;
        private System.Windows.Forms.MaskedTextBox FTextBox;
        private System.Windows.Forms.MaskedTextBox CMinusTextBox;
        private System.Windows.Forms.MaskedTextBox CTextBox;
        private System.Windows.Forms.MaskedTextBox CPlusTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button returnButton;
    }
}