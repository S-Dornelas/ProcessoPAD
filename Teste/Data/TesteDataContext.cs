using Microsoft.EntityFrameworkCore;
using Teste.Models;

namespace Teste.Data
{
    public class TesteDataContext : DbContext
    {
        public DbSet<ProcessoPad> ProcessoPads { get; set; }
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("CONNECTION-STRING");
        }
    }
}
