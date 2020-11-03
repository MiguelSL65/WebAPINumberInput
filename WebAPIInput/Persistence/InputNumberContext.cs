using Microsoft.EntityFrameworkCore;
using WebAPIInput.Models;

namespace WebAPIInput.Persistence
{
    public class InputNumberContext : DbContext
    {
        /**
         * Configures a DbContext to connect a Database
         */
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
