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

namespace Restaurant
{
    public partial class Startscherm : Form
    {
        public Startscherm()
        {
            InitializeComponent();
        }

        public static string username;
        public static string recby
        {
            get { return username; }
            set { username = value; }
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("datasource=remotemysql.com;port=3306;username=KOkL7wllES;password=ZkNaR0D22e;database=KOkL7wllES;");
            MySqlDataAdapter da = new MySqlDataAdapter("select count(*) from Users where Username = '"+Username.Text+"' and Password = '"+Password.Text+"'",conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows[0][0].ToString() == "1")
            {
                recby = Username.Text;
                this.Hide();
                Form1 main = new Form1();
                main.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("datasource=remotemysql.com;port=3306;username=KOkL7wllES;password=ZkNaR0D22e;database=KOkL7wllES;");

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                MySqlCommand commandInsert = new MySqlCommand("INSERT INTO Users(Username,Password) VALUES(@Username,@Password)", conn);
                commandInsert.Parameters.AddWithValue("@Username", Username);
                commandInsert.Parameters.AddWithValue("@Password", Password);
                commandInsert.ExecuteNonQuery();
                commandInsert.Parameters.Clear();
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
