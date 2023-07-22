using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ShopAdo3tier.DAL.Context
{
    public partial class ShopAdoContext : DbContext
    {
        public ShopAdoContext()
            : base("name=ShopAdoContext")
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Good> Good { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Good>()
                .Property(e => e.GoodName)
                .IsUnicode(false);

            modelBuilder.Entity<Good>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Good>()
                .Property(e => e.GoodCount)
                .HasPrecision(18, 3);
        }
    }
}
