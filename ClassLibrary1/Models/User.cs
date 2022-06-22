using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Direction { get; set; }
        public DateTime DateofBirth { get; set; }
<<<<<<< Updated upstream:ClassLibrary1/Models/Users.cs
=======
        public ICollection<Product> Products { get; set; }
>>>>>>> Stashed changes:ClassLibrary1/Models/User.cs
    }
}
