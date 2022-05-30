using System;
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
        Image[] images;
        public GoodPanel(int _id, string _name, string _company, int _flash, int _SSD, int _processor, double _price)
        {

            InitializeComponent();
            images = new Image[] { new Bitmap(Properties.Resources._1), new Bitmap(Properties.Resources._2), new Bitmap(Properties.Resources._3),
                new Bitmap(Properties.Resources._4), new Bitmap(Properties.Resources._5), new Bitmap(Properties.Resources._6), new Bitmap(Properties.Resources._6),
                new Bitmap(Properties.Resources._6), new Bitmap(Properties.Resources._6) };
            id = _id;
            textBoxName.Text = _name;
            textBoxCompany.Text = _company;
            textBoxFlash.Text = $"{_flash.ToString()} Gb";
            textBoxSSD.Text = $"{_SSD.ToString()} Gb";
            textBoxProessor.Text = $"{ _processor.ToString()} Core";
            textBoxPrice.Text = _price.ToString();
            pictureBox1.Image = images[_id - 1];
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Model_Db_Other modelDB = new Model_Db_Other();
            modelDB.Mobiles.Remove(modelDB.Mobiles.Find(id));
            modelDB.SaveChanges();
            Program.mainForm.Show_Goods();
        }
    }
}
