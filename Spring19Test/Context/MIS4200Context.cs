using Spring19Test.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Spring19Test.Context
{
    public class MIS4200Context: DbContext
    {
        public MIS4200Context() : base ("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context, Spring19Test.Migrations.MISContext.Configuration>("DefaultConnection"));
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Email> Email { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<Spring19Test.Models.RegisteredUser> RegisteredUsers { get; set; }
    }
}