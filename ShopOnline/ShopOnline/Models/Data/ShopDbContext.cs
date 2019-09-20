using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ShopOnline.Models.Data
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext() : base("ShopDbContext")
        {
        }
        public virtual DbSet<Advertise> Advertises { get; set; }
        public virtual DbSet<Company> Companys { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<GroupProduct> GroupProducts { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<Support> Supports { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}