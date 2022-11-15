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
    public partial class Locations : UserControl
    {
        public Locations()
        {
            InitializeComponent();
            addLocationIdToComboBox();
        }
        
        // Action Methods
        private void addLocationIdToComboBox()
        {
            sqlConnection1.Open();
            SqlCommand cmd = sqlConnection1.CreateCommand();
            cmd.CommandText = "SELECT loc_id,loc_name FROM LOCATION";
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                comboBox_loc_id.Items.Add(rd["loc_id"] + " - " + rd["loc_name"]);
            }

            sqlConnection1.Close();
        }
        private void clearAllTextboxes()
        {
            textBox_loc_name.Clear();
            textBox_loc_address.Clear();
            textBox_loc_close_time.Clear();
            textBox_loc_open_time.Clear();
            textBox_loc_super_id.Clear();
            textBox_loc_phone_num.Clear();
            textBox_loc_id.Clear();
        }
        private string getLocationID()
        {
            // Authored By: Marcel Rico
            string locID = "";


            try
            {
                sqlConnection1.Open();
                SqlCommand cmd = sqlConnection1.CreateCommand();
                cmd.CommandText = "SELECT MAX(LOC_ID) FROM LOCATION";
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    if (DBNull.Value.Equals(dr[0]))
                    {
                        locID = "1";
                        Console.WriteLine(dr[0]);
                    }
                    else
                    {
                        locID = (int.Parse(dr[0].ToString()) + 1).ToString();
                    }

                }
                sqlConnection1.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return locID;
        }

        // Policy Methods
        private void editButtonEnabled(bool enable)
        {
            button_edit.Enabled = enable;
        }
        private void allTextboxesReadOnly(bool enable)
        {
            textBox_loc_name.ReadOnly = enable;
            textBox_loc_address.ReadOnly = enable;
            textBox_loc_open_time.ReadOnly = enable;
            textBox_loc_close_time.ReadOnly = enable;
            textBox_loc_phone_num.ReadOnly = enable;
            textBox_loc_super_id.ReadOnly = enable;
        }
        private void submitEditButtonIsVisible(bool enable)
        {
            button_submit_edit.Visible = enable;
            button_submit_edit.Enabled = enable;
        }
        private void submitCreateButtonIsVisible(bool enable)
        {
            button_submit_create.Enabled = enable;
            button_submit_create.Visible = enable;
        }
        private void cancelButtonIsEnabled(bool enable)
        {
            button_cancel.Enabled = enable;
        }


        // ============= Button Actions Below =============


        // Home Button
        private void button_home_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }


        // Create Buttons
        private void button_create_Click(object sender, EventArgs e)
        {
            clearAllTextboxes();
            allTextboxesReadOnly(false);
            submitCreateButtonIsVisible(true);
            cancelButtonIsEnabled(true);
            textBox_loc_id.Visible = true;
            textBox_loc_id.Text = getLocationID();
            textBox_loc_name.Focus();
        }

        private void button_submit_create_Click(object sender, EventArgs e)
        {
            // Edit Me Here
        }


        // Edit Buttons
        private void button_edit_Click(object sender, EventArgs e)
        {
            allTextboxesReadOnly(false);
            submitEditButtonIsVisible(true);
            cancelButtonIsEnabled(true);
        }
        private void button_submit_edit_Click(object sender, EventArgs e)
        {  
        }


        // Delete Button
        private void button_delete_Click(object sender, EventArgs e)
        {
        }

        // Cancel Button
        private void button_cancel_Click(object sender, EventArgs e)
        {
            clearAllTextboxes();
            allTextboxesReadOnly(true);
            cancelButtonIsEnabled(false);
            submitEditButtonIsVisible(false);
            editButtonEnabled(false);
            submitCreateButtonIsVisible(false);
            textBox_loc_id.Visible = false;
            comboBox_loc_id.Text = "";
            comboBox_loc_id.Focus();
        }

        private void comboBox_loc_id_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Enable Edit Option
            editButtonEnabled(true);

            sqlConnection1.Open();
            string loc_id = comboBox_loc_id.Text[0].ToString();

            SqlCommand cmd = sqlConnection1.CreateCommand();
            cmd.CommandText = @"SELECT * FROM LOCATION
                                WHERE loc_id = @loc_id";
            cmd.Parameters.AddWithValue("@loc_id",loc_id);
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                textBox_loc_name.Text = rd["LOC_NAME"].ToString();
                textBox_loc_phone_num.Text = rd["LOC_PHONE"].ToString();
                textBox_loc_super_id.Text = rd["LOC_SUPER_ID"].ToString();
                textBox_loc_address.Text = rd["LOC_ADDRESS"].ToString();
                textBox_loc_open_time.Text = rd["LOC_HOURS"].ToString().Substring(0, 8).Trim();
                textBox_loc_close_time.Text = rd["LOC_HOURS"].ToString().Substring(10).Trim();
            }

            sqlConnection1.Close();
        }
    }
}
