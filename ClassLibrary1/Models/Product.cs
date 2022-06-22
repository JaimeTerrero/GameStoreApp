using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
<<<<<<< Updated upstream:ClassLibrary1/Models/Products.cs
=======


        public int SaleId { get; set; }
        public Sale Sale { get; set; }
        public int InventaryId { get; set; }
        public Inventary Inventary { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
>>>>>>> Stashed changes:ClassLibrary1/Models/Product.cs
    }
}
