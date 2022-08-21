using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class SavingProductsInventary
    {
        public int Id { get; set; }
        public int InventaryId { get; set; }
        public Inventary Inventaries { get; set; }
        public int ProductId { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
