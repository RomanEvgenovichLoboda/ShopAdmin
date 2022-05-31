﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopAdmin.GUI
{
    public partial class GoodPanel : UserControl
    {
        int id;
        Dictionary<string, Image> imageDict;
        //Image[] images;
        public GoodPanel(int _id, string _name, string _company, int _flash, int _SSD, int _processor, double _price)
        {

            InitializeComponent();
            imageDict = new Dictionary<string, Image>()
            {
                ["iphone 13pro"] = new Bitmap(Properties.Resources.iPhone_13Pro),
                ["pixel 6pro"] = new Bitmap(Properties.Resources.Pixel_6Pro),
                ["iphone xr"] = new Bitmap(Properties.Resources.iPhone_XR),
                ["plus 9rt"] = new Bitmap(Properties.Resources.Plus_9RT),
                ["galaxy s21"] = new Bitmap(Properties.Resources.Galaxy_S21),
                ["galaxy m52"] = new Bitmap(Properties.Resources.Galaxy_M52),
              

            };
            //images = new Image[] { new Bitmap(Properties.Resources.iPhone_13Pro), new Bitmap(Properties.Resources.Pixel_6Pro), new Bitmap(Properties.Resources.iPhone_XR),
            //    new Bitmap(Properties.Resources.Plus_9RT), new Bitmap(Properties.Resources.Galaxy_S21), new Bitmap(Properties.Resources.Galaxy_M52), new Bitmap(Properties.Resources.Galaxy_M52),
            //    new Bitmap(Properties.Resources.Galaxy_M52), new Bitmap(Properties.Resources.Galaxy_M52) };
            id = _id;
            textBoxName.Text = _name;
            textBoxCompany.Text = _company;
            textBoxFlash.Text = _flash.ToString();
            textBoxSSD.Text = _SSD.ToString();
            textBoxProessor.Text = _processor.ToString();
            textBoxPrice.Text = _price.ToString();
            //pictureBox1.Image = images[_id - 1];
            pictureBox1.Image = imageDict[_name.ToLower()];
        }
        
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            //Model_Db_Other modelDB = new Model_Db_Other();
            //modelDB.Mobiles.Remove(modelDB.Mobiles.Find(id));
            //modelDB.SaveChanges();
            //Program.mainForm.Show_Goods();
            using(Model_Db_Other model_Db = new Model_Db_Other())
            {
                model_Db.Mobiles.Remove(model_Db.Mobiles.Find(id));
                model_Db.SaveChanges(); 
            }
            Program.mainForm.Show_Goods();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            using (Model_Db_Other model_Db = new Model_Db_Other())
            {
                Mobile mobile = new Mobile()
                {
                    Id = this.id,
                    Name = textBoxName.Text,
                    Company = textBoxCompany.Text,
                    Flash = Convert.ToInt32(textBoxFlash.Text),
                    SSD = Convert.ToInt32(textBoxSSD.Text),
                    Processor = Convert.ToInt32(textBoxProessor.Text),
                    Price = Convert.ToDouble(textBoxPrice.Text)
                };
                
                model_Db.Mobiles.Remove(model_Db.Mobiles.Find(id));
                model_Db.SaveChanges();
                model_Db.Mobiles.Add(mobile);
                model_Db.SaveChanges();
            }
            Program.mainForm.Show_Goods();
        }
    }
}
