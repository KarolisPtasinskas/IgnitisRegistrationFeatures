using IgnitisRegistrationFeatures.Models;
using Microsoft.EntityFrameworkCore;

namespace IgnitisRegistrationFeatures.Data
{
    public class RegistrationFormContext : DbContext
    {
        public DbSet<RegistrationForm> RegistrationForms { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        public RegistrationFormContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
