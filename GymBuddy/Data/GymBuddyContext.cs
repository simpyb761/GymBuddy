using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GymBuddy.Models;

namespace GymBuddy.Data
{
    public class GymBuddyContext : DbContext
    {
        public GymBuddyContext(DbContextOptions<GymBuddyContext> options) : base(options) { }
        public DbSet<Exercises> Exercises { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Exercises>()
                .Property(p => p.TrainingLevel)
                .HasConversion(
                    v => v.ToString(),
                    v => (TrainingLevel)Enum.Parse(typeof(TrainingLevel), v));

            modelBuilder
                .Entity<Exercises>()
                .Property (p => p.IntensityLevel)
                .HasConversion(
                    v => v.ToString(),
                    v => (IntensityLevel)Enum.Parse(typeof(IntensityLevel), v));
        }
    }
}
