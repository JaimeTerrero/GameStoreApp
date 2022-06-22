using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }
<<<<<<< Updated upstream:ClassLibrary1/Models/Sales.cs
=======

        public ICollection<Product> Products { get; set; }
<<<<<<< Updated upstream:ClassLibrary1/Models/Sale.cs
>>>>>>> Stashed changes:ClassLibrary1/Models/Sale.cs
=======
>>>>>>> Stashed changes:ClassLibrary1/Models/Sales.cs
    }
}
