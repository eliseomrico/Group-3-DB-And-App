namespace HotelApp_v1
{
    partial class CustomerQueryForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_cust_id = new System.Windows.Forms.ComboBox();
            this.textBox_cust_balance = new System.Windows.Forms.TextBox();
            this.textBox_cc_part1 = new System.Windows.Forms.TextBox();
            this.textBox_cust_phone = new System.Windows.Forms.TextBox();
            this.textBox_cust_lname = new System.Windows.Forms.TextBox();
            this.textBox_cust_fname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_cc_part4 = new System.Windows.Forms.TextBox();
            this.textBox_cc_part3 = new System.Windows.Forms.TextBox();
            this.textBox_cc_part2 = new System.Windows.Forms.TextBox();
            this.textBox_cust_id = new System.Windows.Forms.TextBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_submit_edit = new System.Windows.Forms.Button();
            this.button_submit_create = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_create = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(232, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(611, 45);
            this.label7.TabIndex = 31;
            this.label7.Text = "Enter Customer ID and click Search below";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Customer ID";
            // 
            // comboBox_cust_id
            // 
            this.comboBox_cust_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_cust_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_cust_id.BackColor = System.Drawing.Color.White;
            this.comboBox_cust_id.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_cust_id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_cust_id.FormattingEnabled = true;
            this.comboBox_cust_id.Location = new System.Drawing.Point(62, 238);
            this.comboBox_cust_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_cust_id.Name = "comboBox_cust_id";
            this.comboBox_cust_id.Size = new System.Drawing.Size(338, 40);
            this.comboBox_cust_id.TabIndex = 16;
            this.comboBox_cust_id.SelectedIndexChanged += new System.EventHandler(this.comboBox_cust_id_SelectedIndexChanged);
            // 
            // textBox_cust_balance
            // 
            this.textBox_cust_balance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cust_balance.Location = new System.Drawing.Point(622, 659);
            this.textBox_cust_balance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_cust_balance.Name = "textBox_cust_balance";
            this.textBox_cust_balance.ReadOnly = true;
            this.textBox_cust_balance.Size = new System.Drawing.Size(338, 39);
            this.textBox_cust_balance.TabIndex = 9;
            // 
            // textBox_cc_part1
            // 
            this.textBox_cc_part1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cc_part1.Location = new System.Drawing.Point(62, 659);
            this.textBox_cc_part1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_cc_part1.Name = "textBox_cc_part1";
            this.textBox_cc_part1.ReadOnly = true;
            this.textBox_cc_part1.Size = new System.Drawing.Size(68, 39);
            this.textBox_cc_part1.TabIndex = 5;
            this.textBox_cc_part1.TextChanged += new System.EventHandler(this.textBox_cc_part1_TextChanged);
            // 
            // textBox_cust_phone
            // 
            this.textBox_cust_phone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cust_phone.Location = new System.Drawing.Point(62, 512);
            this.textBox_cust_phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_cust_phone.Name = "textBox_cust_phone";
            this.textBox_cust_phone.ReadOnly = true;
            this.textBox_cust_phone.Size = new System.Drawing.Size(338, 39);
            this.textBox_cust_phone.TabIndex = 4;
            // 
            // textBox_cust_lname
            // 
            this.textBox_cust_lname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cust_lname.Location = new System.Drawing.Point(622, 362);
            this.textBox_cust_lname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_cust_lname.Name = "textBox_cust_lname";
            this.textBox_cust_lname.ReadOnly = true;
            this.textBox_cust_lname.Size = new System.Drawing.Size(338, 39);
            this.textBox_cust_lname.TabIndex = 3;
            // 
            // textBox_cust_fname
            // 
            this.textBox_cust_fname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cust_fname.Location = new System.Drawing.Point(62, 362);
            this.textBox_cust_fname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_cust_fname.Name = "textBox_cust_fname";
            this.textBox_cust_fname.ReadOnly = true;
            this.textBox_cust_fname.Size = new System.Drawing.Size(338, 39);
            this.textBox_cust_fname.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 609);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(339, 32);
            this.label6.TabIndex = 25;
            this.label6.Text = "Customer Credit Card Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(618, 609);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 32);
            this.label5.TabIndex = 24;
            this.label5.Text = "Customer Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 458);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 32);
            this.label4.TabIndex = 23;
            this.label4.Text = "Customer Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(618, 309);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 32);
            this.label3.TabIndex = 22;
            this.label3.Text = "Customer Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 309);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "Customer First Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.textBox_cc_part4);
            this.panel2.Controls.Add(this.textBox_cc_part3);
            this.panel2.Controls.Add(this.textBox_cc_part2);
            this.panel2.Controls.Add(this.textBox_cust_id);
            this.panel2.Controls.Add(this.button_cancel);
            this.panel2.Controls.Add(this.button_submit_edit);
            this.panel2.Controls.Add(this.button_submit_create);
            this.panel2.Controls.Add(this.button_delete);
            this.panel2.Controls.Add(this.button_edit);
            this.panel2.Controls.Add(this.button_create);
            this.panel2.Controls.Add(this.button_home);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.comboBox_cust_id);
            this.panel2.Controls.Add(this.textBox_cust_balance);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox_cc_part1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBox_cust_phone);
            this.panel2.Controls.Add(this.textBox_cust_fname);
            this.panel2.Controls.Add(this.textBox_cust_lname);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 852);
            this.panel2.TabIndex = 32;
            // 
            // textBox_cc_part4
            // 
            this.textBox_cc_part4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cc_part4.Location = new System.Drawing.Point(372, 659);
            this.textBox_cc_part4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_cc_part4.Name = "textBox_cc_part4";
            this.textBox_cc_part4.ReadOnly = true;
            this.textBox_cc_part4.Size = new System.Drawing.Size(68, 39);
            this.textBox_cc_part4.TabIndex = 8;
            this.textBox_cc_part4.TextChanged += new System.EventHandler(this.textBox_cc_part4_TextChanged);
            // 
            // textBox_cc_part3
            // 
            this.textBox_cc_part3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cc_part3.Location = new System.Drawing.Point(270, 659);
            this.textBox_cc_part3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_cc_part3.Name = "textBox_cc_part3";
            this.textBox_cc_part3.ReadOnly = true;
            this.textBox_cc_part3.Size = new System.Drawing.Size(68, 39);
            this.textBox_cc_part3.TabIndex = 7;
            this.textBox_cc_part3.TextChanged += new System.EventHandler(this.textBox_cc_part3_TextChanged);
            // 
            // textBox_cc_part2
            // 
            this.textBox_cc_part2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cc_part2.Location = new System.Drawing.Point(164, 659);
            this.textBox_cc_part2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_cc_part2.Name = "textBox_cc_part2";
            this.textBox_cc_part2.ReadOnly = true;
            this.textBox_cc_part2.Size = new System.Drawing.Size(68, 39);
            this.textBox_cc_part2.TabIndex = 6;
            this.textBox_cc_part2.TextChanged += new System.EventHandler(this.textBox_cc_part2_TextChanged);
            // 
            // textBox_cust_id
            // 
            this.textBox_cust_id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cust_id.Location = new System.Drawing.Point(62, 238);
            this.textBox_cust_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_cust_id.Name = "textBox_cust_id";
            this.textBox_cust_id.ReadOnly = true;
            this.textBox_cust_id.Size = new System.Drawing.Size(338, 39);
            this.textBox_cust_id.TabIndex = 1;
            this.textBox_cust_id.Visible = false;
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_cancel.Enabled = false;
            this.button_cancel.FlatAppearance.BorderSize = 0;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.ForeColor = System.Drawing.Color.White;
            this.button_cancel.Location = new System.Drawing.Point(494, 783);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(208, 69);
            this.button_cancel.TabIndex = 39;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
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
            this.button_submit_edit.Location = new System.Drawing.Point(696, 783);
            this.button_submit_edit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_submit_edit.Name = "button_submit_edit";
            this.button_submit_edit.Size = new System.Drawing.Size(208, 69);
            this.button_submit_edit.TabIndex = 38;
            this.button_submit_edit.Text = "Submit Edit";
            this.button_submit_edit.UseVisualStyleBackColor = false;
            this.button_submit_edit.Visible = false;
            this.button_submit_edit.Click += new System.EventHandler(this.button_submit_edit_Click);
            // 
            // button_submit_create
            // 
            this.button_submit_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_submit_create.FlatAppearance.BorderSize = 0;
            this.button_submit_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_submit_create.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit_create.ForeColor = System.Drawing.Color.White;
            this.button_submit_create.Location = new System.Drawing.Point(316, 783);
            this.button_submit_create.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_submit_create.Name = "button_submit_create";
            this.button_submit_create.Size = new System.Drawing.Size(183, 69);
            this.button_submit_create.TabIndex = 37;
            this.button_submit_create.Text = "Submit Create";
            this.button_submit_create.UseVisualStyleBackColor = false;
            this.button_submit_create.Visible = false;
            this.button_submit_create.Click += new System.EventHandler(this.button_submit_create_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_delete.Enabled = false;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(898, 783);
            this.button_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(140, 69);
            this.button_delete.TabIndex = 35;
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
            this.button_edit.Location = new System.Drawing.Point(696, 783);
            this.button_edit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(208, 69);
            this.button_edit.TabIndex = 34;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_create
            // 
            this.button_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_create.FlatAppearance.BorderSize = 0;
            this.button_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_create.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_create.ForeColor = System.Drawing.Color.White;
            this.button_create.Location = new System.Drawing.Point(316, 783);
            this.button_create.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(183, 69);
            this.button_create.TabIndex = 33;
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
            this.button_home.Location = new System.Drawing.Point(0, 783);
            this.button_home.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(320, 69);
            this.button_home.TabIndex = 32;
            this.button_home.Text = "Back";
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=ELISEORICOCE42;Initial Catalog=TestDatabase;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // CustomerQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomerQueryForm";
            this.Size = new System.Drawing.Size(1038, 852);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_cust_id;
        private System.Windows.Forms.TextBox textBox_cust_balance;
        private System.Windows.Forms.TextBox textBox_cc_part1;
        private System.Windows.Forms.TextBox textBox_cust_phone;
        private System.Windows.Forms.TextBox textBox_cust_lname;
        private System.Windows.Forms.TextBox textBox_cust_fname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Button button_submit_edit;
        private System.Windows.Forms.Button button_submit_create;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox textBox_cust_id;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.TextBox textBox_cc_part4;
        private System.Windows.Forms.TextBox textBox_cc_part3;
        private System.Windows.Forms.TextBox textBox_cc_part2;
    }
}
