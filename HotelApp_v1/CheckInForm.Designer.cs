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
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtSecCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblSecCode = new System.Windows.Forms.Label();
            this.lblResID = new System.Windows.Forms.Label();
            this.txtResID = new System.Windows.Forms.TextBox();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.reservationQueryForm1);
            this.panel3.Controls.Add(this.btnResSearch);
            this.panel3.Controls.Add(this.btnSubmit);
            this.panel3.Controls.Add(this.btnHome);
            this.panel3.Controls.Add(this.txtLname);
            this.panel3.Controls.Add(this.txtSecCode);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lblLname);
            this.panel3.Controls.Add(this.lblSecCode);
            this.panel3.Controls.Add(this.lblResID);
            this.panel3.Controls.Add(this.txtResID);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(692, 545);
            this.panel3.TabIndex = 22;
            // 
            // reservationQueryForm1
            // 
            this.reservationQueryForm1.Location = new System.Drawing.Point(0, 0);
            this.reservationQueryForm1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reservationQueryForm1.Name = "reservationQueryForm1";
            this.reservationQueryForm1.Size = new System.Drawing.Size(692, 545);
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
            this.btnResSearch.Location = new System.Drawing.Point(175, 501);
            this.btnResSearch.Name = "btnResSearch";
            this.btnResSearch.Size = new System.Drawing.Size(346, 44);
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
            this.btnSubmit.Location = new System.Drawing.Point(513, 501);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(179, 44);
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
            this.btnHome.Location = new System.Drawing.Point(0, 501);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(179, 44);
            this.btnHome.TabIndex = 27;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.button_home_Click);
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(238, 190);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(227, 27);
            this.txtLname.TabIndex = 9;
            // 
            // txtSecCode
            // 
            this.txtSecCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecCode.Location = new System.Drawing.Point(300, 387);
            this.txtSecCode.Name = "txtSecCode";
            this.txtSecCode.Size = new System.Drawing.Size(98, 27);
            this.txtSecCode.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(295, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Check In";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.BackColor = System.Drawing.Color.White;
            this.lblLname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.Location = new System.Drawing.Point(234, 153);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(79, 20);
            this.lblLname.TabIndex = 0;
            this.lblLname.Text = "Last Name";
            // 
            // lblSecCode
            // 
            this.lblSecCode.AutoSize = true;
            this.lblSecCode.BackColor = System.Drawing.Color.White;
            this.lblSecCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecCode.Location = new System.Drawing.Point(298, 352);
            this.lblSecCode.Name = "lblSecCode";
            this.lblSecCode.Size = new System.Drawing.Size(100, 20);
            this.lblSecCode.TabIndex = 4;
            this.lblSecCode.Text = "Security Code";
            // 
            // lblResID
            // 
            this.lblResID.AutoSize = true;
            this.lblResID.BackColor = System.Drawing.Color.White;
            this.lblResID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResID.Location = new System.Drawing.Point(234, 246);
            this.lblResID.Name = "lblResID";
            this.lblResID.Size = new System.Drawing.Size(105, 20);
            this.lblResID.TabIndex = 1;
            this.lblResID.Text = "Reservation ID";
            // 
            // txtResID
            // 
            this.txtResID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResID.Location = new System.Drawing.Point(238, 285);
            this.txtResID.Name = "txtResID";
            this.txtResID.Size = new System.Drawing.Size(227, 27);
            this.txtResID.TabIndex = 10;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=ESCO-PC\\SQLEXPRESS01;Initial Catalog=HOTEL_TEST;Integrated Security=T" +
    "rue";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // CheckInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "CheckInForm";
            this.Size = new System.Drawing.Size(692, 545);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtLname;
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
    }
}
