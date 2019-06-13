namespace Restaurant
{
    partial class Waiter
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
            this.Terug.Location = new System.Drawing.Point(12, 12);
            this.Terug.Name = "Terug";
            this.Terug.Size = new System.Drawing.Size(103, 46);
            this.Terug.TabIndex = 11;
            this.Terug.Text = "Terug";
            this.Terug.UseVisualStyleBackColor = true;
            this.Terug.Click += new System.EventHandler(this.Terug_Click);
            // 
            // Waiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 561);
            this.Controls.Add(this.Terug);
            this.Name = "Waiter";
            this.Text = "Waiter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Waiter_FormClosed);
            this.Load += new System.EventHandler(this.Waiter_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Terug;
    }
}