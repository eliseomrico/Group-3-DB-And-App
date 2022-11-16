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
    public partial class RoomAvailability : UserControl
    {
        public RoomAvailability()
        {
            InitializeComponent();
            fillRoomDataGrid();
            AddRoomComboBoxItems();
        }

        private List<Room_Obj> getRooms()
        {
            List<Room_Obj> rooms = new List<Room_Obj>();

            try
            {
                sqlConnection1.Open();
                SqlCommand cmd = sqlConnection1.CreateCommand();

                cmd.CommandText = "SELECT * FROM ROOM";

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    rooms.Add(new Room_Obj()
                    {
                        room_no = dr["ROOM_NO"].ToString(),
                        room_location = dr["ROOM_LOC"].ToString(),
                        room_type = dr["ROOM_TYPE"].ToString(),
                        room_available = dr["ROOM_AVAILABLE"].ToString(),
                    });

                }
                sqlConnection1.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine(rooms);

            return rooms;
        }

        public void fillRoomDataGrid()
        {
            dataGridView_room.DataSource = getRooms();
            dataGridView_room.Columns[0].HeaderText = "Room ID";
            dataGridView_room.Columns[1].HeaderText = "Room Loc";
            dataGridView_room.Columns[2].HeaderText = "Room Type";
            dataGridView_room.Columns[3].HeaderText = "Available";

        }

        private void AddRoomComboBoxItems()
        {
            comboBox_location_name.Items.Clear();

            sqlConnection2.Open();

            SqlCommand cmd = sqlConnection2.CreateCommand();
            cmd.CommandText = "SELECT * FROM ROOM";
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                comboBox_location_name.Items.Add(rd["ROOM_NO"]);
            }

            sqlConnection2.Close();
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_manage_rooms_Click(object sender, EventArgs e)
        {
            rooms1.Visible = true;
        }
    }
}
