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
            decimal operand2 = Convert.ToDecimal(txtOper2.Text);
            string operator1 = txtOper.Text;
            // if statement to capture answer to rounded to 4th decimal
            if (operator1 == "+")
            {
                answer = Math.Round(operand1 + operand2, 4);
            }
            else if (operator1 == "-")
            {
                answer = Math.Round(operand1 - operand2, 4);
            }
            else if (operator1 == "/")
            {
                answer = Math.Round(operand1 / operand2, 4);
            }
            else if (operator1 == "*")
            {
                answer = Math.Round(operand1 * operand2, 4);
            }
            // added messagebox error if operator1 is invalid also to clear it and focus on it
            else
            {
                MessageBox.Show("Operator must be +  -  *  or /  Please make sure operator is valid.", "Entry Error");
                txtOper.Text = "";
                txtOper.Focus();
            }
            return answer;
        }

        // calc button code to perform function and clear error and produce results
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal answerALL = 0;
                decimal answer = Calculate(answerALL);
                txtResult.Text = answer.ToString();

            } //closing of try
            //catch different exceptions
            catch (FormatException)
            {
                MessageBox.Show("A format exception has occured. Please make sure all operands are numeric and entries are valid.", "Entry Error");
            }
            // note*** - since operand 1 and 2 are decimal -overflow exception will not happen unless > 29 numbers entered
            catch (OverflowException)
            {
                MessageBox.Show("An overflow exception has occured.  Please enter smaller values.", "Entry Error");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Operand 2 cannot be 0.  You cannot divide by 0. Please enter a valid Operand 2.", "Entry Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
            }
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
