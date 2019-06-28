/*
 * Author Aina
 * Menu for food and drinks
 * 19 June 2019
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace menu_la_vita_e_bella
{
    public partial class Form1 : Form
    {
        string MySQLConnectionString = "datasource=remotemysql.com;port=3306;username=KOkL7wllES;password=ZkNaR0D22e;database=KOkL7wllES";
        bool Editing = false;

        public Form1()
        {
            InitializeComponent();            
        }

            //this function refreshes the datagrids
        private void RefreshDGV()
        {
            using (MySqlConnection SqlCon = new MySqlConnection(MySQLConnectionString))
            {
                SqlCon.Open();

                MySqlDataAdapter SqlDa = new MySqlDataAdapter("SELECT PizzaName, PizzaPrice, PizzaID FROM Pizzas", SqlCon);
                DataTable DtblPizza = new DataTable();
                SqlDa.Fill(DtblPizza);

                MySqlDataAdapter SqlDa2 = new MySqlDataAdapter("SELECT PastaName, PastaPrice, PastaID FROM Pastas", SqlCon);
                DataTable DtblPasta = new DataTable();
                SqlDa2.Fill(DtblPasta);

                MySqlDataAdapter SqlDa3 = new MySqlDataAdapter("SELECT DrinkName, DrinkPrice, DrinkID FROM Drinks", SqlCon);
                DataTable DtblDrink = new DataTable();
                SqlDa3.Fill(DtblDrink);

                PizzaList.DataSource = DtblPizza;
                PastaList.DataSource = DtblPasta;
                DrinkList.DataSource = DtblDrink;
            }
        }

            //upon starting the app, datagrids automatically load using refresh function
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDGV();
        }

            //button refreshes the datagrids
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDGV();
        }

            //opens a little menu in which you can add a new food and its price
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddItem f2 = new AddItem();
            f2.ShowDialog();
        }

            //delete and edit food/drink buttons
        private void PizzaList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection DatabaseConnection = new MySqlConnection(MySQLConnectionString);
            
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow Row = this.PizzaList.Rows[e.RowIndex];

                string PizzaName = Row.Cells["PizzaName"].Value.ToString();

                string QueryDelete = "DELETE FROM `Pizzas` WHERE PizzaName = '" + PizzaName + "';";
                MySqlCommand Delete = new MySqlCommand(QueryDelete, DatabaseConnection);
                DatabaseConnection.Open();
                MySqlDataReader MyReader = Delete.ExecuteReader();
                
                RefreshDGV();
            }
                
            else if (e.ColumnIndex == 1 && Editing == false)
            {
                Editing = true;
                PizzaList.ReadOnly = false;
            }
            else if (e.ColumnIndex == 1 && Editing == true)
            {
                Editing = false;
                PizzaList.ReadOnly = true;
                
                DataGridViewRow Row = this.PizzaList.Rows[e.RowIndex];
                string AlteredPizzaName = Row.Cells["PizzaName"].Value.ToString();
                string AlteredPizzaPrice = Row.Cells["PizzaPrice"].Value.ToString();
                string PizzaID = Row.Cells["PizzaID"].Value.ToString();
                
                string QueryAlter = "UPDATE Pizzas SET PizzaName = '" + AlteredPizzaName + "', PizzaPrice = " + AlteredPizzaPrice + " WHERE PizzaID = " + PizzaID;
                MySqlCommand Alter = new MySqlCommand(QueryAlter, DatabaseConnection);
                DatabaseConnection.Open();
                MySqlDataReader MyReader = Alter.ExecuteReader();

                RefreshDGV();
            }
        }

        private void PastaList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection DatabaseConnection = new MySqlConnection(MySQLConnectionString);

            if (e.ColumnIndex == 0)
            {
                DataGridViewRow Row = this.PastaList.Rows[e.RowIndex];

                string PastaName = Row.Cells["PastaName"].Value.ToString();

                string QueryDelete = "DELETE FROM `Pastas` WHERE PastaName = '" + PastaName + "';";
                MySqlCommand commandDatabase = new MySqlCommand(QueryDelete, DatabaseConnection);
                DatabaseConnection.Open();
                MySqlDataReader MyReader = commandDatabase.ExecuteReader();

                RefreshDGV();
            }
            else if (e.ColumnIndex == 1 && Editing == false)
            {
                Editing = true;
                PastaList.ReadOnly = false;
            }
            else if (e.ColumnIndex == 1 && Editing == true)
            {
                Editing = false;
                PastaList.ReadOnly = true;

                DataGridViewRow Row = this.PastaList.Rows[e.RowIndex];
                string AlteredPastaName = Row.Cells["PastaName"].Value.ToString();
                string AlteredPastaPrice = Row.Cells["PastaPrice"].Value.ToString();
                string PastaID = Row.Cells["PastaID"].Value.ToString();

                string QueryAlter = "UPDATE Pastas SET PastaName = '" + AlteredPastaName + "', PastaPrice = " + AlteredPastaPrice + " WHERE PastaID = " + PastaID;
                MySqlCommand Alter = new MySqlCommand(QueryAlter, DatabaseConnection);
                DatabaseConnection.Open();
                MySqlDataReader MyReader = Alter.ExecuteReader();

                RefreshDGV();
            }
        }

        private void DrinkList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection DatabaseConnection = new MySqlConnection(MySQLConnectionString);

            if (e.ColumnIndex == 0)
            {
                DataGridViewRow Row = this.DrinkList.Rows[e.RowIndex];

                string DrinkName = Row.Cells["DrinkName"].Value.ToString();

                string QueryDelete = "DELETE FROM `Drinks` WHERE DrinkName = '" + DrinkName + "';";
                MySqlCommand commandDatabase = new MySqlCommand(QueryDelete, DatabaseConnection);
                DatabaseConnection.Open();
                MySqlDataReader MyReader = commandDatabase.ExecuteReader();

                RefreshDGV();
            }
            else if (e.ColumnIndex == 1 && Editing == false)
            {
                Editing = true;
                DrinkList.ReadOnly = false;
            }
            else if (e.ColumnIndex == 1 && Editing == true)
            {
                Editing = false;
                DrinkList.ReadOnly = true;

                DataGridViewRow Row = this.DrinkList.Rows[e.RowIndex];
                string AlteredDrinkName = Row.Cells["DrinkName"].Value.ToString();
                string AlteredDrinkPrice = Row.Cells["DrinkPrice"].Value.ToString();
                string DrinkID = Row.Cells["DrinkID"].Value.ToString();

                string QueryAlter = "UPDATE Drinks SET DrinkName = '" + AlteredDrinkName + "', DrinkPrice = " + AlteredDrinkPrice + " WHERE DrinkID = " + DrinkID;
                MySqlCommand Alter = new MySqlCommand(QueryAlter, DatabaseConnection);
                DatabaseConnection.Open();
                MySqlDataReader MyReader = Alter.ExecuteReader();

                RefreshDGV();
            }
        }



            /*TESTING

            //trying to draw image on button
        private void PizzaList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
                var image = Properties.Resources.DeleteIcon; //An image
            string fileName = "C:\\Users\\Aina\\Desktop\\aqua.png";

            Bitmap img;
            img = new Bitmap(@"C:\\Users\\Aina\\Desktop\\aqua.png");



        }

    */

        private void PizzaList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PizzaList.Rows[e.RowIndex].Cells[0].Value = "x";
            PizzaList.Rows[e.RowIndex].Cells[1].Value = "e";
            
            //PizzaList.Rows[e.RowIndex].Cells[0].
        }

        private void PastaList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PastaList.Rows[e.RowIndex].Cells[0].Value = "x";
        }

        private void DrinkList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DrinkList.Rows[e.RowIndex].Cells[0].Value = "x";
        }




        void PastaList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        void PizzaList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }       
    }
}
