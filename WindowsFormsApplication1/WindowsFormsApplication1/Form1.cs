using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public int timeLeft;
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timeLeft = 1000;
            Random rnd = new Random();
            int a = rnd.Next(100) + 1;
            int b = rnd.Next(100) + 1;
            aLabel.Text = a.ToString();
            bLabel.Text = b.ToString();

            timer1.Start();

            startButton.Enabled = false;
            doneButton.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            timeLabel.Text = timeLeft.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
