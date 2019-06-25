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
        public static bool isBezet;        


        public Tafels( Panel panelArgument)
        {
            InitializeComponent();
            this.panel = panelArgument;
            labelLoad();

        }

        private void Tafels_Load(object sender, EventArgs e)
        {
            changeTable();

        }

        //veranderen kleur tafel
        public void changeTable()
        {
            //grote tafels
            if (isBezet == true && Form1.isBezet1[0] == true)
            {
                pictureBox1.Image = Properties.Resources.Lange_Tafel;
            } 
            if (isBezet == true && Form1.isBezet1[1] == true)
            {
                pictureBox2.Image = Properties.Resources.Lange_Tafel;
            }
            if (isBezet == true && Form1.isBezet1[2] == true)
            {
                pictureBox3.Image = Properties.Resources.Lange_Tafel;
            }
            if (isBezet == true && Form1.isBezet1[3] == true)
            {
                pictureBox4.Image = Properties.Resources.Lange_Tafel;
            }
            if (isBezet == true && Form1.isBezet1[4] == true)
            {
                pictureBox5.Image = Properties.Resources.Lange_Tafel;
            }
            if (isBezet == true && Form1.isBezet1[5] == true)
            {
                pictureBox6.Image = Properties.Resources.Lange_Tafel;
            }

            //de kleine tafels
            if (isBezet == true && Form1.isBezet1[6] == true)
            {
                pictureBox7.Image = Properties.Resources.thumbnail__1_1;
            }
            if (isBezet == true && Form1.isBezet1[7] == true)
            {
                pictureBox8.Image = Properties.Resources.thumbnail__1_1;
            }
            if (isBezet == true && Form1.isBezet1[8] == true)
            {
                pictureBox9.Image = Properties.Resources.thumbnail__1_1;
            }
            if (isBezet == true && Form1.isBezet1[9] == true)
            {
                pictureBox10.Image = Properties.Resources.thumbnail__1_1;
            }
            if (isBezet == true && Form1.isBezet1[10] == true)
            {
                pictureBox11.Image = Properties.Resources.thumbnail__1_1;
            }
            if (isBezet == true && Form1.isBezet1[11] == true)
            {
                pictureBox12.Image = Properties.Resources.thumbnail__1_1;
            }

        }

         
        //***************************************************//
        //Openen order tafel 1
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1.isBezet1[0] = true;
            panel.Controls.Clear();
            var myControl = new Order();
            panel.Controls.Add(myControl);
        }

        //Openen order tafel 2
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1.isBezet1[1] = true;
            panel.Controls.Clear();
            var myControl = new Order();
            panel.Controls.Add(myControl);    
        }

        //Openen order tafel 3
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1.isBezet1[2] = true;
            panel.Controls.Clear();
            var myControl = new Order();
            panel.Controls.Add(myControl);           
        }

        //Openen order tafel 4
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1.isBezet1[3] = true;
            panel.Controls.Clear();
            var myControl = new Order();
            panel.Controls.Add(myControl);
        }

        //Openen order tafel 5
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1.isBezet1[4] = true;
            panel.Controls.Clear();
            var myControl = new Order();
            panel.Controls.Add(myControl);
        }

        //Openen order tafel 6
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form1.isBezet1[5] = true;
            panel.Controls.Clear();
            var myControl = new Order();
            panel.Controls.Add(myControl);
        }

        //Openen order tafel 7
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form1.isBezet1[6] = true;
            panel.Controls.Clear();
            var myControl = new Order();
            panel.Controls.Add(myControl);
        }

        //Openen order tafel 8
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form1.isBezet1[7] = true;
            panel.Controls.Clear();
            var myControl = new Order();
            panel.Controls.Add(myControl);
        }

        //Openen order tafel 9
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form1.isBezet1[8] = true;
            panel.Controls.Clear();
            var myControl = new Order();
            panel.Controls.Add(myControl);
        }

        //Openen order tafel 10
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form1.isBezet1[9] = true;
            panel.Controls.Clear();
            var myControl = new Order();
            panel.Controls.Add(myControl);
        }

        //Openen order tafel 11
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Form1.isBezet1[10] = true;
            panel.Controls.Clear();
            var myControl = new Order();
            panel.Controls.Add(myControl);
        }

        //Openen order tafel 12
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Form1.isBezet1[11] = true;
            panel.Controls.Clear();
            var myControl = new Order();
            panel.Controls.Add(myControl);
        }
        //***************************************************//


        //Zorgt ervoor dat de label bij de juiste tafel staat, en transparant is.
        private void labelLoad()
        {

            var pos1 = this.PointToScreen(label1.Location);
            pos1 = pictureBox1.PointToClient(pos1);
            label1.Parent = pictureBox1;
            label1.Location = pos1;

            var pos2 = this.PointToScreen(label2.Location);
            pos2 = pictureBox2.PointToClient(pos2);
            label2.Parent = pictureBox2;
            label2.Location = pos2;

            var pos3 = this.PointToScreen(label3.Location);
            pos3 = pictureBox3.PointToClient(pos3);
            label3.Parent = pictureBox3;
            label3.Location = pos3;

            var pos4 = this.PointToScreen(label4.Location);
            pos4 = pictureBox4.PointToClient(pos4);
            label4.Parent = pictureBox4;
            label4.Location = pos4;

            var pos5 = this.PointToScreen(label5.Location);
            pos5 = pictureBox5.PointToClient(pos5);
            label5.Parent = pictureBox5;
            label5.Location = pos5;

            var pos6 = this.PointToScreen(label6.Location);
            pos6 = pictureBox6.PointToClient(pos6);
            label6.Parent = pictureBox6;
            label6.Location = pos6;

            var pos7 = this.PointToScreen(label7.Location);
            pos7 = pictureBox7.PointToClient(pos7);
            label7.Parent = pictureBox7;
            label7.Location = pos7;

            var pos8 = this.PointToScreen(label8.Location);
            pos8 = pictureBox8.PointToClient(pos8);
            label8.Parent = pictureBox8;
            label8.Location = pos8;

            var pos9 = this.PointToScreen(label9.Location);
            pos9 = pictureBox9.PointToClient(pos9);
            label9.Parent = pictureBox9;
            label9.Location = pos9;

            var pos10 = this.PointToScreen(label10.Location);
            pos10 = pictureBox10.PointToClient(pos10);
            label10.Parent = pictureBox10;
            label10.Location = pos10;

            var pos11 = this.PointToScreen(label11.Location);
            pos11 = pictureBox11.PointToClient(pos11);
            label11.Parent = pictureBox11;
            label11.Location = pos11;

            var pos12 = this.PointToScreen(label12.Location);
            pos12 = pictureBox12.PointToClient(pos12);
            label12.Parent = pictureBox12;
            label12.Location = pos12;
        }

    }
}
