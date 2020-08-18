using System;
namespace CinemaApp.Models
{
    public class CinemaUserModel
    {
        public int UserId { get; set; }
        public int UserType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
    }
}