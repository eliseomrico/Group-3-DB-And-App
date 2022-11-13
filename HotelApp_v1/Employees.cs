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
using System.Xml.Linq;

namespace HotelApp_v1
{
    public partial class Employees : UserControl
    {
        public Employees()
        {
            InitializeComponent();
        }

        // Toggles read-only status of text boxes
        private void changeTextBoxesReadOnlyStatus(bool status)
        {
            txtEmpFname.ReadOnly = status;
            txtEmpLoc.ReadOnly = status;
            txtEmpSSN.ReadOnly = status;
            txtEmpSup.ReadOnly = status;
            txtSearchBox.ReadOnly = !status;
            txtEmpLname.ReadOnly = status;
            txtEmpTitle.ReadOnly = status;
        }

        // Clears text from text boxes
        private void clearTextBoxes() 
        {
            txtEmpLoc.Clear();
            txtEmpFname.Clear();
            txtEmpSSN.Clear();
            txtEmpSup.Clear();
            txtEmpLname.Clear();
            txtEmpTitle.Clear();
        }

        // Clears text from text boxes
        private void clearCmbBoxes()
        {
            cmbEmpLoc.Items.Clear();
            cmbEmpSup.Items.Clear();
            cmbEmpTitle.Items.Clear();
            cmbEmpFname.Items.Clear();

            cmbEmpFname.SelectedIndex = -1;
            cmbEmpLoc.SelectedIndex = -1;
            cmbEmpSup.SelectedIndex = -1;
            cmbEmpTitle.SelectedIndex = -1;
        }

        // Show/Hide Button Functions
        private void showEditButton(bool status) // after search is clicked, show edit and delete buttons
        {
            btnEdit.Visible       = status;
            btnSubmitEdit.Visible = !status;
        }
        private void showCreateButton(bool status)
        {
            btnCreate.Visible       = status;
            btnSubmitCreate.Visible = !status;
            btnSubmitCreate.Enabled = !status;
        }
        private void showCancelButton(bool status)
        {
            btnCancel.Enabled = status;
            btnCancel.Visible = status;
        }

        // Switch to text fields for displaying info. about an employee
        private void showTxtFields(bool status)
        {
            txtEmpFname.Visible = status;
            txtEmpLoc.Visible   = status;
            txtEmpTitle.Visible = status;
            txtEmpSup.Visible   = status;
        }

        // Switch to showing combo boxes for adding/editing an employee
        private void showCmbFields(bool status)
        {
            cmbEmpFname.Visible = status;
            cmbEmpLoc.Visible   = status;
            cmbEmpTitle.Visible = status;
            cmbEmpSup.Visible   = status;
        }

        // Toggle enabled state of "Edit"/"Delete" buttons
        private void enableEditDeleteButtons(bool status)
        {
            btnEdit.Enabled = status;
            btnDelete.Enabled = status;
        }

        // "Home" button click 
        private void button_home_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
            clearCmbBoxes();
            enableEditDeleteButtons(false);
            this.Visible = false;
        }

