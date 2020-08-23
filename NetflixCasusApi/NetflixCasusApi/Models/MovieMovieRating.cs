namespace NetflixCasusApi.Models
{
    public class MovieMovieRating
    {
        public Movie Movie { get; set; }
        public MovieRating MovieRating { get; set; }
        public int MovieId { get; set; }
        public int MovieRatingId { get; set; }
    }
}
