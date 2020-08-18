using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RegistratieApi.Models;

namespace RegistratieApi.Data
{
    public class RegistratieApiContext : DbContext
    {
        public RegistratieApiContext (DbContextOptions<RegistratieApiContext> options)
            : base(options)
        {
        }

        public DbSet<RegistratieApi.Models.User> User { get; set; }

        public DbSet<RegistratieApi.Models.Registration> Registration { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>()
        //        .HasMany(u => u.Registrations)
        //        .WithOne(r => r.RegistrationUser);
        //}
    }
}
