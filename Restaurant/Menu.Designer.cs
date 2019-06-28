namespace menu_la_vita_e_bella
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PizzaList = new System.Windows.Forms.DataGridView();
            this.DeletePizza = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditPizza = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PastaList = new System.Windows.Forms.DataGridView();
            this.DeletePasta = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditPasta = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DrinkList = new System.Windows.Forms.DataGridView();
            this.DeleteDrink = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditDrink = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PizzaList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PastaList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrinkList)).BeginInit();
            this.SuspendLayout();
            // 
            // PizzaList
            // 
            this.PizzaList.AccessibleDescription = "";
            this.PizzaList.AllowUserToAddRows = false;
            this.PizzaList.AllowUserToDeleteRows = false;
            this.PizzaList.AllowUserToResizeColumns = false;
            this.PizzaList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.PizzaList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PizzaList.BackgroundColor = System.Drawing.Color.Black;
            this.PizzaList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PizzaList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PizzaList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PizzaList.ColumnHeadersVisible = false;
            this.PizzaList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeletePizza,
            this.EditPizza});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PizzaList.DefaultCellStyle = dataGridViewCellStyle3;
            this.PizzaList.Location = new System.Drawing.Point(166, 138);
            this.PizzaList.Name = "PizzaList";
            this.PizzaList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PizzaList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.PizzaList.RowHeadersVisible = false;
            this.PizzaList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Format = "N2";
            this.PizzaList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.PizzaList.Size = new System.Drawing.Size(209, 511);
            this.PizzaList.TabIndex = 0;
            this.PizzaList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PizzaList_CellClick);
            this.PizzaList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PizzaList_CellContentClick);
            this.PizzaList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.PizzaList_CellFormatting);
            // 
            // DeletePizza
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.DeletePizza.DefaultCellStyle = dataGridViewCellStyle2;
            this.DeletePizza.HeaderText = "delete";
            this.DeletePizza.Name = "DeletePizza";
            this.DeletePizza.ReadOnly = true;
            this.DeletePizza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DeletePizza.Width = 20;
            // 
            // EditPizza
            // 
            this.EditPizza.HeaderText = "edit";
            this.EditPizza.Name = "EditPizza";
            this.EditPizza.ReadOnly = true;
            this.EditPizza.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditPizza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EditPizza.Text = "e";
            this.EditPizza.Width = 20;
            // 
            // PastaList
            // 
            this.PastaList.AllowUserToAddRows = false;
            this.PastaList.AllowUserToDeleteRows = false;
            this.PastaList.AllowUserToResizeColumns = false;
            this.PastaList.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.PastaList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.PastaList.BackgroundColor = System.Drawing.Color.Black;
            this.PastaList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PastaList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PastaList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PastaList.ColumnHeadersVisible = false;
            this.PastaList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeletePasta,
            this.EditPasta});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PastaList.DefaultCellStyle = dataGridViewCellStyle7;
            this.PastaList.Location = new System.Drawing.Point(419, 138);
            this.PastaList.Name = "PastaList";
            this.PastaList.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PastaList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.PastaList.RowHeadersVisible = false;
            this.PastaList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle9.Format = "N2";
            this.PastaList.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.PastaList.Size = new System.Drawing.Size(209, 511);
            this.PastaList.TabIndex = 1;
            this.PastaList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PastaList_CellClick);
            this.PastaList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PastaList_CellContentClick);
            this.PastaList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.PastaList_CellFormatting);
            // 
            // DeletePasta
            // 
            this.DeletePasta.HeaderText = "delete";
            this.DeletePasta.Name = "DeletePasta";
            this.DeletePasta.ReadOnly = true;
            this.DeletePasta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DeletePasta.Text = "x";
            this.DeletePasta.Width = 20;
            // 
            // EditPasta
            // 
            this.EditPasta.HeaderText = "edit";
            this.EditPasta.Name = "EditPasta";
            this.EditPasta.ReadOnly = true;
            this.EditPasta.Width = 20;
            // 
            // DrinkList
            // 
            this.DrinkList.AllowUserToAddRows = false;
            this.DrinkList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.DrinkList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DrinkList.BackgroundColor = System.Drawing.Color.Black;
            this.DrinkList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DrinkList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DrinkList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DrinkList.ColumnHeadersVisible = false;
            this.DrinkList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeleteDrink,
            this.EditDrink});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DrinkList.DefaultCellStyle = dataGridViewCellStyle11;
            this.DrinkList.Location = new System.Drawing.Point(678, 138);
            this.DrinkList.Name = "DrinkList";
            this.DrinkList.ReadOnly = true;
            this.DrinkList.RowHeadersVisible = false;
            this.DrinkList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.Format = "N2";
            this.DrinkList.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DrinkList.Size = new System.Drawing.Size(209, 511);
            this.DrinkList.TabIndex = 2;
            this.DrinkList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DrinkList_CellContentClick);
            // 
            // DeleteDrink
            // 
            this.DeleteDrink.HeaderText = "delete";
            this.DeleteDrink.Name = "DeleteDrink";
            this.DeleteDrink.ReadOnly = true;
            this.DeleteDrink.Text = "x";
            this.DeleteDrink.Width = 20;
            // 
            // EditDrink
            // 
            this.EditDrink.HeaderText = "edit";
            this.EditDrink.Name = "EditDrink";
            this.EditDrink.ReadOnly = true;
            this.EditDrink.Width = 20;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(1105, 138);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(57, 44);
            this.BtnRefresh.TabIndex = 4;
            this.BtnRefresh.Text = "refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(1105, 188);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(57, 44);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 107);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "PIZZAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(499, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "PASTAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(755, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "DRINKEN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1232, 661);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.DrinkList);
            this.Controls.Add(this.PastaList);
            this.Controls.Add(this.PizzaList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PizzaList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PastaList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrinkList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView PastaList;
        private System.Windows.Forms.DataGridView DrinkList;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.DataGridView PizzaList;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteDrink;
        private System.Windows.Forms.DataGridViewButtonColumn EditDrink;
        private System.Windows.Forms.DataGridViewButtonColumn DeletePasta;
        private System.Windows.Forms.DataGridViewButtonColumn EditPasta;
        private System.Windows.Forms.DataGridViewButtonColumn DeletePizza;
        private System.Windows.Forms.DataGridViewButtonColumn EditPizza;
    }
}

