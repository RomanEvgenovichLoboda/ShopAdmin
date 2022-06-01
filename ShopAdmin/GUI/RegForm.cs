using ShopAdmin.Classes;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ShopAdmin.GUI
{
    public partial class RegForm : Form
    {
        string pattern;
        Registration reg;
        public RegForm()
        {
            InitializeComponent();
            reg = new Registration();
            pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
        }
        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (emailBox.Text != "" && passwordBox.Text != "")
            {
                if  (!Regex.IsMatch(emailBox.Text, pattern, RegexOptions.IgnoreCase)) { MessageBox.Show("Wrong email format"); }
                else
                {
                    reg.signIn(emailBox.Text, passwordBox.Text);
                    this.Close();
                }
            }
            else { MessageBox.Show("Empty Line =("); }
        }
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (emailBox.Text != "" && passwordBox.Text != "") 
            {
                if (!Regex.IsMatch(emailBox.Text, pattern, RegexOptions.IgnoreCase)) { MessageBox.Show("Wrong email format"); }
                else
                {
                    reg.Regestration(emailBox.Text, passwordBox.Text);
                    MessageBox.Show("Registration Is OK =)");
                }
            }
            else { MessageBox.Show("Empty Line =("); }
        }
    }
}