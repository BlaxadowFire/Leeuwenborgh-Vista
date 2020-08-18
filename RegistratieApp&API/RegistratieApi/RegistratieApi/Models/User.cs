using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RegistratieApi.Models
{
    public class User
    {
        [Key]
        public int OvNummer { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Registration> Registrations { get; set; }
        public User()
        {
            Registrations = new List<Registration>();
        }
    }
}
