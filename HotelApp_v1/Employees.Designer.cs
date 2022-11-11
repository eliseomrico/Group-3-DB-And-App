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
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbEmpFname = new System.Windows.Forms.ComboBox();
            this.lblEmpFname = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_submit_edit = new System.Windows.Forms.Button();
            this.button_submit_create = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_create = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpSSN = new System.Windows.Forms.TextBox();
            this.txtSupID = new System.Windows.Forms.TextBox();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.txtEmpLname = new System.Windows.Forms.TextBox();
            this.txtEmpTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSelectEmployee = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSearchFname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtEmpID);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.cmbEmpFname);
            this.panel2.Controls.Add(this.lblEmpFname);
            this.panel2.Controls.Add(this.button_cancel);
            this.panel2.Controls.Add(this.button_submit_edit);
            this.panel2.Controls.Add(this.button_submit_create);
            this.panel2.Controls.Add(this.button_search);
            this.panel2.Controls.Add(this.button_delete);
            this.panel2.Controls.Add(this.button_edit);
            this.panel2.Controls.Add(this.button_create);
            this.panel2.Controls.Add(this.button_home);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtEmpSSN);
            this.panel2.Controls.Add(this.txtSupID);
            this.panel2.Controls.Add(this.txtSearchBox);
            this.panel2.Controls.Add(this.txtEmpLname);
            this.panel2.Controls.Add(this.txtEmpTitle);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblSelectEmployee);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblSearchFname);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 545);
            this.panel2.TabIndex = 23;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(83, 305);
            this.txtEmpID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.ReadOnly = true;
            this.txtEmpID.Size = new System.Drawing.Size(227, 27);
            this.txtEmpID.TabIndex = 49;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(466, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 25);
            this.btnSearch.TabIndex = 48;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSearch_MouseClick);
            // 
            // cmbEmpFname
            // 
            this.cmbEmpFname.BackColor = System.Drawing.Color.White;
            this.cmbEmpFname.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbEmpFname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpFname.FormattingEnabled = true;
            this.cmbEmpFname.Location = new System.Drawing.Point(83, 216);
            this.cmbEmpFname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEmpFname.Name = "cmbEmpFname";
            this.cmbEmpFname.Size = new System.Drawing.Size(227, 28);
            this.cmbEmpFname.TabIndex = 47;
            this.cmbEmpFname.SelectedIndexChanged += new System.EventHandler(this.cmbEmpFname_SelectedIndexChanged);
            // 
            // lblEmpFname
            // 
            this.lblEmpFname.AutoSize = true;
            this.lblEmpFname.BackColor = System.Drawing.Color.White;
            this.lblEmpFname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpFname.Location = new System.Drawing.Point(79, 184);
            this.lblEmpFname.Name = "lblEmpFname";
            this.lblEmpFname.Size = new System.Drawing.Size(80, 20);
            this.lblEmpFname.TabIndex = 46;
            this.lblEmpFname.Text = "First Name";
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_cancel.Enabled = false;
            this.button_cancel.FlatAppearance.BorderSize = 0;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.ForeColor = System.Drawing.Color.White;
            this.button_cancel.Location = new System.Drawing.Point(553, 501);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(139, 44);
            this.button_cancel.TabIndex = 45;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Visible = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_submit_edit
            // 
            this.button_submit_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_submit_edit.Enabled = false;
            this.button_submit_edit.FlatAppearance.BorderSize = 0;
            this.button_submit_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_submit_edit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit_edit.ForeColor = System.Drawing.Color.White;
            this.button_submit_edit.Location = new System.Drawing.Point(415, 501);
            this.button_submit_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_submit_edit.Name = "button_submit_edit";
            this.button_submit_edit.Size = new System.Drawing.Size(139, 44);
            this.button_submit_edit.TabIndex = 44;
            this.button_submit_edit.Text = "Submit Edit";
            this.button_submit_edit.UseVisualStyleBackColor = false;
            this.button_submit_edit.Visible = false;
            this.button_submit_edit.Click += new System.EventHandler(this.button_submit_edit_Click);
            // 
            // button_submit_create
            // 
            this.button_submit_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_submit_create.Enabled = false;
            this.button_submit_create.FlatAppearance.BorderSize = 0;
            this.button_submit_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_submit_create.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit_create.ForeColor = System.Drawing.Color.White;
            this.button_submit_create.Location = new System.Drawing.Point(276, 501);
            this.button_submit_create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_submit_create.Name = "button_submit_create";
            this.button_submit_create.Size = new System.Drawing.Size(139, 44);
            this.button_submit_create.TabIndex = 43;
            this.button_submit_create.Text = "Submit Create";
            this.button_submit_create.UseVisualStyleBackColor = false;
            this.button_submit_create.Visible = false;
            this.button_submit_create.Click += new System.EventHandler(this.button_submit_create_Click);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_search.FlatAppearance.BorderSize = 0;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(139, 501);
            this.button_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(139, 44);
            this.button_search.TabIndex = 32;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_delete.Enabled = false;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(553, 501);
            this.button_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(139, 44);
            this.button_delete.TabIndex = 31;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_edit.Enabled = false;
            this.button_edit.FlatAppearance.BorderSize = 0;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.ForeColor = System.Drawing.Color.White;
            this.button_edit.Location = new System.Drawing.Point(415, 501);
            this.button_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(139, 44);
            this.button_edit.TabIndex = 30;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_create
            // 
            this.button_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_create.Enabled = false;
            this.button_create.FlatAppearance.BorderSize = 0;
            this.button_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_create.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_create.ForeColor = System.Drawing.Color.White;
            this.button_create.Location = new System.Drawing.Point(276, 501);
            this.button_create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(139, 44);
            this.button_create.TabIndex = 29;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = false;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // button_home
            // 
            this.button_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_home.ForeColor = System.Drawing.Color.White;
            this.button_home.Location = new System.Drawing.Point(0, 501);
            this.button_home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(139, 44);
            this.button_home.TabIndex = 28;
            this.button_home.Text = "Home";
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // txtEmpSSN
            // 
            this.txtEmpSSN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpSSN.Location = new System.Drawing.Point(384, 305);
            this.txtEmpSSN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmpSSN.Name = "txtEmpSSN";
            this.txtEmpSSN.ReadOnly = true;
            this.txtEmpSSN.Size = new System.Drawing.Size(227, 27);
            this.txtEmpSSN.TabIndex = 8;
            // 
            // txtSupID
            // 
            this.txtSupID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupID.Location = new System.Drawing.Point(384, 399);
            this.txtSupID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSupID.Name = "txtSupID";
            this.txtSupID.ReadOnly = true;
            this.txtSupID.Size = new System.Drawing.Size(227, 27);
            this.txtSupID.TabIndex = 9;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.Location = new System.Drawing.Point(229, 99);
            this.txtSearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(227, 27);
            this.txtSearchBox.TabIndex = 10;
            // 
            // txtEmpLname
            // 
            this.txtEmpLname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpLname.Location = new System.Drawing.Point(384, 216);
            this.txtEmpLname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmpLname.Name = "txtEmpLname";
            this.txtEmpLname.ReadOnly = true;
            this.txtEmpLname.Size = new System.Drawing.Size(227, 27);
            this.txtEmpLname.TabIndex = 11;
            // 
            // txtEmpTitle
            // 
            this.txtEmpTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpTitle.Location = new System.Drawing.Point(83, 399);
            this.txtEmpTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmpTitle.Name = "txtEmpTitle";
            this.txtEmpTitle.ReadOnly = true;
            this.txtEmpTitle.Size = new System.Drawing.Size(227, 27);
            this.txtEmpTitle.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Social Security Number";
            // 
            // lblSelectEmployee
            // 
            this.lblSelectEmployee.AutoSize = true;
            this.lblSelectEmployee.BackColor = System.Drawing.Color.White;
            this.lblSelectEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectEmployee.Location = new System.Drawing.Point(233, 20);
            this.lblSelectEmployee.Name = "lblSelectEmployee";
            this.lblSelectEmployee.Size = new System.Drawing.Size(223, 28);
            this.lblSelectEmployee.TabIndex = 14;
            this.lblSelectEmployee.Text = "Employee Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supervisor ID";
            // 
            // lblSearchFname
            // 
            this.lblSearchFname.AutoSize = true;
            this.lblSearchFname.BackColor = System.Drawing.Color.White;
            this.lblSearchFname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchFname.Location = new System.Drawing.Point(103, 105);
            this.lblSearchFname.Name = "lblSearchFname";
            this.lblSearchFname.Size = new System.Drawing.Size(120, 20);
            this.lblSearchFname.TabIndex = 4;
            this.lblSearchFname.Text = "Search by Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Job Title";
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=ESCO-PC\\SQLEXPRESS01;Initial Catalog=HOTEL_TEST;Integrated Security=T" +
    "rue";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Employees";
            this.Size = new System.Drawing.Size(692, 545);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpSSN;
        private System.Windows.Forms.TextBox txtSupID;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.TextBox txtEmpLname;
        private System.Windows.Forms.TextBox txtEmpTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSelectEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSearchFname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Button button_submit_create;
        private System.Windows.Forms.Button button_submit_edit;
        private System.Windows.Forms.Button button_cancel;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.Label lblEmpFname;
        private System.Windows.Forms.ComboBox cmbEmpFname;
        private System.Windows.Forms.Button btnSearch;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.TextBox txtEmpID;
    }
}
