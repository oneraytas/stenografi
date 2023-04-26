using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stenografi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sifrele_Click(object sender, EventArgs e)
        {
            stenosifre cagir =new stenosifre();
            cagir.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void coz_Click(object sender, EventArgs e)
        {
            stenocoz cagir = new stenocoz();
            cagir.Show();
            this.Hide();
        }
    }
}
