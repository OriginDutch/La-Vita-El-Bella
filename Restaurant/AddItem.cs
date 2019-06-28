using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace menu_la_vita_e_bella
{
    public partial class AddItem : Form
    {
        string MySQLConnectionString = "datasource=remotemysql.com;port=3306;username=KOkL7wllES;password=ZkNaR0D22e;database=KOkL7wllES";

        public AddItem()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Selection = ComboBox1.Text;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection DatabaseConnection = new MySqlConnection(MySQLConnectionString);
            

                //checks if price tb is empty, if not it converts it to a float
            if (TextBoxPrice.Text == "")
            {
                MessageBox.Show("Error: invalid price");
                return;
            }
            float Price = float.Parse(TextBoxPrice.Text);

            string Name = TextBoxName.Text;
            string Selection = ComboBox1.Text;

                //checks if all info except for note is inputted
            if (Name == "" | Selection == "" | Price <= 0)
            {
                MessageBox.Show("Error: invalid name, price, or selection");
                return;
            }
 
                //uses the selection string to input data into correct table and updates the productid
            string QueryAddItem = "INSERT INTO " + Selection + "s(" + Selection + "Name, " + Selection + "Price) VALUES ('" + Name + "','" + Price + "')";
            string QueryUpdateProductID = "UPDATE Pizzas, Pastas, Drinks SET Pizzas.ProductID = CONCAT(1, PizzaID), Pastas.ProductID = CONCAT(2, PastaID), Drinks.ProductID = CONCAT(3, DrinkID)";

            MySqlCommand AddItem = new MySqlCommand(QueryAddItem, DatabaseConnection);
            MySqlCommand UpdateProductID = new MySqlCommand(QueryUpdateProductID, DatabaseConnection);

            DatabaseConnection.Open();
            MySqlDataReader MyReader = AddItem.ExecuteReader();
            DatabaseConnection.Close();
            DatabaseConnection.Open();
            MySqlDataReader MyReader2 = UpdateProductID.ExecuteReader();

            MessageBox.Show("Successfully added!");
            this.Hide();
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
