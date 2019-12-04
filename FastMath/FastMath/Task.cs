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
        double a = 0, b = 0;
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
                    a = rnd.NextDouble() *50;
                    b = rnd.NextDouble() *50;
                    a=Math.Round(a,2);
                    b=Math.Round(b,2);
                    break;
                case "mixed":
                    int mix = rnd.Next(1,4);
                    switch (mix)
	                {
                        case 1:
                            difficulty = "ez";
                            Osszeadas(difficulty);
                            break;
                        case 2:
                            difficulty = "med";
                            Osszeadas(difficulty);
                            break;
                        case 3:
                            difficulty = "hard";
                            Osszeadas(difficulty);
                            break;
                        default:
                            MessageBox.Show("ERR");
                            break;
	                }
                    break;
                default:
                    break;
            }
            firstNum.Text = a.ToString();
            secondNum.Text = b.ToString();
        }
        private void Kivonas(string difficulty)
        {
            Random rnd = new Random();
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
                    a = rnd.NextDouble() * 50;
                    b = rnd.NextDouble() * 50;
                    a = Math.Round(a, 2);
                    b = Math.Round(b, 2);
                    break;
                case "mixed":
                    int mix = rnd.Next(1, 4);
                    switch (mix)
                    {
                        case 1:
                            difficulty = "ez";
                            Kivonas(difficulty);
                            break;
                        case 2:
                            difficulty = "med";
                            Kivonas(difficulty);
                            break;
                        case 3:
                            difficulty = "hard";
                            Kivonas(difficulty);
                            break;
                        default:
                            MessageBox.Show("ERR");
                            break;
                    }
                    break;
                default:
                    break;
            }
            firstNum.Text = a.ToString();
            secondNum.Text = b.ToString();
        }
        private void Szorzas(string difficulty)
        {
            Random rnd = new Random();
            switch (difficulty)
            {
                case "ez":
                    a = rnd.Next(11);
                    b = rnd.Next(11);
                    break;
                case "med":
                    a = rnd.Next(51);
                    b = rnd.Next(51);
                    break;
                case "hard":
                    a = rnd.NextDouble() * 20;
                    b = rnd.Next(31) ;
                    a = Math.Round(a, 2);
                    break;
                case "mixed":
                    int mix = rnd.Next(1, 4);
                    switch (mix)
                    {
                        case 1:
                            difficulty = "ez";
                            Szorzas(difficulty);
                            break;
                        case 2:
                            difficulty = "med";
                            Szorzas(difficulty);
                            break;
                        case 3:
                            difficulty = "hard";
                            Szorzas(difficulty);
                            break;
                        default:
                            MessageBox.Show("ERR");
                            break;
                    }
                    break;
                default:
                    break;
            }
            firstNum.Text = a.ToString();
            secondNum.Text = b.ToString();
        }
        private void Osztas(string difficulty)
        {

        }

        private void done_Click(object sender, EventArgs e)
        {
            done.Text = "Kész";
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
