namespace HotelApp_v1
{
    partial class RoomAvailability
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
            this.button_manage_rooms = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.comboBox_location_name = new System.Windows.Forms.ComboBox();
            this.dataGridView_room = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlConnection2 = new System.Data.SqlClient.SqlConnection();
            this.rooms1 = new HotelApp_v1.Rooms();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_room)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.rooms1);
            this.panel2.Controls.Add(this.button_manage_rooms);
            this.panel2.Controls.Add(this.button_home);
            this.panel2.Controls.Add(this.comboBox_location_name);
            this.panel2.Controls.Add(this.dataGridView_room);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(519, 443);
            this.panel2.TabIndex = 23;
            // 
            // button_manage_rooms
            // 
            this.button_manage_rooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.button_manage_rooms.FlatAppearance.BorderSize = 0;
            this.button_manage_rooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_manage_rooms.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_manage_rooms.ForeColor = System.Drawing.Color.White;
            this.button_manage_rooms.Location = new System.Drawing.Point(260, 407);
            this.button_manage_rooms.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_manage_rooms.Name = "button_manage_rooms";
            this.button_manage_rooms.Size = new System.Drawing.Size(260, 36);
            this.button_manage_rooms.TabIndex = 26;
            this.button_manage_rooms.Text = "Manage Rooms";
            this.button_manage_rooms.UseVisualStyleBackColor = false;
            this.button_manage_rooms.Click += new System.EventHandler(this.button_manage_rooms_Click);
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
            this.button_home.Size = new System.Drawing.Size(260, 36);
            this.button_home.TabIndex = 24;
            this.button_home.Text = "Home";
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // comboBox_location_name
            // 
            this.comboBox_location_name.BackColor = System.Drawing.Color.White;
            this.comboBox_location_name.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_location_name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_location_name.FormattingEnabled = true;
            this.comboBox_location_name.Location = new System.Drawing.Point(249, 101);
            this.comboBox_location_name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox_location_name.Name = "comboBox_location_name";
            this.comboBox_location_name.Size = new System.Drawing.Size(157, 23);
            this.comboBox_location_name.TabIndex = 16;
            // 
            // dataGridView_room
            // 
            this.dataGridView_room.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_room.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_room.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_room.Location = new System.Drawing.Point(0, 145);
            this.dataGridView_room.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView_room.Name = "dataGridView_room";
            this.dataGridView_room.RowHeadersWidth = 51;
            this.dataGridView_room.RowTemplate.Height = 24;
            this.dataGridView_room.Size = new System.Drawing.Size(519, 264);
            this.dataGridView_room.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(73, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(392, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Choose desired location to view rooms and room types";
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
            // rooms1
            // 
            this.rooms1.Location = new System.Drawing.Point(1, 0);
            this.rooms1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rooms1.Name = "rooms1";
            this.rooms1.Size = new System.Drawing.Size(519, 443);
            this.rooms1.TabIndex = 27;
            this.rooms1.Visible = false;
            // 
            // RoomAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "RoomAvailability";
            this.Size = new System.Drawing.Size(519, 443);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_room)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox_location_name;
        private System.Windows.Forms.DataGridView dataGridView_room;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Button button_manage_rooms;
        private Rooms rooms1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlConnection sqlConnection2;
    }
}
