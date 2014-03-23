using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuizzer
{
    public partial class Form1 : Form
    {
        private Problem problem = new Problem();
        public Form1()
        {
            InitializeComponent();
            labelAssign(problem);
        }

        private void labelAssign(Problem problem)
        {
            operand1.Text = problem.operand1.ToString();
            operand2.Text = problem.operand2.ToString();
            op.Text = problem.operate.ToString();
            hiddenAnswer.Text = problem.trueAnswer.ToString();
            answerButton1.Text = problem.possibleAnswers[0].ToString();
            answerButton2.Text = problem.possibleAnswers[1].ToString();
            answerButton3.Text = problem.possibleAnswers[2].ToString();
            answerButton4.Text = problem.possibleAnswers[3].ToString();
        }

        private void answerButton1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("True Answer: " + problem.trueAnswer + " | Answer Compared: " + problem.possibleAnswers[0]);
            if (problem.possibleAnswers[0] == problem.trueAnswer)
            {
                problem = new Problem();
                labelAssign(problem);
                Console.Write("Answer Correct.");
                operand1.ForeColor = Color.Green;
                operand2.ForeColor = Color.Green;
                op.ForeColor = Color.Green;
            }
            else
            {
                problem = new Problem();
                labelAssign(problem);
                Console.Write("Answer Incorrect.");
                operand1.ForeColor = Color.Red;
                operand2.ForeColor = Color.Red;
                op.ForeColor = Color.Red;
            }            
        }

        private void answerButton2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("True Answer: " + problem.trueAnswer + " | Answer Compared: " + problem.possibleAnswers[1]);
            if (problem.possibleAnswers[1] == problem.trueAnswer)            
            {
                problem = new Problem();
                labelAssign(problem);
                Console.Write("Answer Correct.");
                operand1.ForeColor = Color.Green;
                operand2.ForeColor = Color.Green;
                op.ForeColor = Color.Green;
            }
            else
            {
                problem = new Problem();
                labelAssign(problem);
                Console.Write("Answer Incorrect.");
                operand1.ForeColor = Color.Red;
                operand2.ForeColor = Color.Red;
                op.ForeColor = Color.Red;    
            }      
        }

        private void answerButton3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("True Answer: " + problem.trueAnswer + " | Answer Compared: " + problem.possibleAnswers[2]);
            if (problem.possibleAnswers[2] == problem.trueAnswer)
            {
                problem = new Problem();
                labelAssign(problem);
                Console.Write("Answer Correct.");
                operand1.ForeColor = Color.Green;
                operand2.ForeColor = Color.Green;
                op.ForeColor = Color.Green;
            }
            else
            {
                problem = new Problem();
                labelAssign(problem);
                Console.Write("Answer Incorrect.");
                operand1.ForeColor = Color.Red;
                operand2.ForeColor = Color.Red;
                op.ForeColor = Color.Red;    
            }
        }

        private void answerButton4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("True Answer: " + problem.trueAnswer + " | Answer Compared: " + problem.possibleAnswers[3]);
            if (problem.possibleAnswers[3] == problem.trueAnswer)
            {
                problem = new Problem();
                labelAssign(problem);
                Console.Write("Answer Correct.");
                operand1.ForeColor = Color.Green;
                operand2.ForeColor = Color.Green;
                op.ForeColor = Color.Green;
            }
            else
            {
                problem = new Problem();
                labelAssign(problem);
                Console.Write("Answer Incorrect.");
                operand1.ForeColor = Color.Red;
                operand2.ForeColor = Color.Red;
                op.ForeColor = Color.Red;     
            }                    
        }
    }
}
