using menu_la_vita_e_bella;
using MySql.Data.MySqlClient;
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
    public partial class MainMenu : Form
    {

        static public bool[] isBezet1 = new bool[12];
        public MainMenu()
        {
            InitializeComponent();
        }
  

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("datasource=remotemysql.com;port=3306;username=KOkL7wllES;password=ZkNaR0D22e;database=KOkL7wllES;");
           // conn.Open();
            label3.Text= Startscherm.recby;
        }

        //Zorgt ervoor dat het kruisje rechtbovenin daadwerkelijk de app afsluit
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Order History knop
        private void OrHi_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var myControl = new OrderHistory();
            panel1.Controls.Add(myControl);
        }

        //Chef Menu knop
        private void ChMe_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var myControl = new chef();
            panel1.Controls.Add(myControl);
        }

        //Tafeltjes scherm
        private void Tafel_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var myControl = new Tafels(panel1);
            panel1.Controls.Add(myControl);
        }


        private void Menu_click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var myControl = new Form1(panel1);
            panel1.Controls.Add(myControl);
        }

        private void Conn_Click(object sender, EventArgs e)
        {
            databasetest main = new databasetest();
            main.Show();
            this.Hide();
        }
    }
}
