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
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //FLUENT API

            #region tables
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Category>().ToTable("Categories");
            modelBuilder.Entity<User>().ToTable("Users");
            #endregion

            #region "primary keys"
            modelBuilder.Entity<Product>().HasKey(product => product.Id);
            modelBuilder.Entity<Category>().HasKey(category => category.Id);
            modelBuilder.Entity<User>().HasKey(user => user.Id);
            #endregion

            #region "Relationships"
            modelBuilder.Entity<Category>()
                .HasMany<Product>(category => category.Products)
                .WithOne(product => product.Category)
                .HasForeignKey(product => product.CategoryId)
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

            modelBuilder.Entity<Product>().Property(product => product.Price).IsRequired();

            #endregion

            #region categories

            modelBuilder.Entity<Category>().Property(category => category.Name).IsRequired().HasMaxLength(100);

            #endregion

            #region users

            modelBuilder.Entity<User>().Property(user => user.Username).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<User>().Property(user => user.Password).IsRequired();
            modelBuilder.Entity<User>().Property(user => user.Name).IsRequired().HasMaxLength(150);
            modelBuilder.Entity<User>().Property(user => user.Email).IsRequired();
            modelBuilder.Entity<User>().Property(user => user.Phone).IsRequired();

            #endregion

            #endregion
        }
    }
}