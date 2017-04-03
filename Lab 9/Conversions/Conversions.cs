using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversions
{
    public partial class Conversions : Form
    {
        public Conversions()
        {
            InitializeComponent();
        }

        string[,] conversionTable = {
            { "Miles to kilometers", "Miles", "Kilometers", "1.6093" },
            { "Kilometers to miles", "Kilometers", "Miles", "0.6214" },
            { "Feet to meters", "Feet", "Meters", "0.3048" },
            { "Meters to feet", "Meters", "Feet", "3.2808" },
            { "Inches to centimeters", "Inches", "Centimeters", "2.54" },
            { "Centimeters to inches", "Centimeters", "Inches", "0.3937" }
        };

        //isPresent validation function
        public bool isPresent(TextBox somethinghere)
        {
            if (somethinghere.Text == "")
            {
                MessageBox.Show("Invalid Entry. You cannot have a leave the amount Box empty", "Error");
                return false;
            }
            else
            {
                return true;
            }
        }
        //isDecimal format catch
        public bool isDecimal(TextBox decimalonly)
        {
            decimal notDecimal = 0;
            if (decimal.TryParse(decimalonly.Text, out notDecimal))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Entry. Numeric entry only please", "Error");
                return false;
            }
        }
        
        private void Conversions_Load(object sender, EventArgs e)
        {
            // grab the first index of each row of the array
            int firststringonly = conversionTable.GetLength(0);
            for (int i = 0; i < firststringonly; i++)
            {
                cboNames.Items.Add(conversionTable[i, 0]);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (isPresent(txtAmount) == true && isDecimal(txtAmount) == true)
            {
                //variables -converting index to double
                double MilesKilometers = Convert.ToDouble(conversionTable[0, 3]);
                double KilometersToMiles = Convert.ToDouble(conversionTable[1, 3]);
                double FeetToMeters = Convert.ToDouble(conversionTable[2, 3]);
                double MetersToFeet = Convert.ToDouble(conversionTable[3, 3]);
                double InchesToCentimeters = Convert.ToDouble(conversionTable[4, 3]);
                double CentimetersToInches = Convert.ToDouble(conversionTable[5, 3]);
                double amount = Convert.ToDouble(txtAmount.Text);
                double result;
                //if's and caluclation per each array chosen
                if (cboNames.Text == (conversionTable[0, 0]))
                {
                    result = amount * MilesKilometers;
                    txtAnswer.Text = result.ToString();
                }
                if (cboNames.Text == (conversionTable[1, 0]))
                {
                    result = amount * KilometersToMiles;
                    txtAnswer.Text = result.ToString();
                }
                if (cboNames.Text == (conversionTable[2, 0]))
                {
                    result = amount * FeetToMeters;
                    txtAnswer.Text = result.ToString();
                }
                if (cboNames.Text == (conversionTable[3, 0]))
                {
                    result = amount * MetersToFeet;
                    txtAnswer.Text = result.ToString();
                }
                if (cboNames.Text == (conversionTable[4, 0]))
                {
                    result = amount * InchesToCentimeters;
                    txtAnswer.Text = result.ToString();
                }
                if (cboNames.Text == (conversionTable[5, 0]))
                {
                    result = amount * CentimetersToInches;
                    txtAnswer.Text = result.ToString();
                }
            }
        }

        private void cboNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Miles to KM conversion and display array index text string
            if (cboNames.Text == (conversionTable[0, 0]))
            {
                lblFrom.Text = conversionTable[0, 1];
                lblTo.Text = conversionTable[0, 2];
            }
            //KM to Miles conversion and display array index text string
            if (cboNames.Text == (conversionTable[1, 0]))
            {
                lblFrom.Text = conversionTable[1, 1];
                lblTo.Text = conversionTable[1, 2];
            }
            //Ft to Meters conversion and display array index text string
            if (cboNames.Text == (conversionTable[2, 0]))
            {
                lblFrom.Text = conversionTable[2, 1];
                lblTo.Text = conversionTable[2, 2];
            }
            //Meters to Ft conversion and display array index text string
            if (cboNames.Text == (conversionTable[3, 0]))
            {
                lblFrom.Text = conversionTable[3, 1];
                lblTo.Text = conversionTable[3, 2];
            }
            //Inches to cm conversion and display array index text string
            if (cboNames.Text == (conversionTable[4, 0]))
            {
                lblFrom.Text = conversionTable[4, 1];
                lblTo.Text = conversionTable[4, 2];
            }
            //cm to Inches conversion and display array index text string
            if (cboNames.Text == (conversionTable[5, 0]))
            {
                lblFrom.Text = conversionTable[5, 1];
                lblTo.Text = conversionTable[5, 2];
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}