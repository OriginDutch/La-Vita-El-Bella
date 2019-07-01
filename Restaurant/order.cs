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
using System.Diagnostics;
using System.Globalization;

namespace Restaurant
{
    public partial class Order : UserControl
    {
        string connectionString = "datasource=remotemysql.com;port=3306;username=KOkL7wllES;password=ZkNaR0D22e;database=KOkL7wllES;";
        int[,] OrderList = new int[50, 4];

        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            TableNumberDisplay.Text = "Tafel : " + Tafels.CurrentTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Tafels.isBezet == false)
            {
                Tafels.isBezet = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Tafels.isBezet == true)
            {
                Tafels.isBezet = false;
            }
        }

        private void LoadPizzas_Click(object sender, EventArgs e)
        {
            while (flowLayoutPanel2.Controls.Count > 0) flowLayoutPanel2.Controls.RemoveAt(0);
            MySqlConnection dbc = new MySqlConnection(connectionString);
            dbc.Open();
            MySqlCommand pullData = new MySqlCommand("SELECT * FROM Pizzas", dbc);
            MySqlDataReader PullingData = pullData.ExecuteReader();

            while (PullingData.Read())
            {
                var Pizza = new Button
                {
                    Size = new Size(300, 25),
                    Text = "" + PullingData["PizzaName"],
                    Tag = "" + PullingData["ProductID"],
                    Name = "" + PullingData["PizzaPrice"]
                };
                flowLayoutPanel2.Controls.Add(Pizza);
                Pizza.Click += (object sending, EventArgs r) =>
                {
                    Debug.WriteLine("" + Pizza.Name + " - Name : " + Pizza.Text + " - ID : " + Pizza.Tag);
                    

                    var OrderPiece = new TextBox
                    {
                        Size = new Size(300, 25),
                        Text = Pizza.Text + " - Prijs €" + Pizza.Name,
                        ReadOnly = true
                    };

                    flowLayoutPanel1.Controls.Add(OrderPiece);

                };
            }
            dbc.Close();
        }

        private void LoadPastas_Click(object sender, EventArgs e)
        {
            while (flowLayoutPanel2.Controls.Count > 0) flowLayoutPanel2.Controls.RemoveAt(0);
            MySqlConnection dbc = new MySqlConnection(connectionString);
            dbc.Open();
            MySqlCommand pullData = new MySqlCommand("SELECT * FROM Pastas", dbc);
            MySqlDataReader PullingData = pullData.ExecuteReader();

            while (PullingData.Read())
            {
                var Pasta = new Button
                {
                    Size = new Size(300, 25),
                    Text = "" + PullingData["PastaName"],
                    Tag = "" + PullingData["ProductID"],
                    Name = "" + PullingData["PastaPrice"]
                };
                flowLayoutPanel2.Controls.Add(Pasta);
                Pasta.Click += (object sending, EventArgs r) =>
                {
                    Debug.WriteLine("" + Pasta.Name + " - Name : " + Pasta.Text + " - ID : " + Pasta.Tag);

                    var OrderPiece = new TextBox
                    {
                        Size = new Size(300, 25),
                        Text = Pasta.Text + " - Prijs €" + Pasta.Name,
                        ReadOnly = true
                    };

                    flowLayoutPanel1.Controls.Add(OrderPiece);

                };
            }
            dbc.Close();
        }

        private void LoadDrinks_Click(object sender, EventArgs e)
        {
            while (flowLayoutPanel2.Controls.Count > 0) flowLayoutPanel2.Controls.RemoveAt(0);
            MySqlConnection dbc = new MySqlConnection(connectionString);
            dbc.Open();
            MySqlCommand pullData = new MySqlCommand("SELECT * FROM Drinks", dbc);
            MySqlDataReader PullingData = pullData.ExecuteReader();

            while (PullingData.Read())
            {
                var Drink = new Button
                {
                    Size = new Size(300, 25),
                    Text = "" + PullingData["DrinkName"],
                    Tag = "" + PullingData["ProductID"],
                    Name = "" + PullingData["DrinkPrice"]
                };
                flowLayoutPanel2.Controls.Add(Drink);
                Drink.Click += (object sending, EventArgs r) =>
                {
                    Debug.WriteLine("" + Drink.Name + " - Name : " + Drink.Text + " - ID : " + Drink.Tag);

                    var OrderPiece = new TextBox
                    {
                        Size = new Size(300, 25),
                        Text = Drink.Text + " - Prijs € " + Drink.Name,
                        ReadOnly = true
                    };

                    flowLayoutPanel1.Controls.Add(OrderPiece);

                };
            }
            dbc.Close();
        }

        private void LoadDesserts_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           string query = "INSERT INTO Orders(`ProductID`, `Quantity`, `TableNum`, `OrderPrice`) VALUES ('ProductID', '', 'Tafels.CurrentTable ', '')";

        }
    }
}
