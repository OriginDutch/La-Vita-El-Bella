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

        public chef()
        {
            InitializeComponent();
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
            Debug.WriteLine("Test");
            string connectionString = "datasource=remotemysql.com;port=3306;username=KOkL7wllES;password=ZkNaR0D22e;database=KOkL7wllES;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            databaseConnection.Open();
            MySqlCommand pulldata = new MySqlCommand("SELECT * FROM Orders", databaseConnection);
            MySqlDataReader pullingdata = pulldata.ExecuteReader();
            
            //Lees alle data in
            while (pullingdata.Read())
            {
                Debug.WriteLine("Test");
                Debug.WriteLine(pullingdata["OrderID"].ToString() );
                entryID.Add(Int32.Parse(pullingdata["OrderID"].ToString()));
                string OrderIdButton = pullingdata["OrderID"].ToString();
                
                //maak de blokjes aan
                var FlowBox = new FlowLayoutPanel
                {
                    Size = new Size(540, 333),
                };
                flowLayoutPanel1.Controls.Add(FlowBox);

                //laat het taffelnummer zien
                var TafelNummer = new Label
                {
                    Size = new Size(540, 40),
                    Text = "Tafel Nummer: " + pullingdata["TableNum"],
                    Font = new Font(FontFamily.GenericSansSerif, 20, FontStyle.Bold),
                };
                FlowBox.Controls.Add(TafelNummer);

                //laat het gerecht zien
                var NameText = new Label
                {

                    Size = new Size(540, 25),
                    Text = "", //+ pullingdata["DishName"],
                    //ReadOnly = true
              
                };
                FlowBox.Controls.Add(NameText);

                //laat de OrderId zien
                var OrderId = new Label
                {

                    Size = new Size(540, 25),
                    Text = "Order ID = " + pullingdata["OrderID"],
                    //ReadOnly = true

                };
                FlowBox.Controls.Add(OrderId);

                //Maak de button aan
                var Button = new Button
                {
                    Size = new Size(530, 25),
                    Text = "Order klaar.",
                    
                };

                FlowBox.Controls.Add(Button);
                Button.Click += new EventHandler(button_Click);
                void button_Click(object sender, EventArgs e)
                {
                    Button button = sender as Button;
                    // identify which button was clicked and perform necessary actions
                    //MessageBox.Show(pullingdata["OrderID"].ToString() );
                    MessageBox.Show(OrderIdButton);
                }




                /*void button_click(object sender, EventArgs e)
                {
                    Button btn = sender as Button;
                    MessageBox.Show (btn.Name+ "Created");
                }*/
                
                /*var picture = new PictureBox
                {
                    Name = "" + pullingdata["SkinNaam"] + ".png",
                    Size = new Size(300, 300),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Image = Image.FromFile(pullingdata["SkinImage"].ToString())
                };
                flowbox.Controls.Add(picture);*/

            }
            databaseConnection.Close();
            entryID.ForEach(Console.WriteLine);

        
        }
        

    }
}
