using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class frmSimpleCalculator : Form
    {
        public frmSimpleCalculator()
        {
            InitializeComponent();
        }

        // function Calculate that returns decimal value
        private decimal Calculate(decimal answersALL)
        {
            // variables
            decimal answer = 0;
            decimal operand1 = Convert.ToDecimal(txtOper1.Text);
            string oper = txtOper.Text;
            decimal operand2 = Convert.ToDecimal(txtOper2.Text);

            // if statement to capture answer to rounded to 4th decimal
            if (oper == "+")
            {
                answer = Math.Round(operand1 + operand2, 4);
                txtError.Text = "";
            }
            else if (oper == "-")
            {
                answer = Math.Round(operand1 - operand2, 4);
                txtError.Text = "";
            }
            else if (oper == "/")
            {
                answer = Math.Round(operand1 / operand2, 4);
                txtError.Text = "";
            }
            else if (oper == "*")
            {
                answer = Math.Round(operand1 * operand2, 4);
                txtError.Text = "";
            }
            // added error message if invalid operand is chosen also to clear it and focus on it
            else
            {
                txtError.Text = "Invalid Operator. Only +, -, *, or / ";
                txtOper.Text = "";
                txtOper.Focus();
            }
            return answer;
        }

        // calc button code to perform function and clear error and produce results
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtError.Text = "";
            decimal answerALL = 0;
            decimal answer = Calculate(answerALL);
            txtResult.Text = answer.ToString();
        }

        // exit program is exit button clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        // added clear result if this textbox is changed
        private void txtOper1_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }
        
        // added clear result if this textbox is changed
        private void txtOper_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        // added clear result if this textbox is changed
        private void txtOper2_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }
    }
}
