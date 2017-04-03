using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emurillo_ScoreCalc
{

    public partial class frmScoreCalculator : Form
    {
        public frmScoreCalculator()
        {
            InitializeComponent();
        }

        int[] ScoreTotalsArray = new int[5];
        int ScoreCount = 0;
        int scoreTotal = 0;
        int average;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int Score;
            if (!Int32.TryParse(txtScore.Text, out Score) || (Score < 0) || (Score > 100))
            {
                MessageBox.Show("Min Max error.  Score must be between 0-100.", "Error");
                txtScore.Focus();
                this.txtScore.Clear();
            }
            else
            {
                try
                {
                    Int32.TryParse(txtScore.Text, out Score);
                    ScoreTotalsArray[ScoreCount] = Score;  //add score to array and update index
                    ScoreCount++;
                    scoreTotal += Score;
                    average = (scoreTotal / ScoreCount);
                    txtScoreCount.Text = ScoreCount.ToString();
                    txtScore.Focus();
                    txtScore.SelectAll();  //selects all and highlights
                    txtScoreTotal.Text = scoreTotal.ToString();
                    txtAverage.Text = average.ToString();
                }

                catch (IndexOutOfRangeException)  // max 5 in array
                {
                    MessageBox.Show("Max Score Count error.  Maximum of 5 score counts allowed.", "Error");
                    txtScore.Focus();
                    this.txtScore.Clear();
                }

                catch (DivideByZeroException)  // just in case but it would never happen
                {
                    MessageBox.Show("Divide-by-zero error. Please enter a non-zero value.", "Error");
                    txtScore.Focus();
                    this.txtScore.Clear();
                }

                catch (OverflowException)  // overflow exception
                {
                    MessageBox.Show("Overflow exception error.  Please enter smaller values.", "Error");
                    txtScore.Focus();
                    this.txtScore.Clear();
                }

                catch (FormatException)  // non int error
                {
                    MessageBox.Show("Exception error:  Score must be numeric value. Please renter.", "Entry Error");
                    txtScore.Focus();
                    this.txtScore.Clear();
                }

                catch (Exception ex)   // any other 
                {
                    MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
                }
            }
        }

        private void btnClearScores_Click(object sender, EventArgs e)   // clear everything
        {
            this.txtScore.Clear();
            this.txtScoreCount.Clear();
            this.txtAverage.Clear();
            this.txtScoreTotal.Clear();
            this.scoreTotal = 0;  // after click clear scores , score total starts from 0 again
            this.ScoreCount = 0; // after click clear scores , score count starts from 0 again otherwise get forever IndexOutOfRangeException
            this.ScoreTotalsArray = new int[5]; // after click clear scores , clears the array stored 5 scores back to all 0's otherwise if you cleare score and display again, old 5 scores still there
            txtScore.Focus();  // after click clear scores , focus's back to score  
        }

        private void btnExit_Click(object sender, EventArgs e)   //exit
        {
            this.Close();
        }

        private void btnDisplayScores_Click(object sender, EventArgs e)   //disply scores popup
        {
            Array.Sort(ScoreTotalsArray);   //sorts array
            string numbersString = "";   // string
            for (int i = 0; i < ScoreTotalsArray.Length; i++)   //for loop 
            numbersString += ScoreTotalsArray[i] + "\n";   // display vertical
            MessageBox.Show(numbersString, "Score Array");    //show it
        }
    }
}
