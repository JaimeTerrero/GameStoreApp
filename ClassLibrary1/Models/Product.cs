﻿using System;
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


        
        public int CategoryId { get; set; } //Foreign Key
        // Navigation Properties
        public Category Category { get; set; }


        
        public int UserId { get; set; } //Foreign Key
        // Navigation Properties
        public User User { get; set; } // Un producto pertenece a un Usuario

    }
}
