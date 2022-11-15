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
    public partial class ViewLocations : UserControl
    {
        public ViewLocations()
        {
            InitializeComponent();
            fillLocationDataGrid("");
        }

        public void fillLocationDataGrid(string lname)
        {
            dataGridLocations.DataSource = GetLocations(lname);
        }

        private List<Location_Obj> GetLocations(string loc_name)
        {
            List<Location_Obj> locations = new List<Location_Obj>();

            try
            {
                sqlConnection1.Open();
                SqlCommand cmd = sqlConnection1.CreateCommand();

                if (loc_name == "")
                {
                    cmd.CommandText = "SELECT * FROM LOCATION";
                }
                else
                {
                    cmd.CommandText = "SELECT * FROM LOCATION " +
                                      "WHERE loc_name LIKE '%" + loc_name + "%' ";
                }

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    locations.Add(new Location_Obj()
                    {
                        loc_id = dr["LOC_ID"].ToString(),
                        loc_name = dr["LOC_NAME"].ToString(),
                        loc_hours = dr["LOC_HOURS"].ToString(),
                        loc_address = dr["LOC_ADDRESS"].ToString(),
                        loc_phone = dr["LOC_PHONE"].ToString(),
                        loc_super_id = dr["LOC_SUPER_ID"].ToString()
                    });

                }
                sqlConnection1.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return locations;
        }


        private void button_home_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void button_manage_locations_Click(object sender, EventArgs e)
        {
            locations1.Visible = true;
        }

        private void textBox_location_name_TextChanged(object sender, EventArgs e)
        {
            fillLocationDataGrid(textBox_location_name.Text);
        }
    }
}
