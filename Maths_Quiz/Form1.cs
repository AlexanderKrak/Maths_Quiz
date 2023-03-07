using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maths_Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int counter = 10;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_startGame_Click(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Start();
            label_timer.Text = counter.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
                timer.Stop();
            label_timer.Text = counter.ToString();
            //Console.WriteLine("Your time is up");
        }
    }
}
