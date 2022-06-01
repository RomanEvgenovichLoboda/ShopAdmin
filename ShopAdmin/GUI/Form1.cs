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
        public Form1()
        {
            InitializeComponent();
            Show_Goods();
        }
        public void Show_Goods(string str = "")
        {
            using (Model_Db_Other model_Db = new Model_Db_Other())
            {
                panel2.Controls.Clear();
                int x = 10, y = 10;
                foreach (var item in model_Db.Mobiles)
                {
                    if(str == "")
                    { 
                        panel2.Controls.Add(new GoodPanel(item.Id, item.Name, item.Company, item.Flash, item.SSD, item.Processor, item.Price) { Location = new Point(x, y) });
                        x += 320;
                    }
                    else if (str.ToLower() == item.Company.ToLower() || str.ToLower() == item.Name.ToLower()) 
                    { 
                        panel2.Controls.Add(new GoodPanel(item.Id, item.Name, item.Company, item.Flash, item.SSD, item.Processor, item.Price) { Location = new Point(x, y) });
                        x += 320;
                    }
                    if (x / 320 >= 4)
                    {
                        y += 300;
                        x = 10;
                    }
                }
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e) { Show_Goods(textBoxSearch.Text); }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxAddName.Text != "" && textBoxAddCompany.Text != "" && textBoxAddFlash.Text != "" && textBoxAddSSD.Text != "" && textBoxAddProcessor.Text != "" && textBoxAddPrice.Text != "")
                {
                    using (Model_Db_Other model_Db = new Model_Db_Other())
                    {
                        int _id = 1;
                        foreach (var item in model_Db.Mobiles) { if (item.Id >= _id) { _id = item.Id + 1; } }
                        Mobile mobile = new Mobile()
                        {
                            Id = _id,
                            Name = textBoxAddName.Text,
                            Company = textBoxAddCompany.Text,
                            Flash = Convert.ToInt32(textBoxAddFlash.Text),
                            SSD = Convert.ToInt32(textBoxAddSSD.Text),
                            Processor = Convert.ToInt32(textBoxAddProcessor.Text),
                            Price = Convert.ToDouble(textBoxAddPrice.Text)
                        };
                        model_Db.Mobiles.Add(mobile);
                        model_Db.SaveChanges();
                        textBoxAddName.Text = textBoxAddCompany.Text = textBoxAddFlash.Text = textBoxAddSSD.Text = textBoxAddProcessor.Text = textBoxAddPrice.Text = "";
                        Program.mainForm.Show_Goods();
                    }
                }
                else { MessageBox.Show("Заполните Все Поля Bвода", " ErroR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch { MessageBox.Show("Не Правильный Ввод =(", " ErroR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
    }
}
