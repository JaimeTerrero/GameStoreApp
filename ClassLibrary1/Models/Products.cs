using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        public int SalesId { get; set; }
        public Sales Sales { get; set; }
        public int InventaryId { get; set; }
        public Inventary Inventary { get; set; }
        public int UsersId { get; set; }
        public Users Users { get; set; }
        

    }
}
