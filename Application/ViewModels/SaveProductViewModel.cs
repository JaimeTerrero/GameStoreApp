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
        public string Name { get; set; }

        [Required(ErrorMessage = "Debe colocar la descripción del producto")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Debe colocar el precio del producto")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Debe colocar la Url de la imagen")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Debe colocar la categoría del producto")]
        public int CategoryId { get; set; }

        public List<CategoryViewModel> Categories { get; set; }
    }
}
