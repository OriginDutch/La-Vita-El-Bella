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
        string connectionString = "datasource=remotemysql.com;port=3306;username=KOkL7wllES;password=ZkNaR0D22e;database=KOkL7wllES;";

        public databasetest()
        {
            InitializeComponent();
        }
        private void databasetest_Load(object sender, EventArgs e)
        {
            MySQLFunctions.Refresh(dataGrid);
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MessageBox.Show("Connection Created");
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DrinkName.Text != "" && DrinkPrice.Text != "")
            {
                MySQLFunctions.InsertDrink(DrinkName.Text, int.Parse(DrinkPrice.Text), dataGrid);
                MySQLFunctions.Refresh(dataGrid);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            MySQLFunctions.DeleteRow(dataGrid);
            MySQLFunctions.Refresh(dataGrid);
        }
    }

}

