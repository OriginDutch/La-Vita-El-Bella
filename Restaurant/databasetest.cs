using MySql.Data.MySqlClient;
using MySql.Data;
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
    public partial class databasetest : Form
    {
        public databasetest()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           /* string connectionString = "datasource=remotemysql.com;port=3306;username=KOkL7wllES;password=ZkNaR0D22e;database=KOkL7wllES;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            databaseConnection.Open();
            MessageBox.Show("Connection Created");
            MySqlCommand cmd = new MySqlCommand(connectionString);
            cmd.CommandText = "Select * from [Tabel1]";

            MySqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                MessageBox.Show(rd["Test"].ToString());
            }*/

            string connectionString = "datasource=remotemysql.com;port=3306;username=KOkL7wllES;password=ZkNaR0D22e;database=KOkL7wllES;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            databaseConnection.Open();
            MessageBox.Show("Connection Created");
           // MySqlDataReader pullingdata = pulldata.ExecuteReader();
        }
    }
}
