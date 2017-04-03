namespace maint_student_scores
{
    partial class Form1
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.ScoreCount = new System.Windows.Forms.Label();
            this.ScoreAverage = new System.Windows.Forms.Label();
            this.ScoreTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteStudent = new System.Windows.Forms.Button();
            this.updateStudent = new System.Windows.Forms.Button();
            this.addStudent = new System.Windows.Forms.Button();
            this.students = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ScoreTotalTextBox = new System.Windows.Forms.TextBox();
            this.ScoreCountTextBox = new System.Windows.Forms.TextBox();
            this.ScoreAverageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(404, 275);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(97, 23);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click_1);
            // 
            // ScoreCount
            // 
            this.ScoreCount.AutoSize = true;
            this.ScoreCount.Location = new System.Drawing.Point(339, 253);
            this.ScoreCount.Name = "ScoreCount";
            this.ScoreCount.Size = new System.Drawing.Size(0, 13);
            this.ScoreCount.TabIndex = 22;
            // 
            // ScoreAverage
            // 
            this.ScoreAverage.AutoSize = true;
            this.ScoreAverage.Location = new System.Drawing.Point(339, 275);
            this.ScoreAverage.Name = "ScoreAverage";
            this.ScoreAverage.Size = new System.Drawing.Size(0, 13);
            this.ScoreAverage.TabIndex = 21;
            // 
            // ScoreTotal
            // 
            this.ScoreTotal.AutoSize = true;
            this.ScoreTotal.Location = new System.Drawing.Point(339, 231);
            this.ScoreTotal.Name = "ScoreTotal";
            this.ScoreTotal.Size = new System.Drawing.Size(0, 13);
            this.ScoreTotal.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Score Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Average";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Score Total";
            // 
            // deleteStudent
            // 
            this.deleteStudent.Location = new System.Drawing.Point(404, 92);
            this.deleteStudent.Name = "deleteStudent";
            this.deleteStudent.Size = new System.Drawing.Size(97, 23);
            this.deleteStudent.TabIndex = 3;
            this.deleteStudent.Text = "Delete...";
            this.deleteStudent.UseVisualStyleBackColor = true;
            this.deleteStudent.Click += new System.EventHandler(this.deleteStudent_Click_1);
            // 
            // updateStudent
            // 
            this.updateStudent.Location = new System.Drawing.Point(404, 63);
            this.updateStudent.Name = "updateStudent";
            this.updateStudent.Size = new System.Drawing.Size(97, 23);
            this.updateStudent.TabIndex = 2;
            this.updateStudent.Text = "Update...";
            this.updateStudent.UseVisualStyleBackColor = true;
            this.updateStudent.Click += new System.EventHandler(this.updateStudent_Click_1);
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(404, 34);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(97, 23);
            this.addStudent.TabIndex = 1;
            this.addStudent.Text = "Add New...";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // students
            // 
            this.students.FormattingEnabled = true;
            this.students.Location = new System.Drawing.Point(12, 34);
            this.students.Name = "students";
            this.students.Size = new System.Drawing.Size(366, 173);
            this.students.TabIndex = 5;
            this.students.SelectedIndexChanged += new System.EventHandler(this.students_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Students:";
            // 
            // ScoreTotalTextBox
            // 
            this.ScoreTotalTextBox.Location = new System.Drawing.Point(326, 228);
            this.ScoreTotalTextBox.Name = "ScoreTotalTextBox";
            this.ScoreTotalTextBox.ReadOnly = true;
            this.ScoreTotalTextBox.Size = new System.Drawing.Size(52, 20);
            this.ScoreTotalTextBox.TabIndex = 6;
            // 
            // ScoreCountTextBox
            // 
            this.ScoreCountTextBox.Location = new System.Drawing.Point(326, 250);
            this.ScoreCountTextBox.Name = "ScoreCountTextBox";
            this.ScoreCountTextBox.ReadOnly = true;
            this.ScoreCountTextBox.Size = new System.Drawing.Size(52, 20);
            this.ScoreCountTextBox.TabIndex = 7;
            // 
            // ScoreAverageTextBox
            // 
            this.ScoreAverageTextBox.Location = new System.Drawing.Point(326, 275);
            this.ScoreAverageTextBox.Name = "ScoreAverageTextBox";
            this.ScoreAverageTextBox.ReadOnly = true;
            this.ScoreAverageTextBox.Size = new System.Drawing.Size(52, 20);
            this.ScoreAverageTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AcceptButton = this.addStudent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(521, 314);
            this.Controls.Add(this.ScoreAverageTextBox);
            this.Controls.Add(this.ScoreCountTextBox);
            this.Controls.Add(this.ScoreTotalTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ScoreCount);
            this.Controls.Add(this.ScoreAverage);
            this.Controls.Add(this.ScoreTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteStudent);
            this.Controls.Add(this.updateStudent);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.students);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Student Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label ScoreCount;
        private System.Windows.Forms.Label ScoreAverage;
        private System.Windows.Forms.Label ScoreTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteStudent;
        private System.Windows.Forms.Button updateStudent;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.ListBox students;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ScoreTotalTextBox;
        private System.Windows.Forms.TextBox ScoreCountTextBox;
        private System.Windows.Forms.TextBox ScoreAverageTextBox;

    }
}

