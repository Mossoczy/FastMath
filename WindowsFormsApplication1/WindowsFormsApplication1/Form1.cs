using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {   
        Form2 asd = new Form2();
        public int segg = 0;
        public int timeLeft;
        public int a;
        public int b;
        public int seg;
        public string művelet;
        public Form1(string művelet)
        {
            this.művelet = művelet;
            InitializeComponent();
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            switch (művelet)
	        {
                case "+":
                    Osszeadas();
                    break;
                case "-":
                    Kivonas();
                    break;
                case "*":
                    Szorzas();
                    break;
                case "/":
                    Osztas();
                    break;
		        default:
                    break;
	        }
            timeLeft = 100;
            timer1.Start();
            yoLabel.Text = "Helyes megoldás: ";
            startButton.Enabled = false;
            doneButton.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label2.Text = művelet;
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
            if(seg == Convert.ToInt32(answerBox.Text))
            {
                segg++;
                yodbLabel.Text = "Helyes megoldások száma: "+ segg ;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void valasszBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vissza_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 form2 = new Form2();
            form2.Show();
        }
        public void Osszeadas()
        {
            Random rnd = new Random();
            if (valasszBox.SelectedItem == "Könnyű")
            {
                a = rnd.Next(100) + 1;
                b = rnd.Next(100) + 1;
            }
            if (valasszBox.SelectedItem == "Közepes")
            {
                a = rnd.Next(1000) + 1;
                b = rnd.Next(1000) + 1;
            }
            if (valasszBox.SelectedValue == "Nehéz")
            {
                a = rnd.Next(10000) + 1;
                b = rnd.Next(10000) + 1;
            }
            aLabel.Text = a.ToString();
            bLabel.Text = b.ToString();
            seg = a + b;
        }
        public void Kivonas()
        {
            Random rnd = new Random();
            if (valasszBox.SelectedItem == "Könnyű")
            {
                a = rnd.Next(100) + 1;
                b = rnd.Next(100) + 1;
            }
            if (valasszBox.SelectedItem == "Közepes")
            {
                a = rnd.Next(1000) + 1;
                b = rnd.Next(1000) + 1;
            }
            if (valasszBox.SelectedItem == "Nehéz")
            {
                a = rnd.Next(10000) + 1;
                b = rnd.Next(10000) + 1;
            }
            aLabel.Text = a.ToString();
            bLabel.Text = b.ToString();
            seg = a - b;
        }
        public void Szorzas()
        {
            Random rnd = new Random();
            if (valasszBox.SelectedItem == "Könnyű")
            {
                a = rnd.Next(100) + 1;
                b = rnd.Next(100) + 1;
            }
            if (valasszBox.SelectedItem == "Közepes")
            {
                a = rnd.Next(1000) + 1;
                b = rnd.Next(1000) + 1;
            }
            if (valasszBox.SelectedItem == "Nehéz")
            {
                a = rnd.Next(10000) + 1;
                b = rnd.Next(10000) + 1;
            }
            aLabel.Text = a.ToString();
            bLabel.Text = b.ToString();
            seg = a - b;
        }
        public void Osztas()
        {
            Random rnd = new Random();
            if (valasszBox.SelectedItem == "Könnyű")
            {
                a = rnd.Next(100) + 1;
                b = rnd.Next(100) + 1;
            }
            if (valasszBox.SelectedItem == "Közepes")
            {
                a = rnd.Next(1000) + 1;
                b = rnd.Next(1000) + 1;
            }
            if (valasszBox.SelectedItem == "Nehéz")
            {
                a = rnd.Next(10000) + 1;
                b = rnd.Next(10000) + 1;
            }
            aLabel.Text = a.ToString();
            bLabel.Text = b.ToString();
            seg = a - b;
        }
    }
}
