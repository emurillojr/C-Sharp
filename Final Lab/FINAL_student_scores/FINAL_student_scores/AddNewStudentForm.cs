using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


// Ernesto Murillo Final Add new student form code
namespace maint_student_scores
{
    public partial class AddNewStudentForm : Form
    {
        private Form1 parentForm;  //parent form
        private Student studentToAdd; //student list to add to

        public AddNewStudentForm(Form1 parentForm)
        {
            this.parentForm = parentForm;
            studentToAdd = new Student();
            InitializeComponent();
        }

        private void AddScore_Click(object sender, EventArgs e)
        {

            try
            {
                studentToAdd.AddScore(Convert.ToInt32(NewScoreValue.Text));  //add score to student
                UpdateScores();  //update score list
            }
            catch (FormatException)
            {
                MessageBox.Show("Score has to be nummeric value", "Error");
            }
        }

        private void UpdateScores() //update the score list in the box
        {
            Scores.Text = "";  
            foreach (int score in studentToAdd.GetScores())
            {
                Scores.Text += score.ToString() + " ";
            }
        }

        private void SaveStudent_Click_1(object sender, EventArgs e) //add student to previous form and add scores to that student
        {
            studentToAdd.Name = StudentName.Text;  
            this.parentForm.RemoveOwnedForm(this); 
            this.parentForm.AddStudent(studentToAdd); 
            this.Close();
        }

        private void ClearScoresButton_Click_1(object sender, EventArgs e)
        {
            studentToAdd.DestroyScores();  // remove all scores
            UpdateScores(); //update score box
        }

        private void CloseForm_Click_1(object sender, EventArgs e)
        {
            this.Close();  //close form
        }
    }
}
