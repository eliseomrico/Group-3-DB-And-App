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
    public partial class ViewTransactions : UserControl
    {
        public ViewTransactions()
        {
            InitializeComponent();
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_manage_locations_Click(object sender, EventArgs e)
        {
            pnlManageTransactions.Visible = true;
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            sqlConnection1.Open();

            DateTime SDate = dtpStartDate.Value;
            string sqlFormattedSDate = SDate.ToString("yyyy-MM-dd HH:mm:ss.fff");

            DataTable transactionsResults = new DataTable();

            SqlCommand cmdGetTransactions = sqlConnection1.CreateCommand();
            cmdGetTransactions.CommandText = @"SELECT *
                                               FROM TRANSACTIONS
                                               WHERE TRANS_DATE >= @search";
            cmdGetTransactions.Parameters.AddWithValue("@search", sqlFormattedSDate);

            SqlDataReader reader = cmdGetTransactions.ExecuteReader();

            transactionsResults.Load(reader);
            dgvTransactionsList.DataSource = transactionsResults;

            reader.Close();
            sqlConnection1.Close();
            cmdGetTransactions.Dispose();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            sqlConnection1.Open();

            DateTime SDate = dtpEndDate.Value;
            string sqlFormattedSDate = SDate.ToString("yyyy-MM-dd HH:mm:ss.fff");

            DataTable transactionsResults = new DataTable();

            SqlCommand cmdGetTransactions = sqlConnection1.CreateCommand();
            cmdGetTransactions.CommandText = @"SELECT *
                                               FROM TRANSACTIONS
                                               WHERE TRANS_DATE <= @search";
            cmdGetTransactions.Parameters.AddWithValue("@search", sqlFormattedSDate);

            SqlDataReader reader = cmdGetTransactions.ExecuteReader();

            transactionsResults.Load(reader);
            dgvTransactionsList.DataSource = transactionsResults;

            reader.Close();
            sqlConnection1.Close();
            cmdGetTransactions.Dispose();
        }
    }
}
