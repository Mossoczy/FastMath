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
    public partial class FastMath : Form
    {
        string difficulty;
        char művelet;
        int counter;
        int cAnswers;
        double a = 0, b = 0, result;


        public FastMath()
        {
            InitializeComponent();
        }

        private void Osszeadas_Click(object sender, EventArgs e)
        {
            művelet = '+';
            this.Controls.Clear();
            Difficulty();
        }

        private void Kivonas_Click(object sender, EventArgs e)
        {
            művelet = '-';
            this.Controls.Clear();
            Difficulty();
        }

        private void Szorzas_Click(object sender, EventArgs e)
        {
            művelet = '*';
            this.Controls.Clear();
            Difficulty();
        }

        private void Osztas_Click(object sender, EventArgs e)
        {
            művelet = '/';
            this.Controls.Clear();
            Difficulty();
        }
        private void Easy_Click(object sender, System.EventArgs e)
        {
            this.Controls.Clear();
            Task();
            difficulty = "ez";
            startTask();
        }
        private void Medium_Click(object sender, System.EventArgs e)
        {
            this.Controls.Clear();
            Task();
            difficulty = "med";
            startTask();
        }
        private void Hard_Click(object sender, System.EventArgs e)
        {
            this.Controls.Clear();
            Task();
            difficulty = "hard";
            startTask();
        }
        private void Mixed_Click(object sender, System.EventArgs e)
        {
            this.Controls.Clear();
            Task();
            difficulty = "mixed";
            startTask();
        }
        private void startTask()
        {
            counter = 20;
            timeRemain.Text = "Hátralévő idő:\n" + counter + " másodperc";
            switch (művelet)
            {
                case '+':
                    DoOsszeadas(difficulty);
                    break;
                case '-':
                    DoKivonas(difficulty);
                    break;
                case '*':
                    DoSzorzas(difficulty);
                    break;
                case '/':
                    DoOsztas(difficulty);
                    break;
                default:
                    break;
            }
        }
        private void Task_Load(object sender, EventArgs e)
        {
            timer.Tick += new EventHandler(timer_Tick);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter = counter - 1;
                timeRemain.Text = "Hátralévő idő:\n" + counter + " másodperc";
                timer.Tick -= timer_Tick;
            }
            else
            {
                timer.Stop();
                timeRemain.Text = "Hátralévő idő:\n" + "Az idő lejárt!";
                MessageBox.Show("Sajnos nem sikerült időben befejezni.", ":(");
            }
        }
        private void DoOsszeadas(string difficulty)
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
                            DoOsszeadas(difficulty);
                            break;
                        case 2:
                            difficulty = "med";
                            DoOsszeadas(difficulty);
                            break;
                        case 3:
                            difficulty = "hard";
                            DoOsszeadas(difficulty);
                            break;
                        default:
                            MessageBox.Show("ERR");
                            break;
                    }
                    break;
                default:
                    break;
            }
            firstNum.Text = a.ToString() + művelet + b.ToString() + "=";
            result = a + b;
        }
        private void DoKivonas(string difficulty)
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
                            DoKivonas(difficulty);
                            break;
                        case 2:
                            difficulty = "med";
                            DoKivonas(difficulty);
                            break;
                        case 3:
                            difficulty = "hard";
                            DoKivonas(difficulty);
                            break;
                        default:
                            MessageBox.Show("ERR");
                            break;
                    }
                    break;
                default:
                    break;
            }
            firstNum.Text = a.ToString() + művelet + b.ToString() + "=";
            result = a - b;

        }
        private void DoSzorzas(string difficulty)
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
                    b = rnd.Next(31);
                    a = Math.Round(a, 2);
                    break;
                case "mixed":
                    int mix = rnd.Next(1, 4);
                    switch (mix)
                    {
                        case 1:
                            difficulty = "ez";
                            DoSzorzas(difficulty);
                            break;
                        case 2:
                            difficulty = "med";
                            DoSzorzas(difficulty);
                            break;
                        case 3:
                            difficulty = "hard";
                            DoSzorzas(difficulty);
                            break;
                        default:
                            MessageBox.Show("ERR");
                            break;
                    }
                    break;
                default:
                    break;
            }
            firstNum.Text = a.ToString() + művelet + b.ToString() + "=";
            result = a * b;

        }
        private void DoOsztas(string difficulty)
        {

        }

        private void done_Click(object sender, EventArgs e)
        {
            done.Text = "Kész";
            startTask();

            timer.Enabled = true;
            timer.Start();
        }
    }
}
