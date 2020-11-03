using Microsoft.EntityFrameworkCore;
using WebAPIInput.Models;

namespace WebAPIInput.Persistence
{
    public class InputNumberContext : DbContext
    {
        public InputNumberContext(DbContextOptions<InputNumberContext> options)
            : base(options)
        {
        }

        public DbSet<InputNumber> Numbers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<InputNumber>().ToTable("Number");
        }
    }
}
