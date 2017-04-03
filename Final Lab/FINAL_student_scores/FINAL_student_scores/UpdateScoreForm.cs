using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Ernesto Murillo FINAL update score form code
namespace maint_student_scores
{
    public partial class UpdateScoreForm : Form
    {
        private UpdateStudentScoresForm parentForm; //current form
        private int index; //index of score

        public UpdateScoreForm(UpdateStudentScoresForm parentForm, int index)  //pull score from previous form.
        {
            this.parentForm = parentForm;
            this.index = index;
            InitializeComponent();
            this.CurrentScore.Text = this.parentForm.GetScoreAtIndex(index).ToString();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close(); //close form
        }

        private void UpdateButton_Click_1(object sender, EventArgs e) //update current score that was selected from previous form
        {
            this.parentForm.UpdateScoreAtIndex(index, Convert.ToInt32(CurrentScore.Text));
            this.Close();
        }
    }
}
