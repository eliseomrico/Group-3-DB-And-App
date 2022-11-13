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
            btnEdit.Visible = enable;
            btnSubmitEdit.Visible = !enable;
        }
        private void changeCreateButtonsVisibility(bool enable)
        {
            btnCreate.Visible = enable;
            btnSubmitCreate.Visible = !enable;
        }
        private void changeCancelButton(bool enable)
        {
            btnCancel.Enabled = enable;
            btnCancel.Visible = enable;
        }
        private void changeTextBoxesReadOnlyStatus(bool enable) // makes text boxes read-only or not read-only
        {
            txtEmpName.ReadOnly = enable;
            txtLocName.ReadOnly = enable;
            txtRoomNo.ReadOnly = enable;
            dtpResStart.Enabled = !enable;
            dtpResEnd.Enabled = !enable;
        }
        private void emptyTextBoxes() // clears text from text boxes
        {
            comboBox_res_id.Text = "";
            txtEmpName.Clear();
            txtLocName.Clear();
            txtRoomNo.Clear();
            dtpResStart.Value = DateTime.Now;
            dtpResEnd.Value = DateTime.Now;
        }
        private void changeButtonsEnabled(bool enable)
        {
            btnCreate.Enabled = enable;
            btnEdit.Enabled = enable;
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
            btnSearch.Enabled = false;
            btnSubmitCreate.Enabled = true;
            changeCancelButton(true);

            // Marcel's Code Here

            txtEmpName.ReadOnly = false;
            txtLocName.ReadOnly = false;
            txtRoomNo.ReadOnly = false;
            comboBox_res_id.Visible = false;
            txtResID.Text = getReservationID();
            txtResID.Visible= true;
            cmbCustName.Focus();

            // Load Cust IDs into ComboBox

            SqlConnection sqlConnection = new SqlConnection("Data Source=ELISEORICOCE42;Initial Catalog=TestDatabase;Integrated Security=SSPI");
            
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT cust_id,cust_fname,cust_lname FROM CUSTOMER",sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbCustName.Items.Add(dr[0].ToString()+" - " + dr[1].ToString() + " " + dr[2].ToString());
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
            btnSearch.Enabled = true;
            btnSubmitCreate.Enabled = false;
            changeCancelButton(false);
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            changeEditButtonsVisibility(false);
            changeTextBoxesReadOnlyStatus(false); // make text boxes non-'editable' or read-only
            changeButtonsEnabled(false);
            btnSubmitEdit.Enabled = true;
            btnSearch.Enabled = false; // disable search button
            changeCancelButton(true);
        }

        private void button_submit_edit_Click(object sender, EventArgs e)
        {
            changeEditButtonsVisibility(true);
            changeTextBoxesReadOnlyStatus(true); // make text boxes non-'editable' or read-only
            changeButtonsEnabled(true);
            btnSubmitEdit.Enabled = false;
            btnSearch.Enabled = true; // enable search button
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
            btnSubmitEdit.Enabled = false;
            btnSubmitCreate.Enabled = false;
            btnSearch.Enabled = true; // enable search button
        }
    }
}
