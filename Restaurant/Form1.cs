using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Restaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
  

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chef main = new Chef();
            main.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Waiter main = new Waiter();
            main.Show();
            this.Hide();
        }

        //Zorgt ervoor dat het kruisje rechtbovenin daadwerkelijk de app afsluit
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            databasetest main = new databasetest();
            main.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var myControl = new Tafels();
            panel1.Controls.Add(myControl);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var myControl = new test();
            panel1.Controls.Add(myControl);
        }
    }
}
