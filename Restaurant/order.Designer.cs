namespace Restaurant
{
    partial class order
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
            this.Terug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Terug
            // 
            this.Terug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Terug.Location = new System.Drawing.Point(26, 350);
            this.Terug.Name = "Terug";
            this.Terug.Size = new System.Drawing.Size(162, 75);
            this.Terug.TabIndex = 0;
            this.Terug.Text = "Terug";
            this.Terug.UseVisualStyleBackColor = true;
            this.Terug.Click += new System.EventHandler(this.Terug_Click);
            // 
            // order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Terug);
            this.Name = "order";
            this.Text = "order";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.order_FormClosed);
            this.Load += new System.EventHandler(this.order_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Terug;
    }
}