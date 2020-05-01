using System.Collections.Generic;

namespace NetflixCasusApi.Models
{
    public class MovieRating
    {
        public int MovieRatingId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public ICollection<MovieMovieRating> Movies{ get; set; }
    }
}