namespace HotelApp_v1
{
    partial class CheckInForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.reservationQueryForm1 = new HotelApp_v1.ReservationQueryForm();
            this.btnResSearch = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtSecCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblSecCode = new System.Windows.Forms.Label();
            this.lblResID = new System.Windows.Forms.Label();
            this.txtResID = new System.Windows.Forms.TextBox();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.cmbCustName = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.reservationQueryForm1);
            this.panel3.Controls.Add(this.cmbCustName);
            this.panel3.Controls.Add(this.btnResSearch);
            this.panel3.Controls.Add(this.btnSubmit);
            this.panel3.Controls.Add(this.btnHome);
            this.panel3.Controls.Add(this.txtSecCode);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lblLname);
            this.panel3.Controls.Add(this.lblSecCode);
            this.panel3.Controls.Add(this.lblResID);
            this.panel3.Controls.Add(this.txtResID);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1038, 852);
            this.panel3.TabIndex = 22;
            // 
            // reservationQueryForm1
            // 
            this.reservationQueryForm1.Location = new System.Drawing.Point(0, 0);
            this.reservationQueryForm1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.reservationQueryForm1.Name = "reservationQueryForm1";
            this.reservationQueryForm1.Size = new System.Drawing.Size(1038, 852);
            this.reservationQueryForm1.TabIndex = 30;
            this.reservationQueryForm1.Visible = false;
            // 
            // btnResSearch
            // 
            this.btnResSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnResSearch.FlatAppearance.BorderSize = 0;
            this.btnResSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResSearch.ForeColor = System.Drawing.Color.White;
            this.btnResSearch.Location = new System.Drawing.Point(262, 783);
            this.btnResSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResSearch.Name = "btnResSearch";
            this.btnResSearch.Size = new System.Drawing.Size(519, 69);
            this.btnResSearch.TabIndex = 29;
            this.btnResSearch.Text = "Need to Search for Reservation ID?";
            this.btnResSearch.UseVisualStyleBackColor = false;
            this.btnResSearch.Click += new System.EventHandler(this.btnResSearch_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(770, 783);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(268, 69);
            this.btnSubmit.TabIndex = 28;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 783);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(268, 69);
            this.btnHome.TabIndex = 27;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.button_home_Click);

            // 
            // txtSecCode
            // 
            this.txtSecCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecCode.Location = new System.Drawing.Point(450, 605);
            this.txtSecCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSecCode.Name = "txtSecCode";
            this.txtSecCode.Size = new System.Drawing.Size(145, 39);
            this.txtSecCode.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(442, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 45);
            this.label6.TabIndex = 5;
            this.label6.Text = "Check In";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.BackColor = System.Drawing.Color.White;
            this.lblLname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.Location = new System.Drawing.Point(351, 239);
            this.lblLname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(126, 32);
            this.lblLname.TabIndex = 0;
            this.lblLname.Text = "Last Name";
            // 
            // lblSecCode
            // 
            this.lblSecCode.AutoSize = true;
            this.lblSecCode.BackColor = System.Drawing.Color.White;
            this.lblSecCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecCode.Location = new System.Drawing.Point(447, 550);
            this.lblSecCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecCode.Name = "lblSecCode";
            this.lblSecCode.Size = new System.Drawing.Size(162, 32);
            this.lblSecCode.TabIndex = 4;
            this.lblSecCode.Text = "Security Code";
            // 
            // lblResID
            // 
            this.lblResID.AutoSize = true;
            this.lblResID.BackColor = System.Drawing.Color.White;
            this.lblResID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResID.Location = new System.Drawing.Point(351, 384);
            this.lblResID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResID.Name = "lblResID";
            this.lblResID.Size = new System.Drawing.Size(167, 32);
            this.lblResID.TabIndex = 1;
            this.lblResID.Text = "Reservation ID";
            // 
            // txtResID
            // 
            this.txtResID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResID.Location = new System.Drawing.Point(357, 445);
            this.txtResID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResID.Name = "txtResID";
            this.txtResID.Size = new System.Drawing.Size(338, 39);
            this.txtResID.TabIndex = 10;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=ELISEORICOCE42;Initial Catalog=TestDatabase;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // cmbCustName
            // 
            this.cmbCustName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustName.FormattingEnabled = true;
            this.cmbCustName.Location = new System.Drawing.Point(238, 200);
            this.cmbCustName.Name = "cmbCustName";
            this.cmbCustName.Size = new System.Drawing.Size(226, 28);
            this.cmbCustName.TabIndex = 31;
            this.cmbCustName.Click += new System.EventHandler(this.cmbCustName_Click);
            // 
            // CheckInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CheckInForm";
            this.Size = new System.Drawing.Size(1038, 852);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSecCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblSecCode;
        private System.Windows.Forms.Label lblResID;
        private System.Windows.Forms.TextBox txtResID;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnResSearch;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private ReservationQueryForm reservationQueryForm1;
        private System.Windows.Forms.ComboBox cmbCustName;
    }
}
