using Microsoft.EntityFrameworkCore;
using Teste.Models;

namespace Teste.Data
{
    public class TesteDataContext : DbContext
    {
        public DbSet<ProcessoPad> ProcessoPads { get; set; }
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Password=Dornelas;Persist Security Info=True;User ID=sa;Initial Catalog=Db_Processo;Data Source=DORNELAS;Trust Server Certificate=true");
        }
    }
}