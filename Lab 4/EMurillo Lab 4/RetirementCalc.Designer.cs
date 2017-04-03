namespace EMurillo_Lab_4
{
    partial class RetirementCalc
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
            this.lblStartAmount = new System.Windows.Forms.Label();
            this.lblRetireGoal = new System.Windows.Forms.Label();
            this.txtStartAmount = new System.Windows.Forms.TextBox();
            this.txtRetireGoal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStartAmount
            // 
            this.lblStartAmount.AutoSize = true;
            this.lblStartAmount.Location = new System.Drawing.Point(31, 40);
            this.lblStartAmount.Name = "lblStartAmount";
            this.lblStartAmount.Size = new System.Drawing.Size(133, 13);
            this.lblStartAmount.TabIndex = 0;
            this.lblStartAmount.Text = "Enter your starting amount:";
            // 
            // lblRetireGoal
            // 
            this.lblRetireGoal.AutoSize = true;
            this.lblRetireGoal.Location = new System.Drawing.Point(31, 98);
            this.lblRetireGoal.Name = "lblRetireGoal";
            this.lblRetireGoal.Size = new System.Drawing.Size(135, 13);
            this.lblRetireGoal.TabIndex = 1;
            this.lblRetireGoal.Text = "Enter your Retirement goal:";
            // 
            // txtStartAmount
            // 
            this.txtStartAmount.Location = new System.Drawing.Point(182, 37);
            this.txtStartAmount.Name = "txtStartAmount";
            this.txtStartAmount.Size = new System.Drawing.Size(100, 20);
            this.txtStartAmount.TabIndex = 1;
            // 
            // txtRetireGoal
            // 
            this.txtRetireGoal.Location = new System.Drawing.Point(182, 95);
            this.txtRetireGoal.Name = "txtRetireGoal";
            this.txtRetireGoal.Size = new System.Drawing.Size(100, 20);
            this.txtRetireGoal.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(73, 149);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(169, 149);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(263, 149);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(31, 203);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 6;
            // 
            // RetirementCalc
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(424, 253);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtRetireGoal);
            this.Controls.Add(this.txtStartAmount);
            this.Controls.Add(this.lblRetireGoal);
            this.Controls.Add(this.lblStartAmount);
            this.Name = "RetirementCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retirement Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartAmount;
        private System.Windows.Forms.Label lblRetireGoal;
        private System.Windows.Forms.TextBox txtStartAmount;
        private System.Windows.Forms.TextBox txtRetireGoal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblOutput;
    }
}

