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

        private void btnSubmit_Click(object sender, EventArgs e)
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
                                            AND CUST_LNAME = 
                                            AND CREDIT_SEC_CODE = @search3";

/*select cust_fname, cust_lname
from customer
	join reservation on RES_CUST_ID = cust_id
	join CREDIT_CARD on credit_card_no = cust_credit_card_no
where RES_NO = 1
and cust_lname = 'smith'
and credit_sec_code = 5*/

            // Check the customer in
        }
    }
}
