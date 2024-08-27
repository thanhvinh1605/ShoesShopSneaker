using APPDATA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace APPDATA.DB
{
    public class ShopingDB : DbContext  
    {
        public ShopingDB()
        {
        }
        public ShopingDB(DbContextOptions<ShopingDB> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-H4H9TH9\SQLEXPRESS;Initial Catalog=ShoesShopSneaker;Integrated Security=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Color> Colors { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
    }
}
