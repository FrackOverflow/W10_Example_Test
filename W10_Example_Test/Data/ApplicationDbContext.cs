using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using W10_Example_Test.Models;

namespace W10_Example_Test.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<W10_Example_Test.Models.Job> Job { get; set; } = default!;

        public DbSet<W10_Example_Test.Models.Candidate>? Candidate { get; set; }
    }
}
