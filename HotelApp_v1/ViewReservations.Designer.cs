namespace HotelApp_v1
{
    partial class ViewReservations
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.reservationQueryForm1 = new HotelApp_v1.ReservationQueryForm();
            this.btnManageRes = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.cmbLocName = new System.Windows.Forms.ComboBox();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.lblLocName = new System.Windows.Forms.Label();
            this.lblResTitle = new System.Windows.Forms.Label();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.lblEndDate);
            this.panel2.Controls.Add(this.lblStartDate);
            this.panel2.Controls.Add(this.dtpEndDate);
            this.panel2.Controls.Add(this.dtpStartDate);
            this.panel2.Controls.Add(this.reservationQueryForm1);
            this.panel2.Controls.Add(this.btnManageRes);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Controls.Add(this.cmbLocName);
            this.panel2.Controls.Add(this.dgvRooms);
            this.panel2.Controls.Add(this.lblLocName);
            this.panel2.Controls.Add(this.lblResTitle);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 545);
            this.panel2.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(210, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 44);
            this.button1.TabIndex = 39;
            this.button1.Text = "Create Reservation";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(523, 129);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 32);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button_search_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.BackColor = System.Drawing.Color.White;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(88, 113);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(73, 20);
            this.lblEndDate.TabIndex = 36;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.White;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(87, 81);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(79, 20);
            this.lblStartDate.TabIndex = 35;
            this.lblStartDate.Text = "Start Date:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Checked = false;
            this.dtpEndDate.CustomFormat = " MM/dd/yyyy";
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(171, 112);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(145, 27);
            this.dtpEndDate.TabIndex = 34;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Checked = false;
            this.dtpStartDate.CustomFormat = " MM/dd/yyyy";
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(171, 79);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(145, 27);
            this.dtpStartDate.TabIndex = 33;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // reservationQueryForm1
            // 
            this.reservationQueryForm1.Location = new System.Drawing.Point(0, 0);
            this.reservationQueryForm1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reservationQueryForm1.Name = "reservationQueryForm1";
            this.reservationQueryForm1.Size = new System.Drawing.Size(692, 545);
            this.reservationQueryForm1.TabIndex = 27;
            this.reservationQueryForm1.Visible = false;
            // 
            // btnManageRes
            // 
            this.btnManageRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnManageRes.FlatAppearance.BorderSize = 0;
            this.btnManageRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageRes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageRes.ForeColor = System.Drawing.Color.White;
            this.btnManageRes.Location = new System.Drawing.Point(450, 501);
            this.btnManageRes.Name = "btnManageRes";
            this.btnManageRes.Size = new System.Drawing.Size(242, 44);
            this.btnManageRes.TabIndex = 26;
            this.btnManageRes.Text = "Manage Reservations";
            this.btnManageRes.UseVisualStyleBackColor = false;
            this.btnManageRes.Click += new System.EventHandler(this.button_manage_reservations_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 501);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(210, 44);
            this.btnHome.TabIndex = 24;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.button_home_Click);
            // 
            // cmbLocName
            // 
            this.cmbLocName.BackColor = System.Drawing.Color.White;
            this.cmbLocName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbLocName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocName.FormattingEnabled = true;
            this.cmbLocName.Location = new System.Drawing.Point(439, 82);
            this.cmbLocName.Name = "cmbLocName";
            this.cmbLocName.Size = new System.Drawing.Size(208, 28);
            this.cmbLocName.TabIndex = 16;
            this.cmbLocName.Click += new System.EventHandler(this.cmbLocName_Click);
            // 
            // dgvRooms
            // 
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(0, 179);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.RowHeadersWidth = 51;
            this.dgvRooms.RowTemplate.Height = 24;
            this.dgvRooms.Size = new System.Drawing.Size(692, 325);
            this.dgvRooms.TabIndex = 15;
            // 
            // lblLocName
            // 
            this.lblLocName.AutoSize = true;
            this.lblLocName.BackColor = System.Drawing.Color.White;
            this.lblLocName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocName.Location = new System.Drawing.Point(365, 85);
            this.lblLocName.Name = "lblLocName";
            this.lblLocName.Size = new System.Drawing.Size(69, 20);
            this.lblLocName.TabIndex = 0;
            this.lblLocName.Text = "Location:";
            // 
            // lblResTitle
            // 
            this.lblResTitle.AutoSize = true;
            this.lblResTitle.BackColor = System.Drawing.Color.White;
            this.lblResTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResTitle.Location = new System.Drawing.Point(66, 24);
            this.lblResTitle.Name = "lblResTitle";
            this.lblResTitle.Size = new System.Drawing.Size(523, 28);
            this.lblResTitle.TabIndex = 14;
            this.lblResTitle.Text = "Choose desired location and dates to view available rooms";
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=ESCO-PC\\SQLEXPRESS01;Initial Catalog=HOTEL_TEST;Integrated Security=T" +
    "rue";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // ViewReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "ViewReservations";
            this.Size = new System.Drawing.Size(692, 545);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnManageRes;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ComboBox cmbLocName;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.Label lblLocName;
        private System.Windows.Forms.Label lblResTitle;
        private ReservationQueryForm reservationQueryForm1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button1;
    }
}
