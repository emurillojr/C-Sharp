using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Reservations
{
    public partial class Reservations : Form
    {
        public Reservations()
        {
            InitializeComponent();
        }

        DateTime aDate, dDate;
        DateTime dtUpperBoundary = DateTime.Today.AddDays(365 * 5);   // 5 year mark

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            String arrival, departure;     // assign variables       
            arrival = txtArrivalDate.Text;   // assign variable to textbox
            departure = txtDepartureDate.Text;  // assign variable to textbox
            decimal price = 115.00m;

            if (string.IsNullOrEmpty(txtArrivalDate.Text) || !DateTime.TryParse(txtArrivalDate.Text, out aDate))  // if arrival date is null or empty or not a date
            {
                MessageBox.Show("Invalid arrival date. Please enter in format DD/MM/YYYY", "Error");
                txtArrivalDate.Focus();
            }

            else if (string.IsNullOrEmpty(txtDepartureDate.Text) || !DateTime.TryParse(txtDepartureDate.Text, out dDate)) // if departure date is null or empty or not a date
            {
                MessageBox.Show("Invalid departure date. Please enter in format DD/MM/YYYY", "Error");
                txtDepartureDate.Focus();
            }

            else if (dDate < aDate)   // if departure date is less than todays date or less than arrival date
            {
                MessageBox.Show("Departure Date cannot be less than Arrival Date", "Error");
                txtDepartureDate.Focus();
            }

            else if (dDate > dtUpperBoundary || aDate > dtUpperBoundary)   //if arrival or departure date is greater than 5 years
            {
                MessageBox.Show("Departure / Arrival Date cannot be more than 5 years in the future", "Error");

            }

            else if (aDate == dDate)   // if arrival date and departure date are the same
            {
                MessageBox.Show("You cannot depart and arrive on the same date", "Error");
            }

            else
            {
                // variables again
                aDate = DateTime.Parse(arrival);
                dDate = DateTime.Parse(departure);
                TimeSpan dateDiff;
                dateDiff = dDate.Subtract(aDate);
                int nights = (int)dateDiff.TotalDays;    // get total days from difference of dates
                txtNumberOfNights.Text = ("" + nights);
                txtTotalPrice.Text = ("$" + (nights * price));  // calc
                txtPricePerNight.Text = ("$" + (Convert.ToString(price)));
            }
        }

        private void Reservations_Load(object sender, EventArgs e)
        {
            txtArrivalDate.Text = DateTime.Today.ToShortDateString();    //auto display on load todays date
            txtDepartureDate.Text = DateTime.Today.AddDays(3).ToShortDateString();  //auto display on load todays date +3 days
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();  //close
        }

        private void txtArrivalDate_TextChanged(object sender, EventArgs e)
        {
            txtNumberOfNights.Clear();  //clears
            txtPricePerNight.Clear();
            txtTotalPrice.Clear();
        }

        private void txtDepartureDate_TextChanged(object sender, EventArgs e)
        {
            txtNumberOfNights.Clear();  //clears
            txtPricePerNight.Clear();
            txtTotalPrice.Clear();
        }
    }
}
