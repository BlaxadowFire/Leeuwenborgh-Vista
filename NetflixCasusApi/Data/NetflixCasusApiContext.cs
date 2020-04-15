using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetflixCasusApi.Models;

namespace NetflixCasusApi.Data
{
    public class NetflixCasusApiContext : DbContext
    {
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
