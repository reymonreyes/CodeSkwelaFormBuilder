using CodeSkwelaFormBuilder.Blazor.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeSkwelaFormBuilder.Blazor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Data\\localdatabase.db");
        }

        public DbSet<Form> Forms { get; set; }
        public DbSet<FormControl> FormControls { get; set; }
    }
}
