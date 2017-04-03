using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emurillo___Lab3
{
    public partial class frmCalcLetterGradeApp : Form
    {
        public frmCalcLetterGradeApp()
        {
            InitializeComponent();
        }
        // variables that needed to be non local.
        string grade;
        string answer;

        // function to clear all after type class and numeric grade are valid and after enter button is clicked. 
        private void clearAll()
        {
            txtStudentFullName.Text = "";
            txtTypeOfClass.Text = "";
            txtNumericGrade.Text = "";
        }

        // function for answer if type class and numeric grade are valid and after enter button is clicked.
        private void answerfinal()
        {
            string studentfullname = txtStudentFullName.Text;
            lblAnswer.Text = studentfullname + "'s final grade in " + answer + " is " + grade;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //  local variables
            string studentfullname = txtStudentFullName.Text;
            string typeclass = txtTypeOfClass.Text;
            decimal numgrade = Convert.ToDecimal(txtNumericGrade.Text);

            // Switch case to check type of class
            switch (typeclass)
            {
                case "m":
                case "M":
                    answer = "Math";
                    break;

                case "s":
                case "S":
                    answer = "Science";
                    break;

                case "e":
                case "E":
                    answer = "English";
                    break;

                default:
                    lblAnswer.Text = "Invalid CLass Type!  Enter M for Math, S for Science, or E for English only";
                    txtTypeOfClass.Text = "";
                    txtTypeOfClass.Focus();
                    break;
            }

            // nested if to change numeric grade to string grade with typeclass validation.
            if (typeclass == "S" | typeclass == "s" | typeclass == "M" | typeclass == "m" | typeclass == "E" | typeclass == "e")
            {
                if (numgrade >= 94 && numgrade <= 100)
                {
                    grade = "A";
                    answerfinal();
                    clearAll();
                    txtStudentFullName.Focus();
                }
                else if (numgrade >= 90 && numgrade < 94)
                {
                    grade = "A-";
                    answerfinal();
                    clearAll();
                    txtStudentFullName.Focus();
                }
                else if (numgrade >= 87 && numgrade < 90)
                {
                    grade = "B+";
                    answerfinal();
                    clearAll();
                    txtStudentFullName.Focus();
                }
                else if (numgrade >= 84 && numgrade < 87)
                {
                    grade = "B";
                    answerfinal();
                    clearAll();
                    txtStudentFullName.Focus();
                }
                else if (numgrade >= 80 && numgrade < 84)
                {
                    grade = "B-";
                    answerfinal();
                    clearAll();
                    txtStudentFullName.Focus();
                }
                else if (numgrade >= 77 && numgrade < 80)
                {
                    grade = "C+";
                    answerfinal();
                    clearAll();
                    txtStudentFullName.Focus();
                }
                else if (numgrade >= 74 && numgrade < 77)
                {
                    grade = "C-";
                    answerfinal();
                    clearAll();
                    txtStudentFullName.Focus();
                }
                else if (numgrade >= 70 && numgrade < 74)
                {
                    grade = "C";
                    answerfinal();
                    clearAll();
                    txtStudentFullName.Focus();
                }
                else if (numgrade >= 65 && numgrade < 70)
                {
                    grade = "D";
                    answerfinal();
                    clearAll();
                    txtStudentFullName.Focus();
                }
                else if (numgrade >= 0 && numgrade < 65)
                {
                    grade = "F";
                    answerfinal();
                    clearAll();
                    txtStudentFullName.Focus();
                }
                else if (numgrade > 100)
                {
                    lblAnswer.Text = "Please enter a valid number form 0 - 100";
                    txtNumericGrade.Focus();
                    txtNumericGrade.Text = "";
                }
                else
                    txtStudentFullName.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
