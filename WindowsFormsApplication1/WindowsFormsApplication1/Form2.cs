using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public string művelet;
       // public string Művelet { get { return művelet; } set { művelet = value; } }


        public Form2()
        {
            InitializeComponent();

        }

        public void osszeadGomb_Click(object sender, EventArgs e)
        {
            művelet = "+";
            Form1 form = new Form1(művelet);
            form.Show();
            this.Visible = false;
        }

        private void kivonGomb_Click(object sender, EventArgs e)
        {
            művelet = "-";
            Form1 form = new Form1(művelet);
            form.Show();
            this.Visible = false;
        }

        private void szorozGomb_Click(object sender, EventArgs e)
        {
            művelet = "*";
            Form1 form = new Form1(művelet);
            form.Show();
            this.Visible = false;
        }

        private void osztGomb_Click(object sender, EventArgs e)
        {
            művelet = "/";
            Form1 form = new Form1(művelet);
            form.Show();
            this.Visible = false;
        }

    }
}
