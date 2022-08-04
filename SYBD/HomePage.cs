﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYBD
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegCustomer regCustomer = new RegCustomer();
            regCustomer.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegGoods regGoods = new RegGoods();
            regGoods.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ControlDB controlDB = new ControlDB();
            controlDB.Show();
        }
    }
}
