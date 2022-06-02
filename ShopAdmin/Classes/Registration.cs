using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ShopAdmin.Classes
{
    class Registration
    {
        public bool sidn_in; 
        string connectionString = @"Data Source=DESKTOP-54SAU6R\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void Regestration(string _email, string _pass)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    User regestration = new User() { email = _email, password = new Crypt().Generate(_pass) };
                    connection.Execute("INSERT INTO Users (email, password) VALUES(@email,@password)", regestration);
                }
            }
            catch { MessageBox.Show("Проблмы С Подключением =(", " ErroR !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

        }
        public void signIn(string _email, string _pass)
        {
            try
            {
                List<User> usList = GetUsers();
                foreach (var item in usList)
                {
                    if (item.email == _email && new Crypt().veryfy(_pass, item.password) == true) 
                    {
                        Program.mainForm.sign = true;
                        sidn_in = true;
                    } 
                }
            }
            catch { MessageBox.Show("Проблмы С Подключением =(", " ErroR !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        public List<User> GetUsers() { using (IDbConnection connection = new SqlConnection(connectionString)) { return connection.Query<User>($"SELECT * FROM [Users] ").ToList(); }}
    }
}