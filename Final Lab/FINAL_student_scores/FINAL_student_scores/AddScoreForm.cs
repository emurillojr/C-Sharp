using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Ernesto Murillo FINAL add score form code
namespace maint_student_scores
{
    public partial class AddScoreForm : Form
    {
        private UpdateStudentScoresForm parentForm;

        public AddScoreForm(UpdateStudentScoresForm parentForm)
        {
            this.parentForm = parentForm; //allow adding score to previous student selected
            InitializeComponent();
        }

        private void CancelButton1_Click(object sender, EventArgs e)
        {
            this.Close();  //close form
        }

        private void AddScoreButton_Click_1(object sender, EventArgs e)
        {
            parentForm.AddScoreToStudent(Convert.ToInt32(ScoreValue.Text));  //add score to current student (from previous form)
            this.Close();
        }
    }
}
