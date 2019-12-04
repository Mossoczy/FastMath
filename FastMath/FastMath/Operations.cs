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
    public partial class ChooseOperation : Form
    {
        public ChooseOperation()
        {
            InitializeComponent();
        }
        private void OpenNewForm(char művelet)
        {
            Difficulty dif = new Difficulty(művelet);
            Application.Run(dif); 
        }

        private void Osszeadas_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => OpenNewForm('+'));
            thread.Start();
            this.Close();
        }

        private void Kivonas_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => OpenNewForm('-'));
            thread.Start();
            this.Close();
        }

        private void Szorzas_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => OpenNewForm('*'));
            thread.Start();
            this.Close();
        }

        private void Osztas_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => OpenNewForm('/'));
            thread.Start();
            this.Close();
        }
    }
}
