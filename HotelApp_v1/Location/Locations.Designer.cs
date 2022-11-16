namespace HotelApp_v1
{
    partial class Locations
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
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_loc_address = new System.Windows.Forms.TextBox();
            this.textBox_loc_close_time = new System.Windows.Forms.TextBox();
            this.textBox_loc_open_time = new System.Windows.Forms.TextBox();
            this.textBox_loc_phone_num = new System.Windows.Forms.TextBox();
            this.textBox_loc_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_loc_id = new System.Windows.Forms.ComboBox();
            this.button_home = new System.Windows.Forms.Button();
            this.button_create = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_submit_create = new System.Windows.Forms.Button();
            this.button_submit_edit = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_loc_id = new System.Windows.Forms.TextBox();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.comboBox_loc_super_id = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 299);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Location Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 237);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Location Supervisor ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 237);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Location Close Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(290, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Location Open Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location Phone Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(79, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(289, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Enter Location ID and click Search below";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location Name";
            // 
            // textBox_loc_address
            // 
            this.textBox_loc_address.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_loc_address.Location = new System.Drawing.Point(61, 325);
            this.textBox_loc_address.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_loc_address.Name = "textBox_loc_address";
            this.textBox_loc_address.ReadOnly = true;
            this.textBox_loc_address.Size = new System.Drawing.Size(234, 23);
            this.textBox_loc_address.TabIndex = 7;
            // 
            // textBox_loc_close_time
            // 
            this.textBox_loc_close_time.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_loc_close_time.Location = new System.Drawing.Point(293, 263);
            this.textBox_loc_close_time.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_loc_close_time.Name = "textBox_loc_close_time";
            this.textBox_loc_close_time.ReadOnly = true;
            this.textBox_loc_close_time.Size = new System.Drawing.Size(171, 23);
            this.textBox_loc_close_time.TabIndex = 6;
            // 
            // textBox_loc_open_time
            // 
            this.textBox_loc_open_time.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_loc_open_time.Location = new System.Drawing.Point(293, 197);
            this.textBox_loc_open_time.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_loc_open_time.Name = "textBox_loc_open_time";
            this.textBox_loc_open_time.ReadOnly = true;
            this.textBox_loc_open_time.Size = new System.Drawing.Size(171, 23);
            this.textBox_loc_open_time.TabIndex = 4;
            // 
            // textBox_loc_phone_num
            // 
            this.textBox_loc_phone_num.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_loc_phone_num.Location = new System.Drawing.Point(61, 197);
            this.textBox_loc_phone_num.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_loc_phone_num.Name = "textBox_loc_phone_num";
            this.textBox_loc_phone_num.ReadOnly = true;
            this.textBox_loc_phone_num.Size = new System.Drawing.Size(171, 23);
            this.textBox_loc_phone_num.TabIndex = 3;
            // 
            // textBox_loc_name
            // 
            this.textBox_loc_name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_loc_name.Location = new System.Drawing.Point(293, 125);
            this.textBox_loc_name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_loc_name.Name = "textBox_loc_name";
            this.textBox_loc_name.ReadOnly = true;
            this.textBox_loc_name.Size = new System.Drawing.Size(171, 23);
            this.textBox_loc_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location ID";
            // 
            // comboBox_loc_id
            // 
            this.comboBox_loc_id.BackColor = System.Drawing.Color.White;
            this.comboBox_loc_id.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_loc_id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_loc_id.FormattingEnabled = true;
            this.comboBox_loc_id.Location = new System.Drawing.Point(61, 125);
            this.comboBox_loc_id.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox_loc_id.Name = "comboBox_loc_id";
            this.comboBox_loc_id.Size = new System.Drawing.Size(171, 23);
            this.comboBox_loc_id.TabIndex = 16;
            this.comboBox_loc_id.SelectedIndexChanged += new System.EventHandler(this.comboBox_loc_id_SelectedIndexChanged);
            // 
            // button_home
            // 
            this.button_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_home.ForeColor = System.Drawing.Color.White;
            this.button_home.Location = new System.Drawing.Point(0, 407);
            this.button_home.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(104, 36);
            this.button_home.TabIndex = 37;
            this.button_home.Text = "Back";
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // button_create
            // 
            this.button_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_create.FlatAppearance.BorderSize = 0;
            this.button_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_create.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_create.ForeColor = System.Drawing.Color.White;
            this.button_create.Location = new System.Drawing.Point(103, 407);
            this.button_create.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(142, 36);
            this.button_create.TabIndex = 38;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = false;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_edit.Enabled = false;
            this.button_edit.FlatAppearance.BorderSize = 0;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.ForeColor = System.Drawing.Color.White;
            this.button_edit.Location = new System.Drawing.Point(317, 407);
            this.button_edit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(104, 36);
            this.button_edit.TabIndex = 39;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_delete.Enabled = false;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(415, 407);
            this.button_delete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(104, 36);
            this.button_delete.TabIndex = 40;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_submit_create
            // 
            this.button_submit_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_submit_create.Enabled = false;
            this.button_submit_create.FlatAppearance.BorderSize = 0;
            this.button_submit_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_submit_create.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit_create.ForeColor = System.Drawing.Color.White;
            this.button_submit_create.Location = new System.Drawing.Point(103, 407);
            this.button_submit_create.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_submit_create.Name = "button_submit_create";
            this.button_submit_create.Size = new System.Drawing.Size(142, 36);
            this.button_submit_create.TabIndex = 42;
            this.button_submit_create.Text = "Submit Create";
            this.button_submit_create.UseVisualStyleBackColor = false;
            this.button_submit_create.Visible = false;
            this.button_submit_create.Click += new System.EventHandler(this.button_submit_create_Click);
            // 
            // button_submit_edit
            // 
            this.button_submit_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_submit_edit.Enabled = false;
            this.button_submit_edit.FlatAppearance.BorderSize = 0;
            this.button_submit_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_submit_edit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit_edit.ForeColor = System.Drawing.Color.White;
            this.button_submit_edit.Location = new System.Drawing.Point(317, 407);
            this.button_submit_edit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_submit_edit.Name = "button_submit_edit";
            this.button_submit_edit.Size = new System.Drawing.Size(104, 36);
            this.button_submit_edit.TabIndex = 43;
            this.button_submit_edit.Text = "Submit Edit";
            this.button_submit_edit.UseVisualStyleBackColor = false;
            this.button_submit_edit.Visible = false;
            this.button_submit_edit.Click += new System.EventHandler(this.button_submit_edit_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_cancel.Enabled = false;
            this.button_cancel.FlatAppearance.BorderSize = 0;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.ForeColor = System.Drawing.Color.White;
            this.button_cancel.Location = new System.Drawing.Point(243, 407);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(79, 36);
            this.button_cancel.TabIndex = 44;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.comboBox_loc_super_id);
            this.panel2.Controls.Add(this.textBox_loc_id);
            this.panel2.Controls.Add(this.button_cancel);
            this.panel2.Controls.Add(this.button_submit_edit);
            this.panel2.Controls.Add(this.button_submit_create);
            this.panel2.Controls.Add(this.button_delete);
            this.panel2.Controls.Add(this.button_edit);
            this.panel2.Controls.Add(this.button_create);
            this.panel2.Controls.Add(this.button_home);
            this.panel2.Controls.Add(this.comboBox_loc_id);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox_loc_name);
            this.panel2.Controls.Add(this.textBox_loc_phone_num);
            this.panel2.Controls.Add(this.textBox_loc_open_time);
            this.panel2.Controls.Add(this.textBox_loc_close_time);
            this.panel2.Controls.Add(this.textBox_loc_address);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(519, 443);
            this.panel2.TabIndex = 23;
            // 
            // textBox_loc_id
            // 
            this.textBox_loc_id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_loc_id.Location = new System.Drawing.Point(61, 126);
            this.textBox_loc_id.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_loc_id.Name = "textBox_loc_id";
            this.textBox_loc_id.ReadOnly = true;
            this.textBox_loc_id.Size = new System.Drawing.Size(171, 23);
            this.textBox_loc_id.TabIndex = 1;
            this.textBox_loc_id.Visible = false;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=ELISEORICOCE42;Initial Catalog=TestDatabase;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // comboBox_loc_super_id
            // 
            this.comboBox_loc_super_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_loc_super_id.Enabled = false;
            this.comboBox_loc_super_id.FormattingEnabled = true;
            this.comboBox_loc_super_id.Location = new System.Drawing.Point(61, 265);
            this.comboBox_loc_super_id.Name = "comboBox_loc_super_id";
            this.comboBox_loc_super_id.Size = new System.Drawing.Size(171, 21);
            this.comboBox_loc_super_id.TabIndex = 45;
            // 
            // Locations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Locations";
            this.Size = new System.Drawing.Size(519, 443);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_loc_address;
        private System.Windows.Forms.TextBox textBox_loc_close_time;
        private System.Windows.Forms.TextBox textBox_loc_open_time;
        private System.Windows.Forms.TextBox textBox_loc_phone_num;
        private System.Windows.Forms.TextBox textBox_loc_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_loc_id;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_submit_create;
        private System.Windows.Forms.Button button_submit_edit;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Panel panel2;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.TextBox textBox_loc_id;
        private System.Windows.Forms.ComboBox comboBox_loc_super_id;
    }
}
