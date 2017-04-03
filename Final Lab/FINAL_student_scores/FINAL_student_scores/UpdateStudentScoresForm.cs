using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Ernesto Murillo FINAL update student scores code
namespace maint_student_scores
{
    public partial class UpdateStudentScoresForm : Form
    {
        private Form1 parentForm;  //main form
        private Student studentToEdit; //student list
        private int index; //index

        public UpdateStudentScoresForm(Form1 parentForm, int index)  //update parent form (Form1) with the new student and scores
        {
            this.parentForm = parentForm;
            this.index = index;
            this.studentToEdit = this.parentForm.GetStudent(index);
            InitializeComponent();
            this.StudentName.Text = this.studentToEdit.Name;
            UpdateScoreDisplay();
        }

        public void AddScoreToStudent(int value) //add score to current student and display in the list
        {
            studentToEdit.AddScore(value);
            UpdateScoreDisplay();
        }

        public void UpdateScoreAtIndex(int id, int value)  //update a score selected from the list
        {
            studentToEdit.GetScores()[id] = value;
            UpdateScoreDisplay();
        }

        public int GetScoreAtIndex(int id)  //get the score index
        {
            return studentToEdit.GetScoreAt(id);
        }

        private void UpdateScoreDisplay()  //update the score display list
        {
            this.CurrentScores.DataSource = null;
            this.CurrentScores.DataSource = studentToEdit.GetScores();
        }

        private void AddScoreButton_Click(object sender, EventArgs e)  //open the add score form
        {
            AddScoreForm addScoreForm = new AddScoreForm(this);
            addScoreForm.Show();
        }

        private void RemoveScoreButton_Click_1(object sender, EventArgs e) //remove a score from current index and update display list
        {
            studentToEdit.GetScores().RemoveAt(CurrentScores.SelectedIndex);
            UpdateScoreDisplay();
        }

        private void ClearScoresButton_Click_1(object sender, EventArgs e) //clear all scores
        {
            studentToEdit.DestroyScores();
            UpdateScoreDisplay();
        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            this.Close();  //close form
        }

        private void UpdateButton_Click_1(object sender, EventArgs e)  //open update form for current student
        {
            Student updatedStudent = new Student();
            updatedStudent.Name = StudentName.Text;
            this.parentForm.UpdateStudent(index, updatedStudent);
            this.Close();
        }

        private void UpdateScoresButton_Click(object sender, EventArgs e)
        {
            UpdateScoreForm updateScoreForm = new UpdateScoreForm(this, CurrentScores.SelectedIndex);
            updateScoreForm.Show();
        }
    }
}
