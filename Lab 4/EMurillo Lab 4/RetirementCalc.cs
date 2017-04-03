using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMurillo_Lab_4
{
    public partial class RetirementCalc : Form
    {
        public RetirementCalc()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Variables
            decimal startAmount = Convert.ToDecimal(txtStartAmount.Text);
            decimal retireGoal = Convert.ToDecimal(txtRetireGoal.Text);
            int count = 0;

            // if statement to verify if start amount is greater than retire amount and if so produce error
            if (startAmount >= retireGoal)
            {
                lblOutput.Text = "Error! The start amount can not be greater than the retirement goal!  Try again.";
                txtStartAmount.Text = "";
                txtRetireGoal.Text = "";
                txtStartAmount.Focus();
            }
            else
            // if no error, while to add srat amount to itself + itself and count it and produce label
            {
                while (startAmount <= retireGoal)
                {
                    startAmount += startAmount;
                    count++;
                }
                lblOutput.Text = "You will reach retirement amount in " + count + " days";
            }
        }

        // clear everyting if button clear is clicked
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStartAmount.Text = "";
            txtRetireGoal.Text = "";
            lblOutput.Text = "";
            txtStartAmount.Focus();
        }

        // Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
