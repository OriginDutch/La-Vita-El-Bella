using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Restaurant
{
    public partial class OrderHistory : UserControl
       
    {
        List<int> entryID = new List<int>();
        public OrderHistory()
        {
            InitializeComponent();
            loadFromDatabase();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=remotemysql.com;port=3306;username=KOkL7wllES;password=ZkNaR0D22e;database=KOkL7wllES;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            databaseConnection.Open();
            //test als de database het doet
            MessageBox.Show("Connection Created");
            MySqlCommand test = new MySqlCommand("SELECT * FROM Orders WHERE OrderStatus = 1", databaseConnection);
        }


        //Connect naar de database
        public void loadFromDatabase()
        {
            // Maak De datbase connectie
            string connectionString = "datasource=remotemysql.com;port=3306;username=KOkL7wllES;password=ZkNaR0D22e;database=KOkL7wllES;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            //Open de database connectie
            databaseConnection.Open();

            // Laat alleen de orders zien waar de OrderStatus 0 is
            MySqlCommand pulldata = new MySqlCommand("SELECT * FROM Orders WHERE OrderStatus = 1", databaseConnection);
            MySqlDataReader pullingdata = pulldata.ExecuteReader();

            //Lees alle data in
            while (pullingdata.Read())
            {


                entryID.Add(Int32.Parse(pullingdata["OrderID"].ToString()));

                // Maar de OrderIdButton String en geef hem de OrderId
                string OrderIdButton = pullingdata["OrderID"].ToString();

                //maak de blokjes aan
                var FlowBox = new FlowLayoutPanel
                {
                    Size = new Size(1674, 100),
                  
                };
                flowLayoutPanel1.Controls.Add(FlowBox);

                //laat het taffelnummer zien
                var TafelNummer = new Label
                {
                    Size = new Size(200, 100),
                    Text = "Tafelnummer: " + pullingdata["TableNum"],
                    Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold),
                };
                FlowBox.Controls.Add(TafelNummer);

                //laat het gerecht zien
                var NameText = new Label
                {
                    Size = new Size(200, 100),
                    Text = "", //+ pullingdata["DishName"],
                               //ReadOnly = true
                };
                FlowBox.Controls.Add(NameText);

                //laat de OrderId zien
                var OrderId = new Label
                {
                    Size = new Size(200, 100),
                    Text = "Order ID = " + pullingdata["OrderID"],
                };
                FlowBox.Controls.Add(OrderId);

                

                var Price = new Label
                {
                    Size = new Size(410, 100),
                    Text = "Prijs €  = " + pullingdata["OrderPrice"],
                };
                FlowBox.Controls.Add(Price);
            }
            databaseConnection.Close();

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            float price, total = 0;
            string connectionString = "datasource=remotemysql.com;port=3306;username=KOkL7wllES;password=ZkNaR0D22e;database=KOkL7wllES;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            databaseConnection.Open();

            MySqlCommand pulldata = new MySqlCommand("SELECT * FROM Orders WHERE OrderStatus = 1", databaseConnection);
            MySqlDataReader pullingdata = pulldata.ExecuteReader();
            while (pullingdata.Read()) {

                price = float.Parse(pullingdata["OrderPrice"].ToString());
                total = total + price;
                textBox1.Text = total.ToString();
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        

        
    }
}
