/*
Ernesto Murillo
Lab 1 
SE245.54 C# 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emurillo_InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /*
            This method calculates the total for an invoice depending
            on a discount that's based on the invoiceSubtotal.
            */

            // Get the invoiceSubtotal amount from the Subtotal text box.
            decimal invoiceSubtotal = Convert.ToDecimal(txtSubtotal.Text);

            // Set the discountPercent variable based on the value of the invoiceSubtotal variable.
            decimal discountPercent = 0m;
            if (invoiceSubtotal >= 500)
            {
                discountPercent = .2m;
            }
            else if (invoiceSubtotal >= 250 && invoiceSubtotal < 500)
            {
                discountPercent = .15m;
            }
            else if (invoiceSubtotal >= 100 && invoiceSubtotal < 250)
            {
                discountPercent = .1m;
            }

            // Calculate and assign the values for the discountAmount and invoiceTotal variables.
            decimal discountAmount = invoiceSubtotal * discountPercent;
            decimal invoiceTotal = invoiceSubtotal - discountAmount;

            // Format the values and display them in their text boxes.
            // Percent format with 1 decimal place.
            txtDiscountPercent.Text = discountPercent.ToString("p1");
 
            // Currency format.
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            // Move the focus to the Subtotal text box.
            txtSubtotal.Focus();
        }
    }
}
