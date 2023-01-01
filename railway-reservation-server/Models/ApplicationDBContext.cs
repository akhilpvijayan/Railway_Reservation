using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Passengers> Passengers { get; set; }
        public DbSet<Stations> Stations { get; set; }
        public DbSet<Trains> Trains { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<Seats> Seats { get; set; }
        public DbSet<TrainTypes> Traintypes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
