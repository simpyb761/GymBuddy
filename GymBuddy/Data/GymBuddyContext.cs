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
        public GymBuddyContext (DbContextOptions<GymBuddyContext> options)
            : base(options)
        {
        }

        public DbSet<GymBuddy.Models.Exercises> Exercises { get; set; } = default!;
    }
}
