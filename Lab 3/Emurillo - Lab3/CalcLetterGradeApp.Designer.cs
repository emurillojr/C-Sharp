namespace Emurillo___Lab3
{
    partial class frmCalcLetterGradeApp
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
            this.lblStudentFullName = new System.Windows.Forms.Label();
            this.lblTypeOfClass = new System.Windows.Forms.Label();
            this.lnlNumericGrade = new System.Windows.Forms.Label();
            this.txtStudentFullName = new System.Windows.Forms.TextBox();
            this.txtTypeOfClass = new System.Windows.Forms.TextBox();
            this.txtNumericGrade = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStudentFullName
            // 
            this.lblStudentFullName.AutoSize = true;
            this.lblStudentFullName.Location = new System.Drawing.Point(12, 18);
            this.lblStudentFullName.Name = "lblStudentFullName";
            this.lblStudentFullName.Size = new System.Drawing.Size(97, 13);
            this.lblStudentFullName.TabIndex = 0;
            this.lblStudentFullName.Text = "Student Full Name:";
            // 
            // lblTypeOfClass
            // 
            this.lblTypeOfClass.AutoSize = true;
            this.lblTypeOfClass.Location = new System.Drawing.Point(35, 57);
            this.lblTypeOfClass.Name = "lblTypeOfClass";
            this.lblTypeOfClass.Size = new System.Drawing.Size(74, 13);
            this.lblTypeOfClass.TabIndex = 1;
            this.lblTypeOfClass.Text = "Type of Class:";
            // 
            // lnlNumericGrade
            // 
            this.lnlNumericGrade.AutoSize = true;
            this.lnlNumericGrade.Location = new System.Drawing.Point(28, 95);
            this.lnlNumericGrade.Name = "lnlNumericGrade";
            this.lnlNumericGrade.Size = new System.Drawing.Size(81, 13);
            this.lnlNumericGrade.TabIndex = 2;
            this.lnlNumericGrade.Text = "Numeric Grade:";
            // 
            // txtStudentFullName
            // 
            this.txtStudentFullName.Location = new System.Drawing.Point(127, 15);
            this.txtStudentFullName.Name = "txtStudentFullName";
            this.txtStudentFullName.Size = new System.Drawing.Size(145, 20);
            this.txtStudentFullName.TabIndex = 1;
            // 
            // txtTypeOfClass
            // 
            this.txtTypeOfClass.Location = new System.Drawing.Point(127, 54);
            this.txtTypeOfClass.Name = "txtTypeOfClass";
            this.txtTypeOfClass.Size = new System.Drawing.Size(37, 20);
            this.txtTypeOfClass.TabIndex = 2;
            // 
            // txtNumericGrade
            // 
            this.txtNumericGrade.Location = new System.Drawing.Point(127, 92);
            this.txtNumericGrade.Name = "txtNumericGrade";
            this.txtNumericGrade.Size = new System.Drawing.Size(51, 20);
            this.txtNumericGrade.TabIndex = 3;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(49, 136);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(166, 136);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoEllipsis = true;
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(46, 180);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(45, 13);
            this.lblAnswer.TabIndex = 8;
            this.lblAnswer.Text = "Answer:";
            // 
            // frmCalcLetterGradeApp
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(442, 214);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtNumericGrade);
            this.Controls.Add(this.txtTypeOfClass);
            this.Controls.Add(this.txtStudentFullName);
            this.Controls.Add(this.lnlNumericGrade);
            this.Controls.Add(this.lblTypeOfClass);
            this.Controls.Add(this.lblStudentFullName);
            this.Name = "frmCalcLetterGradeApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate Letter Grade App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentFullName;
        private System.Windows.Forms.Label lblTypeOfClass;
        private System.Windows.Forms.Label lnlNumericGrade;
        private System.Windows.Forms.TextBox txtStudentFullName;
        private System.Windows.Forms.TextBox txtTypeOfClass;
        private System.Windows.Forms.TextBox txtNumericGrade;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAnswer;
    }
}

