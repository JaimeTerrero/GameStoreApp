using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class InventaryViewModel
    {
        public int Id { get; set; }
        public List<ProductViewModel> Products { get; set; }
        public List<SavingProductsInventaryViewModel> SavingProductsInventaries { get; set; }
        public int UserId { get; set; }
        public int Quantity { get; set; }
    }
}
