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
    public partial class EmployeeLoginForm : UserControl
    {
        public EmployeeLoginForm()
        {
            InitializeComponent();
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string Lname = cmbUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            sqlConnection1.Open();

            SqlCommand cmdLogin = sqlConnection1.CreateCommand();
            cmdLogin.CommandText = @"SELECT EMP_FNAME, EMP_LNAME
                                     FROM EMPLOYEE
                                     WHERE EMP_LNAME = @search
                                     AND EMP_SSN = @search2";
            cmdLogin.Parameters.AddWithValue("@search", Lname);
            cmdLogin.Parameters.AddWithValue("@search2", pass);

            SqlDataReader reader = cmdLogin.ExecuteReader();

            if (reader.Read())
            {
                string name = reader[0].ToString() + " " + reader[1].ToString();
                sqlConnection1.Close();
                reader.Close();
                cmdLogin.Dispose();
                MessageBox.Show(name + " is now logged on");
            }
            else
            {
                sqlConnection1.Close();
                reader.Close();
                cmdLogin.Dispose();
                MessageBox.Show("Incorrect login, please try again.");
            }
        }

        // Fill employee by typing
        private void FillEmployees()
        {
            if (cmbUsername.Items.Count > 1)
            {
                // Do nothing
            }
            else
            {
                sqlConnection1.Open();

                SqlCommand cmdEmpSearch = sqlConnection1.CreateCommand();
                cmdEmpSearch.CommandText = @"SELECT EMP_LNAME
                                            FROM EMPLOYEE
                                            ORDER BY EMP_LNAME";

                SqlDataReader reader = cmdEmpSearch.ExecuteReader();

                while (reader.Read())
                {
                    cmbUsername.Items.Add(reader[0].ToString());
                }

                reader.Close();
                sqlConnection1.Close();
            }
        }

        private void cmbUsername_Click(object sender, EventArgs e)
        {
            FillEmployees();
        }
    }
}
