namespace maint_student_scores
{
    partial class AddNewStudentForm
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
            this.ClearScoresButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AddScore = new System.Windows.Forms.Button();
            this.SaveStudent = new System.Windows.Forms.Button();
            this.CloseForm = new System.Windows.Forms.Button();
            this.NewScoreValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Scores = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ClearScoresButton
            // 
            this.ClearScoresButton.Location = new System.Drawing.Point(201, 114);
            this.ClearScoresButton.Name = "ClearScoresButton";
            this.ClearScoresButton.Size = new System.Drawing.Size(75, 23);
            this.ClearScoresButton.TabIndex = 4;
            this.ClearScoresButton.Text = "Clear Scores";
            this.ClearScoresButton.UseVisualStyleBackColor = true;
            this.ClearScoresButton.Click += new System.EventHandler(this.ClearScoresButton_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Scores";
            // 
            // AddScore
            // 
            this.AddScore.Location = new System.Drawing.Point(201, 48);
            this.AddScore.Name = "AddScore";
            this.AddScore.Size = new System.Drawing.Size(75, 23);
            this.AddScore.TabIndex = 3;
            this.AddScore.Text = "Add Score";
            this.AddScore.UseVisualStyleBackColor = true;
            this.AddScore.Click += new System.EventHandler(this.AddScore_Click);
            // 
            // SaveStudent
            // 
            this.SaveStudent.Location = new System.Drawing.Point(97, 156);
            this.SaveStudent.Name = "SaveStudent";
            this.SaveStudent.Size = new System.Drawing.Size(75, 23);
            this.SaveStudent.TabIndex = 5;
            this.SaveStudent.Text = "OK";
            this.SaveStudent.UseVisualStyleBackColor = true;
            this.SaveStudent.Click += new System.EventHandler(this.SaveStudent_Click_1);
            // 
            // CloseForm
            // 
            this.CloseForm.Location = new System.Drawing.Point(201, 156);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(75, 23);
            this.CloseForm.TabIndex = 6;
            this.CloseForm.Text = "Cancel";
            this.CloseForm.UseVisualStyleBackColor = true;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click_1);
            // 
            // NewScoreValue
            // 
            this.NewScoreValue.Location = new System.Drawing.Point(72, 50);
            this.NewScoreValue.Name = "NewScoreValue";
            this.NewScoreValue.Size = new System.Drawing.Size(100, 20);
            this.NewScoreValue.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Score";
            // 
            // StudentName
            // 
            this.StudentName.Location = new System.Drawing.Point(70, 12);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(206, 20);
            this.StudentName.TabIndex = 1;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // Scores
            // 
            this.Scores.Location = new System.Drawing.Point(73, 88);
            this.Scores.Name = "Scores";
            this.Scores.ReadOnly = true;
            this.Scores.Size = new System.Drawing.Size(203, 20);
            this.Scores.TabIndex = 7;
            // 
            // AddNewStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 207);
            this.Controls.Add(this.Scores);
            this.Controls.Add(this.ClearScoresButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddScore);
            this.Controls.Add(this.SaveStudent);
            this.Controls.Add(this.CloseForm);
            this.Controls.Add(this.NewScoreValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.label1);
            this.Name = "AddNewStudentForm";
            this.Text = "Add New Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearScoresButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddScore;
        private System.Windows.Forms.Button SaveStudent;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.TextBox NewScoreValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Scores;
    }
}