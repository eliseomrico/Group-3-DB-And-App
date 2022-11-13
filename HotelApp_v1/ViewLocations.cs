using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApp_v1
{
    public partial class ViewLocations : UserControl
    {
        public ViewLocations()
        {
            InitializeComponent();
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_manage_locations_Click(object sender, EventArgs e)
        {
            locations1.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int location_id = GetLocationID(cmbLocName.Text.Trim());

            sqlConnection1.Open();

            SqlCommand cmdGetRooms = sqlConnection1.CreateCommand();
            cmdGetRooms.CommandText = @"SELECT ROOM_NO, TYPE_DESCRIPTION, TYPE_PRICE
                                        FROM ROOM
                                           JOIN LOCATION ON LOC_ID = ROOM_LOC
                                           JOIN ROOM_TYPE ON TYPE_CODE = ROOM_TYPE
                                        WHERE LOC_ID = @search";
            cmdGetRooms.Parameters.AddWithValue("@search", location_id);

            SqlDataReader reader = cmdGetRooms.ExecuteReader();
            DataTable locationTable = new DataTable();
            locationTable.Load(reader);

            dgvRooms.DataSource = locationTable;
            dgvRooms.Columns[0].HeaderText = "Room Number";
            dgvRooms.Columns[1].HeaderText = "Room Description";
            dgvRooms.Columns[2].HeaderText = "Price/Night";

            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            reader.Close();
            sqlConnection1.Close();
            cmdGetRooms.Dispose();
        }

        // Populates location combo box with available locations
        private void FillLocationsComboBox()
        {
            cmbLocName.Items.Clear();

            sqlConnection1.Open();

            SqlCommand cmdGetLocations = sqlConnection1.CreateCommand();
            cmdGetLocations.CommandText = @"SELECT LOC_NAME
                                                   FROM LOCATION";
            SqlDataReader reader = cmdGetLocations.ExecuteReader();

            while (reader.Read())
            {
                cmbLocName.Items.Add(reader[0].ToString());
            }

            sqlConnection1.Close();
            reader.Close();
            cmdGetLocations.Dispose();
        }

        private int GetLocationID(string name)
        {
            sqlConnection1.Open();

            SqlCommand cmdGetSupName = sqlConnection1.CreateCommand();
            cmdGetSupName.CommandText = @"SELECT LOC_ID
                                          FROM LOCATION
                                          WHERE LOC_NAME = @search";

            cmdGetSupName.Parameters.AddWithValue("@search", name);
            SqlDataReader reader = cmdGetSupName.ExecuteReader();

            if (reader.Read())
            {
                int id = Convert.ToInt32(reader[0].ToString());
                sqlConnection1.Close();
                reader.Close();
                return id;
            }
            else
            {
                MessageBox.Show("Error fetching location ID");
                sqlConnection1.Close();
                reader.Close();
                return -1;
            }
        }

        private void cmbLocName_Click(object sender, EventArgs e)
        {
            FillLocationsComboBox();
        }
    }
}
