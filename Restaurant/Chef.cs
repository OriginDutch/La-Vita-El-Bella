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
            
            
            timer1.Tick += new EventHandler(TimerEventProcessor);

            // Sets the timer interval to 5 seconds.
            timer1.Interval = 5000;
            timer1.Start();

            // Runs the timer, and raises the event.
            while (exitFlag == false)
            {
                // Processes all the events in the queue.
                Application.DoEvents();
                flowLayoutPanel1.Controls.Clear();
                loadFromDatabase();
                exitFlag = true;

            }
        }
        private void TimerEventProcessor(Object myObject,
                                            EventArgs myEventArgs)
        {
            timer1.Stop();
            loadFromDatabase();
            // Displays a message box asking whether to continue running the timer.
            /*if (MessageBox.Show("Continue running?", "Count is: " + alarmCounter,
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Restarts the timer and increments the counter.
                alarmCounter += 1;
                timer1.Enabled = true;
            }
            else
            {
                // Stops the timer.
                exitFlag = true;
            }*/
        }


        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=remotemysql.com;port=3306;username=KOkL7wllES;password=ZkNaR0D22e;database=KOkL7wllES;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            databaseConnection.Open();
            MessageBox.Show("Connection Created");
            
            
             
            
        }

        public void loadFromDatabase()
        {
            Debug.WriteLine("Test");
            string connectionString = "datasource=remotemysql.com;port=3306;username=KOkL7wllES;password=ZkNaR0D22e;database=KOkL7wllES;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            databaseConnection.Open();
            MySqlCommand pulldata = new MySqlCommand("SELECT * FROM Orders", databaseConnection);
            MySqlDataReader pullingdata = pulldata.ExecuteReader();

            while (pullingdata.Read())
            {
                Debug.WriteLine("Test");
                Debug.WriteLine(pullingdata["OrderID"].ToString() + " - Name : " + pullingdata["DishName"].ToString() + " - location : " + pullingdata["DrinkName"].ToString());
                entryID.Add(Int32.Parse(pullingdata["OrderID"].ToString()));

                var flowbox = new FlowLayoutPanel
                {
                    Size = new Size(540, 333),
                };
                flowLayoutPanel1.Controls.Add(flowbox);
                var tafelnummer = new Label
                {
                    Size = new Size(540, 40),
                    Text = "Tafel Nummer: " + pullingdata["TableNum"],
                    Font = new Font(FontFamily.GenericSansSerif, 20, FontStyle.Bold),
                };
                flowbox.Controls.Add(tafelnummer);
                var nametext = new Label
                {

                    Size = new Size(540, 25),
                    Text = "" + pullingdata["DishName"],
                    //ReadOnly = true

                };
                flowbox.Controls.Add(nametext);

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
