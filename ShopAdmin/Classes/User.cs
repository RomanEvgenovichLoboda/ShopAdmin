
namespace ShopAdmin.Classes
{
    class User
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public override string ToString() { return string.Format("id: {0}\nemail: {1}\npassword: {2}", id, email, password); }

    }
}
