using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MIS421Capstone.Models;

namespace MIS421Capstone.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MIS421Capstone.Models.Exercise> Exercise { get; set; }
        public DbSet<MIS421Capstone.Models.Food> Food { get; set; }
        public DbSet<MIS421Capstone.Models.Workout> Workout { get; set; }
        public DbSet<MIS421Capstone.Models.Day> Day { get; set; }
    }
}