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
    public partial class ReservationQueryForm : UserControl
    {
        public ReservationQueryForm()
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
        private void changeCancelButton(bool enable)
        {
            button_cancel.Enabled = enable;
            button_cancel.Visible = enable;
        }
        private void changeTextBoxesReadOnlyStatus(bool enable) // makes text boxes read-only or not read-only
        {
            textBox_res_emp_id.ReadOnly = enable;
            textBox_res_loc_id.ReadOnly = enable;
            textBox_res_room_num.ReadOnly = enable;
            dateTimePicker_start.Enabled = !enable;
            dateTimePicker_end.Enabled = !enable;
        }
        private void emptyTextBoxes() // clears text from text boxes
        {
            comboBox_res_id.Text = "";
            textBox_res_emp_id.Clear();
            textBox_res_loc_id.Clear();
            textBox_res_room_num.Clear();
            dateTimePicker_start.Value = DateTime.Now;
            dateTimePicker_end.Value = DateTime.Now;
        }
        private void changeButtonsEnabled(bool enable)
        {
            button_create.Enabled = enable;
            button_edit.Enabled = enable;
            button_delete.Enabled = enable;
        }
        private string getReservationID()
        {
                // Authored By: Marcel Rico
                string resID = "";

                SqlConnection conn = new SqlConnection("Data Source=ELISEORICOCE42;Initial Catalog=TestDatabase;Integrated Security=SSPI");

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT MAX(res_no) FROM RESERVATION", conn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {

                        if (DBNull.Value.Equals(dr[0]))
                        {
                            resID = "1";
                            Console.WriteLine(dr[0]);
                        }
                        else
                        {
                            resID = (int.Parse(dr[0].ToString()) + 1).ToString();
                        }

                    }

                }
                catch
                {

                }

                return resID;
        }


        // form buttons below
        private void button_home_Click(object sender, EventArgs e)
        {
            emptyTextBoxes();
            changeButtonsEnabled(false);
            this.Visible = false;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            changeButtonsEnabled(true);
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            // used additional form to create customer, now staying on same form
            // CreateReservation createReservationForm = new CreateReservation();
            // createReservationForm.ShowDialog();

            emptyTextBoxes(); // clears texts from text boxes
            changeCreateButtonsVisibility(false);

            changeButtonsEnabled(false);
            button_search.Enabled = false;
            button_submit_create.Enabled = true;
            changeCancelButton(true);

            // Marcel's Code Here

            textBox_res_emp_id.ReadOnly = false;
            textBox_res_loc_id.ReadOnly = false;
            textBox_res_room_num.ReadOnly = false;
            comboBox_res_id.Visible = false;
            textBox_res_id.Text = getReservationID();
            textBox_res_id.Visible= true;
            comboBox_cust_id.Focus();

            // Load Cust IDs into ComboBox

            SqlConnection sqlConnection = new SqlConnection("Data Source=ELISEORICOCE42;Initial Catalog=TestDatabase;Integrated Security=SSPI");
            
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT cust_id,cust_fname,cust_lname FROM CUSTOMER",sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox_cust_id.Items.Add(dr[0].ToString()+" - " + dr[1].ToString() + " " + dr[2].ToString());
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        private void button_submit_create_Click(object sender, EventArgs e)
        {
            emptyTextBoxes(); // clears texts from text boxes
            changeCreateButtonsVisibility(true);
            changeButtonsEnabled(true);
            button_search.Enabled = true;
            button_submit_create.Enabled = false;
            changeCancelButton(false);
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            changeEditButtonsVisibility(false);
            changeTextBoxesReadOnlyStatus(false); // make text boxes non-'editable' or read-only
            changeButtonsEnabled(false);
            button_submit_edit.Enabled = true;
            button_search.Enabled = false; // disable search button
            changeCancelButton(true);
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
            // add delete logic here

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
    }
}
