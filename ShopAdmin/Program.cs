using ShopAdmin.GUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ShopAdmin
{
   
    static class Program
    {
        static public MainForm mainForm;
        static public Dictionary<string, Image> imageDict = new Dictionary<string, Image>()
        {
            ["iphone 11"] = new Bitmap(Properties.Resources.iPhone_11),
            ["iphone 12pro"] = new Bitmap(Properties.Resources.iPhone12pro_graphite),
            ["iphone 13pro"] = new Bitmap(Properties.Resources.iPhone_13Pro),
            ["iphone xr"] = new Bitmap(Properties.Resources.iPhone_XR),
            ["redmi note4"] = new Bitmap(Properties.Resources.redmi_note4),
            ["redmi note10"] = new Bitmap(Properties.Resources.Redmi_Note_10),
            ["redmi note11"] = new Bitmap(Properties.Resources.note11),
            ["redmi 9c"] = new Bitmap(Properties.Resources.Redmi_9C),
            ["galaxy s7562"] = new Bitmap(Properties.Resources.gt_s7562zkaser_001_front_black),
            ["galaxy m52"] = new Bitmap(Properties.Resources.Galaxy_M52),
            ["galaxy s21"] = new Bitmap(Properties.Resources.Galaxy_S21),
            ["galaxy s22"] = new Bitmap(Properties.Resources.Galaxy_S22),
            ["galaxy s20 fe"] = new Bitmap(Properties.Resources.Galaxy_S20_FE),
            ["galaxy fold3"] = new Bitmap(Properties.Resources.Galaxy_Fold3),
            ["galaxy a40"] = new Bitmap(Properties.Resources.a40_black),
            ["galaxy a52"] = new Bitmap(Properties.Resources.Galaxy_A52),
            ["galaxy a13"] = new Bitmap(Properties.Resources.Galaxy_A13),
            ["galaxy a32"] = new Bitmap(Properties.Resources.Galaxy_A32),
            ["galaxy a33"] = new Bitmap(Properties.Resources.Galaxy_A33),
            ["pixel 6pro"] = new Bitmap(Properties.Resources.Pixel_6Pro),
            ["plus 9rt"] = new Bitmap(Properties.Resources.Plus_9RT),
            ["n 95"] = new Bitmap(Properties.Resources.n_95),
            ["f 3"] = new Bitmap(Properties.Resources.f3),
            ["11 t"] = new Bitmap(Properties.Resources._11_T),
            ["12x"] = new Bitmap(Properties.Resources._12X),
            ["blade v30"] = new Bitmap(Properties.Resources.BLADE_V30),
            ["g60"] = new Bitmap(Properties.Resources.G60),
            ["v21e"] = new Bitmap(Properties.Resources.V21E),
            ["x4 pro"] = new Bitmap(Properties.Resources.X4_Pro)
        };
    /// <summary>
    /// Главная точка входа для приложения.
    /// </summary>
    [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new MainForm();
            Application.Run(mainForm);
        }
    }
}