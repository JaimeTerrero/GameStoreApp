using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {}

        public DbSet<Product> Products { get; set; }
        public DbSet<Inventary> Inventaries { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // FLUENT API

            #region tables
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Inventary>().ToTable("Inventaries");
            modelBuilder.Entity<Sale>().ToTable("Sales");
            modelBuilder.Entity<User>().ToTable("Users");
            #endregion

            #region "primary keys"
            modelBuilder.Entity<Product>().HasKey(product => product.Id);
            modelBuilder.Entity<Inventary>().HasKey(inventary => inventary.Id);
            modelBuilder.Entity<Sale>().HasKey(sale => sale.Id);
            modelBuilder.Entity<User>().HasKey(user => user.Id);
            #endregion

            #region "Relationships"
            modelBuilder.Entity<Inventary>()
                .HasMany<Product>(inventary => inventary.Products)
                .WithOne(product => product.Inventary)
                .HasForeignKey(product => product.InventaryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Sale>()
                .HasMany<Product>(sale => sale.Products)
                .WithOne(product => product.Sale)
                .HasForeignKey(product => product.SaleId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany<Product>(user => user.Products)
                .WithOne(product => product.User)
                .HasForeignKey(product => product.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion

            #region "Property configurations"

            #region products
            modelBuilder.Entity<Product>().Property(product => product.Name).IsRequired();
            modelBuilder.Entity<Product>().Property(product => product.ImageUrl).IsRequired();
            modelBuilder.Entity<Product>().Property(product => product.Price).IsRequired();
            modelBuilder.Entity<Product>().Property(product => product.Category).IsRequired().HasMaxLength(100);
            #endregion

            #region sales
            modelBuilder.Entity<Sale>().Property(sale => sale.ProductName).IsRequired();
            #endregion

            #region users
            modelBuilder.Entity<User>().Property(user => user.Name).IsRequired();
            modelBuilder.Entity<User>().Property(user => user.Password).IsRequired();
            modelBuilder.Entity<User>().Property(user => user.Role).IsRequired();
            modelBuilder.Entity<User>().Property(user => user.Email).IsRequired();
            modelBuilder.Entity<User>().Property(user => user.PhoneNumber).IsRequired();
            modelBuilder.Entity<User>().Property(user => user.Direction).IsRequired();
            modelBuilder.Entity<User>().Property(user => user.DateofBirth).IsRequired();
            #endregion

            #endregion
        }
    }
}
