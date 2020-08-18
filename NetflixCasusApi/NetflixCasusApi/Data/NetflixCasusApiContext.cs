using Microsoft.EntityFrameworkCore;
using NetflixCasusApi.Models;

namespace NetflixCasusApi.Data
{
    public class NetflixCasusApiContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieMovieRating>()
                .HasKey(mmr => new { mmr.MovieId, mmr.MovieRatingId });
            modelBuilder.Entity<MovieMovieRating>()
                .HasOne(mmr => mmr.Movie)
                .WithMany(m => m.MovieRatings)
                .HasForeignKey(mr => mr.MovieId);
            modelBuilder.Entity<MovieMovieRating>()
                .HasOne(mmr => mmr.MovieRating)
                .WithMany(mr => mr.Movies)
                .HasForeignKey(m => m.MovieRatingId);
        }


        public NetflixCasusApiContext (DbContextOptions<NetflixCasusApiContext> options)
            : base(options)
        {
        }

        public DbSet<NetflixCasusApi.Models.User> User { get; set; }

        public DbSet<NetflixCasusApi.Models.MovieRating> MovieRating { get; set; }

        public DbSet<NetflixCasusApi.Models.Movie> Movie { get; set; }

        public DbSet<NetflixCasusApi.Models.Subscription> Subscription { get; set; }

        public DbSet<NetflixCasusApi.Models.Actor> Actor { get; set; }
    }
}
