using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

// Functies for databasetest.cs
namespace Restaurant
{
    static class MySQLFunctions
    {

        static private MySqlConnection conn = new MySqlConnection("datasource=remotemysql.com;port=3306;username=KOkL7wllES;password=ZkNaR0D22e;database=KOkL7wllES;");

        // Refresht de datagrid
        static public void Refresh(DataGridView dataGridView)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM Drinks", conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            finally
            {
                conn.Close();
            }

        }
        //Add nieuw drankje
        static public void InsertDrink(String DrinkName, float DrinkPrice, DataGridView dataGridView)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                MySqlCommand commandInsert = new MySqlCommand("INSERT INTO Drinks(DrinkName,DrinkPrice) VALUES(@DrinkName,@DrinkPrice)", conn);
                commandInsert.Parameters.AddWithValue("@DrinkName", DrinkName);
                commandInsert.Parameters.AddWithValue("@DrinkPrice", DrinkPrice);
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

