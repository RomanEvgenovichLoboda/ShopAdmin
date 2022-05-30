using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ShopAdmin
{
    public partial class Model_Db_Other : DbContext
    {
        public Model_Db_Other()
            : base("name=Model_Db_Other")
        {
        }

        public virtual DbSet<Mobile> Mobiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
