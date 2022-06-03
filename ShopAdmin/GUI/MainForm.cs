using ShopAdmin.GUI;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ShopAdmin
{
    public partial class MainForm : Form
    {
        public bool sign;
        int count;
        public MainForm()
        {
            InitializeComponent();
            Show_Goods();
        }
        public void Show_Goods(string str = "")
        {
            using (Model_Db_Other model_Db = new Model_Db_Other())
            {
                count = 0;
                panel2.Controls.Clear();
                int x = 10, y = 10;
                foreach (var item in model_Db.Mobiles)
                {
                    if(str == "")
                    { 
                        panel2.Controls.Add(new GoodPanel(item.Id, item.Name, item.Company, item.Flash, item.SSD, item.Processor, item.Price) { Location = new Point(x, y) });
                        x += 320;
                        count++;
                    }
                    else if (str.ToLower() == item.Company.ToLower() || str.ToLower() == item.Name.ToLower()) 
                    { 
                        panel2.Controls.Add(new GoodPanel(item.Id, item.Name, item.Company, item.Flash, item.SSD, item.Processor, item.Price) { Location = new Point(x, y) });
                        x += 320;
                        count++;
                    }
                    if (x / 320 >= 4)
                    {
                        y += 300;
                        x = 10;
                    }
                }
                labelCount.Text = count.ToString();
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
                else { MessageBox.Show("Заполните Все Поля Bвода", " ErroR !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch { MessageBox.Show("Не Правильный Ввод =(", " ErroR !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            RegForm regForm = new RegForm();
            regForm.ShowDialog();
            if (!sign) { this.Close(); }
            else { MessageBox.Show("Autorisated is OK =)", "Autorisated !", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            int x = 10, y = 10;
            using (Model_Db_Other model_Db = new Model_Db_Other())
            {
                IOrderedQueryable<Mobile> order = null ;
                if (radioButtonName.Checked) { order = model_Db.Mobiles.OrderBy((z) => z.Name); }
                else if (radioButtonCompany.Checked) { order = model_Db.Mobiles.OrderBy((z) => z.Company); }
                else if (radioButtonFlash.Checked) { order = model_Db.Mobiles.OrderBy((z) => z.Flash); }
                else if (radioButtonSSD.Checked) { order = model_Db.Mobiles.OrderBy((z) => z.SSD); }
                else if (radioButtonProcessor.Checked) { order = model_Db.Mobiles.OrderBy((z) => z.Processor); }
                else if(radioButtonPrice.Checked) { order = model_Db.Mobiles.OrderBy((z) => z.Price); }
                foreach (var item in order)
                {
                    panel2.Controls.Add(new GoodPanel(item.Id, item.Name, item.Company, item.Flash, item.SSD, item.Processor, item.Price) { Location = new Point(x, y) });
                    x += 320;
                    count++;
                    if (x / 320 >= 4)
                    {
                        y += 300;
                        x = 10;
                    }
                }
            }
        }
    }
}