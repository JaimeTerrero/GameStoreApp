using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class SaveUserViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe colocar un nombre")]
        [DataType(DataType.Text)]
        public string Name { get; set; }



        [Required(ErrorMessage = "Debe colocar un correo")]
        [DataType(DataType.Text)]
        public string Email { get; set; }



        [Required(ErrorMessage = "Debe colocar un teléfono")]
        [DataType(DataType.Text)]
        public string Phone { get; set; }



        [Required(ErrorMessage = "Debe colocar el nombre de usuario")]
        [DataType(DataType.Text)]
        public string Username { get; set; }



        [Required(ErrorMessage = "Debe colocar una contraseña")]
        [DataType(DataType.Password)]
        public string Password { get; set; }



        [Compare(nameof(Password),ErrorMessage = "Las contraseñas deben coincidir")]
        [Required(ErrorMessage = "Debe colocar una contraseña")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
