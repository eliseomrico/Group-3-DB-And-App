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
    public partial class Transactions : UserControl
    {
        public Transactions()
        {
            InitializeComponent();
        }

        // Clears text from all text boxes
        private void clearTextBoxes() 
        {
            txtResID.Clear();
            txtTransAmt.Clear();
        }

        // "Home" button click - doesn't exist on this form?
        private void button_home_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
            this.Visible = false;
        }

        // "Cancel" button click
        private void button_cancel_Click(object sender, EventArgs e)
        {
            clearTextBoxes(); 
        }

        // "Search" button click - Populate text boxes
        private void btnSearch_Click(object sender, EventArgs e)
        {
            clearTextBoxes();

            int trans_no = Convert.ToInt32(txtTransNo.Text);

            GetTransactionInfo(trans_no);
            PopulateCustomerName(trans_no);
            PopulateEmployeeName(trans_no);
        }

        ////////////////////////// GENERAL METHODS BELOW //////////////////////////

        // Populate transaction information associated with transaction ID
        private void GetTransactionInfo(int trans_no)
        {
            sqlConnection2.Open();

            SqlCommand cmdGetTransInfo = sqlConnection2.CreateCommand();
            cmdGetTransInfo.CommandText = @"SELECT *
                                            FROM TRANSACTIONS
                                            WHERE TRANS_NO = @search";
            cmdGetTransInfo.Parameters.AddWithValue("@search", trans_no);

            SqlDataReader reader = cmdGetTransInfo.ExecuteReader();

            if (reader.Read())
            {
                txtResID.Text = reader[3].ToString();
                txtTransAmt.Text = reader[2].ToString();
                txtTransDate.Text = reader[1].ToString();
            }
            else
            {
                MessageBox.Show("Transaction not found");
            }

            sqlConnection2.Close();
            reader.Close();
            cmdGetTransInfo.Dispose();
        }

        // Return customer name associated with transaction ID
        private void PopulateCustomerName(int trans_no)
        {
            sqlConnection2.Open();

            SqlCommand cmdGetCust = sqlConnection2.CreateCommand();
            cmdGetCust.CommandText = @"SELECT CUST_FNAME, CUST_LNAME
                                       FROM CUSTOMER
                                          JOIN RESERVATION ON CUST_ID = RES_CUST_ID
                                          JOIN TRANSACTIONS ON RES_NO = TRANS_RES_ID
                                       WHERE TRANS_NO = @search";
            cmdGetCust.Parameters.AddWithValue("@search", trans_no);
            SqlDataReader reader2 = cmdGetCust.ExecuteReader();

            if (reader2.Read())
            {
                txtCustName.Text = reader2[0].ToString() + " " + reader2[1].ToString();
            }
            else
            {
                MessageBox.Show("Error retrieving customer name");
            }

            sqlConnection2.Close();
            reader2.Close();
            cmdGetCust.Dispose();
        }

        // Return employee name associated with transaction ID
        private void PopulateEmployeeName(int trans_no)
        {
            sqlConnection2.Open();

            SqlCommand cmdGetEmp = sqlConnection2.CreateCommand();
            cmdGetEmp.CommandText = @"SELECT EMP_FNAME, EMP_LNAME
                                       FROM EMPLOYEE
                                          JOIN RESERVATION ON EMP_ID = RES_EMP_ID
                                          JOIN TRANSACTIONS ON RES_NO = TRANS_RES_ID
                                       WHERE TRANS_NO = @search";
            cmdGetEmp.Parameters.AddWithValue("@search", trans_no);
            SqlDataReader reader2 = cmdGetEmp.ExecuteReader();
            
            if (reader2.Read())
            {
                txtEmpName.Text = reader2[0].ToString() + " " + reader2[1].ToString();
            }
            else
            {
                MessageBox.Show("Error retrieving employee name");
            }

            sqlConnection2.Close();
            reader2.Close();
            cmdGetEmp.Dispose();
        }
    }
}
