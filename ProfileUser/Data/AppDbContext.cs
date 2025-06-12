using Microsoft.EntityFrameworkCore;
using ProfileUser.Model;
using System.Collections.Generic;

namespace ProfileUser.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}