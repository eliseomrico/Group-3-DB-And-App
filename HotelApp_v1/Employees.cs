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
    public partial class Employees : UserControl
    {
        public Employees()
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
            txtEmpSSN.ReadOnly = enable;
            txtSupID.ReadOnly = enable;
            txtSearchBox.ReadOnly = enable;
            txtEmpLname.ReadOnly = enable;
        }
        private void clearTextBoxes() // clears text from text boxes
        {
            txtEmpID.Clear();
            txtEmpSSN.Clear();
            txtSupID.Clear();
            txtEmpLname.Clear();
            txtEmpTitle.Clear();
        }
        private void changeButtonsEnabled(bool enable)
        {
            button_create.Enabled = enable;
            button_edit.Enabled = enable;
            button_delete.Enabled = enable;
        }

        //////
        //  Button Clicks
        //////
        private void button_home_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
            changeButtonsEnabled(false);
            this.Visible = false;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            changeButtonsEnabled(true);
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            clearTextBoxes(); // clears texts from text boxes
            changeCreateButtonsVisibility(false);
            changeButtonsEnabled(false);
            button_search.Enabled = false;
            button_submit_create.Enabled = true;
            changeCancelButton(true);
        }
        private void button_submit_create_Click(object sender, EventArgs e)
        {
            clearTextBoxes(); // clears texts from text boxes
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
            clearTextBoxes(); // clears texts from text boxes
            changeButtonsEnabled(false); // hide edit and delete buttons
            changeTextBoxesReadOnlyStatus(true); // make text boxes read-only
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            changeButtonsEnabled(false); // delete this when above is filled out
            clearTextBoxes(); // clear text boxes
            changeEditButtonsVisibility(true);
            changeCreateButtonsVisibility(true);
            changeCancelButton(false);
            button_submit_edit.Enabled = false;
            button_submit_create.Enabled = false;
            button_search.Enabled = true; // enable search button
        }


        //////////////////////////////
        // Lauren's functions below //
        //////////////////////////////

        // Return employees title string based on title code
        static private string GetTitleText(int type)
        {
            switch(type)
            {
                case 10:
                    return ("Front Desk");
                case 20:
                    return ("Housekeeper");
                case 30:
                    return ("Manager");
                case 40:
                    return ("System Administrator");
                default:
                    return ("Error: Cannot retrieve user type.");

            }
        }

        // Return an employees title 
        private string GetEmployeeTitle(int id)
        {
            SqlCommand cmdGetTitleCode = sqlConnection1.CreateCommand();
            cmdGetTitleCode.CommandText = "SELECT EMP_TITLE" +
                                          "FROM EMPLOYEE"    +
                                          "WHERE EMP_ID = "  + id;
            SqlDataReader reader = cmdGetTitleCode.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();
                return reader.GetString(0);
            } else
            {
                reader.Close();
                MessageBox.Show("Error getting employee title.");
                return null;
            }
        }

        // Populates combo box based on search criteria from search box
        private void btnSearch_MouseClick(object sender, MouseEventArgs e)
        {
            cmbEmpFname.SelectedIndex = -1;
            cmbEmpFname.Items.Clear();
            clearTextBoxes();

            sqlConnection1.Open();

            SqlCommand cmdPopulateTextBox = sqlConnection1.CreateCommand();
            cmdPopulateTextBox.CommandText = @"SELECT EMP_FNAME
                                               FROM EMPLOYEE
                                               WHERE EMP_FNAME LIKE @search";

            cmdPopulateTextBox.Parameters.AddWithValue("@search", "%" + txtSearchBox.Text + "%");
            SqlDataReader reader = cmdPopulateTextBox.ExecuteReader();

            while (reader.Read())
            {
                cmbEmpFname.Items.Add(reader[0].ToString());
            }

            reader.Close();
            sqlConnection1.Close();

            //else
            //{
            //    reader.Close();
            //    sqlConnection1.Close();
            //    MessageBox.Show("Error");
            //}
        }

        // Populates all fields on employee form based on combo box selection
        private void cmbEmpFname_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            clearTextBoxes();

            SqlCommand cmdRetreiveFields = sqlConnection1.CreateCommand();
            cmdRetreiveFields.CommandText = @"SELECT * 
                                              FROM EMPLOYEE 
                                              WHERE EMP_FNAME = @search";
            cmdRetreiveFields.Parameters.AddWithValue("@search", cmbEmpFname.Text);
            SqlDataReader reader = cmdRetreiveFields.ExecuteReader();

            if (reader.Read())
            {
                txtEmpID.Text = reader[0].ToString();
                txtEmpLname.Text = reader[2].ToString();
                txtEmpSSN.Text = reader[6].ToString();
                txtEmpTitle.Text = reader[3].ToString();
                txtSupID.Text = reader[5].ToString();
            }
            else
            {
                MessageBox.Show("Account Not found");
            }
            reader.Close();
            sqlConnection1.Close();
        }
    }
}
