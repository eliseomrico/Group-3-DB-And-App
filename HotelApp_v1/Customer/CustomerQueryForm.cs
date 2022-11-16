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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace HotelApp_v1
{
    public partial class CustomerQueryForm : UserControl
    {

        public CustomerQueryForm()
        {
            InitializeComponent();
            AddCustomerComboBoxItems();
        }

        // Policy Methods
        private void textBoxesAreEnabled(bool enable)
        {
            textBox_cust_fname.Enabled = enable;
            textBox_cust_lname.Enabled = enable;
            textBox_cust_phone.Enabled = enable;
            textBox_cust_balance.Enabled = enable;
            textBox_cc_part1.Enabled = enable;
            textBox_cc_part2.Enabled = enable;
            textBox_cc_part3.Enabled = enable;
            textBox_cc_part4.Enabled = enable;
        }
        private void deleteButtonEnabled(bool enable)
        {
            button_delete.Enabled = enable;
        }
        private void editButtonEnabled(bool enable)
        {
            button_edit.Enabled = enable;
        }
        private void editButtonIsVisible(bool enable)
        {
            button_edit.Visible = enable;
            button_submit_edit.Visible = !enable;
        }
        private void cancelButtonIsEnabled(bool enable)
        {
            button_cancel.Enabled = enable;
        }
        private void submitCreateButtonIsVisible(bool enable)
        {
            button_submit_create.Enabled = enable;
            button_submit_create.Visible = enable;
        }
        private void submitEditButtonIsVisible(bool enable)
        {
            button_submit_edit.Enabled = enable;
            button_submit_edit.Visible = enable;
        }
        private void textBoxesAreReadOnly(bool enable) // makes text boxes read-only or not read-only
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

        // Action Methods
        private void AddCustomerComboBoxItems()
        {
            comboBox_cust_id.Items.Clear();
            sqlConnection1.Open();
            SqlCommand cmd = sqlConnection1.CreateCommand();
            cmd.CommandText = "SELECT * FROM CUSTOMER";
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                comboBox_cust_id.Items.Add(rd["cust_id"] + " - " + rd["cust_fname"] + " " + rd["cust_lname"]);
            }
            sqlConnection1.Close();
        }
        private void clearAllTextBoxes() // clears text from text boxes
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




        // Functionality Methods

        private void button_home_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
       

           // Customer Create Buttons
        private void button_create_Click(object sender, EventArgs e)
        {

            cancelButtonIsEnabled(true);
            clearAllTextBoxes();
            textBoxesAreReadOnly(false);
            textBoxesAreEnabled(true);
            submitCreateButtonIsVisible(true);
            cancelButtonIsEnabled(true);

            textBox_cust_fname.Focus();
            textBox_cust_id.Text = getCustID();
            textBox_cust_id.Visible = true;
            
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
                                 textBox_cc_part4.Text;
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
            textBoxesAreReadOnly(true);


            clearAllTextBoxes();
            AddCustomerComboBoxItems();
            submitCreateButtonIsVisible(false);
            textBox_cust_id.Text = "";
            textBox_cust_id.Visible = false;
            comboBox_cust_id.Focus();

        }

           // Customer Editing Buttons
        private void button_edit_Click(object sender, EventArgs e)
        {
            submitEditButtonIsVisible(true);
            deleteButtonEnabled(true);
            cancelButtonIsEnabled(true);

            textBoxesAreReadOnly(false); // make text boxes non-'editable' or read-only

            button_submit_edit.Enabled = true;

        }
        private void button_submit_edit_Click(object sender, EventArgs e)
        {

            editButtonIsVisible(true);
            textBoxesAreReadOnly(true); // make text boxes non-'editable' or read-only
            cancelButtonIsEnabled(false);
            deleteButtonEnabled(false);
        
            button_submit_edit.Enabled = false;

            string cust_id = comboBox_cust_id.Text.ToString()[0].ToString();
            string cust_first_name = textBox_cust_fname.Text;
            string cust_last_name = textBox_cust_lname.Text;
            string cust_phone_num = textBox_cust_phone.Text;
            string cust_cc_num = textBox_cc_part1.Text +
                                 textBox_cc_part2.Text +
                                 textBox_cc_part3.Text +
                                 textBox_cc_part4.Text;
            string cust_balance = textBox_cust_balance.Text;


            sqlConnection1.Open();

            SqlCommand cmd = sqlConnection1.CreateCommand();
            cmd.CommandText = "UPDATE CUSTOMER " +
                              "SET " +
                              "CUST_FNAME = '"+cust_first_name+"', " +
                              "CUST_LNAME = '"+cust_last_name+"', " +
                              "CUST_PHONE = '"+cust_phone_num+"', " +
                              "CUST_BALANCE = "+ cust_balance+" " +
                              "WHERE " +
                              "CUST_ID = "+cust_id+"";
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
            comboBox_cust_id.Text = cust_id + " - " + cust_first_name + " " + cust_last_name;
            AddCustomerComboBoxItems();
        }

           // Customer Deleting Buttons
        private void button_delete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this customer?",
                                     "Customer Delete",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                string cust_id = comboBox_cust_id.Text[0].ToString();
                sqlConnection1.Open();

                SqlCommand cmd = sqlConnection1.CreateCommand();
                cmd.CommandText = "DELETE FROM CUSTOMER " +
                                  "WHERE " +
                                  "CUST_ID = @search";
                cmd.Parameters.AddWithValue("@search", cust_id);
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();

                MessageBox.Show("1 Account Deleted");


                button_cancel_Click(sender, e);
                AddCustomerComboBoxItems();
            }
            else
            {
                button_cancel.PerformClick();
            }
            
        }

           // Customer Cancel Button
        private void button_cancel_Click(object sender, EventArgs e)
        {
            submitCreateButtonIsVisible(false);
            submitEditButtonIsVisible(false);
            deleteButtonEnabled(false);
            textBoxesAreEnabled(false);
            cancelButtonIsEnabled(false);
            editButtonIsVisible(true);
            editButtonEnabled(false);
            textBox_cust_id.Text = "";
            textBox_cust_id.Visible = false;
            comboBox_cust_id.Focus();
            clearAllTextBoxes();
        }
   

        // Credit Card Auto-Tab Fields
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

        // Customer ID Combobox Selection Change
        private void comboBox_cust_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cust_id = comboBox_cust_id.SelectedIndex+1;
            button_edit.Enabled = true;

            sqlConnection1.Open();

            SqlCommand cmd = sqlConnection1.CreateCommand();
            cmd.CommandText = @"SELECT * FROM CUSTOMER
                                WHERE cust_id = @search";
            cmd.Parameters.AddWithValue("@search", cust_id);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                textBox_cust_fname.Text = rd["cust_fname"].ToString();
                textBox_cust_lname.Text = rd["cust_lname"].ToString();
                textBox_cust_phone.Text = rd["cust_phone"].ToString();
                textBox_cust_balance.Text = rd["cust_balance"].ToString();
                textBox_cc_part1.Text = rd["cust_credit_card_no"].ToString().Substring(0,4);
                textBox_cc_part2.Text = rd["cust_credit_card_no"].ToString().Substring(4, 4);
                textBox_cc_part3.Text = rd["cust_credit_card_no"].ToString().Substring(8, 4);
                textBox_cc_part4.Text = rd["cust_credit_card_no"].ToString().Substring(12, 4);
            }
            sqlConnection1.Close();
        }
    }
}
