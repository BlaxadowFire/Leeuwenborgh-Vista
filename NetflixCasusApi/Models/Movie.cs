using System.Collections.Generic;

namespace NetflixCasusApi.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public ICollection<MovieRating> MovieRatings { get; set; }
        public string Category { get; set; }
        public ICollection<Actor> Actors { get; set; }
    }
}
