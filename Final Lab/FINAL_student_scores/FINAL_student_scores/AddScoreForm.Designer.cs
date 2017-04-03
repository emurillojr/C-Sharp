namespace maint_student_scores
{
    partial class AddScoreForm
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
            this.CancelButton1 = new System.Windows.Forms.Button();
            this.AddScoreButton = new System.Windows.Forms.Button();
            this.ScoreValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelButton1
            // 
            this.CancelButton1.Location = new System.Drawing.Point(102, 50);
            this.CancelButton1.Name = "CancelButton1";
            this.CancelButton1.Size = new System.Drawing.Size(75, 23);
            this.CancelButton1.TabIndex = 3;
            this.CancelButton1.Text = "Cancel";
            this.CancelButton1.UseVisualStyleBackColor = true;
            this.CancelButton1.Click += new System.EventHandler(this.CancelButton1_Click);
            // 
            // AddScoreButton
            // 
            this.AddScoreButton.Location = new System.Drawing.Point(12, 50);
            this.AddScoreButton.Name = "AddScoreButton";
            this.AddScoreButton.Size = new System.Drawing.Size(75, 23);
            this.AddScoreButton.TabIndex = 2;
            this.AddScoreButton.Text = "Add";
            this.AddScoreButton.UseVisualStyleBackColor = true;
            this.AddScoreButton.Click += new System.EventHandler(this.AddScoreButton_Click_1);
            // 
            // ScoreValue
            // 
            this.ScoreValue.Location = new System.Drawing.Point(70, 12);
            this.ScoreValue.Name = "ScoreValue";
            this.ScoreValue.Size = new System.Drawing.Size(68, 20);
            this.ScoreValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score";
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 100);
            this.Controls.Add(this.CancelButton1);
            this.Controls.Add(this.AddScoreButton);
            this.Controls.Add(this.ScoreValue);
            this.Controls.Add(this.label1);
            this.Name = "AddScoreForm";
            this.Text = "Add Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton1;
        private System.Windows.Forms.Button AddScoreButton;
        private System.Windows.Forms.TextBox ScoreValue;
        private System.Windows.Forms.Label label1;
    }
}