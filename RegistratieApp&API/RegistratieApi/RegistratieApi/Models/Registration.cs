using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistratieApi.Models
{
    public class Registration
    {
        [Key]
        public int RegistrationId { get; set; }
        public DateTime RegistrationDateTime { get; set; }
        public int UserId { get; set; }
    }
}
