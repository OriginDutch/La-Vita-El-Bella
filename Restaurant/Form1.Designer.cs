namespace Restaurant
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OrderHistory = new System.Windows.Forms.Button();
            this.orderHistory1 = new Restaurant.OrderHistory();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "Chef Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 100);
            this.button2.TabIndex = 1;
            this.button2.Text = "Waiter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 413);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 100);
            this.button3.TabIndex = 2;
            this.button3.Text = "Test";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.SynchronizingObject = this;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(218, 115);
            this.button4.TabIndex = 3;
            this.button4.Text = "Connection";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.orderHistory1);
            this.panel1.Location = new System.Drawing.Point(247, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1680, 1000);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // OrderHistory
            // 
            this.OrderHistory.Location = new System.Drawing.Point(12, 537);
            this.OrderHistory.Name = "OrderHistory";
            this.OrderHistory.Size = new System.Drawing.Size(218, 100);
            this.OrderHistory.TabIndex = 1;
            this.OrderHistory.Text = "OrderHistory";
            this.OrderHistory.UseVisualStyleBackColor = true;
            this.OrderHistory.Click += new System.EventHandler(this.OrderHistory_Click);
            // 
            // orderHistory1
            // 
            this.orderHistory1.Location = new System.Drawing.Point(0, 3);
            this.orderHistory1.Name = "orderHistory1";
            this.orderHistory1.Size = new System.Drawing.Size(1111, 692);
            this.orderHistory1.TabIndex = 0;
            this.orderHistory1.Load += new System.EventHandler(this.orderHistory1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 719);
            this.Controls.Add(this.OrderHistory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.IO.FileSystemWatcher fileSystemWatcher2;

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private OrderHistory orderHistory1;
        private System.Windows.Forms.Button OrderHistory;
    }
}

