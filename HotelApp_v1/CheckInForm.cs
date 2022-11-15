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
            CheckIn();
        }

        private void CheckIn()
        {
            sqlConnection1.Open();

            string custLname = txtLname.Text;
            int resID = Convert.ToInt32(txtResID.Text);
            int secCode = Convert.ToInt32(txtSecCode);

            // Check the reservation is valid and check in is today
            SqlCommand cmdValidCheckIn = sqlConnection1.CreateCommand();
            cmdValidCheckIn.CommandText = @"SELECT CUST_FNAME, CUST_LNAME
                                            FROM CUSTOMER
                                                JOIN RESERVATION ON RES_CUST_ID = CUST_ID
                                                JOIN CREDIT_CARD ON CREDIT_CARD_NO = CUST_CREDIT_CARD_NO
                                            WHERE RES_NO = @search1
                                            AND CUST_LNAME = @search2
                                            AND CREDIT_SEC_CODE = @search3";
            cmdValidCheckIn.Parameters.AddWithValue("@search1", resID);
            cmdValidCheckIn.Parameters.AddWithValue("@search1", custLname);
            cmdValidCheckIn.Parameters.AddWithValue("@search1", secCode);

            SqlDataReader reader = cmdValidCheckIn.ExecuteReader();
        }

        private void btnResSearch_Click(object sender, EventArgs e)
        {
            reservationQueryForm1.Visible = true;
        }
    }
}
