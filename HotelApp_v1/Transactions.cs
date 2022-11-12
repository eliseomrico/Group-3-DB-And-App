using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApp_v1
{
    public partial class Transactions : UserControl
    {
        public Transactions()
        {
            InitializeComponent();
        }
        private void toggleEditButton(bool enable) // after search is clicked, show edit and delete buttons
        {
            btnEdit.Visible = enable;
            btnSubmitEdit.Visible = !enable;
        }
        private void toggleCreateButton(bool status)
        {
            btnCreate.Visible = status;
            btnSubmitCreate.Visible = !status;
        }
        private void showCancelButton(bool enable)
        {
            btnCancel.Enabled = enable;
            btnCancel.Visible = enable;
        }
        private void changeTextBoxesReadOnlyStatus(bool enable) // makes text boxes read-only or not read-only
        {
            txtResID.ReadOnly = enable;
            txtTransAmt.ReadOnly = enable;
            dtpTransDate.Enabled = !enable;
        }
        private void clearTextBoxes() // clears text from text boxes
        {
            cmbTransNo.Text = "";
            txtResID.Clear();
            txtTransAmt.Clear();
            dtpTransDate.Value = DateTime.Now;
        }
        private void enableMenuButtons(bool enable)
        {
            btnCreate.Enabled = enable;
            btnEdit.Enabled = enable;
            btnDelete.Enabled = enable;
        }


        // form buttons below

        private void button_home_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
            enableMenuButtons(false);
            this.Visible = false;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            enableMenuButtons(true);
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            clearTextBoxes(); // clears texts from text boxes
            toggleCreateButton(false);
            enableMenuButtons(false);
            btnSearch.Enabled = false;
            btnSubmitCreate.Enabled = true;
            showCancelButton(true);
        }

        private void button_submit_create_Click(object sender, EventArgs e)
        {
            clearTextBoxes(); // clears texts from text boxes
            toggleCreateButton(true);
            enableMenuButtons(true);
            btnSearch.Enabled = true;
            btnSubmitCreate.Enabled = false;
            showCancelButton(false);
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            toggleEditButton(false);
            changeTextBoxesReadOnlyStatus(false); // make text boxes non-'editable' or read-only
            enableMenuButtons(false);
            btnSubmitEdit.Enabled = true;
            btnSearch.Enabled = false; // disable search button
            showCancelButton(true);
        }

        private void button_submit_edit_Click(object sender, EventArgs e)
        {
            toggleEditButton(true);
            changeTextBoxesReadOnlyStatus(true); // make text boxes non-'editable' or read-only
            enableMenuButtons(true);
            btnSubmitEdit.Enabled = false;
            btnSearch.Enabled = true; // enable search button
            showCancelButton(false);
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            clearTextBoxes(); // clears texts from text boxes
            enableMenuButtons(false); // hide edit and delete buttons
            changeTextBoxesReadOnlyStatus(true); // make text boxes read-only
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            enableMenuButtons(false); // delete this when above is filled out
            clearTextBoxes(); // clear text boxes
            toggleEditButton(true);
            toggleCreateButton(true);
            showCancelButton(false);
            btnSubmitEdit.Enabled = false;
            btnSubmitCreate.Enabled = false;
            btnSearch.Enabled = true; // enable search button
        }
    }
}
