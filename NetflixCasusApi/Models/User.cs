using System;

namespace NetflixCasusApi.Models
{
    public class User
    {
        public int UserId { get; set; }
        public bool IsSubscriber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
