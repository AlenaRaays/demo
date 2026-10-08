using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace demo
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Manufacture> Manufacture { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Size> Size { get; set; }
        public virtual DbSet<SubCategory> SubCategory { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }
        public virtual DbSet<WarehouseOrder> WarehouseOrder { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Category)
                .HasForeignKey(e => e.idCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Manufacture>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Manufacture)
                .HasForeignKey(e => e.idManufacturer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.WarehouseOrder)
                .WithRequired(e => e.Order)
                .HasForeignKey(e => e.idOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Warehouse)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.idProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.idRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Size>()
                .HasMany(e => e.Warehouse)
                .WithRequired(e => e.Size)
                .HasForeignKey(e => e.idSize)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SubCategory>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.SubCategory)
                .HasForeignKey(e => e.idSubCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.idUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.WarehouseOrder)
                .WithRequired(e => e.Warehouse)
                .HasForeignKey(e => e.idWarehouse)
                .WillCascadeOnDelete(false);
        }
    }
}
