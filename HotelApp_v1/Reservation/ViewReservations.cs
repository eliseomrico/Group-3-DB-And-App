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
    public partial class ViewReservations : UserControl
    {
        public ViewReservations()
        {
            InitializeComponent();
        }

        private void button_manage_reservations_Click(object sender, EventArgs e)
        {
            reservationQueryForm1.Visible = true;
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            this.Visible = false;
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

        // Populates the datagridview with available rooms based on location and dates
        private void FillDataGrid()
        {
            int location_id = GetLocationID(cmbLocName.Text.Trim());
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            string sqlFormatStartDate = startDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string sqlFormatEndDate = endDate.ToString("yyyy-MM-dd HH:mm:ss.fff");

            sqlConnection1.Open();

            SqlCommand cmdGetRooms = sqlConnection1.CreateCommand();
            cmdGetRooms.CommandText = @"SELECT ROOM_NO, ROOM_TYPE
                                        FROM ROOM
                                        WHERE ROOM_NO NOT IN (SELECT RES_ROOM_NO
                                                              FROM RESERVATION
                                                              WHERE @search BETWEEN RES_START_DATE AND RES_END_DATE
                                                              AND @search1 BETWEEN RES_START_DATE AND RES_END_DATE)
                                        AND ROOM_LOC = @search2";

            cmdGetRooms.Parameters.AddWithValue("@search", sqlFormatStartDate);
            cmdGetRooms.Parameters.AddWithValue("@search1", sqlFormatEndDate);
            cmdGetRooms.Parameters.AddWithValue("@search2", location_id);

            SqlDataReader reader = cmdGetRooms.ExecuteReader();
            DataTable availableRooms = new DataTable();

            availableRooms.Load(reader);
            dgvRooms.DataSource = availableRooms;

            dgvRooms.Columns[0].HeaderText = "Room Number";
            dgvRooms.Columns[1].HeaderText = "Room Type";

            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            reader.Close();
            sqlConnection1.Close();
            cmdGetRooms.Dispose();
        }

        // Returns location ID from location name
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
                MessageBox.Show("Error fetching location ID", "Error Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConnection1.Close();
                reader.Close();
                return -1;
            }
        }

        // Fill location combo box when it is clicked on (on load would be better option)
        private void cmbLocName_Click(object sender, EventArgs e)
        {
            FillLocationsComboBox();
        }

        // "Search" button clicked
        private void button_search_Click(object sender, EventArgs e)
        {
            if(cmbLocName.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a location", "Informational Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FillDataGrid();
            }
        }

        // Set min and max dates dynamically based on user selections
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStartDate.Value;
            FillLocationsComboBox();
        }
        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            dtpStartDate.MaxDate = dtpEndDate.Value;
            FillLocationsComboBox();
        }
    }
}
