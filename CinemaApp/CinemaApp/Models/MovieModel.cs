using System;
namespace CinemaApp.Models
{
    public class MovieModel
    {
        public int MovieId { get; set; }
        public string Titel { get; set; }
        public TimeSpan Duration { get; set; }
        public int MinimumAge { get; set; }
    }
}
