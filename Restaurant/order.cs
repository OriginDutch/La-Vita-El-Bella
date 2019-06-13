using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
        }

        private void order_Load(object sender, EventArgs e)
        {

        }

        private void order_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Terug_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }
    }
}
