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
    public partial class Rooms : UserControl
    {
        public Rooms()
        {
            InitializeComponent();
            AddRoomComboBoxItems();
        }
        private void AddRoomComboBoxItems()
        {
            comboBox_loc_id.Items.Clear();
            sqlConnection1.Open();

            SqlCommand cmd = sqlConnection1.CreateCommand();
            cmd.CommandText = "SELECT * FROM LOCATION";
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                comboBox_loc_id.Items.Add(rd["LOC_ID"] + " - " + rd["LOC_NAME"]);
            }

            sqlConnection1.Close();
        }
        private void textBoxesAreReadOnly(bool enable)
        {
            textBox_room_type.ReadOnly = enable;
            textBox_room_price.ReadOnly = enable;
            textBox_room_available.ReadOnly = enable;
            textBox_room_type_description.ReadOnly = enable;
        }
        private void cancelButtonVisible(bool enable)
        {
            button_cancel.Enabled = enable;
            button_cancel.Visible = enable;
        }
        private void submitCreateButtonVisible(bool enable)
        {
            button_submit_create.Enabled = enable;
            button_submit_create.Visible = enable;
        }
        private void changeEditButtonsVisibility(bool enable)
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
            textBox_room_type.ReadOnly = enable;
            textBox_room_type_description.ReadOnly = enable;
            textBox_room_price.ReadOnly = enable;
            textBox_room_available.ReadOnly = enable;
        }
        private void clearAllTextBoxes() // clears text from text boxes
        {
            comboBox_room_num.Text = "";
            comboBox_loc_id.Text = "";
            textBox_room_type.Clear();
            textBox_room_type_description.Clear();
            textBox_room_price.Clear();
            textBox_room_available.Clear();
            textBox_room_no.Clear();
        }
        private void changeButtonsEnabled(bool enable)
        {
            button_create.Enabled = enable;
            button_edit.Enabled = enable;
            button_delete.Enabled = enable;
        }


        // Room Navigation Buttons
        private void button_home_Click(object sender, EventArgs e)
        {
            clearAllTextBoxes();
            changeButtonsEnabled(false);
            this.Visible = false;
        }
        private void button_search_Click(object sender, EventArgs e)
        {
            changeButtonsEnabled(true);
        }


        // Room Create Buttons
        private void button_create_Click(object sender, EventArgs e)
        {
            textBoxesAreReadOnly(false);
            clearAllTextBoxes();
            textBox_room_no.Visible = true;
            
            cancelButtonVisible(true);
            submitCreateButtonVisible(true);
            textBox_room_no.Focus();
            textBox_room_no.ReadOnly = false;

        }
        private void button_submit_create_Click(object sender, EventArgs e)
        {
            string room_no = textBox_room_no.Text;
            string room_location = comboBox_loc_id.Text[0].ToString();
            string room_type = textBox_room_type.Text;
            string room_description = textBox_room_type_description.Text;
            string room_price = textBox_room_price.Text;
            string room_available = textBox_room_available.Text;


            sqlConnection1.Open();

            SqlCommand cmd = sqlConnection1.CreateCommand();


            // Add a Room Type
            cmd.CommandText = "INSERT INTO ROOM_TYPE (TYPE_CODE,TYPE_PRICE,TYPE_DESCRIPTION) VALUES (@type, @price, @descript)";
            cmd.Parameters.AddWithValue("@type", room_type);
            cmd.Parameters.AddWithValue("@price",room_price);
            cmd.Parameters.AddWithValue("@descript", room_description);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            // Add a Room
            cmd.CommandText = "INSERT INTO ROOM (ROOM_NO,ROOM_LOC,ROOM_TYPE,ROOM_AVAILABLE) VALUES (@num,@loc,@room_type,@available)";
            cmd.Parameters.AddWithValue("@num", room_no);
            cmd.Parameters.AddWithValue("@loc", room_location);
            cmd.Parameters.AddWithValue("@room_type", room_type);
            cmd.Parameters.AddWithValue("@available", room_available);
            cmd.ExecuteNonQuery();

            MessageBox.Show("One Room and Room Type Added");
            sqlConnection1.Close();

            clearAllTextBoxes(); // clears texts from text boxes
            changeCreateButtonsVisibility(true);
            changeButtonsEnabled(true);
            button_search.Enabled = true;
            button_submit_create.Enabled = false;
            changeCancelButton(false);
        }

        // Room Edit Buttons
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


        // Room Delete Button
        private void button_delete_Click(object sender, EventArgs e)
        {
            clearAllTextBoxes(); // clears texts from text boxes
            changeButtonsEnabled(false); // hide edit and delete buttons
            changeTextBoxesReadOnlyStatus(true); // make text boxes read-only
        }


        //Room Cancel Button
        private void button_cancel_Click(object sender, EventArgs e)
        {
            changeButtonsEnabled(false); // delete this when above is filled out
            clearAllTextBoxes(); // clear text boxes
            changeEditButtonsVisibility(true);
            changeCreateButtonsVisibility(true);
            changeCancelButton(false);
            button_submit_edit.Enabled = false;
            button_submit_create.Enabled = false;
            button_search.Enabled = true; // enable search button
        }
    }
}
