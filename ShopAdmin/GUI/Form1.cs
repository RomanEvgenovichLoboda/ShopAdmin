﻿using ShopAdmin.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopAdmin
{
    public partial class Form1 : Form
    {
        Model_Db_Other model;
        public Form1()
        {
            model = new Model_Db_Other();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 5, y = 5;
            foreach (var item in model.Mobiles)
            {
                panel2.Controls.Add(new GoodPanel(item.Id, item.Name, item.Company, item.Flash, item.SSD, item.Processor, item.Price) { Location = new Point(x, y) });
                x += 405;
                if (x / 405 >= 3)
                {
                    y += 410;
                    x = 5;
                }
            }
        }
    }
}