        // "Cancel" button click
        private void button_cancel_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
            enableEditDeleteButtons(false);
            changeTextBoxesReadOnlyStatus(true);
            showEditButton(true);
            showCreateButton(true);
            showCancelButton(false);
            showTxtFields(true);
            showCmbFields(false);
            btnSubmitEdit.Enabled = false;
            btnSubmitCreate.Enabled = false;
            txtEmpFname.Visible = false;
            txtSearchBox.Enabled = true;
            cmbEmpFname.Visible = true;
            btnSearch.Enabled = true;
            txtSearchBox.Focus();
        }

        ///////////
        // Create functions
        ///////////

        // Prep the form for creating/stopping creating
        private void CreateModeToggle(bool status)
        {
            clearTextBoxes();
            clearCmbBoxes();
            showCreateButton(!status);
            showCancelButton(status);
            showTxtFields(!status);
            showCmbFields(status);
            txtEmpFname.Visible = status;
            cmbEmpFname.Visible = !status;
            changeTextBoxesReadOnlyStatus(!status);
            txtSearchBox.Enabled = !status;
            btnSearch.Enabled = !status;
        }

        // "Create" button click  
        private void button_create_Click(object sender, EventArgs e)
        {
            CreateModeToggle(true);
            cmbEmpFname.SelectedIndex = -1;
            enableEditDeleteButtons(false);
            txtEmpFname.Focus();
            FillCmbFields();
        }

        // "Submit Create" button click
        private void button_submit_create_Click(object sender, EventArgs e)
        {
            string[] sup_name = cmbEmpSup.Text.Split(' ');
            int location = GetLocationID(cmbEmpLoc.Text);
                // if (location == -1) { }
            int title = GetTitleCode(cmbEmpTitle.Text);
                // if (title == -1) { }
            int ssn = Convert.ToInt32(txtEmpSSN.Text);
            int supervisor = GetSupervisorID(sup_name[0], sup_name[1]);

            sqlConnection1.Open();
            SqlCommand cmdInsertUser = sqlConnection1.CreateCommand();
            cmdInsertUser.CommandText = @"INSERT INTO EMPLOYEE
                                          (EMP_FNAME,
                                           EMP_LNAME,
                                           EMP_LOC_ID,
                                           EMP_TITLE,
                                           SUPER_ID,
                                           EMP_SSN)
                                           VALUES(@bind1, @bind2, @bind3, @bind4, @bind5, @bind6)";

            cmdInsertUser.Parameters.AddWithValue("@bind1", txtEmpFname.Text);
            cmdInsertUser.Parameters.AddWithValue("@bind2", txtEmpLname.Text);
            cmdInsertUser.Parameters.AddWithValue("@bind3", location);
            cmdInsertUser.Parameters.AddWithValue("@bind4", title);
            cmdInsertUser.Parameters.AddWithValue("@bind5", supervisor);
            cmdInsertUser.Parameters.AddWithValue("@bind6", ssn);

            cmdInsertUser.ExecuteNonQuery();
            cmdInsertUser.Dispose();

            sqlConnection1.Close();

            MessageBox.Show("Employee Added");

            CreateModeToggle(false);
            btnSubmitCreate.Enabled = false;
            txtSearchBox.Focus();
        }

        ///////////
        // Edit functions
        ///////////
        
        // "Edit" button click
        private void button_edit_Click(object sender, EventArgs e)
        {
            showEditButton(false);
            changeTextBoxesReadOnlyStatus(false); 
            enableEditDeleteButtons(false);
            showCancelButton(true);
            showTxtFields(false);
            showCmbFields(true);
            btnSubmitEdit.Enabled = true;
            txtEmpFname.Visible = true;
            cmbEmpFname.Visible = false;
            txtEmpFname.Focus();

            txtEmpFname.Text = cmbEmpFname.Text;
            cmbEmpLoc.Text = txtEmpLoc.Text;
            cmbEmpSup.Text = txtEmpSup.Text;
            cmbEmpTitle.Text = txtEmpTitle.Text;

            FillCmbFields();
        }

        // "Submit Edit" button click
        private void button_submit_edit_Click(object sender, EventArgs e)
        {
            int ssn, location, title, supervisor, id;
            string[] sup_name = cmbEmpSup.Text.Split(' ');

            location = GetLocationID(cmbEmpLoc.Text);
            // if (location == -1) { }
            title = GetTitleCode(cmbEmpTitle.Text);
            // if (title == -1) { }
            ssn = Convert.ToInt32(txtEmpSSN.Text);
            supervisor = GetSupervisorID(sup_name[0], sup_name[1]);
            id = Convert.ToInt32(txtHiddenID.Text);

            sqlConnection1.Open();

            SqlCommand cmdUpdateUser = sqlConnection1.CreateCommand();
            cmdUpdateUser.CommandText = @"UPDATE EMPLOYEE
                                          SET EMP_FNAME = @bind1,
                                              EMP_LNAME = @bind2,
                                              EMP_LOC_ID = @bind3,
                                              EMP_TITLE = @bind4,
                                              SUPER_ID = @bind5,
                                              EMP_SSN = @bind6
                                          WHERE EMP_ID = @bind7";

            cmdUpdateUser.Parameters.AddWithValue("@bind1", txtEmpFname.Text);
            cmdUpdateUser.Parameters.AddWithValue("@bind2", txtEmpLname.Text);
            cmdUpdateUser.Parameters.AddWithValue("@bind3", location);
            cmdUpdateUser.Parameters.AddWithValue("@bind4", title);
            cmdUpdateUser.Parameters.AddWithValue("@bind5", supervisor);
            cmdUpdateUser.Parameters.AddWithValue("@bind6", ssn);
            cmdUpdateUser.Parameters.AddWithValue("@bind7", id);

            cmdUpdateUser.ExecuteNonQuery();

            sqlConnection1.Close();

            MessageBox.Show("Employee Updated");

            showEditButton(true);
            changeTextBoxesReadOnlyStatus(true); 
            enableEditDeleteButtons(true);
            btnSubmitEdit.Enabled = false;
            showCancelButton(false);
            showCmbFields(false);
            showTxtFields(true);
            txtEmpFname.Visible = false;
            cmbEmpFname.Visible = true;
            clearTextBoxes();
            clearCmbBoxes();

            // RefreshTextBoxes();
        }

        ///////////
        // Delete function
        ///////////

        // "Delete" button click
        private void button_delete_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();

            SqlCommand cmdDeleteUser = sqlConnection1.CreateCommand();
            cmdDeleteUser.CommandText = @"DELETE FROM EMPLOYEE
                                          WHERE EMP_SSN = @search";
            cmdDeleteUser.Parameters.AddWithValue("@search", Convert.ToInt32(txtEmpSSN.Text));
            cmdDeleteUser.ExecuteNonQuery();

            sqlConnection1.Close();

            MessageBox.Show("User deleted");
            
            clearTextBoxes();
            enableEditDeleteButtons(false); 
            changeTextBoxesReadOnlyStatus(true);

            cmbEmpFname.Items.RemoveAt(cmbEmpFname.SelectedIndex);
            cmbEmpFname.SelectedIndex = -1;
        }

        ///////////
        // Search functions
        ///////////

        // "Search" button click - Populates "First Name" combo box based on search criteria from search box
        private void btnSearch_MouseClick_1(object sender, MouseEventArgs e)
        {
            // Empty combo box and revert selected index
            cmbEmpFname.SelectedIndex = -1;
            cmbEmpFname.Items.Clear();

            // Clear all text boxes and enable lower menu
            clearTextBoxes();

            sqlConnection1.Open();

            SqlCommand cmdEmpSearch = sqlConnection1.CreateCommand();
            cmdEmpSearch.CommandText = @"SELECT EMP_FNAME
                                         FROM EMPLOYEE
                                         WHERE EMP_FNAME LIKE @search";

            cmdEmpSearch.Parameters.AddWithValue("@search", "%" + txtSearchBox.Text + "%");
            SqlDataReader reader = cmdEmpSearch.ExecuteReader();

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

        // "First Name" combo box selection - Populates all fields on employee form based on selection
        private void cmbEmpFname_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            clearTextBoxes();

            enableEditDeleteButtons(true);

            SqlCommand cmdGetEmpInfo = sqlConnection1.CreateCommand();
            cmdGetEmpInfo.CommandText = @"SELECT * 
                                          FROM EMPLOYEE 
                                          WHERE EMP_FNAME = @search";
            cmdGetEmpInfo.Parameters.AddWithValue("@search", cmbEmpFname.Text);
            SqlDataReader reader = cmdGetEmpInfo.ExecuteReader();

            if (reader.Read())
            {
                txtHiddenID.Text = reader[0].ToString();
                txtEmpLname.Text = reader[2].ToString();
                txtEmpTitle.Text = GetEmployeeTitle(Convert.ToInt32(reader[3].ToString()));
                txtEmpLoc.Text   = GetLocationName(Convert.ToInt32(reader[4].ToString()));
                txtEmpSSN.Text   = reader[6].ToString();

                if (!reader.IsDBNull(5))
                {
                    txtEmpSup.Text = GetSupervisorName(Convert.ToInt32(reader[5].ToString()));
                }
                else
                {
                    txtEmpSup.Text = "N/A";
                }
            }
   
            reader.Close();
            sqlConnection1.Close();
        }

        ///////////////////////////////////// General Methods /////////////////////////////////////

        private string GetLocationName(int id)
        {
            sqlConnection2.Open();

            SqlCommand cmdGetSupName = sqlConnection2.CreateCommand();
            cmdGetSupName.CommandText = @"SELECT LOC_NAME
                                          FROM LOCATION
                                            JOIN EMPLOYEE ON LOC_ID = EMP_LOC_ID
                                          WHERE EMP_ID = @search";

            cmdGetSupName.Parameters.AddWithValue("@search", id);
            SqlDataReader reader = cmdGetSupName.ExecuteReader();

            if (reader.Read())
            {
                string name = reader[0].ToString();
                sqlConnection2.Close();
                reader.Close();
                return name;
            }
            else
            {
                MessageBox.Show("Error fetching location name");
                sqlConnection2.Close();
                reader.Close();
                return null;
            }
        }

        private int GetLocationID(string name)
        {
            sqlConnection2.Open();

            SqlCommand cmdGetSupName = sqlConnection2.CreateCommand();
            cmdGetSupName.CommandText = @"SELECT LOC_ID
                                          FROM LOCATION
                                          WHERE LOC_NAME = @search";

            cmdGetSupName.Parameters.AddWithValue("@search", name);
            SqlDataReader reader = cmdGetSupName.ExecuteReader();

            if (reader.Read())
            {
                int id = Convert.ToInt32(reader[0].ToString());
                sqlConnection2.Close();
                reader.Close();
                return id;
            }
            else
            {
                MessageBox.Show("Error fetching location ID");
                sqlConnection2.Close();
                reader.Close();
                return -1;
            }
        }

        private string GetSupervisorName(int id)
        {
            sqlConnection2.Open();

            SqlCommand cmdGetSupName = sqlConnection2.CreateCommand();
            cmdGetSupName.CommandText = @"SELECT EMP_FNAME, EMP_LNAME
                                          FROM EMPLOYEE
                                          WHERE EMP_ID = @search";

            cmdGetSupName.Parameters.AddWithValue("@search", id);
            SqlDataReader reader = cmdGetSupName.ExecuteReader();

            if (reader.Read())
            {
                string name = reader[0].ToString() + " " + reader[1].ToString();
                sqlConnection2.Close();
                reader.Close();
                return name;
            }
            else
            {
                MessageBox.Show("Error fetching supervisor name");
                sqlConnection2.Close();
                reader.Close();
                return null;
            }
        }

        private int GetSupervisorID(string fname, string lname)
        {
            sqlConnection2.Open();

            SqlCommand cmdGetSupID = sqlConnection2.CreateCommand();
            cmdGetSupID.CommandText = @"SELECT EMP_ID
                                        FROM EMPLOYEE
                                        WHERE EMP_FNAME = @search1
                                        AND EMP_LNAME = @search2";

            cmdGetSupID.Parameters.AddWithValue("@search1", fname);
            cmdGetSupID.Parameters.AddWithValue("@search2", lname);
            SqlDataReader reader = cmdGetSupID.ExecuteReader();

            if (reader.Read())
            {
                int id = Convert.ToInt32(reader[0].ToString());
                sqlConnection2.Close();
                reader.Close();
                return id;
            }
            else
            {
                MessageBox.Show("Error fetching supervisor ID");
                sqlConnection2.Close();
                reader.Close();
                return -1;
            }
        }

        private string GetEmployeeTitle(int id)
        {
            switch (id)
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

        private int GetTitleCode(string title)
        {
            switch (title)
            {
                case "Front Desk":
                    return 10;
                case "Housekeeper":
                    return 20;
                case "Manager":
                    return 30;
                case "System Administrator":
                    return 40;
                default:
                    return -1;
            }
        }

        // Populate combo boxes used in create/edit with available options in DB
        private void FillCmbFields()
        {
            cmbEmpLoc.Items.Clear();
            cmbEmpSup.Items.Clear();
            cmbEmpTitle.Items.Clear();

            // Locations
            sqlConnection2.Open();

            SqlCommand cmdFillLocations = sqlConnection2.CreateCommand();
            cmdFillLocations.CommandText = @"SELECT LOC_NAME
                                             FROM LOCATION";
            SqlDataReader reader = cmdFillLocations.ExecuteReader();

            while (reader.Read())
            {
                cmbEmpLoc.Items.Add(reader[0].ToString());
            }          
            reader.Close();

            // Supervisors

            // int sup_id = Convert.ToInt32(txtHiddenID.Text);

            SqlCommand cmdFillSupervisors = sqlConnection2.CreateCommand();
            cmdFillSupervisors.CommandText = @"SELECT a.EMP_FNAME, a.EMP_LNAME
                                               FROM EMPLOYEE a
                                               WHERE a.EMP_ID IN (SELECT b.SUPER_ID
                                                                  FROM EMPLOYEE b)";
                                               // AND EMP_ID != @search";
            // cmdFillSupervisors.Parameters.AddWithValue("@search", sup_id);

            SqlDataReader reader2 = cmdFillSupervisors.ExecuteReader();

            while (reader2.Read())
            {
                cmbEmpSup.Items.Add(reader2[0].ToString() + " " + reader2[1].ToString());
            }

            // Titles
            for (int i = 10; i <= 40; i+=10)
            {
                cmbEmpTitle.Items.Add(GetEmployeeTitle(i));
            }

            sqlConnection2.Close();
            reader2.Close();
        }

        //private void RefreshTextBoxes()
        //{
        //    sqlConnection2.Open();
        //    clearTextBoxes();
        //    enableEditDeleteButtons(true);

        //    int id = Convert.ToInt32(txtHiddenID.Text);

        //    SqlCommand cmdRefreshInfo = sqlConnection2.CreateCommand();
        //    cmdRefreshInfo.CommandText = @"SELECT * 
        //                                  FROM EMPLOYEE 
        //                                  WHERE EMP_FNAME = @search";
        //    cmdRefreshInfo.Parameters.AddWithValue("@search", id);
        //    SqlDataReader reader = cmdRefreshInfo.ExecuteReader();

        //    if (reader.Read())
        //    {
        //        txtHiddenID.Text = reader[0].ToString();
        //        txtEmpLname.Text = reader[2].ToString();
        //        txtEmpTitle.Text = GetEmployeeTitle(Convert.ToInt32(reader[3].ToString()));
        //        txtEmpLoc.Text = GetLocationName(Convert.ToInt32(reader[4].ToString()));
        //        txtEmpSSN.Text = reader[6].ToString();

        //        if (!reader.IsDBNull(5))
        //        {
        //            txtEmpSup.Text = GetSupervisorName(Convert.ToInt32(reader[5].ToString()));
        //        }
        //        else
        //        {
        //            txtEmpSup.Text = "N/A";
        //        }
        //    }

        //    reader.Close();
        //    sqlConnection2.Close();
        //}
    }
}
