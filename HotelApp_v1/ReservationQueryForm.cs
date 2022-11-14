using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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

        // Toggle enabled status of components used in modes
        private void CreateMode(bool status)
        {
            emptyTextBoxes();
            changeButtonsEnabled(!status);
            showCancelButton(status);
            showCreateButton(!status);
            enableComboBoxes(status);
            btnGetPrice.Enabled = status;
        }
        private void EditMode(bool status)
        {
            emptyTextBoxes();
            changeButtonsEnabled(!status);
            showCancelButton(status);
            showEditButton(!status);
            enableComboBoxes(status);
            btnGetPrice.Enabled = status;
        }
        private void DeleteMode(bool status)
        {
            emptyTextBoxes();
            changeTextBoxesReadOnlyStatus(status);
            changeButtonsEnabled(!status);
            showCancelButton(status);
            showDeleteButton(!status);
            enableComboBoxes(!status);
            btnSearch.Enabled = !status;
            btnCancel2.Visible = status;
            btnCancel2.Enabled = status;
            cmbResID.Enabled = status;
            cmbResID.Visible = status;
            cmbResID.SelectedIndex = -1;
            txtLocNameDeletion.Visible = status;
            txtRoomNoDeletion.Visible = status;
            txtRoomTypeDeletion.Visible = status;
            btnGetPrice.Enabled = !status;
            FillReservationIDs();
        }
        private void FillReservationIDs()
        {
            cmbResID.Items.Clear();
            try
            {
                sqlConnection1.Open();
                SqlCommand getResIDs = sqlConnection1.CreateCommand();
                getResIDs.CommandText = @"SELECT RES_NO
                                          FROM RESERVATION";
                SqlDataReader reader = getResIDs.ExecuteReader();
                while (reader.Read())
                {
                    cmbResID.Items.Add(reader[0]);
                }
                sqlConnection1.Close();
                reader.Close();
                getResIDs.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Toggle enabled status of combo boxes
        private void enableComboBoxes(bool status)
        {
            cmbCustName.Enabled = status;
            cmbLocName.Enabled = status;
            cmbRoomNo.Enabled = status;
            cmbRoomType.Enabled = status;
            dtpResEnd.Enabled = status;
            dtpResStart.Enabled = status;
        }

        // Toggle button visibility
        private void showCreateButton(bool status)
        {
            btnCreate.Visible = status;
            btnSubmitCreate.Visible = !status;
            btnSubmitCreate.Enabled = !status;
        }
        private void showEditButton(bool status)
        {
            btnEdit.Visible = status;
            btnSubmitEdit.Visible = !status;
            btnSubmitEdit.Enabled = !status;
        }
        private void showDeleteButton(bool status)
        {
            btnDelete.Visible = status;
            btnSubmitDelete.Visible = !status;
            btnSubmitDelete.Enabled = !status;
        }

        // Toggle cancel button visibility
        private void showCancelButton(bool enable)
        {
            btnCancel.Enabled = enable;
            btnCancel.Visible = enable;
        }

        // Toggles read-only status of text boxes
        private void changeTextBoxesReadOnlyStatus(bool enable) 
        {
            dtpResStart.Enabled = !enable;
            dtpResEnd.Enabled = !enable;
        }

        // Clears text boxes
        private void emptyTextBoxes() 
        {
            txtPrice.Clear();
            txtResID.Clear();

        }

        // Toggle enabled status of buttons
        private void changeButtonsEnabled(bool status)
        {
            btnCreate.Enabled = status;
            btnEdit.Enabled = status;
            btnDelete.Enabled = status;
        }

        // Returns next available reservation ID
        private string getReservationID()
        {
            string resID = "";

            try
            {
                sqlConnection1.Open();

                SqlCommand cmdGetResID = sqlConnection1.CreateCommand();
                cmdGetResID.CommandText = @"SELECT MAX(RES_NO)
                                            FROM RESERVATION";
                SqlDataReader reader = cmdGetResID.ExecuteReader();
                while (reader.Read())
                {

                    if (DBNull.Value.Equals(reader[0]))
                    {
                        resID = "1";
                    }
                    else
                    {
                        resID = (int.Parse(reader[0].ToString())).ToString();
                    }
                }
                reader.Close();
                cmdGetResID.Dispose();
                sqlConnection1.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return resID;
        }

        // "Home" button clicked
        private void button_home_Click(object sender, EventArgs e)
        {
            emptyTextBoxes();
            changeButtonsEnabled(false);
            this.Visible = false;
        }

        // "Search" button clicked
        private void button_search_Click(object sender, EventArgs e)
        {
            if (dgvReservations.Visible == true)
            {
                FillReservationDataGrid();
            }
            else
            {
                dgvReservations.Visible = true;
                cmbCustName.Enabled = true;
                cmbLocName.Enabled = true;
                changeButtonsEnabled(false);
                showCancelButton(true);
                LoadCustomers();
                LoadLocations();
                FillReservationDataGrid();
            }
        }

        // Populate datagridview with reservations matching search criteria
        private void FillReservationDataGrid()
        {
            // Fill with no search parameters
            if (cmbCustName.SelectedIndex == -1 && cmbLocName.SelectedIndex == -1)
            {
                sqlConnection1.Open();

                SqlCommand cmdReservationSearch = sqlConnection1.CreateCommand();
                cmdReservationSearch.CommandText = @"SELECT RES_NO,
                                                            CUST_LNAME, 
                                                            LOC_NAME,
                                                            RES_ROOM_NO,
                                                            RES_START_DATE,
                                                            RES_END_DATE
                                                     FROM RESERVATION
                                                        JOIN CUSTOMER ON CUST_ID = RES_CUST_ID
                                                        JOIN LOCATION ON LOC_ID = RES_LOC_ID";
                SqlDataReader reader = cmdReservationSearch.ExecuteReader();
                DataTable reservations = new DataTable();
                reservations.Load(reader);
                dgvReservations.DataSource = reservations;
                dgvReservations.Columns[0].HeaderText = "Res. No.";
                dgvReservations.Columns[1].HeaderText = "Last Name";
                dgvReservations.Columns[2].HeaderText = "Location";
                dgvReservations.Columns[3].HeaderText = "Room No.";
                dgvReservations.Columns[4].HeaderText = "Check-In";
                dgvReservations.Columns[5].HeaderText = "Check-Out";
                dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                reader.Close();
                cmdReservationSearch.Dispose();
                sqlConnection1.Close();
            }
            // Search by location
            if (cmbCustName.SelectedIndex == -1 && cmbLocName.SelectedIndex > -1)
            {
                int location = Convert.ToInt32(GetLocationID(cmbLocName.Text));

                sqlConnection1.Open();

                SqlCommand cmdReservationSearch = sqlConnection1.CreateCommand();
                cmdReservationSearch.CommandText = @"SELECT CUST_LNAME, 
                                                            LOC_NAME,
                                                            RES_ROOM_NO,
                                                            RES_START_DATE,
                                                            RES_END_DATE
                                                     FROM RESERVATION
                                                        JOIN CUSTOMER ON CUST_ID = RES_CUST_ID
                                                        JOIN LOCATION ON LOC_ID = RES_LOC_ID
                                                     WHERE RES_LOC_ID = @search";
                cmdReservationSearch.Parameters.AddWithValue("@search", location);
                SqlDataReader reader = cmdReservationSearch.ExecuteReader();
                DataTable reservations = new DataTable();
                reservations.Load(reader);
                dgvReservations.DataSource = reservations;
                dgvReservations.Columns[0].HeaderText = "Last Name";
                dgvReservations.Columns[1].HeaderText = "Location";
                dgvReservations.Columns[2].HeaderText = "Room Number";
                dgvReservations.Columns[3].HeaderText = "Check-In Date";
                dgvReservations.Columns[4].HeaderText = "Check-Out Date";
                dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                reader.Close();
                cmdReservationSearch.Dispose();
                sqlConnection1.Close();
            }
            // Search by customer name
            if (cmbCustName.SelectedIndex > -1 && cmbLocName.SelectedIndex == -1)
            {
                string[] name = cmbCustName.Text.Split(' ');
                string custFname = name[0];
                string custLname = name[1];

                sqlConnection1.Open();

                SqlCommand cmdReservationSearch = sqlConnection1.CreateCommand();
                cmdReservationSearch.CommandText = @"SELECT CUST_LNAME, 
                                                            LOC_NAME,
                                                            RES_ROOM_NO,
                                                            RES_START_DATE,
                                                            RES_END_DATE
                                                     FROM RESERVATION
                                                        JOIN CUSTOMER ON CUST_ID = RES_CUST_ID
                                                        JOIN LOCATION ON LOC_ID = RES_LOC_ID
                                                     WHERE CUST_FNAME LIKE @search3
                                                     AND CUST_LNAME LIKE @search4";
                cmdReservationSearch.Parameters.AddWithValue("@search3", custFname);
                cmdReservationSearch.Parameters.AddWithValue("@search4", custLname);
                SqlDataReader reader = cmdReservationSearch.ExecuteReader();
                DataTable reservations = new DataTable();
                reservations.Load(reader);
                dgvReservations.DataSource = reservations;
                dgvReservations.Columns[0].HeaderText = "Last Name";
                dgvReservations.Columns[1].HeaderText = "Location";
                dgvReservations.Columns[2].HeaderText = "Room Number";
                dgvReservations.Columns[3].HeaderText = "Check-In Date";
                dgvReservations.Columns[4].HeaderText = "Check-Out Date";
                dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                reader.Close();
                cmdReservationSearch.Dispose();
                sqlConnection1.Close();
            }
            // Search by location and name
            if (cmbCustName.SelectedIndex > -1 && cmbLocName.SelectedIndex > -1)
            {
                string[] name = cmbCustName.Text.Split(' ');
                string custFname = name[0];
                string custLname = name[1];
                int location = Convert.ToInt32(GetLocationID(cmbLocName.Text));

                sqlConnection1.Open();

                SqlCommand cmdReservationSearch = sqlConnection1.CreateCommand();
                cmdReservationSearch.CommandText = @"SELECT CUST_LNAME, 
                                                            LOC_NAME,
                                                            RES_ROOM_NO,
                                                            RES_START_DATE,
                                                            RES_END_DATE
                                                     FROM RESERVATION
                                                        JOIN CUSTOMER ON CUST_ID = RES_CUST_ID
                                                        JOIN LOCATION ON LOC_ID = RES_LOC_ID
                                                     WHERE CUST_FNAME LIKE @search1
                                                     AND CUST_LNAME LIKE @search2
                                                     AND RES_LOC_ID = @search5";
                cmdReservationSearch.Parameters.AddWithValue("@search1", custFname);
                cmdReservationSearch.Parameters.AddWithValue("@search2", custLname);
                cmdReservationSearch.Parameters.AddWithValue("@search5", location);
                SqlDataReader reader = cmdReservationSearch.ExecuteReader();
                DataTable reservations = new DataTable();
                reservations.Load(reader);
                dgvReservations.DataSource = reservations;
                dgvReservations.Columns[0].HeaderText = "Last Name";
                dgvReservations.Columns[1].HeaderText = "Location";
                dgvReservations.Columns[2].HeaderText = "Room Number";
                dgvReservations.Columns[3].HeaderText = "Check-In Date";
                dgvReservations.Columns[4].HeaderText = "Check-Out Date";
                dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                reader.Close();
                cmdReservationSearch.Dispose();
                sqlConnection1.Close();

            }
        }

        // "Create" button clicked
        private void button_create_Click(object sender, EventArgs e)
        {
            CreateMode(true);
            
            btnSearch.Enabled = false;
            LoadRoomTypes();
            LoadCustomers();
            LoadLocations();
            cmbCustName.Focus();
        }

        // Populates rooms combo box based on location, dates, and room type selected
        private void LoadAvailableRooms()
        {
            cmbRoomNo.Items.Clear();

            int locationID = Convert.ToInt32(GetLocationID(cmbLocName.Text.Trim()));
            int roomType = Convert.ToInt32(GetRoomTypeCode(cmbRoomType.Text.Trim()));
            DateTime startDate = dtpResStart.Value;
            DateTime endDate = dtpResEnd.Value;
            string sqlFormatStartDate = startDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string sqlFormatEndDate = endDate.ToString("yyyy-MM-dd HH:mm:ss.fff");

            sqlConnection1.Open();

            SqlCommand cmdGetAvailableRooms = sqlConnection1.CreateCommand();
            cmdGetAvailableRooms.CommandText = @"SELECT ROOM_NO
                                                 FROM ROOM
                                                 WHERE ROOM_LOC = @search1
	                                                 AND ROOM_TYPE = @search2
	                                                 AND ROOM_NO NOT IN (SELECT RES_ROOM_NO
						                                                 FROM RESERVATION
						                                                 WHERE RES_START_DATE >= @search3
						                                                 AND RES_END_DATE <= @search4)";
            cmdGetAvailableRooms.Parameters.AddWithValue("@search1", locationID);
            cmdGetAvailableRooms.Parameters.AddWithValue("@search2", roomType);
            cmdGetAvailableRooms.Parameters.AddWithValue("@search3", sqlFormatStartDate);
            cmdGetAvailableRooms.Parameters.AddWithValue("@search4", sqlFormatEndDate);
            SqlDataReader reader = cmdGetAvailableRooms.ExecuteReader();

            while (reader.Read())
            {
                cmbRoomNo.Items.Add(reader[0]);
            }

            sqlConnection1.Close();
            reader.Close();
            cmdGetAvailableRooms.Dispose();
        }

        // Populates rooms combo box with available rooms
        private void LoadRoomTypes()
        {
            cmbRoomNo.Items.Clear();

            sqlConnection1.Open();

            SqlCommand cmdGetRoomTypes = sqlConnection1.CreateCommand();
            cmdGetRoomTypes.CommandText = @"SELECT TYPE_DESCRIPTION
                                            FROM ROOM_TYPE";
            SqlDataReader reader = cmdGetRoomTypes.ExecuteReader();

            while (reader.Read())
            {
                cmbRoomType.Items.Add(reader[0]);
            }

            reader.Close();
            sqlConnection1.Close();
            cmdGetRoomTypes.Dispose();
        }

        // Populates location combo box with available locations
        private void LoadLocations()
        {
            cmbLocName.Items.Clear();

            sqlConnection1.Open();

            SqlCommand cmdGetLocations = sqlConnection1.CreateCommand();
            cmdGetLocations.CommandText = @"SELECT LOC_NAME
                                                   FROM LOCATION";
            SqlDataReader reader = cmdGetLocations.ExecuteReader();

            while (reader.Read())
            {
                cmbLocName.Items.Add(reader[0].ToString());
            }

            sqlConnection1.Close();
            reader.Close();
            cmdGetLocations.Dispose();
        }

        // Fill customers combo box
        private void LoadCustomers()
        {
            cmbCustName.Items.Clear();
            sqlConnection1.Open();
            try
            {
                SqlCommand cmdFillCustomers = sqlConnection1.CreateCommand();
                cmdFillCustomers.CommandText = @"SELECT cust_lname,cust_fname 
                                             FROM CUSTOMER";
                SqlDataReader reader = cmdFillCustomers.ExecuteReader();
                while (reader.Read())
                {
                    cmbCustName.Items.Add(reader[0].ToString() + " " + reader[1].ToString());
                }
                reader.Close();
                cmdFillCustomers.Dispose();
            }
            catch (Exception ex)
            {
                sqlConnection1.Close();
                Console.WriteLine(ex.Message);
            }
            sqlConnection1.Close();
        }

        // "Submit create" button clicked
        private void button_submit_create_Click(object sender, EventArgs e)
        {
            showCreateButton(true);
            changeButtonsEnabled(true);
            btnSearch.Enabled = true;
            btnSubmitCreate.Enabled = false;
            showCancelButton(false);

            try
            {
                int cust_id = getCustID();
                int loc_id = Convert.ToInt32(GetLocationID(cmbLocName.Text.Trim()));
                int room_no = Convert.ToInt32(cmbRoomNo.Text);
                DateTime resStart = dtpResStart.Value;
                DateTime endDate = dtpResEnd.Value;

                // Perform insertion query
                sqlConnection1.Open();
                SqlCommand cmdInsertReservation = sqlConnection1.CreateCommand();
                cmdInsertReservation.CommandText = @"INSERT INTO RESERVATION 
                                                 (RES_CUST_ID,
                                                  RES_LOC_ID,
                                                  RES_ROOM_NO,
                                                  RES_START_DATE,   
                                                  RES_END_DATE)
                                                 VALUES(@search1, @search2, @search3, @search4, @search5)";
                cmdInsertReservation.Parameters.AddWithValue("@search1", cust_id);
                cmdInsertReservation.Parameters.AddWithValue("@search2", loc_id);
                cmdInsertReservation.Parameters.AddWithValue("@search3", room_no);
                cmdInsertReservation.Parameters.AddWithValue("@search4", resStart);
                cmdInsertReservation.Parameters.AddWithValue("@search5", endDate);

                cmdInsertReservation.ExecuteNonQuery();

                sqlConnection1.Close();
                cmdInsertReservation.Dispose();

                MessageBox.Show("Reservation created\n" + "Your reservation ID is " + getReservationID());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            emptyTextBoxes();
            clearComboBoxes();
        }

        // "Edit" button clicked
        private void button_edit_Click(object sender, EventArgs e)
        {
            EditMode(true);
            changeTextBoxesReadOnlyStatus(false); 
            changeButtonsEnabled(false);
            btnSubmitEdit.Enabled = true;
            btnSearch.Enabled = false; 
            showCancelButton(true);
        }

        // "Submit Edit" button clicked
        private void button_submit_edit_Click(object sender, EventArgs e)
        {
            EditMode(false);
            changeTextBoxesReadOnlyStatus(true); 
            changeButtonsEnabled(true);
            btnSubmitEdit.Enabled = false;
            btnSearch.Enabled = true; 
            showCancelButton(false);
        }

        // "Delete" button clicked
        private void button_delete_Click(object sender, EventArgs e)
        {            
            DeleteMode(true);
        }

        private void clearComboBoxes()
        {
            cmbCustName.Items.Clear();
            cmbLocName.Items.Clear();
            cmbRoomNo.Items.Clear();
            cmbRoomType.Items.Clear();

            cmbRoomType.SelectedIndex = -1;
            cmbCustName.SelectedIndex = -1;
            cmbLocName.SelectedIndex = -1;
            cmbRoomNo.SelectedIndex = -1;
        }

        // "Cancel" button clicked
        private void button_cancel_Click(object sender, EventArgs e)
        {
            changeButtonsEnabled(true); // delete this when above is filled out
            emptyTextBoxes();
            clearComboBoxes();            
            showCreateButton(true);
            showDeleteButton(true);
            showEditButton(true);
            showCancelButton(false);
            changeButtonsEnabled(true);
            enableComboBoxes(false);

            btnSearch.Enabled = true;
            dgvReservations.Visible = false;
        }
        private void btnCancel2_Click(object sender, EventArgs e)
        {
            changeButtonsEnabled(true); // delete this when above is filled out
            emptyTextBoxes();
            clearComboBoxes();
            showCreateButton(true);
            showDeleteButton(true);
            showEditButton(true);
            showCancelButton(false);
            changeButtonsEnabled(true);
            enableComboBoxes(false);
            btnCancel2.Visible = false;
            DeleteMode(false);

            btnSearch.Enabled = true;
            dgvReservations.Visible = false;
        }

        // Returns location ID from location name
        private int GetLocationID(string name)
        {
            sqlConnection1.Open();

            SqlCommand cmdGetSupName = sqlConnection1.CreateCommand();
            cmdGetSupName.CommandText = @"SELECT LOC_ID
                                          FROM LOCATION
                                          WHERE LOC_NAME = @search";

            cmdGetSupName.Parameters.AddWithValue("@search", name);
            SqlDataReader reader = cmdGetSupName.ExecuteReader();

            if (reader.Read())
            {
                int id = Convert.ToInt32(reader[0].ToString());
                sqlConnection1.Close();
                reader.Close();
                return id;
            }
            else
            {
                MessageBox.Show("Error fetching location ID");
                sqlConnection1.Close();
                reader.Close();
                return -1;
            }
        }

        // Returns room type code from type description
        private int GetRoomTypeCode(string typeDesc)
        {
            sqlConnection1.Open();

            SqlCommand cmdGetTypeCode = sqlConnection1.CreateCommand();
            cmdGetTypeCode.CommandText = @"SELECT TYPE_CODE
                                          FROM ROOM_TYPE
                                          WHERE TYPE_DESCRIPTION = @search";

            cmdGetTypeCode.Parameters.AddWithValue("@search", typeDesc);
            SqlDataReader reader = cmdGetTypeCode.ExecuteReader();

            try
            {
                if (reader.Read())
                {
                    int code = Convert.ToInt32(reader[0].ToString());
                    sqlConnection1.Close();
                    reader.Close();
                    return code;
                }
                else
                {
                    MessageBox.Show("Error fetching room type code");
                    sqlConnection1.Close();
                    reader.Close();
                    return -1;
                }
            }
            catch (Exception ex)
            {
                sqlConnection1.Close();
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        private void cmbRoomNo_MouseClick_1(object sender, MouseEventArgs e)
        {
            if ((cmbLocName.SelectedIndex == -1) || (cmbRoomType.SelectedIndex == -1))
            {
                MessageBox.Show("Please enter a location and room type to view available rooms");
            }
            else
            {
                LoadAvailableRooms();
            }
        }

        private void btnGetPrice_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpResStart.Value;
            DateTime endDate = dtpResEnd.Value;
            int stayLength = ((int) (endDate - startDate).TotalDays) +1;
            double price = GetRoomPrice();

            double priceOfStay = price * stayLength;

            txtPrice.Text = priceOfStay.ToString();
                
        }

        private double GetRoomPrice()
        {
            string type = cmbRoomType.Text.Trim();

            sqlConnection1.Open();
            SqlCommand cmdGetPrice = sqlConnection1.CreateCommand();
            cmdGetPrice.CommandText = @"SELECT TYPE_PRICE 
                                        FROM ROOM_TYPE
                                        WHERE TYPE_DESCRIPTION = @search";
            cmdGetPrice.Parameters.AddWithValue("@search", type);
            SqlDataReader reader = cmdGetPrice.ExecuteReader();

            if (reader.Read())
            {
                double price = Convert.ToDouble(reader[0]);
                sqlConnection1.Close();
                reader.Close();
                cmdGetPrice.Dispose();
                return price;
            }
            else
            {
                MessageBox.Show("Error retrieving type price");
                sqlConnection1.Close();
                reader.Close();
                cmdGetPrice.Dispose();
                return -1;
            }
        }

        private int getCustID()
        {
            string[] name = cmbCustName.Text.Split(' ');
            string custLname = name[0];
            string custFname = name[1];

            sqlConnection1.Open();
            SqlCommand cmdGetCustID = sqlConnection1.CreateCommand();
            cmdGetCustID.CommandText = @"SELECT CUST_ID
                                         FROM CUSTOMER
                                         WHERE CUST_FNAME = @search1
                                         AND CUST_LNAME = @search2";
            cmdGetCustID.Parameters.AddWithValue("@search1", custFname);
            cmdGetCustID.Parameters.AddWithValue("@search2", custLname);

            SqlDataReader reader = cmdGetCustID.ExecuteReader();

            if (reader.Read())
            {
                int custID = Convert.ToInt32(reader[0]);
                reader.Close();
                sqlConnection1.Close();
                cmdGetCustID.Dispose();
                return custID;
            }
            else
            {
                MessageBox.Show("Error retrieving customer ID");
                reader.Close();
                sqlConnection1.Close();
                cmdGetCustID.Dispose();
                return -1;
            }
        }

        private void btnSubmitDelete_Click(object sender, EventArgs e)
        {
            int res_id = Convert.ToInt32(cmbResID.Text);
            try
            {
                sqlConnection1.Open();
                SqlCommand cmdDeleteReservation = sqlConnection1.CreateCommand();
                cmdDeleteReservation.CommandText = @"DELETE FROM RESERVATION
                                                     WHERE RES_NO = @search";
                cmdDeleteReservation.Parameters.AddWithValue("@search", res_id);

                cmdDeleteReservation.ExecuteNonQuery();
                MessageBox.Show("Reservation cancelled");
                sqlConnection1.Close();
                cmdDeleteReservation.Dispose();
            }
            catch (Exception ex)
            {
                sqlConnection1.Close();
                MessageBox.Show(ex.Message + " in deletion submission");
            }
            sqlConnection1.Close();
            DeleteMode(false);
            clearComboBoxes();
            emptyTextBoxes();
            cmbResID.Items.Clear();
        }

        private void cmbResID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillOutForm();
        }

        private void FillOutForm()
        {
            if (cmbResID.SelectedIndex > -1)
            {
                int res_id = Convert.ToInt32(cmbResID.Text);
                try
                {
                    sqlConnection1.Open();
                    SqlCommand getInfo = sqlConnection1.CreateCommand();
                    getInfo.CommandText = @"SELECT RES_CUST_ID,
                                               RES_LOC_ID,
                                               RES_ROOM_NO,
                                               TYPE_DESCRIPTION,
                                               RES_START_DATE,
                                               RES_END_DATE
                                        FROM RESERVATION
                                            JOIN ROOM ON ROOM_NO = RES_ROOM_NO
                                            JOIN ROOM_TYPE ON ROOM_TYPE = TYPE_CODE
                                        WHERE RES_NO = @search";
                    getInfo.Parameters.AddWithValue("@search", res_id);

                    SqlDataReader reader = getInfo.ExecuteReader();
                    if (reader.Read())
                    {
                        txtRoomNoDeletion.Text = reader[2].ToString();
                        txtRoomTypeDeletion.Text = reader[3].ToString();
                        dtpResStart.Value = (DateTime)reader[4];
                        dtpResEnd.Value = (DateTime)reader[5];
                        int loc_id = Convert.ToInt32(reader[1]);
                        int cust_id = Convert.ToInt32(reader[0]);

                        sqlConnection1.Close();
                        reader.Close();
                        getInfo.Dispose();

                        txtLocNameDeletion.Text = GetLocName(loc_id).ToString(); ;
                        cmbCustName.Text = GetCustName(cust_id).ToString(); ;
                    }
                }
                catch (Exception ex)
                {
                    sqlConnection1.Close();
                    MessageBox.Show(ex.Message + " in fill out form");
                }
            }
        }
        private string GetCustName(int id)
        {
            try
            {
                sqlConnection1.Open();
                SqlCommand cmdGetName = sqlConnection1.CreateCommand();
                cmdGetName.CommandText = @"SELECT CUST_FNAME, CUST_LNAME
                                           FROM CUSTOMER    
                                           WHERE CUST_ID = @search";
                cmdGetName.Parameters.AddWithValue("@search", id);
                SqlDataReader reader = cmdGetName.ExecuteReader();
                if (reader.Read())
                {
                    string name = reader[0].ToString() + " " + reader[1].ToString();
                    reader.Close();
                    cmdGetName.Dispose();
                    sqlConnection1.Close();
                    return name;
                }
                else
                {
                    return "Error";
                }
            }
            catch (Exception ex)
            {
                sqlConnection1.Close();
                MessageBox.Show(ex.Message + " in retrieving customer name");
                return "Error";
            }
        }
        private string GetLocName(int id)
        {
            try
            {
                sqlConnection1.Open();
                SqlCommand cmdGetName = sqlConnection1.CreateCommand();
                cmdGetName.CommandText = @"SELECT LOC_NAME
                                           FROM LOCATION
                                           WHERE LOC_ID = @search";
                cmdGetName.Parameters.AddWithValue("@search", id);
                SqlDataReader reader = cmdGetName.ExecuteReader();
                if (reader.Read())
                {
                    string name = reader[0].ToString();
                    reader.Close();
                    cmdGetName.Dispose();
                    sqlConnection1.Close();
                    return name;
                }
                else
                {
                    return "Error";
                }
            }
            catch (Exception ex)
            {
                sqlConnection1.Close();
                MessageBox.Show(ex.Message + " in retrieving loaction name");
                return "Error";
            }
        }
    }
}
