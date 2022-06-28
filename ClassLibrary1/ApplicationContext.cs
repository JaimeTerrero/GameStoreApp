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
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //FLUENT API

            #region tables
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Category>().ToTable("Categories");
            #endregion

            #region "primary keys"
            modelBuilder.Entity<Product>().HasKey(product => product.Id);
            modelBuilder.Entity<Category>().HasKey(category => category.Id);
            #endregion

            #region "Relationships"
            modelBuilder.Entity<Category>()
                .HasMany<Product>(category => category.Products)
                .WithOne(product => product.Category)
                .HasForeignKey(product => product.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion

            #region "Property configurations"

            #region products

            modelBuilder.Entity<Product>().Property(product => product.Name).IsRequired();

            modelBuilder.Entity<Product>().Property(product => product.Price).IsRequired();

            #endregion

            #region categories

            modelBuilder.Entity<Category>().Property(category => category.Name).IsRequired().HasMaxLength(100);

            #endregion

            #endregion
        }
    }
}