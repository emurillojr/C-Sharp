namespace maint_student_scores
{
    partial class UpdateStudentScoresForm
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
            this.RemoveScoreButton = new System.Windows.Forms.Button();
            this.UpdateScoresButton = new System.Windows.Forms.Button();
            this.AddScoreButton = new System.Windows.Forms.Button();
            this.CurrentScores = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.StudentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClearScoresButton
            // 
            this.ClearScoresButton.Location = new System.Drawing.Point(204, 149);
            this.ClearScoresButton.Name = "ClearScoresButton";
            this.ClearScoresButton.Size = new System.Drawing.Size(75, 23);
            this.ClearScoresButton.TabIndex = 19;
            this.ClearScoresButton.Text = "Clear Scores";
            this.ClearScoresButton.UseVisualStyleBackColor = true;
            this.ClearScoresButton.Click += new System.EventHandler(this.ClearScoresButton_Click_1);
            // 
            // RemoveScoreButton
            // 
            this.RemoveScoreButton.Location = new System.Drawing.Point(204, 110);
            this.RemoveScoreButton.Name = "RemoveScoreButton";
            this.RemoveScoreButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveScoreButton.TabIndex = 18;
            this.RemoveScoreButton.Text = "Remove";
            this.RemoveScoreButton.UseVisualStyleBackColor = true;
            this.RemoveScoreButton.Click += new System.EventHandler(this.RemoveScoreButton_Click_1);
            // 
            // UpdateScoresButton
            // 
            this.UpdateScoresButton.Location = new System.Drawing.Point(204, 72);
            this.UpdateScoresButton.Name = "UpdateScoresButton";
            this.UpdateScoresButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateScoresButton.TabIndex = 17;
            this.UpdateScoresButton.Text = "Update";
            this.UpdateScoresButton.UseVisualStyleBackColor = true;
            this.UpdateScoresButton.Click += new System.EventHandler(this.UpdateScoresButton_Click);
            // 
            // AddScoreButton
            // 
            this.AddScoreButton.Location = new System.Drawing.Point(204, 38);
            this.AddScoreButton.Name = "AddScoreButton";
            this.AddScoreButton.Size = new System.Drawing.Size(75, 23);
            this.AddScoreButton.TabIndex = 16;
            this.AddScoreButton.Text = "Add";
            this.AddScoreButton.UseVisualStyleBackColor = true;
            this.AddScoreButton.Click += new System.EventHandler(this.AddScoreButton_Click);
            // 
            // CurrentScores
            // 
            this.CurrentScores.FormattingEnabled = true;
            this.CurrentScores.Location = new System.Drawing.Point(58, 38);
            this.CurrentScores.Name = "CurrentScores";
            this.CurrentScores.Size = new System.Drawing.Size(120, 134);
            this.CurrentScores.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Scores";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(204, 203);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 13;
            this.CloseButton.Text = "Cancel";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click_1);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(103, 203);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 12;
            this.UpdateButton.Text = "OK";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click_1);
            // 
            // StudentName
            // 
            this.StudentName.Location = new System.Drawing.Point(53, 6);
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Size = new System.Drawing.Size(100, 20);
            this.StudentName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // UpdateStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 259);
            this.Controls.Add(this.ClearScoresButton);
            this.Controls.Add(this.RemoveScoreButton);
            this.Controls.Add(this.UpdateScoresButton);
            this.Controls.Add(this.AddScoreButton);
            this.Controls.Add(this.CurrentScores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.label1);
            this.Name = "UpdateStudentForm";
            this.Text = "Update Student Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearScoresButton;
        private System.Windows.Forms.Button RemoveScoreButton;
        private System.Windows.Forms.Button UpdateScoresButton;
        private System.Windows.Forms.Button AddScoreButton;
        private System.Windows.Forms.ListBox CurrentScores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.Label label1;
    }
}