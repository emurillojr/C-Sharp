using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Ernesto Murillo FINAL student scores main form code

namespace maint_student_scores
{
    public partial class Form1 : Form
    {
        public List<Student> studentList = new List<Student>(25);

        public Form1()
        {
            InitializeComponent();
            students.DataSource = studentList;  //Show students.
            students.DisplayMember = "Name";  //Display their name
        }

        public void UpdateStudentList()
        {
            students.DataSource = null;
            students.DataSource = studentList;
            students.DisplayMember = "Name";
        }

        public bool AddStudent(Student studentToAdd)
        {
            try
            {
                this.studentList.Add(studentToAdd); //add student to the list.
                UpdateStudentList(); //update student list.
            }
            catch { return false; }
            return true;
        }

        public bool UpdateStudent(int originalIndex, Student studentToEdit)
        {
            try
            {
                Student student = GetStudent(originalIndex);  //select index of student
                student.Name = studentToEdit.Name;  //name of student
                this.studentList.RemoveAt(originalIndex); //remove the student at the index selected
                this.studentList.Insert(originalIndex, student); //insert new student at index.
                UpdateStudentList(); //update student list
            }
            catch { return false; }
            return true;
        }

        public Student GetStudent(int id)  //Get student index
        {
            return studentList[1];   
        }

        public bool DeleteStudent(int id) //remove student at index.
        {
            try
            {
                studentList.RemoveAt(id); 
                UpdateStudentList();
            }
            catch { return false; }
            return true;
        }

        private void updateStudent_Click_1(object sender, EventArgs e)
        {
            UpdateStudentScoresForm updateStudentForm = new UpdateStudentScoresForm(this, students.SelectedIndex); //pass curent info to new form
            updateStudentForm.Show(); //open new form
        }

        private void deleteStudent_Click_1(object sender, EventArgs e)
        {
            if (!DeleteStudent(students.SelectedIndex))  //check if student is selected from list.
            MessageBox.Show("Error deleting student..."); //throw message box saying that a student isn't selected.
        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            this.Dispose();  //clear everything
            this.Close();  //close form
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            AddNewStudentForm addStudentForm = new AddNewStudentForm(this);  //pass info to new form
            addStudentForm.Show(); // open new form
        }

        private void students_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Student student = GetStudent(students.SelectedIndex);  //select index from list
            ScoreTotalTextBox.Text = student.GetScoreTotal().ToString(); //show Score Total to box
            ScoreCountTextBox.Text = student.GetScoreCount().ToString(); //show Score Count to box
            ScoreAverageTextBox.Text = student.GetScoreAverage().ToString(); //show Score Average to box               
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    Students.Add("Jim Bianco", new List<int> { 97, 71, 83 });
        //    studentList.Add("Tom Brady", new List<int> { 99, 93, 97 });
        //    studentList.Add("Ronda Rousey", new List<int> { 100, 100, 100 });
        //}
        }
}


