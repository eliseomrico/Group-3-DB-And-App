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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelApp_v1
{
    public partial class Employees : UserControl
    {
        public Employees()
        {
            InitializeComponent();
        }

        ///////////////////////////////////////////////////////////////
        //                     GENERAL METHODS                       //
        ///////////////////////////////////////////////////////////////

        // Toggles read-only status of text boxes
        private void changeTextBoxesReadOnlyStatus(bool status)
        {
            txtEmpFname.ReadOnly = status;
            txtEmpLoc.ReadOnly = status;
            txtEmpSSN.ReadOnly = status;
            txtEmpSup.ReadOnly = status;
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
        private void showEditButton(bool status) 
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

        // Enables new supervisor checkbox
        private void EnableSuperCheckbox(bool status)
        {
            chkNewSuper.Enabled = status;
        }

        ///////////////////////////////////////////////////////////////
        //                          CREATE                           //
        ///////////////////////////////////////////////////////////////

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
            EnableSuperCheckbox(status);
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
            if (txtEmpFname.Text == "" || txtEmpLname.Text == "" || 
                cmbEmpLoc.SelectedIndex == -1 || cmbEmpTitle.SelectedIndex == -1 || 
                txtEmpSSN.Text == "" || cmbEmpSup.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
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

                MessageBox.Show("Employee Added", "Confirmation Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                CreateModeToggle(false);
                btnSubmitCreate.Enabled = false;
            }
        }

        ///////////////////////////////////////////////////////////////
        //                            EDIT                           //
        ///////////////////////////////////////////////////////////////

        // Toggle edit mode settings
        private void EditMode(bool status)
        {
            showEditButton(!status);
            changeTextBoxesReadOnlyStatus(!status);
            enableEditDeleteButtons(!status);
            btnSubmitEdit.Enabled = status;
            btnCreate.Enabled = !status;
            showCancelButton(status);
            showCmbFields(status);
            showTxtFields(!status);
            txtEmpFname.Visible = status;
            cmbEmpFname.Visible = !status;
            EnableSuperCheckbox(status);
        }

        // "Edit" button click
        private void button_edit_Click(object sender, EventArgs e)
        {
            EditMode(true);
            FillCmbFields();

            showCreateButton(true);
            txtEmpFname.Focus();

            txtEmpFname.Text = cmbEmpFname.Text;
            cmbEmpLoc.Text = txtEmpLoc.Text;
            cmbEmpSup.Text = txtEmpSup.Text;
            cmbEmpTitle.Text = txtEmpTitle.Text;
        }

        // "Submit Edit" button click
        private void button_submit_edit_Click(object sender, EventArgs e)
        {
            int ssn, location, title, supervisor, id;

            location = GetLocationID(cmbEmpLoc.Text);
            // if (location == -1) { }
            title = GetTitleCode(cmbEmpTitle.Text);
            // if (title == -1) { }
            ssn = Convert.ToInt32(txtEmpSSN.Text);
            id = Convert.ToInt32(txtHiddenID.Text);

            sqlConnection1.Open();
            SqlCommand cmdUpdateUser = sqlConnection1.CreateCommand();

            if (cmbEmpSup.Text.Length > 1)
            {
                cmdUpdateUser.CommandText = @"UPDATE EMPLOYEE
                                          SET EMP_FNAME = @bind1,
                                              EMP_LNAME = @bind2,
                                              EMP_LOC_ID = @bind3,
                                              EMP_TITLE = @bind4,
                                              SUPER_ID = @bind5,
                                              EMP_SSN = @bind6
                                          WHERE EMP_ID = @bind7";
            }
            else
            {
                cmdUpdateUser.CommandText = @"UPDATE EMPLOYEE
                                          SET EMP_FNAME = @bind1,
                                              EMP_LNAME = @bind2,
                                              EMP_LOC_ID = @bind3,
                                              EMP_TITLE = @bind4,
                                              EMP_SSN = @bind6
                                          WHERE EMP_ID = @bind7";
            }

            cmdUpdateUser.Parameters.AddWithValue("@bind1", txtEmpFname.Text);
            cmdUpdateUser.Parameters.AddWithValue("@bind2", txtEmpLname.Text);
            cmdUpdateUser.Parameters.AddWithValue("@bind3", location);
            cmdUpdateUser.Parameters.AddWithValue("@bind4", title);
            if (cmbEmpSup.Text.Length > 1)
            {
                string[] sup_name = cmbEmpSup.Text.Split(' ');
                supervisor = GetSupervisorID(sup_name[0], sup_name[1]);
                cmdUpdateUser.Parameters.AddWithValue("@bind5", supervisor);
            }
            cmdUpdateUser.Parameters.AddWithValue("@bind6", ssn);
            cmdUpdateUser.Parameters.AddWithValue("@bind7", id);

            cmdUpdateUser.ExecuteNonQuery();

            sqlConnection1.Close();

            MessageBox.Show("Employee Updated", "Confirmation Message", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            EditMode(false);
            showCreateButton(true);

            clearTextBoxes();
            clearCmbBoxes();
        }

        ///////////////////////////////////////////////////////////////
        //                          DELETE                           //
        ///////////////////////////////////////////////////////////////

        // "Delete" button click
        private void button_delete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this employee?", 
                                                "Employee Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                sqlConnection2.Open();

                SqlCommand cmdIsSupervisor = sqlConnection2.CreateCommand();
                cmdIsSupervisor.CommandText = @"SELECT a.EMP_ID
                                               FROM EMPLOYEE a
                                               WHERE a.EMP_ID IN (SELECT b.SUPER_ID
                                                                  FROM EMPLOYEE b)
                                               AND a.EMP_ID = @search1";
                cmdIsSupervisor.Parameters.AddWithValue("@search1", Convert.ToInt32(txtHiddenID.Text));
                SqlDataReader reader = cmdIsSupervisor.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Cannot delete a supervisor", "Informational Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmdIsSupervisor.Dispose();
                    reader.Close();
                    sqlConnection2.Close();
                }
                else
                {
                    sqlConnection1.Open();

                    // If not a supervisor, continue with deletion

                    SqlCommand cmdDeleteUser = sqlConnection1.CreateCommand();
                    cmdDeleteUser.CommandText = @"DELETE FROM EMPLOYEE
                                          WHERE EMP_SSN = @search";
                    cmdDeleteUser.Parameters.AddWithValue("@search", Convert.ToInt32(txtEmpSSN.Text));
                    cmdDeleteUser.ExecuteNonQuery();

                    sqlConnection1.Close();
                    sqlConnection2.Close();

                    MessageBox.Show("User deleted", "Confirmation Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clearTextBoxes();
                    enableEditDeleteButtons(false);
                    changeTextBoxesReadOnlyStatus(true);

                    cmbEmpFname.Items.RemoveAt(cmbEmpFname.SelectedIndex);
                    cmbEmpFname.SelectedIndex = -1;
                }
            }
            else
            {
                // Do nothing
            }
        }


        ///////////////////////////////////////////////////////////////
        //                       GET METHODS                         //
        ///////////////////////////////////////////////////////////////

        // Get location name from ID
        private string GetLocationName(int id)
        {
            sqlConnection2.Open();

            SqlCommand cmdGetSupName = sqlConnection2.CreateCommand();
            cmdGetSupName.CommandText = @"SELECT LOC_NAME
                                          FROM LOCATION
                                          WHERE LOC_ID = @search";

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
                MessageBox.Show("Error fetching location name", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConnection2.Close();
                reader.Close();
                return null;
            }
        }

        // Get location ID from name
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
                MessageBox.Show("Error fetching location ID", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConnection2.Close();
                reader.Close();
                return -1;
            }
        }

        // Get supervisoe Name from ID
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
                MessageBox.Show("Error fetching supervisor name", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConnection2.Close();
                reader.Close();
                return null;
            }
        }

        // Get supervisor ID from name
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
                MessageBox.Show("Error fetching supervisor ID", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConnection2.Close();
                reader.Close();
                return -1;
            }
        }

        // Get employee title text from code
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

        // Get title code from title text
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

        ///////////////////////////////////////////////////////////////
        //                      FILL METHODS                         //
        ///////////////////////////////////////////////////////////////

        // Fill employee by typing
        private void FillEmployees()
        {
            if (cmbEmpFname.Items.Count > 1)
            {
                // Do nothing
            }
            else
            {

                sqlConnection1.Open();

                SqlCommand cmdEmpSearch = sqlConnection1.CreateCommand();
                cmdEmpSearch.CommandText = @"SELECT EMP_FNAME
                                         FROM EMPLOYEE
                                         ORDER BY EMP_FNAME";

                SqlDataReader reader = cmdEmpSearch.ExecuteReader();

                while (reader.Read())
                {
                    cmbEmpFname.Items.Add(reader[0].ToString());
                }

                reader.Close();
                sqlConnection1.Close();
            }
        }

        // Populate combo boxes used in create/edit with available options in DB
        private void FillCmbFields()
        {
            // Fill Locations
            FillLocations();

            // Supervisors
            FillSupervisors();

            // Job Titles
            FillJobTitles();
        }
        
        // Populate locations dropdown
        private void FillLocations()
        {
            cmbEmpLoc.Items.Clear();

            sqlConnection2.Open();

            SqlCommand cmdFillLocations = sqlConnection2.CreateCommand();
            cmdFillLocations.CommandText = @"SELECT LOC_NAME
                                             FROM LOCATION";
            SqlDataReader reader = cmdFillLocations.ExecuteReader();

            while (reader.Read())
            {
                cmbEmpLoc.Items.Add(reader[0].ToString());
            }

            sqlConnection2.Close();
            reader.Close();
            cmdFillLocations.Dispose();
        }

        // Populate supervisors dropdown
        private void FillSupervisors()
        {
            cmbEmpSup.Items.Clear();

            sqlConnection2.Open();

            if (chkNewSuper.Checked == false)
            {
                SqlCommand cmdFillSupervisors = sqlConnection2.CreateCommand();
                cmdFillSupervisors.CommandText = @"SELECT a.EMP_FNAME, a.EMP_LNAME
                                               FROM EMPLOYEE a
                                               WHERE a.EMP_ID IN (SELECT b.SUPER_ID
                                                                  FROM EMPLOYEE b)";
                SqlDataReader reader = cmdFillSupervisors.ExecuteReader();

                while (reader.Read())
                {
                    cmbEmpSup.Items.Add(reader[0].ToString() + " " + reader[1].ToString());
                }

                reader.Close();
                cmdFillSupervisors.Dispose();
            }
            else // New supervisor is checked
            {
                SqlCommand cmdFillSupervisors = sqlConnection2.CreateCommand();
                cmdFillSupervisors.CommandText = @"SELECT EMP_FNAME, EMP_LNAME
                                                   FROM EMPLOYEE";
                SqlDataReader reader = cmdFillSupervisors.ExecuteReader();

                while (reader.Read())
                {
                    cmbEmpSup.Items.Add(reader[0].ToString() + " " + reader[1].ToString());
                }

                reader.Close();
                cmdFillSupervisors.Dispose();
            }

            sqlConnection2.Close();
        }

        // Populate job title dropdown
        private void FillJobTitles()
        {
            cmbEmpTitle.Items.Clear();

            for (int i = 10; i <= 40; i += 10)
            {
                cmbEmpTitle.Items.Add(GetEmployeeTitle(i));
            }
        }

        ///////////////////////////////////////////////////////////////
        //                           CLICKS                          //
        ///////////////////////////////////////////////////////////////

        // Fill employees upon opening employee dropdown
        private void cmbEmpFname_Click(object sender, EventArgs e)
        {
            FillEmployees();
        }

        // Refresh supervisors list when checkbox is checked
        private void chkNewSuper_Click(object sender, EventArgs e)
        {
            FillSupervisors();
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
                txtEmpLoc.Text = GetLocationName(Convert.ToInt32(reader[4].ToString()));
                txtEmpSSN.Text = reader[6].ToString();

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

            showCancelButton(true);
        }

        // SSN validation
        private void txtEmpSSN_Leave(object sender, EventArgs e)
        {
            if (txtEmpSSN.Text.Length < 9)
            {
                MessageBox.Show("Please enter a full SSN", "Informational Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmpSSN.Focus();
            }
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
            changeTextBoxesReadOnlyStatus(true);
            showEditButton(true);
            showTxtFields(true);
            showCmbFields(false);
            btnSubmitEdit.Enabled = false;
            btnSubmitCreate.Enabled = false;
            txtEmpFname.Visible = false;
            cmbEmpFname.Visible = true;
            showCreateButton(true);
            btnCreate.Enabled = true;
            cmbEmpFname.SelectedIndex = -1;
            txtEmpFname.Text = "";
            showCancelButton(false);
            enableEditDeleteButtons(false);

        }
    }
}
