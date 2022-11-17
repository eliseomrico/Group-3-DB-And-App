namespace HotelApp_v1
{
    partial class CheckOutForm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.txtCustLname = new System.Windows.Forms.TextBox();
            this.txtResID = new System.Windows.Forms.TextBox();
            this.lblResID = new System.Windows.Forms.Label();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnSubmit);
            this.panel3.Controls.Add(this.btnHome);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lblLname);
            this.panel3.Controls.Add(this.txtCustLname);
            this.panel3.Controls.Add(this.txtResID);
            this.panel3.Controls.Add(this.lblResID);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(692, 545);
            this.panel3.TabIndex = 23;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(346, 501);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(346, 44);
            this.btnSubmit.TabIndex = 30;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.button_submit_Click);
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
            this.btnHome.Size = new System.Drawing.Size(346, 44);
            this.btnHome.TabIndex = 29;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.button_home_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(289, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Check Out";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.BackColor = System.Drawing.Color.White;
            this.lblLname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.Location = new System.Drawing.Point(234, 202);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(79, 20);
            this.lblLname.TabIndex = 7;
            this.lblLname.Text = "Last Name";
            // 
            // txtCustLname
            // 
            this.txtCustLname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustLname.Location = new System.Drawing.Point(238, 239);
            this.txtCustLname.Name = "txtCustLname";
            this.txtCustLname.Size = new System.Drawing.Size(227, 27);
            this.txtCustLname.TabIndex = 10;
            // 
            // txtResID
            // 
            this.txtResID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResID.Location = new System.Drawing.Point(238, 334);
            this.txtResID.Name = "txtResID";
            this.txtResID.Size = new System.Drawing.Size(227, 27);
            this.txtResID.TabIndex = 11;
            // 
            // lblResID
            // 
            this.lblResID.AutoSize = true;
            this.lblResID.BackColor = System.Drawing.Color.White;
            this.lblResID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResID.Location = new System.Drawing.Point(234, 295);
            this.lblResID.Name = "lblResID";
            this.lblResID.Size = new System.Drawing.Size(105, 20);
            this.lblResID.TabIndex = 8;
            this.lblResID.Text = "Reservation ID";
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=ESCO-PC\\SQLEXPRESS01;Initial Catalog=HOTEL_TEST;Integrated Security=T" +
    "rue";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // CheckOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "CheckOutForm";
            this.Size = new System.Drawing.Size(692, 545);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.TextBox txtCustLname;
        private System.Windows.Forms.TextBox txtResID;
        private System.Windows.Forms.Label lblResID;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnHome;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
    }
}
