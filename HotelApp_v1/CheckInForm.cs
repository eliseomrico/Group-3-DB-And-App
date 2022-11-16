using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApp_v1
{
    public partial class CheckInForm : UserControl
    {
        public CheckInForm()
        {
            InitializeComponent();
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        // Check In Customer
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsValidCheckIn()) 
            {
                MarkRoomUnavailable();
                MessageBox.Show("You have been successfully checked in for your stay");
                cmbCustName.SelectedIndex = -1;
                txtResID.Text = "";
                txtSecCode.Text = "";
            }
            else
            {
                MessageBox.Show("Reservation under this name not found");
            }
        }

        private void btnResSearch_Click(object sender, EventArgs e)
        {
            reservationQueryForm1.Visible = true;
        }

        // Check if reservation is valid and check in is today
        private bool IsValidCheckIn()
        {
            sqlConnection1.Open();

            string custLname = cmbCustName.Text.ToString().Trim();
            int resID = Convert.ToInt32(txtResID.Text);
            int secCode = Convert.ToInt32(txtSecCode.Text);

            // Check the reservation exists and check in is today
            SqlCommand cmdValidCheckIn = sqlConnection1.CreateCommand();
            cmdValidCheckIn.CommandText = @"SELECT CUST_FNAME, CUST_LNAME
                                            FROM CUSTOMER
                                                JOIN RESERVATION ON RES_CUST_ID = CUST_ID
                                                JOIN CREDIT_CARD ON CREDIT_CARD_NO = CUST_CREDIT_CARD_NO
                                            WHERE RES_NO = @search1
                                            AND CUST_LNAME = @search2
                                            AND CREDIT_SEC_CODE = @search3";
            cmdValidCheckIn.Parameters.AddWithValue("@search1", resID);
            cmdValidCheckIn.Parameters.AddWithValue("@search2", custLname);
            cmdValidCheckIn.Parameters.AddWithValue("@search3", secCode);

            SqlDataReader reader = cmdValidCheckIn.ExecuteReader();

            if (reader.Read())
            {
                sqlConnection1.Close();
                reader.Close();
                cmdValidCheckIn.Dispose();

                return true; ;
            }
            else
            {
                sqlConnection1.Close();
                reader.Close();
                cmdValidCheckIn.Dispose();

                return false;
            }
        }

        // Mark room as unavailable
        private void MarkRoomUnavailable()
        {
            string[] roomLoc = GetResRoomAndLoc().Split(' ');
            
            sqlConnection1.Open();

            SqlCommand cmdRoomUnavailable = sqlConnection1.CreateCommand();
            cmdRoomUnavailable.CommandText = @"UPDATE ROOM
                                               SET ROOM_AVAILABLE = 'N'
                                               WHERE ROOM_NO = @search1
                                               AND ROOM_LOC = @search2";
            cmdRoomUnavailable.Parameters.AddWithValue("@search1", roomLoc[0]);
            cmdRoomUnavailable.Parameters.AddWithValue("@search2", roomLoc[1]);

            cmdRoomUnavailable.ExecuteNonQuery();

            sqlConnection1.Close();
            cmdRoomUnavailable.Dispose();
        }

        // Return reservation room_no
        private string GetResRoomAndLoc ()
        {
            int resID = Convert.ToInt32(txtResID.Text);
            string resInfo;

            sqlConnection1.Open();

            SqlCommand cmdRoomUnavailable = sqlConnection1.CreateCommand();
            cmdRoomUnavailable.CommandText = @"SELECT RES_ROOM_NO, RES_LOC_ID
                                               FROM RESERVATION
                                               WHERE RES_NO = @search1";
            cmdRoomUnavailable.Parameters.AddWithValue("@search1", resID);
            SqlDataReader reader = cmdRoomUnavailable.ExecuteReader();

            if (reader.Read())
            {
                resInfo = reader.GetInt32(0) + " " + reader.GetInt32(1);
                reader.Close();
                sqlConnection1.Close();
                cmdRoomUnavailable.Dispose();

                return resInfo;
            }
            else
            {
                MessageBox.Show("Error getting reservation information");
                reader.Close();
                sqlConnection1.Close();
                cmdRoomUnavailable.Dispose();

                return "Error";
            }
        }

        // Fill customers combo box
        private void LoadCustomers()
        {
            cmbCustName.Items.Clear();

            DateTime date = DateTime.Now;
            string sqlFormattedDate = date.ToString("yyyy-MM-dd");
            int index = sqlFormattedDate.IndexOf(" ")+1;
            sqlFormattedDate = sqlFormattedDate.Substring(index);

            sqlConnection1.Open();
            SqlCommand cmdLoadCust = sqlConnection1.CreateCommand();
            cmdLoadCust.CommandText = @"SELECT CUST_LNAME
                                        FROM CUSTOMER
                                           JOIN RESERVATION ON RES_CUST_ID = CUST_ID
                                           JOIN ROOM ON (RES_ROOM_NO = ROOM_NO
                                                            AND RES_LOC_ID = ROOM_LOC)
                                        WHERE ROOM_AVAILABLE = 'Y'";
            cmdLoadCust.Parameters.AddWithValue("@search", sqlFormattedDate);

            SqlDataReader reader = cmdLoadCust.ExecuteReader();
            while (reader.Read())
            {
                cmbCustName.Items.Add(reader[0]);
            }
            sqlConnection1.Close();
            reader.Close();
            cmdLoadCust.Dispose();
        }

        // Load customers upon clicking combo box
        private void cmbCustName_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }
    }
}
