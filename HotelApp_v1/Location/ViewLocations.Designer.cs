namespace HotelApp_v1
{
    partial class ViewLocations
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
            this.locations1 = new HotelApp_v1.Locations();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnManageLocations = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.dataGridLocations = new System.Windows.Forms.DataGridView();
            this.lblLocName = new System.Windows.Forms.Label();
            this.lblRoomsHeader = new System.Windows.Forms.Label();
            this.textBox_location_name = new System.Windows.Forms.TextBox();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLocations)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.locations1);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnManageLocations);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Controls.Add(this.dataGridLocations);
            this.panel2.Controls.Add(this.lblLocName);
            this.panel2.Controls.Add(this.lblRoomsHeader);
            this.panel2.Controls.Add(this.textBox_location_name);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(519, 443);
            this.panel2.TabIndex = 25;
            // 
            // locations1
            // 
            this.locations1.Location = new System.Drawing.Point(0, 0);
            this.locations1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.locations1.Name = "locations1";
            this.locations1.Size = new System.Drawing.Size(519, 443);
            this.locations1.TabIndex = 28;
            this.locations1.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(360, 100);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 24);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnManageLocations
            // 
            this.btnManageLocations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnManageLocations.FlatAppearance.BorderSize = 0;
            this.btnManageLocations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageLocations.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageLocations.ForeColor = System.Drawing.Color.White;
            this.btnManageLocations.Location = new System.Drawing.Point(260, 407);
            this.btnManageLocations.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnManageLocations.Name = "btnManageLocations";
            this.btnManageLocations.Size = new System.Drawing.Size(260, 36);
            this.btnManageLocations.TabIndex = 26;
            this.btnManageLocations.Text = "Manage Locations";
            this.btnManageLocations.UseVisualStyleBackColor = false;
            this.btnManageLocations.Click += new System.EventHandler(this.button_manage_locations_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 407);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(260, 36);
            this.btnHome.TabIndex = 24;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.button_home_Click);
            // 
            // dataGridLocations
            // 
            this.dataGridLocations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLocations.Location = new System.Drawing.Point(0, 145);
            this.dataGridLocations.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridLocations.Name = "dataGridLocations";
            this.dataGridLocations.RowHeadersWidth = 51;
            this.dataGridLocations.RowTemplate.Height = 24;
            this.dataGridLocations.Size = new System.Drawing.Size(519, 264);
            this.dataGridLocations.TabIndex = 15;
            // 
            // lblLocName
            // 
            this.lblLocName.AutoSize = true;
            this.lblLocName.BackColor = System.Drawing.Color.White;
            this.lblLocName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocName.Location = new System.Drawing.Point(85, 103);
            this.lblLocName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocName.Name = "lblLocName";
            this.lblLocName.Size = new System.Drawing.Size(91, 15);
            this.lblLocName.TabIndex = 0;
            this.lblLocName.Text = "Location Name:";
            // 
            // lblRoomsHeader
            // 
            this.lblRoomsHeader.AutoSize = true;
            this.lblRoomsHeader.BackColor = System.Drawing.Color.White;
            this.lblRoomsHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomsHeader.Location = new System.Drawing.Point(62, 31);
            this.lblRoomsHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomsHeader.Name = "lblRoomsHeader";
            this.lblRoomsHeader.Size = new System.Drawing.Size(392, 21);
            this.lblRoomsHeader.TabIndex = 14;
            this.lblRoomsHeader.Text = "Choose desired location to view rooms and room types";
            // 
            // textBox_location_name
            // 
            this.textBox_location_name.Location = new System.Drawing.Point(191, 107);
            this.textBox_location_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_location_name.Name = "textBox_location_name";
            this.textBox_location_name.Size = new System.Drawing.Size(152, 20);
            this.textBox_location_name.TabIndex = 31;
            this.textBox_location_name.TextChanged += new System.EventHandler(this.textBox_location_name_TextChanged);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=ELISEORICOCE42;Initial Catalog=TestDatabase;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // ViewLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ViewLocations";
            this.Size = new System.Drawing.Size(519, 443);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLocations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnManageLocations;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridView dataGridLocations;
        private System.Windows.Forms.Label lblLocName;
        private System.Windows.Forms.Label lblRoomsHeader;
        private Locations locations1;
        private System.Windows.Forms.Button btnSearch;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.TextBox textBox_location_name;
    }
}
