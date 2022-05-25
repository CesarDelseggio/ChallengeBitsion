using ChallengeBitsion.DataAccess.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace ChallengeBitsion.DataAccess
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {

        }

        public DbSet<Log> Logs { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Log>().HasData(
                new Log() { Id = 1, Date = DateTime.Now, Title = "First Log", Message = "Data for test services" },
                new Log() { Id = 2, Date = DateTime.Now, Title = "Second Log", Message = "This message is not valid" },
                new Log() { Id = 3, Date = DateTime.Now, Title = "Third Log", Message = "Data access faild" });
        }
    }
}
