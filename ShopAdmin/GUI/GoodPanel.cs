using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ShopAdmin.GUI
{
    public partial class GoodPanel : UserControl
    {
        int id;
        Dictionary<string, Image> imageDict;
        public GoodPanel(int _id, string _name, string _company, int _flash, int _SSD, int _processor, double _price)
        {

            InitializeComponent();
            imageDict = new Dictionary<string, Image>()
            {
                ["iphone 11"] = new Bitmap(Properties.Resources.iPhone_11),
                ["iphone 12pro"] = new Bitmap(Properties.Resources.iPhone12pro_graphite),
                ["iphone 13pro"] = new Bitmap(Properties.Resources.iPhone_13Pro),
                ["iphone xr"] = new Bitmap(Properties.Resources.iPhone_XR),
                ["redmi note4"] = new Bitmap(Properties.Resources.redmi_note4),
                ["redmi note10"] = new Bitmap(Properties.Resources.Redmi_Note_10),
                ["redmi note11"] = new Bitmap(Properties.Resources.note11),
                ["galaxy s7562"] = new Bitmap(Properties.Resources.gt_s7562zkaser_001_front_black),
                ["galaxy m52"] = new Bitmap(Properties.Resources.Galaxy_M52),
                ["galaxy s21"] = new Bitmap(Properties.Resources.Galaxy_S21),
                ["galaxy a40"] = new Bitmap(Properties.Resources.a40_black),
                ["galaxy a52"] = new Bitmap(Properties.Resources.Galaxy_A52),
                ["galaxy a13"] = new Bitmap(Properties.Resources.Galaxy_A13),
                ["galaxy a32"] = new Bitmap(Properties.Resources.Galaxy_A32),
                ["galaxy a33"] = new Bitmap(Properties.Resources.Galaxy_A33),
                ["pixel 6pro"] = new Bitmap(Properties.Resources.Pixel_6Pro),
                ["plus 9rt"] = new Bitmap(Properties.Resources.Plus_9RT),
                ["n 95"] = new Bitmap(Properties.Resources.n_95),
                ["f 3"] = new Bitmap(Properties.Resources.f3),
                ["11 t"] = new Bitmap(Properties.Resources._11_T)

            };
            id = _id;
            textBoxName.Text = _name;
            textBoxCompany.Text = _company;
            textBoxFlash.Text = _flash.ToString();
            textBoxSSD.Text = _SSD.ToString();
            textBoxProessor.Text = _processor.ToString();
            textBoxPrice.Text = _price.ToString();
            try { pictureBox1.Image = imageDict[_name.ToLower()]; }
            catch { pictureBox1.Image = new Bitmap(Properties.Resources.test); }
        } 
        private void buttonRemove_Click(object sender, EventArgs e)
        {
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
                model_Db.Mobiles.Add(mobile);
                model_Db.SaveChanges();
            }
            Program.mainForm.Show_Goods();
        }
    }
}