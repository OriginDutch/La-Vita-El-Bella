namespace Restaurant
{
    partial class Order
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.LoadDrinks = new System.Windows.Forms.Button();
            this.LoadPizzas = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TableNumberDisplay = new System.Windows.Forms.Label();
            this.LoadDesserts = new System.Windows.Forms.Button();
            this.LoadPastas = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bezet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoadDrinks
            // 
            this.LoadDrinks.Location = new System.Drawing.Point(15, 428);
            this.LoadDrinks.Name = "LoadDrinks";
            this.LoadDrinks.Size = new System.Drawing.Size(100, 30);
            this.LoadDrinks.TabIndex = 11;
            this.LoadDrinks.Text = "Dranken";
            this.LoadDrinks.UseVisualStyleBackColor = true;
            this.LoadDrinks.Click += new System.EventHandler(this.LoadDrinks_Click);
            // 
            // LoadPizzas
            // 
            this.LoadPizzas.Location = new System.Drawing.Point(15, 392);
            this.LoadPizzas.Name = "LoadPizzas";
            this.LoadPizzas.Size = new System.Drawing.Size(100, 30);
            this.LoadPizzas.TabIndex = 10;
            this.LoadPizzas.Text = "Pizza";
            this.LoadPizzas.UseVisualStyleBackColor = true;
            this.LoadPizzas.Click += new System.EventHandler(this.LoadPizzas_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(15, 71);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(354, 315);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(691, 392);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 30);
            this.button4.TabIndex = 9;
            this.button4.Text = "Send";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(375, 71);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(416, 315);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // TableNumberDisplay
            // 
            this.TableNumberDisplay.AutoSize = true;
            this.TableNumberDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableNumberDisplay.Location = new System.Drawing.Point(12, 23);
            this.TableNumberDisplay.Name = "TableNumberDisplay";
            this.TableNumberDisplay.Size = new System.Drawing.Size(93, 33);
            this.TableNumberDisplay.TabIndex = 12;
            this.TableNumberDisplay.Text = "-------\\";
            // 
            // LoadDesserts
            // 
            this.LoadDesserts.Location = new System.Drawing.Point(121, 428);
            this.LoadDesserts.Name = "LoadDesserts";
            this.LoadDesserts.Size = new System.Drawing.Size(100, 30);
            this.LoadDesserts.TabIndex = 14;
            this.LoadDesserts.Text = "Desserts";
            this.LoadDesserts.UseVisualStyleBackColor = true;
            this.LoadDesserts.Click += new System.EventHandler(this.LoadDesserts_Click);
            // 
            // LoadPastas
            // 
            this.LoadPastas.Location = new System.Drawing.Point(121, 392);
            this.LoadPastas.Name = "LoadPastas";
            this.LoadPastas.Size = new System.Drawing.Size(100, 30);
            this.LoadPastas.TabIndex = 13;
            this.LoadPastas.Text = "Pasta";
            this.LoadPastas.UseVisualStyleBackColor = true;
            this.LoadPastas.Click += new System.EventHandler(this.LoadPastas_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(121, 506);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 30);
            this.button7.TabIndex = 15;
            this.button7.Text = "Vrij";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button7);
            this.Controls.Add(this.LoadDesserts);
            this.Controls.Add(this.LoadPastas);
            this.Controls.Add(this.TableNumberDisplay);
            this.Controls.Add(this.LoadDrinks);
            this.Controls.Add(this.LoadPizzas);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(969, 554);
            this.Load += new System.EventHandler(this.Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button LoadDrinks;
        private System.Windows.Forms.Button LoadPizzas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label TableNumberDisplay;
        private System.Windows.Forms.Button LoadDesserts;
        private System.Windows.Forms.Button LoadPastas;
        private System.Windows.Forms.Button button7;
    }
}
