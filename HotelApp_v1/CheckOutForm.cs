using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApp_v1
{
    public partial class CheckOutForm : UserControl
    {
        public CheckOutForm()
        {
            InitializeComponent();
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        // Create a transaction and check the customer out
        private void button_submit_Click(object sender, EventArgs e)
        {
            if (IsCheckOutDate())
            {
                double roomPrice = GetPrice();
                DateTime startDate = GetResStart();
                DateTime endDate = GetResEnd();
                int stayLength = ((int)(endDate - startDate).TotalDays) + 1;

                double priceOfStay = roomPrice * stayLength;

                GenerateTransaction(priceOfStay);
            }
            else
            {
                var confirm = MessageBox.Show("Are you sure you want to check out early?",
                                              "Early Check Out", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    double roomPrice = GetPrice();
                    DateTime startDate = GetResStart();
                    DateTime endDate = GetResEnd();
                    int stayLength = ((int)(endDate - startDate).TotalDays) + 1;

                    double priceOfStay = roomPrice * stayLength;

                    GenerateTransaction(priceOfStay);
                }
                else
                {
                    // Do nothing
                }
            }
        }

        // Creates a transaction for the customer "paying" for their stay
        private void GenerateTransaction(double totalCost)
        {
            DateTime today = DateTime.Now;
            string sqlFormattedDate = today.ToString("yyyy-MM-dd HH:mm:ss.fff");

            int resID = Convert.ToInt32(txtResID.Text);

            sqlConnection1.Open();
            SqlCommand cmdGenerateTransaction = sqlConnection1.CreateCommand();
            cmdGenerateTransaction.CommandText = @"INSERT INTO TRANSACTIONS
                                                   (TRANS_DATE,
                                                    TRANS_AMT,
                                                    TRANS_RES_ID)
                                                    VALUES (@search1, @search2, @search3)";
            cmdGenerateTransaction.Parameters.AddWithValue("@search1", sqlFormattedDate);
            cmdGenerateTransaction.Parameters.AddWithValue("@search2", totalCost);
            cmdGenerateTransaction.Parameters.AddWithValue("@search3", resID);

            cmdGenerateTransaction.ExecuteNonQuery();

            sqlConnection1.Close();
            cmdGenerateTransaction.Dispose();

            int transNo = GetTransactionNumber();

            MessageBox.Show("You have been successfully checked out!\n\tYour transaction number is " + transNo + "\n\tYou have been charged " + totalCost,
                            "Check Out", MessageBoxButtons.OK);

        }

        // Returns the price of the stay based on room and length
        private double GetPrice()
        {
            int resID = Convert.ToInt32(txtResID.Text);

            sqlConnection1.Open();
            SqlCommand cmdGetPrice = sqlConnection1.CreateCommand();
            cmdGetPrice.CommandText = @"SELECT TYPE_PRICE
                                        FROM ROOM_TYPE
                                            JOIN ROOM ON ROOM_TYPE = TYPE_CODE
                                            JOIN RESERVATION ON RES_ROOM_NO = ROOM_NO
                                        WHERE RES_NO = @search";
            cmdGetPrice.Parameters.AddWithValue("@search", resID);
            SqlDataReader reader = cmdGetPrice.ExecuteReader();

            if (reader.Read())
            {
                double result = Convert.ToDouble(reader[0]);
                sqlConnection1.Close();
                reader.Close();
                cmdGetPrice.Dispose();
                return result;
            }
            else
            {
                sqlConnection1.Close();
                reader.Close();
                cmdGetPrice.Dispose();
                MessageBox.Show("Error retrieving room price", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        // Returns reservations start date
        private DateTime GetResStart()
        {
            int resID = Convert.ToInt32(txtResID.Text);

            sqlConnection1.Open();
            SqlCommand cmdGetStart = sqlConnection1.CreateCommand();
            cmdGetStart.CommandText = @"SELECT RES_START_DATE
                                        FROM RESERVATION
                                        WHERE RES_NO = @search";
            cmdGetStart.Parameters.AddWithValue("@search", resID);
            SqlDataReader reader = cmdGetStart.ExecuteReader();

            if (reader.Read())
            {
                DateTime result = Convert.ToDateTime(reader[0]);
                sqlConnection1.Close();
                reader.Close();
                cmdGetStart.Dispose();
                return result;
            }
            else
            {
                sqlConnection1.Close();
                reader.Close();
                cmdGetStart.Dispose();
                MessageBox.Show("Error retrieving reservation start date", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DateTime.Now;
            }
        }

        // Returns reservations start date
        private DateTime GetResEnd()
        {
            int resID = Convert.ToInt32(txtResID.Text);

            sqlConnection1.Open();
            SqlCommand cmdGetEnd = sqlConnection1.CreateCommand();
            cmdGetEnd.CommandText = @"SELECT RES_END_DATE
                                        FROM RESERVATION
                                        WHERE RES_NO = @search";
            cmdGetEnd.Parameters.AddWithValue("@search", resID);
            SqlDataReader reader = cmdGetEnd.ExecuteReader();

            if (reader.Read())
            {
                DateTime result = Convert.ToDateTime(reader[0]);
                sqlConnection1.Close();
                reader.Close();
                cmdGetEnd.Dispose();
                return result;
            }
            else
            {
                sqlConnection1.Close();
                reader.Close();
                cmdGetEnd.Dispose();
                MessageBox.Show("Error retrieving reservation start date", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DateTime.Now;
            }
        }

        // Returns the customers transaction number
        private int GetTransactionNumber()
        {
            int resID = Convert.ToInt32(txtResID.Text);

            sqlConnection1.Open();
            SqlCommand cmdGetPrice = sqlConnection1.CreateCommand();
            cmdGetPrice.CommandText = @"SELECT TRANS_NO
                                        FROM TRANSACTIONS
                                        WHERE TRANS_RES_ID = @search";
            cmdGetPrice.Parameters.AddWithValue("@search", resID);
            SqlDataReader reader = cmdGetPrice.ExecuteReader();

            if (reader.Read())
            {
                int result = Convert.ToInt32(reader[0]);
                sqlConnection1.Close();
                reader.Close();
                cmdGetPrice.Dispose();
                return result;
            }
            else
            {
                sqlConnection1.Close();
                reader.Close();
                cmdGetPrice.Dispose();
                MessageBox.Show("Error retrieving transaction number", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        // Returns true if check out day is today
        private bool IsCheckOutDate()
        {
            int resID = Convert.ToInt32(txtResID.Text);

            sqlConnection1.Open();
            SqlCommand cmdIsValid = sqlConnection1.CreateCommand();
            cmdIsValid.CommandText = @"SELECT RES_END_DATE
                                        FROM RESERVATION
                                        WHERE RES_NO = @search";
            cmdIsValid.Parameters.AddWithValue("@search", resID);
            SqlDataReader reader = cmdIsValid.ExecuteReader();

            if (reader.Read())
            {
                sqlConnection1.Close();
                reader.Close();
                cmdIsValid.Dispose();
                return true;
            }
            else
            {
                sqlConnection1.Close();
                reader.Close();
                cmdIsValid.Dispose();
                MessageBox.Show("Error retrieving check out date", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
