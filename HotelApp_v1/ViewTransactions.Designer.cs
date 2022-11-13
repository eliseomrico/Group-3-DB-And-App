namespace HotelApp_v1
{
    partial class ViewTransactions
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
            this.pnlManageTransactions = new HotelApp_v1.Transactions();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.button_manage_locations = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.dgvTransactionsList = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionsList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pnlManageTransactions);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dtpEndDate);
            this.panel2.Controls.Add(this.dtpStartDate);
            this.panel2.Controls.Add(this.button_manage_locations);
            this.panel2.Controls.Add(this.button_home);
            this.panel2.Controls.Add(this.dgvTransactionsList);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 545);
            this.panel2.TabIndex = 26;
            // 
            // pnlManageTransactions
            // 
            this.pnlManageTransactions.Location = new System.Drawing.Point(0, 0);
            this.pnlManageTransactions.Name = "pnlManageTransactions";
            this.pnlManageTransactions.Size = new System.Drawing.Size(692, 545);
            this.pnlManageTransactions.TabIndex = 33;
            this.pnlManageTransactions.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "End Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Start Date:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Checked = false;
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(429, 112);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(254, 27);
            this.dtpEndDate.TabIndex = 30;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Checked = false;
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(92, 112);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(254, 27);
            this.dtpStartDate.TabIndex = 29;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // button_manage_locations
            // 
            this.button_manage_locations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_manage_locations.FlatAppearance.BorderSize = 0;
            this.button_manage_locations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_manage_locations.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_manage_locations.ForeColor = System.Drawing.Color.White;
            this.button_manage_locations.Location = new System.Drawing.Point(346, 501);
            this.button_manage_locations.Name = "button_manage_locations";
            this.button_manage_locations.Size = new System.Drawing.Size(346, 44);
            this.button_manage_locations.TabIndex = 26;
            this.button_manage_locations.Text = "Manage Transactions";
            this.button_manage_locations.UseVisualStyleBackColor = false;
            this.button_manage_locations.Click += new System.EventHandler(this.button_manage_locations_Click);
            // 
            // button_home
            // 
            this.button_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_home.ForeColor = System.Drawing.Color.White;
            this.button_home.Location = new System.Drawing.Point(0, 501);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(346, 44);
            this.button_home.TabIndex = 24;
            this.button_home.Text = "Home";
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // dgvTransactionsList
            // 
            this.dgvTransactionsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactionsList.Location = new System.Drawing.Point(0, 178);
            this.dgvTransactionsList.Name = "dgvTransactionsList";
            this.dgvTransactionsList.RowHeadersWidth = 51;
            this.dgvTransactionsList.RowTemplate.Height = 24;
            this.dgvTransactionsList.Size = new System.Drawing.Size(692, 325);
            this.dgvTransactionsList.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(154, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(386, 28);
            this.label8.TabIndex = 14;
            this.label8.Text = "Choose date range to view transactions";
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=ESCO-PC\\SQLEXPRESS01;Initial Catalog=HOTEL_TEST;Integrated Security=T" +
    "rue";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // ViewTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "ViewTransactions";
            this.Size = new System.Drawing.Size(692, 545);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_manage_locations;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.DataGridView dgvTransactionsList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Transactions pnlManageTransactions;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
    }
}
