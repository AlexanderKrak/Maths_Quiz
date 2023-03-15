using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Maths_Quiz
{
    public partial class Form1 : Form
    {
        
        private int seconds = 0;
        
        int numA;
        int numB;
        int total;

        Random rnd = new Random();
        string[] maths = { "Add", "Subtract", "Multiply" };

        string secretAnswer;
        string userChoice;

        public Form1()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            seconds = 10;
            timer1.Start();
            numA = rnd.Next(10, 20);
            numB = rnd.Next(0, 9);

            secretAnswer = maths[rnd.Next(0, maths.Length)];

            switch (secretAnswer)
            {
                case "Add":
                    total = numA + numB;
                    break;
                case "Subtract":
                    total = numA - numB;
                    break;
                case "Multiply":
                    total = numA * numB;
                    break;
            }

            label_left.Text = numA.ToString();
            label_right.Text = numB.ToString();
            label_total.Text = total.ToString();
            label_symbol.Text = "?";
        }

        private void CheckAnswer()
        {
            if (userChoice == secretAnswer)
            {
                timer1.Stop();
                MessageBox.Show("Correct. Try it again");
                SetUpGame();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Incorrect");
                label_symbol.Text = "?";
            }
        }

        //private void button_startGame_Click(object sender, EventArgs e)
        //{
        //    button_startGame.Enabled = false;
        //    seconds = 10;
        //    countdown_timer.Start();
        //}
        //
        //
        private void timer_Tick(object sender, EventArgs e)
        {
            label_time.Text = seconds--.ToString();
            if(label_time.Text == "0")
            {
                timer1.Stop();
                label_time.Text = "You re sucks";
                //button_startGame.Enabled = true;
        
            }
        }
        
        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                userChoice = "Add";
                label_symbol.Text = "+";
                CheckAnswer();

            }
            if (e.KeyCode == Keys.W)
            {
                userChoice = "Subtract";
                label_symbol.Text = "-";
                CheckAnswer();
            }
            if (e.KeyCode == Keys.E)
            {
                userChoice = "Multiply";
                label_symbol.Text = "x";
                CheckAnswer();
            }
        }
    }
}
