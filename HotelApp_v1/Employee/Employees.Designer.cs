namespace HotelApp_v1
{
    partial class Employees
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
            this.chkNewSuper = new System.Windows.Forms.CheckBox();
            this.cmbEmpLoc = new System.Windows.Forms.ComboBox();
            this.cmbEmpTitle = new System.Windows.Forms.ComboBox();
            this.cmbEmpSup = new System.Windows.Forms.ComboBox();
            this.txtEmpFname = new System.Windows.Forms.TextBox();
            this.txtEmpLoc = new System.Windows.Forms.TextBox();
            this.cmbEmpFname = new System.Windows.Forms.ComboBox();
            this.lblEmpFname = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmitEdit = new System.Windows.Forms.Button();
            this.btnSubmitCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblEmpLoc = new System.Windows.Forms.Label();
            this.txtEmpSSN = new System.Windows.Forms.TextBox();
            this.txtEmpSup = new System.Windows.Forms.TextBox();
            this.txtEmpLname = new System.Windows.Forms.TextBox();
            this.txtEmpTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSelectEmployee = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHiddenID = new System.Windows.Forms.TextBox();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlConnection2 = new System.Data.SqlClient.SqlConnection();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.chkNewSuper);
            this.panel2.Controls.Add(this.cmbEmpLoc);
            this.panel2.Controls.Add(this.cmbEmpTitle);
            this.panel2.Controls.Add(this.cmbEmpSup);
            this.panel2.Controls.Add(this.txtEmpFname);
            this.panel2.Controls.Add(this.txtEmpLoc);
            this.panel2.Controls.Add(this.cmbEmpFname);
            this.panel2.Controls.Add(this.lblEmpFname);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSubmitEdit);
            this.panel2.Controls.Add(this.btnSubmitCreate);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnCreate);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Controls.Add(this.lblEmpLoc);
            this.panel2.Controls.Add(this.txtEmpSSN);
            this.panel2.Controls.Add(this.txtEmpSup);
            this.panel2.Controls.Add(this.txtEmpLname);
            this.panel2.Controls.Add(this.txtEmpTitle);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblSelectEmployee);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtHiddenID);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 852);
            this.panel2.TabIndex = 23;
            // 
            // chkNewSuper
            // 
            this.chkNewSuper.AutoSize = true;
            this.chkNewSuper.Enabled = false;
            this.chkNewSuper.Location = new System.Drawing.Point(480, 426);
            this.chkNewSuper.Name = "chkNewSuper";
            this.chkNewSuper.Size = new System.Drawing.Size(131, 20);
            this.chkNewSuper.TabIndex = 51;
            this.chkNewSuper.Text = "New Supervisor?";
            this.chkNewSuper.UseVisualStyleBackColor = true;
            this.chkNewSuper.Click += new System.EventHandler(this.chkNewSuper_Click);
            // 
            // cmbEmpLoc
            // 
            this.cmbEmpLoc.BackColor = System.Drawing.Color.White;
            this.cmbEmpLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpLoc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbEmpLoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpLoc.FormattingEnabled = true;
            this.cmbEmpLoc.Location = new System.Drawing.Point(83, 273);
            this.cmbEmpLoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEmpLoc.Name = "cmbEmpLoc";
            this.cmbEmpLoc.Size = new System.Drawing.Size(338, 40);
            this.cmbEmpLoc.TabIndex = 13;
            this.cmbEmpLoc.Visible = false;
            // 
            // cmbEmpTitle
            // 
            this.cmbEmpTitle.BackColor = System.Drawing.Color.White;
            this.cmbEmpTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpTitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbEmpTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpTitle.FormattingEnabled = true;
            this.cmbEmpTitle.Location = new System.Drawing.Point(83, 394);
            this.cmbEmpTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEmpTitle.Name = "cmbEmpTitle";
            this.cmbEmpTitle.Size = new System.Drawing.Size(338, 40);
            this.cmbEmpTitle.TabIndex = 15;
            this.cmbEmpTitle.Visible = false;
            // 
            // cmbEmpSup
            // 
            this.cmbEmpSup.BackColor = System.Drawing.Color.White;
            this.cmbEmpSup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpSup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbEmpSup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpSup.FormattingEnabled = true;
            this.cmbEmpSup.Location = new System.Drawing.Point(384, 393);
            this.cmbEmpSup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEmpSup.Name = "cmbEmpSup";
            this.cmbEmpSup.Size = new System.Drawing.Size(338, 40);
            this.cmbEmpSup.TabIndex = 16;
            this.cmbEmpSup.Visible = false;
            // 
            // txtEmpFname
            // 
            this.txtEmpFname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpFname.Location = new System.Drawing.Point(83, 172);
            this.txtEmpFname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmpFname.MaxLength = 20;
            this.txtEmpFname.Name = "txtEmpFname";
            this.txtEmpFname.ReadOnly = true;
            this.txtEmpFname.Size = new System.Drawing.Size(338, 39);
            this.txtEmpFname.TabIndex = 11;
            this.txtEmpFname.Visible = false;
            // 
            // txtEmpLoc
            // 
            this.txtEmpLoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpLoc.Location = new System.Drawing.Point(83, 273);
            this.txtEmpLoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmpLoc.Name = "txtEmpLoc";
            this.txtEmpLoc.ReadOnly = true;
            this.txtEmpLoc.Size = new System.Drawing.Size(338, 39);
            this.txtEmpLoc.TabIndex = 49;
            // 
            // cmbEmpFname
            // 
            this.cmbEmpFname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEmpFname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEmpFname.BackColor = System.Drawing.Color.White;
            this.cmbEmpFname.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbEmpFname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpFname.FormattingEnabled = true;
            this.cmbEmpFname.Location = new System.Drawing.Point(83, 154);
            this.cmbEmpFname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEmpFname.Name = "cmbEmpFname";
            this.cmbEmpFname.Size = new System.Drawing.Size(338, 40);
            this.cmbEmpFname.TabIndex = 47;
            this.cmbEmpFname.SelectedIndexChanged += new System.EventHandler(this.cmbEmpFname_SelectedIndexChanged);
            this.cmbEmpFname.Click += new System.EventHandler(this.cmbEmpFname_Click);
            // 
            // lblEmpFname
            // 
            this.lblEmpFname.AutoSize = true;
            this.lblEmpFname.BackColor = System.Drawing.Color.White;
            this.lblEmpFname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpFname.Location = new System.Drawing.Point(79, 122);
            this.lblEmpFname.Name = "lblEmpFname";
            this.lblEmpFname.Size = new System.Drawing.Size(129, 32);
            this.lblEmpFname.TabIndex = 46;
            this.lblEmpFname.Text = "First Name";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(0, 501);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(260, 69);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // btnSubmitEdit
            // 
            this.btnSubmitEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnSubmitEdit.Enabled = false;
            this.btnSubmitEdit.FlatAppearance.BorderSize = 0;
            this.btnSubmitEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitEdit.ForeColor = System.Drawing.Color.White;
            this.btnSubmitEdit.Location = new System.Drawing.Point(510, 783);
            this.btnSubmitEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSubmitEdit.Name = "btnSubmitEdit";
            this.btnSubmitEdit.Size = new System.Drawing.Size(270, 69);
            this.btnSubmitEdit.TabIndex = 44;
            this.btnSubmitEdit.Text = "Submit Edit";
            this.btnSubmitEdit.UseVisualStyleBackColor = false;
            this.btnSubmitEdit.Visible = false;
            this.btnSubmitEdit.Click += new System.EventHandler(this.button_submit_edit_Click);
            // 
            // btnSubmitCreate
            // 
            this.btnSubmitCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnSubmitCreate.Enabled = false;
            this.btnSubmitCreate.FlatAppearance.BorderSize = 0;
            this.btnSubmitCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitCreate.ForeColor = System.Drawing.Color.White;
            this.btnSubmitCreate.Location = new System.Drawing.Point(519, 501);
            this.btnSubmitCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitCreate.Name = "btnSubmitCreate";
            this.btnSubmitCreate.Size = new System.Drawing.Size(260, 69);
            this.btnSubmitCreate.TabIndex = 43;
            this.btnSubmitCreate.Text = "Submit Create";
            this.btnSubmitCreate.UseVisualStyleBackColor = false;
            this.btnSubmitCreate.Visible = false;
            this.btnSubmitCreate.Click += new System.EventHandler(this.button_submit_create_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(170, 501);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(260, 69);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(510, 783);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(270, 69);
            this.btnEdit.TabIndex = 30;
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
            this.btnCreate.Location = new System.Drawing.Point(519, 501);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(260, 69);
            this.btnCreate.TabIndex = 29;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.button_create_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 783);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(260, 69);
            this.btnHome.TabIndex = 28;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.button_home_Click);
            // 
            // lblEmpLoc
            // 
            this.lblEmpLoc.AutoSize = true;
            this.lblEmpLoc.BackColor = System.Drawing.Color.White;
            this.lblEmpLoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpLoc.Location = new System.Drawing.Point(79, 241);
            this.lblEmpLoc.Name = "lblEmpLoc";
            this.lblEmpLoc.Size = new System.Drawing.Size(104, 32);
            this.lblEmpLoc.TabIndex = 0;
            this.lblEmpLoc.Text = "Location";
            // 
            // txtEmpSSN
            // 
            this.txtEmpSSN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpSSN.Location = new System.Drawing.Point(384, 273);
            this.txtEmpSSN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmpSSN.MaxLength = 9;
            this.txtEmpSSN.Name = "txtEmpSSN";
            this.txtEmpSSN.ReadOnly = true;
            this.txtEmpSSN.Size = new System.Drawing.Size(338, 39);
            this.txtEmpSSN.TabIndex = 14;
            this.txtEmpSSN.Leave += new System.EventHandler(this.txtEmpSSN_Leave);
            // 
            // txtEmpSup
            // 
            this.txtEmpSup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpSup.Location = new System.Drawing.Point(384, 394);
            this.txtEmpSup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmpSup.Name = "txtEmpSup";
            this.txtEmpSup.ReadOnly = true;
            this.txtEmpSup.Size = new System.Drawing.Size(338, 39);
            this.txtEmpSup.TabIndex = 9;
            // 
            // txtEmpLname
            // 
            this.txtEmpLname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpLname.Location = new System.Drawing.Point(384, 154);
            this.txtEmpLname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmpLname.MaxLength = 20;
            this.txtEmpLname.Name = "txtEmpLname";
            this.txtEmpLname.ReadOnly = true;
            this.txtEmpLname.Size = new System.Drawing.Size(338, 39);
            this.txtEmpLname.TabIndex = 12;
            // 
            // txtEmpTitle
            // 
            this.txtEmpTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpTitle.Location = new System.Drawing.Point(83, 394);
            this.txtEmpTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmpTitle.Name = "txtEmpTitle";
            this.txtEmpTitle.ReadOnly = true;
            this.txtEmpTitle.Size = new System.Drawing.Size(338, 39);
            this.txtEmpTitle.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Social Security Number";
            // 
            // lblSelectEmployee
            // 
            this.lblSelectEmployee.AutoSize = true;
            this.lblSelectEmployee.BackColor = System.Drawing.Color.White;
            this.lblSelectEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectEmployee.Location = new System.Drawing.Point(233, 45);
            this.lblSelectEmployee.Name = "lblSelectEmployee";
            this.lblSelectEmployee.Size = new System.Drawing.Size(335, 45);
            this.lblSelectEmployee.TabIndex = 14;
            this.lblSelectEmployee.Text = "Employee Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supervisor ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Job Title";
            // 
            // txtHiddenID
            // 
            this.txtHiddenID.Enabled = false;
            this.txtHiddenID.Location = new System.Drawing.Point(396, 396);
            this.txtHiddenID.Name = "txtHiddenID";
            this.txtHiddenID.ReadOnly = true;
            this.txtHiddenID.Size = new System.Drawing.Size(100, 22);
            this.txtHiddenID.TabIndex = 52;
            this.txtHiddenID.Visible = false;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=ELISEORICOCE42;Initial Catalog=TestDatabase;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlConnection2
            // 
            this.sqlConnection2.ConnectionString = "Data Source=ELISEORICOCE42;Initial Catalog=TestDatabase;Integrated Security=True";
            this.sqlConnection2.FireInfoMessageEventOnUserErrors = false;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Employees";
            this.Size = new System.Drawing.Size(1038, 852);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEmpLoc;
        private System.Windows.Forms.TextBox txtEmpSSN;
        private System.Windows.Forms.TextBox txtEmpSup;
        private System.Windows.Forms.TextBox txtEmpLname;
        private System.Windows.Forms.TextBox txtEmpTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSelectEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSubmitCreate;
        private System.Windows.Forms.Button btnSubmitEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.Label lblEmpFname;
        private System.Windows.Forms.ComboBox cmbEmpFname;
        private System.Windows.Forms.TextBox txtEmpLoc;
        private System.Data.SqlClient.SqlConnection sqlConnection2;
        private System.Windows.Forms.TextBox txtEmpFname;
        private System.Windows.Forms.ComboBox cmbEmpLoc;
        private System.Windows.Forms.ComboBox cmbEmpTitle;
        private System.Windows.Forms.ComboBox cmbEmpSup;
        private System.Windows.Forms.CheckBox chkNewSuper;
        private System.Windows.Forms.TextBox txtHiddenID;
    }
}
