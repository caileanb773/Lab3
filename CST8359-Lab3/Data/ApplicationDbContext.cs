using CST8359_Lab3.Models;
using Microsoft.EntityFrameworkCore;

namespace CST8359_Lab3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Rsvp> RsvpDbSet { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    }
}
