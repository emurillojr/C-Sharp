using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Ernesto Murillo Mid Term
// Calculate Change 


namespace Calculatechange
{
    public partial class CalculateChange : Form
    {
        public CalculateChange()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // assign variables
            int change = Convert.ToInt16(txtChangedue.Text);
            int quarter = 25;
            int dime = 10;
            int nickel = 5;
            int penny = 1;

            // if statement for verification number is 0-99
            if (change < 100 && change >= 0)
            {
                //calculations
                int totalQuarter = Convert.ToInt16(change / quarter);
                change %= quarter;
                int totalDime = Convert.ToInt16(change / dime);
                change %= dime;
                int totalNickel = Convert.ToInt16(change / nickel);
                change %= nickel;
                int totalPenny = Convert.ToInt16(change / penny);
                change %= penny;

                txtQuarters.Text = totalQuarter.ToString();
                txtDimes.Text = totalDime.ToString();
                txtNickels.Text = totalNickel.ToString();
                txtPennies.Text = totalPenny.ToString();
                lblError.Text = "";
            }
            else
            {
                //error message and clear change due and focus on change due
                lblError.Text = "Please enter a valid number from 0 - 99";
                txtChangedue.Text = "";
                txtChangedue.Focus();
            }
        }
        // close if click exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
