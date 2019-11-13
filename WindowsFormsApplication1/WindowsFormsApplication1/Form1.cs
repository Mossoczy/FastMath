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
        public int a;
        public int b;
        public int seg;
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timeLeft = 100;
            Random rnd = new Random();
            a = rnd.Next(100) + 1;
            b = rnd.Next(100) + 1;
            aLabel.Text = a.ToString();
            bLabel.Text = b.ToString();
            seg = a + b;
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
            if(timeLeft>0)
            { 
                timeLeft--;
                timeLabel.Text = timeLeft.ToString();
            }
            if(timeLeft==0)
            {
                doneButton.Enabled = false;
                startButton.Enabled = true;
                timer1.Stop();
                timeLabel.Text = "";
            }
        }

       

        private void doneButton_Click(object sender, EventArgs e)
        {
            doneButton.Enabled = false;
            startButton.Enabled = true;
            timer1.Stop();
            yoLabel.Text = "Helyes megoldás: "+seg;
            if(seg == answerBox.Text)
            {
                yodbLabel.Text = "Helyes megoldások száma: ";
            }
        }

        
    }
}
