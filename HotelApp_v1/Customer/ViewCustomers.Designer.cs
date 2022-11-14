namespace HotelApp_v1
{
    partial class ViewCustomers
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_lname = new System.Windows.Forms.TextBox();
            this.button_manage_customers = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.dataGrid_Customers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.customerQueryForm1 = new HotelApp_v1.CustomerQueryForm();
            this.sqlConnection2 = new System.Data.SqlClient.SqlConnection();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Customers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.customerQueryForm1);
            this.panel2.Controls.Add(this.textBox_lname);
            this.panel2.Controls.Add(this.button_manage_customers);
            this.panel2.Controls.Add(this.button_home);
            this.panel2.Controls.Add(this.dataGrid_Customers);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 852);
            this.panel2.TabIndex = 24;
            // 
            // textBox_lname
            // 
            this.textBox_lname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lname.Location = new System.Drawing.Point(489, 194);
            this.textBox_lname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_lname.Name = "textBox_lname";
            this.textBox_lname.Size = new System.Drawing.Size(338, 39);
            this.textBox_lname.TabIndex = 27;
            this.textBox_lname.TextChanged += new System.EventHandler(this.textBox_lname_TextChanged);
            // 
            // button_manage_customers
            // 
            this.button_manage_customers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_manage_customers.FlatAppearance.BorderSize = 0;
            this.button_manage_customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_manage_customers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_manage_customers.ForeColor = System.Drawing.Color.White;
            this.button_manage_customers.Location = new System.Drawing.Point(519, 783);
            this.button_manage_customers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_manage_customers.Name = "button_manage_customers";
            this.button_manage_customers.Size = new System.Drawing.Size(519, 69);
            this.button_manage_customers.TabIndex = 26;
            this.button_manage_customers.Text = "Manage Customers";
            this.button_manage_customers.UseVisualStyleBackColor = false;
            this.button_manage_customers.Click += new System.EventHandler(this.button_manage_customers_Click);
            // 
            // button_home
            // 
            this.button_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_home.ForeColor = System.Drawing.Color.White;
            this.button_home.Location = new System.Drawing.Point(0, 783);
            this.button_home.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(519, 69);
            this.button_home.TabIndex = 24;
            this.button_home.Text = "Home";
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // dataGrid_Customers
            // 
            this.dataGrid_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Customers.Location = new System.Drawing.Point(0, 278);
            this.dataGrid_Customers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGrid_Customers.Name = "dataGrid_Customers";
            this.dataGrid_Customers.RowHeadersWidth = 51;
            this.dataGrid_Customers.RowTemplate.Height = 24;
            this.dataGrid_Customers.Size = new System.Drawing.Size(1038, 508);
            this.dataGrid_Customers.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(146, 59);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(808, 45);
            this.label8.TabIndex = 14;
            this.label8.Text = "Choose desired location to view rooms and room types";
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=ELISEORICOCE42;Initial Catalog=TestDatabase;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // customerQueryForm1
            // 
            this.customerQueryForm1.Location = new System.Drawing.Point(0, 0);
            this.customerQueryForm1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.customerQueryForm1.Name = "customerQueryForm1";
            this.customerQueryForm1.Size = new System.Drawing.Size(1038, 852);
            this.customerQueryForm1.TabIndex = 28;
            this.customerQueryForm1.Visible = false;
            // 
            // sqlConnection2
            // 
            this.sqlConnection2.FireInfoMessageEventOnUserErrors = false;
            // 
            // ViewCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewCustomers";
            this.Size = new System.Drawing.Size(1038, 852);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Customers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_manage_customers;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.DataGridView dataGrid_Customers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_lname;
        private CustomerQueryForm customerQueryForm1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlConnection sqlConnection2;
    }
}
