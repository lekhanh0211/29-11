using it.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace it.DAL
{
    public class ManagerDbContext : DbContext
    {
        public ManagerDbContext() : base("name=ShopDbContext")
        {

        }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillDetail> BillDetails { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
    }

}
