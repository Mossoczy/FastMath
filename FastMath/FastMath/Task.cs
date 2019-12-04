using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastMath
{
    public partial class Task : Form
    {
        string difficulty;
        char művelet;
        int counter = 20;
        public Task(string difficulty,char művelet)
        {
            InitializeComponent();
            this.difficulty = difficulty;
            this.művelet = művelet;
        }

        private void Task_Load(object sender, EventArgs e)
        {
            timeRemain.Text = "Hátralévő idő: " + counter + " másodperc";
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter = counter - 1;
                timeRemain.Text = "Hátralévő idő: " + counter + " másodperc";
                timer.Tick -= timer_Tick;
            }
            else
            {
                timer.Stop();
                timeRemain.Text = "Hátralévő idő: " + "Az idő lejárt!";
                MessageBox.Show("Sajnos nem sikerült időben befejezni.",":(");
            }
        }
        private void Osszeadas(string difficulty)
        {
            Random rnd = new Random();
            double a=0, b =0;
            switch (difficulty)
            {
                case "ez":
                    a = rnd.Next(101);
                    b = rnd.Next(101);
                    break;
                case "med":
                    a = rnd.Next(1001);
                    b = rnd.Next(1001);
                    break;
                case "hard":
                    a = rnd.NextDouble();
                    b = rnd.NextDouble();
                    break;
                case "mixed":
                    break;
                default:
                    break;
            }
            firstNum.Text = a.ToString("F2");
            secondNum.Text = b.ToString("F2");
        }
        private void Kivonas(string difficulty)
        {

        }
        private void Szorzas(string difficulty)
        {

        }
        private void Osztas(string difficulty)
        {

        }

        private void done_Click(object sender, EventArgs e)
        {
            counter = 21;
            Operation.Text = művelet.ToString();
            switch (művelet)
            {
                case '+':
                    Osszeadas(difficulty);
                    break;
                case '-':
                    Kivonas(difficulty);
                    break;
                case '*':
                    Szorzas(difficulty);
                    break;
                case '/':
                    Osztas(difficulty);
                    break;
                default:
                    break;
            }
            timer.Enabled = true;
            timer.Start();
        }
    }
}
