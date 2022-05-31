using ShopAdmin.GUI;
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
       // Model_Db_Other model;
        public Form1()
        {
           // model = new Model_Db_Other();
            InitializeComponent();
            Show_Goods();
        }
        public void Show_Goods(string str = "ALL")
        {
            using (Model_Db_Other model_Db = new Model_Db_Other())
            {
                panel2.Controls.Clear();
                int x = 10, y = 10;
                foreach (var item in model_Db.Mobiles)
                {
                    if(str == "ALL")
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

        private void buttonSearch_Click(object sender, EventArgs e) { if(textBoxSearch.Text != "") { Show_Goods(textBoxSearch.Text); } }
    }
}
