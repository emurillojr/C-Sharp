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

        int scoreCount = 0;
        decimal scoreTotal = 0m;
        decimal average = 0m;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal scores = Convert.ToDecimal(txtScore.Text);
            scoreCount++;
            scoreTotal += scores;
            average = Math.Round(scoreTotal / scoreCount, 2);
                     
            txtScoreCount.Text = scoreCount.ToString();
            txtScoreTotal.Text = scoreTotal.ToString("c");
            txtAverage.Text = average.ToString("c");
            
            txtScore.Text = "";
            txtScore.Focus();
        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            scoreTotal = 0m;
            scoreCount = 0;
            average = 0m;

            txtScoreTotal.Text = "";
            txtScoreCount.Text = "";
            txtAverage.Text = "";
            
            txtScore.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
