﻿using System;
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
<<<<<<< Updated upstream
<<<<<<< Updated upstream

=======
        public ICollection<Product> Products { get; set; }
>>>>>>> Stashed changes
=======
        public ICollection<Product> Products { get; set; }
>>>>>>> Stashed changes
    }
}
