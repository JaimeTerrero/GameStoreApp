using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class SaveProductViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe colocar el nombre del producto")]
        [DataType(DataType.Text)]
        public string Name { get; set; }


        [Required(ErrorMessage = "Debe colocar la descripción del producto")]
        public string Description { get; set; }


        [Required(ErrorMessage = "Debe colocar el precio del producto")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }


        
        public string ImageUrl { get; set; }


        [Range(1, int.MaxValue, ErrorMessage = "Debe colocar la categoría del producto")]
        public int CategoryId { get; set; }


        public List<CategoryViewModel> Categories { get; set; }


        [DataType(DataType.Upload)]
        public IFormFile File { get; set; }
    }
}
