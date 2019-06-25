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
using MySql.Data;
using System.Diagnostics;

namespace Restaurant
{
    public partial class chef : UserControl
    {
        List<int> entryID = new List<int>();
        static int alarmCounter = 1;
        static bool exitFlag = false;


        private readonly Timer timer;

        public chef()
        {
            // Deze functies laad die automatisch van de start in
            InitializeComponent();

            timer = new Timer
            {
                Interval = 10000
            };
            timer.Tick += Update;

            timer.Start();


            loadFromDatabase();
        }

        private async void Update(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            loadFromDatabase();
        }
       


        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Database connetie maken
            string connectionString = "datasource=remotemysql.com;port=3306;username=KOkL7wllES;password=ZkNaR0D22e;database=KOkL7wllES;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            databaseConnection.Open();
            //test als de database het doet
            MessageBox.Show("Connection Created"); 
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
            MySqlCommand pulldata = new MySqlCommand("SELECT * FROM Orders WHERE OrderStatus = 0", databaseConnection);
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
                    Size = new Size(410, 333),
                };
                flowLayoutPanel1.Controls.Add(FlowBox);

                //laat het taffelnummer zien
                var TafelNummer = new Label
                {
                    Size = new Size(410, 40),
                    Text = "Tafel Nummer: " + pullingdata["TableNum"],
                    Font = new Font(FontFamily.GenericSansSerif, 20, FontStyle.Bold),
                };
                FlowBox.Controls.Add(TafelNummer);

                //laat het gerecht zien
                var NameText = new Label
                {  
                    Size = new Size(410, 25),
                    Text = "", //+ pullingdata["DishName"],
                               //ReadOnly = true
                };
                FlowBox.Controls.Add(NameText);
               //laat de OrderId zien
                var OrderId = new Label
                {
                    Size = new Size(410, 25),
                    Text = "Order ID = " + pullingdata["OrderID"],
                };
                FlowBox.Controls.Add(OrderId);

                //Maak de button aan
                var Button = new Button
                {
                    Size = new Size(409, 25),
                    Text = "Order klaar.",
                };
                FlowBox.Controls.Add(Button);

                

                // Maak een eventhandler voor de button Click
                Button.Click += new EventHandler(button_Click);

                // Event handler voor de button
                void button_Click(object sender, EventArgs e)
                {
                    // Maak de button aan
                    Button button = sender as Button;

                    // Laat zien welke order klaar is
                    MessageBox.Show("Order " + OrderIdButton + " Is klaar.");

                    // Update de orderstatus naar 1 waar de orderidbutton is
                    MySqlCommand test = new MySqlCommand("UPDATE Orders SET OrderStatus = 1 WHERE OrderId = " + OrderIdButton, databaseConnection);

                    // Open De database connectie
                    databaseConnection.Open();

                    // Laat de query in
                    MySqlDataReader pulldata1 = test.ExecuteReader();

                    // Sluit de database connectie
                    databaseConnection.Close();

                    // Clear de flowlayout panel
                    flowLayoutPanel1.Controls.Clear();

                    // Laat het opnieuw in
                    loadFromDatabase();

                    
                }
            }
            databaseConnection.Close();
            
        }

        private void Chef_Load(object sender, EventArgs e)
        {

        }
    }
}
