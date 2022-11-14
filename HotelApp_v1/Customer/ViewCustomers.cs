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
    public partial class ViewCustomers : UserControl
    {
        public ViewCustomers()
        {
            InitializeComponent();
            dataGrid_Customers.DataSource = GetCustomers("");
        }

        private List<Customer_Obj> GetCustomers(string lname)
        {
            List<Customer_Obj> customers = new List<Customer_Obj>();

            try
            {
                sqlConnection1.Open();
                SqlCommand cmd = sqlConnection1.CreateCommand();

                if (lname == "")
                {
                    cmd.CommandText = "SELECT * FROM CUSTOMER";
                }
                else
                {
                    cmd.CommandText = "SELECT * FROM CUSTOMER " +
                                      "WHERE cust_lname LIKE '%"+lname+"%' ";
                }

                SqlDataReader dr = cmd.ExecuteReader();
               
                int idx = 1;
                while (dr.Read() && idx < 3)
                {
                    customers.Add(new Customer_Obj()
                    {
                        cust_id = dr["cust_id"].ToString(),
                        cust_first_name = dr["cust_fname"].ToString(),
                        cust_last_name = dr["cust_lname"].ToString(),
                        cust_balance = dr["cust_balance"].ToString(),
                        cust_phone = dr["cust_phone"].ToString(),
                        cust_cc_number = dr["cust_credit_card_no"].ToString()
                    });

                }
                sqlConnection1.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return customers;
        }

        public void fillCustomerDataGrid(string lname)
        {
            dataGrid_Customers.DataSource = GetCustomers(lname);
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_manage_customers_Click(object sender, EventArgs e)
        {
            customerQueryForm1.Visible = true;

            
        }

        private void textBox_lname_TextChanged(object sender, EventArgs e)
        {
            fillCustomerDataGrid(textBox_lname.Text);
        }

    }
}
