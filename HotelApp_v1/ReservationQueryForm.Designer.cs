namespace HotelApp_v1
{
    partial class ReservationQueryForm
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
            this.cmbCustName = new System.Windows.Forms.ComboBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtTransNo = new System.Windows.Forms.TextBox();
            this.lblTransNo = new System.Windows.Forms.Label();
            this.txtResID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmitCreate = new System.Windows.Forms.Button();
            this.btnSubmitEdit = new System.Windows.Forms.Button();
            this.dtpResEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpResStart = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.comboBox_res_id = new System.Windows.Forms.ComboBox();
            this.lblResID = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtLocName = new System.Windows.Forms.TextBox();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.lblLocID = new System.Windows.Forms.Label();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.lblResStart = new System.Windows.Forms.Label();
            this.lblResEnd = new System.Windows.Forms.Label();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cmbCustName);
            this.panel2.Controls.Add(this.txtCustName);
            this.panel2.Controls.Add(this.txtTransNo);
            this.panel2.Controls.Add(this.lblTransNo);
            this.panel2.Controls.Add(this.txtResID);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSubmitCreate);
            this.panel2.Controls.Add(this.btnSubmitEdit);
            this.panel2.Controls.Add(this.dtpResEnd);
            this.panel2.Controls.Add(this.dtpResStart);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.button_delete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnCreate);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.comboBox_res_id);
            this.panel2.Controls.Add(this.lblResID);
            this.panel2.Controls.Add(this.txtEmpName);
            this.panel2.Controls.Add(this.txtLocName);
            this.panel2.Controls.Add(this.txtRoomNo);
            this.panel2.Controls.Add(this.lblEmpID);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblCustID);
            this.panel2.Controls.Add(this.lblLocID);
            this.panel2.Controls.Add(this.lblRoomNo);
            this.panel2.Controls.Add(this.lblResStart);
            this.panel2.Controls.Add(this.lblResEnd);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 852);
            this.panel2.TabIndex = 23;
            // 
            // cmbCustName
            // 
            this.cmbCustName.FormattingEnabled = true;
            this.cmbCustName.Location = new System.Drawing.Point(111, 367);
            this.cmbCustName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCustName.Name = "cmbCustName";
            this.cmbCustName.Size = new System.Drawing.Size(336, 33);
            this.cmbCustName.TabIndex = 38;
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(108, 362);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.ReadOnly = true;
            this.txtCustName.Size = new System.Drawing.Size(338, 39);
            this.txtCustName.TabIndex = 37;
            // 
            // txtTransNo
            // 
            this.txtTransNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransNo.Location = new System.Drawing.Point(576, 522);
            this.txtTransNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTransNo.Name = "txtTransNo";
            this.txtTransNo.ReadOnly = true;
            this.txtTransNo.Size = new System.Drawing.Size(338, 39);
            this.txtTransNo.TabIndex = 36;
            // 
            // lblTransNo
            // 
            this.lblTransNo.AutoSize = true;
            this.lblTransNo.BackColor = System.Drawing.Color.White;
            this.lblTransNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransNo.Location = new System.Drawing.Point(567, 469);
            this.lblTransNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransNo.Name = "lblTransNo";
            this.lblTransNo.Size = new System.Drawing.Size(229, 32);
            this.lblTransNo.TabIndex = 35;
            this.lblTransNo.Text = "Transaction Number";
            // 
            // txtResID
            // 
            this.txtResID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResID.Location = new System.Drawing.Point(111, 216);
            this.txtResID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtResID.Name = "txtResID";
            this.txtResID.ReadOnly = true;
            this.txtResID.Size = new System.Drawing.Size(338, 39);
            this.txtResID.TabIndex = 34;
            this.txtResID.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(830, 783);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(208, 69);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // btnSubmitCreate
            // 
            this.btnSubmitCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnSubmitCreate.Enabled = false;
            this.btnSubmitCreate.FlatAppearance.BorderSize = 0;
            this.btnSubmitCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitCreate.ForeColor = System.Drawing.Color.White;
            this.btnSubmitCreate.Location = new System.Drawing.Point(414, 783);
            this.btnSubmitCreate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSubmitCreate.Name = "btnSubmitCreate";
            this.btnSubmitCreate.Size = new System.Drawing.Size(208, 69);
            this.btnSubmitCreate.TabIndex = 31;
            this.btnSubmitCreate.Text = "Submit Create";
            this.btnSubmitCreate.UseVisualStyleBackColor = false;
            this.btnSubmitCreate.Visible = false;
            this.btnSubmitCreate.Click += new System.EventHandler(this.button_submit_create_Click);
            // 
            // btnSubmitEdit
            // 
            this.btnSubmitEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnSubmitEdit.Enabled = false;
            this.btnSubmitEdit.FlatAppearance.BorderSize = 0;
            this.btnSubmitEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitEdit.ForeColor = System.Drawing.Color.White;
            this.btnSubmitEdit.Location = new System.Drawing.Point(622, 783);
            this.btnSubmitEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSubmitEdit.Name = "btnSubmitEdit";
            this.btnSubmitEdit.Size = new System.Drawing.Size(208, 69);
            this.btnSubmitEdit.TabIndex = 30;
            this.btnSubmitEdit.Text = "Submit Edit";
            this.btnSubmitEdit.UseVisualStyleBackColor = false;
            this.btnSubmitEdit.Visible = false;
            this.btnSubmitEdit.Click += new System.EventHandler(this.button_submit_edit_Click);
            // 
            // dtpResEnd
            // 
            this.dtpResEnd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpResEnd.Location = new System.Drawing.Point(576, 672);
            this.dtpResEnd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpResEnd.Name = "dtpResEnd";
            this.dtpResEnd.Size = new System.Drawing.Size(338, 39);
            this.dtpResEnd.TabIndex = 29;
            // 
            // dtpResStart
            // 
            this.dtpResStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpResStart.Location = new System.Drawing.Point(111, 672);
            this.dtpResStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpResStart.Name = "dtpResStart";
            this.dtpResStart.Size = new System.Drawing.Size(338, 39);
            this.dtpResStart.TabIndex = 28;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(208, 783);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(208, 69);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_delete.Enabled = false;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(830, 783);
            this.button_delete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(208, 69);
            this.button_delete.TabIndex = 26;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(622, 783);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(208, 69);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(414, 783);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(208, 69);
            this.btnCreate.TabIndex = 24;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.button_create_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(0, 783);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(208, 69);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button_home_Click);
            // 
            // comboBox_res_id
            // 
            this.comboBox_res_id.BackColor = System.Drawing.Color.White;
            this.comboBox_res_id.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_res_id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_res_id.FormattingEnabled = true;
            this.comboBox_res_id.Location = new System.Drawing.Point(108, 212);
            this.comboBox_res_id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_res_id.Name = "comboBox_res_id";
            this.comboBox_res_id.Size = new System.Drawing.Size(338, 40);
            this.comboBox_res_id.TabIndex = 16;
            // 
            // lblResID
            // 
            this.lblResID.AutoSize = true;
            this.lblResID.BackColor = System.Drawing.Color.White;
            this.lblResID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResID.Location = new System.Drawing.Point(105, 167);
            this.lblResID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResID.Name = "lblResID";
            this.lblResID.Size = new System.Drawing.Size(232, 32);
            this.lblResID.TabIndex = 0;
            this.lblResID.Text = "Reservation Number";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(576, 216);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.ReadOnly = true;
            this.txtEmpName.Size = new System.Drawing.Size(338, 39);
            this.txtEmpName.TabIndex = 8;
            // 
            // txtLocName
            // 
            this.txtLocName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocName.Location = new System.Drawing.Point(576, 362);
            this.txtLocName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLocName.Name = "txtLocName";
            this.txtLocName.ReadOnly = true;
            this.txtLocName.Size = new System.Drawing.Size(338, 39);
            this.txtLocName.TabIndex = 10;
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNo.Location = new System.Drawing.Point(108, 522);
            this.txtRoomNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.ReadOnly = true;
            this.txtRoomNo.Size = new System.Drawing.Size(338, 39);
            this.txtRoomNo.TabIndex = 11;
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.BackColor = System.Drawing.Color.White;
            this.lblEmpID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.Location = new System.Drawing.Point(567, 167);
            this.lblEmpID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(190, 32);
            this.lblEmpID.TabIndex = 2;
            this.lblEmpID.Text = "Employee Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(186, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(637, 45);
            this.label8.TabIndex = 14;
            this.label8.Text = "Enter Reservation ID and click Search below";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.BackColor = System.Drawing.Color.White;
            this.lblCustID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.Location = new System.Drawing.Point(105, 309);
            this.lblCustID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(188, 32);
            this.lblCustID.TabIndex = 1;
            this.lblCustID.Text = "Customer Name";
            // 
            // lblLocID
            // 
            this.lblLocID.AutoSize = true;
            this.lblLocID.BackColor = System.Drawing.Color.White;
            this.lblLocID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocID.Location = new System.Drawing.Point(567, 309);
            this.lblLocID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocID.Name = "lblLocID";
            this.lblLocID.Size = new System.Drawing.Size(104, 32);
            this.lblLocID.TabIndex = 4;
            this.lblLocID.Text = "Location";
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.BackColor = System.Drawing.Color.White;
            this.lblRoomNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNo.Location = new System.Drawing.Point(105, 475);
            this.lblRoomNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(171, 32);
            this.lblRoomNo.TabIndex = 3;
            this.lblRoomNo.Text = "Room Number";
            // 
            // lblResStart
            // 
            this.lblResStart.AutoSize = true;
            this.lblResStart.BackColor = System.Drawing.Color.White;
            this.lblResStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResStart.Location = new System.Drawing.Point(102, 628);
            this.lblResStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResStart.Name = "lblResStart";
            this.lblResStart.Size = new System.Drawing.Size(249, 32);
            this.lblResStart.TabIndex = 5;
            this.lblResStart.Text = "Reservation Start Date";
            // 
            // lblResEnd
            // 
            this.lblResEnd.AutoSize = true;
            this.lblResEnd.BackColor = System.Drawing.Color.White;
            this.lblResEnd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResEnd.Location = new System.Drawing.Point(567, 628);
            this.lblResEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResEnd.Name = "lblResEnd";
            this.lblResEnd.Size = new System.Drawing.Size(241, 32);
            this.lblResEnd.TabIndex = 6;
            this.lblResEnd.Text = "Reservation End Date";
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // ReservationQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ReservationQueryForm";
            this.Size = new System.Drawing.Size(1038, 852);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox comboBox_res_id;
        private System.Windows.Forms.Label lblResID;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtLocName;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label lblLocID;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label lblResStart;
        private System.Windows.Forms.Label lblResEnd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpResEnd;
        private System.Windows.Forms.DateTimePicker dtpResStart;
        private System.Windows.Forms.Button btnSubmitEdit;
        private System.Windows.Forms.Button btnSubmitCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtResID;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.TextBox txtTransNo;
        private System.Windows.Forms.Label lblTransNo;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.ComboBox cmbCustName;
    }
}
