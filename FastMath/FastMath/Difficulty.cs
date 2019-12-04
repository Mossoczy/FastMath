using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FastMath
{
    public partial class Difficulty : Form
    {
        char művelet;
        public Difficulty(char művelet)
        {
            this.művelet = művelet;
            InitializeComponent();
        }
        private void OpenNewForm(string difficulty)
        {
            Task task = new Task(difficulty, művelet);
            Application.Run(task);
        }

        private void Easy_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => OpenNewForm("ez"));
            thread.Start();
            this.Close();
        }

        private void Medium_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => OpenNewForm("med"));
            thread.Start();
            this.Close();
        }

        private void Hard_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => OpenNewForm("hard"));
            thread.Start();
            this.Close();
        }

        private void Mixed_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => OpenNewForm("mixed"));
            thread.Start();
            this.Close();
        }
    }
}
