﻿namespace HotelApp_v1
{
    partial class Transactions
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
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.txtTransDate = new System.Windows.Forms.TextBox();
            this.txtTransNo = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTransNo = new System.Windows.Forms.Label();
            this.txtResID = new System.Windows.Forms.TextBox();
            this.txtTransAmt = new System.Windows.Forms.TextBox();
            this.lblResID = new System.Windows.Forms.Label();
            this.lblTransTitle = new System.Windows.Forms.Label();
            this.lblTransAmt = new System.Windows.Forms.Label();
            this.lblTransDate = new System.Windows.Forms.Label();
            this.sqlConnection2 = new System.Data.SqlClient.SqlConnection();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtEmpName);
            this.panel2.Controls.Add(this.txtCustName);
            this.panel2.Controls.Add(this.lblCustName);
            this.panel2.Controls.Add(this.lblEmpName);
            this.panel2.Controls.Add(this.txtTransDate);
            this.panel2.Controls.Add(this.txtTransNo);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.lblTransNo);
            this.panel2.Controls.Add(this.txtResID);
            this.panel2.Controls.Add(this.txtTransAmt);
            this.panel2.Controls.Add(this.lblResID);
            this.panel2.Controls.Add(this.lblTransTitle);
            this.panel2.Controls.Add(this.lblTransAmt);
            this.panel2.Controls.Add(this.lblTransDate);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 852);
            this.panel2.TabIndex = 24;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(592, 648);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.ReadOnly = true;
            this.txtEmpName.Size = new System.Drawing.Size(338, 39);
            this.txtEmpName.TabIndex = 38;
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(93, 648);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.ReadOnly = true;
            this.txtCustName.Size = new System.Drawing.Size(338, 39);
            this.txtCustName.TabIndex = 37;
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.BackColor = System.Drawing.Color.White;
            this.lblCustName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(87, 592);
            this.lblCustName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(188, 32);
            this.lblCustName.TabIndex = 35;
            this.lblCustName.Text = "Customer Name";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.BackColor = System.Drawing.Color.White;
            this.lblEmpName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.Location = new System.Drawing.Point(586, 592);
            this.lblEmpName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(190, 32);
            this.lblEmpName.TabIndex = 36;
            this.lblEmpName.Text = "Employee Name";
            // 
            // txtTransDate
            // 
            this.txtTransDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransDate.Location = new System.Drawing.Point(592, 473);
            this.txtTransDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTransDate.Name = "txtTransDate";
            this.txtTransDate.ReadOnly = true;
            this.txtTransDate.Size = new System.Drawing.Size(338, 39);
            this.txtTransDate.TabIndex = 34;
            // 
            // txtTransNo
            // 
            this.txtTransNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransNo.Location = new System.Drawing.Point(93, 303);
            this.txtTransNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTransNo.Name = "txtTransNo";
            this.txtTransNo.Size = new System.Drawing.Size(338, 39);
            this.txtTransNo.TabIndex = 33;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(764, 783);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(274, 69);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(278, 783);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(489, 69);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(0, 783);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(298, 69);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBackClick);
            // 
            // lblTransNo
            // 
            this.lblTransNo.AutoSize = true;
            this.lblTransNo.BackColor = System.Drawing.Color.White;
            this.lblTransNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransNo.Location = new System.Drawing.Point(87, 239);
            this.lblTransNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransNo.Name = "lblTransNo";
            this.lblTransNo.Size = new System.Drawing.Size(229, 32);
            this.lblTransNo.TabIndex = 0;
            this.lblTransNo.Text = "Transaction Number";
            // 
            // txtResID
            // 
            this.txtResID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResID.Location = new System.Drawing.Point(592, 303);
            this.txtResID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResID.Name = "txtResID";
            this.txtResID.ReadOnly = true;
            this.txtResID.Size = new System.Drawing.Size(338, 39);
            this.txtResID.TabIndex = 8;
            // 
            // txtTransAmt
            // 
            this.txtTransAmt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransAmt.Location = new System.Drawing.Point(93, 473);
            this.txtTransAmt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTransAmt.Name = "txtTransAmt";
            this.txtTransAmt.ReadOnly = true;
            this.txtTransAmt.Size = new System.Drawing.Size(338, 39);
            this.txtTransAmt.TabIndex = 9;
            // 
            // lblResID
            // 
            this.lblResID.AutoSize = true;
            this.lblResID.BackColor = System.Drawing.Color.White;
            this.lblResID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResID.Location = new System.Drawing.Point(586, 239);
            this.lblResID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResID.Name = "lblResID";
            this.lblResID.Size = new System.Drawing.Size(167, 32);
            this.lblResID.TabIndex = 2;
            this.lblResID.Text = "Reservation ID";
            // 
            // lblTransTitle
            // 
            this.lblTransTitle.AutoSize = true;
            this.lblTransTitle.BackColor = System.Drawing.Color.White;
            this.lblTransTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransTitle.Location = new System.Drawing.Point(164, 102);
            this.lblTransTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransTitle.Name = "lblTransTitle";
            this.lblTransTitle.Size = new System.Drawing.Size(719, 45);
            this.lblTransTitle.TabIndex = 14;
            this.lblTransTitle.Text = "Enter Transaction Number and click Search below";
            // 
            // lblTransAmt
            // 
            this.lblTransAmt.AutoSize = true;
            this.lblTransAmt.BackColor = System.Drawing.Color.White;
            this.lblTransAmt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransAmt.Location = new System.Drawing.Point(87, 417);
            this.lblTransAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransAmt.Name = "lblTransAmt";
            this.lblTransAmt.Size = new System.Drawing.Size(227, 32);
            this.lblTransAmt.TabIndex = 1;
            this.lblTransAmt.Text = "Transaction Amount";
            // 
            // lblTransDate
            // 
            this.lblTransDate.AutoSize = true;
            this.lblTransDate.BackColor = System.Drawing.Color.White;
            this.lblTransDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransDate.Location = new System.Drawing.Point(586, 417);
            this.lblTransDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransDate.Name = "lblTransDate";
            this.lblTransDate.Size = new System.Drawing.Size(191, 32);
            this.lblTransDate.TabIndex = 6;
            this.lblTransDate.Text = "Transaction Date";
            // 
            // sqlConnection2
            // 
            this.sqlConnection2.ConnectionString = "Data Source=ELISEORICOCE42;Initial Catalog=TestDatabase;Integrated Security=True";
            this.sqlConnection2.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=ELISEORICOCE42;Initial Catalog=TestDatabase;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Transactions";
            this.Size = new System.Drawing.Size(1038, 852);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTransNo;
        private System.Windows.Forms.TextBox txtResID;
        private System.Windows.Forms.TextBox txtTransAmt;
        private System.Windows.Forms.Label lblResID;
        private System.Windows.Forms.Label lblTransTitle;
        private System.Windows.Forms.Label lblTransAmt;
        private System.Windows.Forms.Label lblTransDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTransNo;
        private System.Windows.Forms.TextBox txtTransDate;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblEmpName;
        private System.Data.SqlClient.SqlConnection sqlConnection2;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
    }
}
