﻿using System;
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
    public partial class ViewReservations : UserControl
    {
        public ViewReservations()
        {
            InitializeComponent();
        }

        private void button_manage_reservations_Click(object sender, EventArgs e)
        {
            reservationQueryForm1.Visible = true;
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}