using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class Inventary
    {
        public int Id { get; set; }
        public string ProvidersName { get; set; }
        public int Quantity { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
