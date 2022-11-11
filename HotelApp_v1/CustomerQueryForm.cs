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
    public partial class CustomerQueryForm : UserControl
    {
        
        public SqlConnection DBConnection;



        public CustomerQueryForm()
        {
            InitializeComponent();
        }
        private void changeEditButtonsVisibility(bool enable) // after search is clicked, show edit and delete buttons
        {
            button_edit.Visible = enable;
            button_submit_edit.Visible = !enable;
        }
        private void changeCreateButtonsVisibility(bool enable)
        {
            button_create.Visible = enable;
            button_submit_create.Visible = !enable;
        }
        private void changeTextBoxesReadOnlyStatus(bool enable) // makes text boxes read-only or not read-only
        {
            textBox_cust_fname.ReadOnly = enable;
            textBox_cust_lname.ReadOnly = enable;
            textBox_cust_phone.ReadOnly = enable;
            textBox_cc_part1.ReadOnly = enable;
            textBox_cc_part2.ReadOnly = enable;
            textBox_cc_part3.ReadOnly = enable;
            textBox_cc_part4.ReadOnly = enable;
            textBox_cust_balance.ReadOnly = enable;
        }
        private void emptyTextBoxes() // clears text from text boxes
        {
            comboBox_cust_id.Text = "";
            textBox_cust_fname.Clear();
            textBox_cust_lname.Clear();
            textBox_cust_phone.Clear();
            textBox_cc_part1.Clear();
            textBox_cc_part2.Clear();
            textBox_cc_part3.Clear();
            textBox_cc_part4.Clear();
            textBox_cust_balance.Clear();
        }
        private string getCustID()
        {
            // Authored By: Marcel Rico
            string custID = "";
            

            try
            {
                sqlConnection1.Open();
                SqlCommand cmd = sqlConnection1.CreateCommand();
                cmd.CommandText = "SELECT MAX(cust_id) FROM CUSTOMER";
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    if (DBNull.Value.Equals(dr[0]))
                    {
                        custID = "1";
                        Console.WriteLine(dr[0]);
                    }
                    else
                    {
                        custID = (int.Parse(dr[0].ToString()) + 1).ToString();
                    }

                }
                sqlConnection1.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return custID;
        }
        private void changeButtonsEnabled(bool enable)
        {
            button_create.Enabled = enable;
            button_edit.Enabled = enable;
            button_delete.Enabled = enable;
        }
        private void changeCancelButton(bool enable)
        {
            button_cancel.Enabled = enable;
            button_cancel.Visible = enable;
        }
        private void button_home_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void button_search_Click(object sender, EventArgs e)
        {
            changeButtonsEnabled(true); // delete this when above is filled out
        }
        private void button_create_Click(object sender, EventArgs e)
        {
            // Modified By: Marcel
            changeTextBoxesReadOnlyStatus(false);
            textBox_cust_fname.Focus();

            textBox_cust_id.Text = getCustID();
            textBox_cust_id.Visible = true;
            button_search.Enabled = false;
            
            changeCreateButtonsVisibility(false);
        }
        private void button_submit_create_Click(object sender, EventArgs e)
        {
            // Modified By: Marcel

            string cust_first_name = textBox_cust_fname.Text;
            string cust_last_name = textBox_cust_lname.Text;
            string cust_phone_num = textBox_cust_phone.Text;
            string cust_cc_num = textBox_cc_part1.Text+
                                 textBox_cc_part2.Text+
                                 textBox_cc_part3.Text+
                                 textBox_cc_part3.Text;
            string cust_balance = textBox_cust_balance.Text;

            // Data Validation

            sqlConnection1.Open();
            SqlCommand cmd = sqlConnection1.CreateCommand();

            // Create Credit Card Entry
            cmd.CommandText = "INSERT INTO CREDIT_CARD (CREDIT_CARD_NO,CREDIT_CARD_FNAME,CREDIT_CARD_LNAME) VALUES ('"+cust_cc_num+"','"+cust_first_name+"','"+cust_last_name+"')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            
            // Create Customer Entry
            cmd.CommandText = "INSERT INTO CUSTOMER (CUST_FNAME,CUST_LNAME,CUST_PHONE,CUST_BALANCE,CUST_CREDIT_CARD_NO) VALUES ('"+cust_first_name+"','"+cust_last_name+"','"+cust_phone_num+"',"+Decimal.Parse(cust_balance)+",'"+cust_cc_num+"')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            

            sqlConnection1.Close();

            MessageBox.Show("1 Credit Card and Customer Added");
            changeTextBoxesReadOnlyStatus(true);


            emptyTextBoxes();
            changeCreateButtonsVisibility(true);

            textBox_cust_id.Text = "";
            textBox_cust_id.Visible = false;
            comboBox_cust_id.Focus();

        }
        private void button_edit_Click(object sender, EventArgs e)
        {
            changeEditButtonsVisibility(false);
            changeTextBoxesReadOnlyStatus(false); // make text boxes non-'editable' or read-only
            changeButtonsEnabled(false);
            button_submit_edit.Enabled = true;
            button_search.Enabled = false; // disable search button
            changeCancelButton(false);
        }
        private void button_submit_edit_Click(object sender, EventArgs e)
        {
            changeEditButtonsVisibility(true);
            changeTextBoxesReadOnlyStatus(true); // make text boxes non-'editable' or read-only
            changeButtonsEnabled(true);
            button_submit_edit.Enabled = false;
            button_search.Enabled = true; // enable search button
            changeCancelButton(false);
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            emptyTextBoxes(); // clears texts from text boxes
            changeButtonsEnabled(false); // hide edit and delete buttons
            changeTextBoxesReadOnlyStatus(true); // make text boxes read-only
        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            changeButtonsEnabled(false); // delete this when above is filled out
            emptyTextBoxes(); // clear text boxes
            changeEditButtonsVisibility(true);
            changeCreateButtonsVisibility(true);
            changeCancelButton(false);
            button_submit_edit.Enabled = false;
            button_submit_create.Enabled = false;
            button_search.Enabled = true; // enable search button
        }

        private void textBox_cc_part1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox_cc_part1.Text.Length > 3)
            {
                GetNextControl(this.textBox_cc_part1, true).Focus();
            }
        }
        private void textBox_cc_part2_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox_cc_part2.Text.Length > 3)
            {
                GetNextControl(this.textBox_cc_part2, true).Focus();
            }
        }
        private void textBox_cc_part3_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox_cc_part3.Text.Length > 3)
            {
                GetNextControl(this.textBox_cc_part3, true).Focus();
            }
        }
        private void textBox_cc_part4_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox_cc_part4.Text.Length > 3)
            {
                GetNextControl(this.textBox_cc_part4, true).Focus();
            }
        }

    }
}
