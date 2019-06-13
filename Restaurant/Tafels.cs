using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Tafels : UserControl
    {
        Panel panel;
        public static bool isBezet = false;

        


        public Tafels( Panel panelArgument)
        {
            InitializeComponent();
            this.panel = panelArgument;
            var pos = this.PointToScreen(label1.Location);
            pos = pictureBox2.PointToClient(pos);
            label1.Parent = pictureBox2;
            label1.Location = pos;


        }

        private void Tafels_Load(object sender, EventArgs e)
        {
            changeTable();
        }

        public void changeTable()
        {
            if (isBezet == true && Form1.isBezet1[0] == true)
            {
                pictureBox2.Image = Properties.Resources.Lange_Tafel;
            }
            if (isBezet == true && Form1.isBezet1[1] == true)
            {
                pictureBox3.Image = Properties.Resources.Lange_Tafel;
            }
            if (isBezet == true && Form1.isBezet1[2] == true)
            {
                pictureBox4.Image = Properties.Resources.Lange_Tafel;
            }
            if (isBezet == true && Form1.isBezet1[3] == true)
            {
                pictureBox5.Image = Properties.Resources.Lange_Tafel;
            }
            if (isBezet == true && Form1.isBezet1[4] == true)
            {
                pictureBox6.Image = Properties.Resources.Lange_Tafel;
            }
            if (isBezet == true && Form1.isBezet1[5] == true)
            {
                pictureBox7.Image = Properties.Resources.Lange_Tafel;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1.isBezet1[0] = true;
            panel.Controls.Clear();
            var myControl = new Order();
            panel.Controls.Add(myControl);
           
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1.isBezet1[1] = true;
            panel.Controls.Clear();
            var myControl = new Order();
            panel.Controls.Add(myControl);
            
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1.isBezet1[2] = true;
            panel.Controls.Clear();
            var myControl = new Order();
            panel.Controls.Add(myControl);

        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1.isBezet1[3] = true;
            panel.Controls.Clear();
            var myControl = new Order();
            panel.Controls.Add(myControl);

        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form1.isBezet1[4] = true;
            panel.Controls.Clear();
            var myControl = new Order();
            panel.Controls.Add(myControl);

        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form1.isBezet1[5] = true;
            panel.Controls.Clear();
            var myControl = new Order();
            panel.Controls.Add(myControl);

        }

    }
}
