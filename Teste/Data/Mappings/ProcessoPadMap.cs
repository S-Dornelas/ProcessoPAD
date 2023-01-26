using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teste.Models;

namespace Teste.Data.Mappings
{
    public class ProcessoPadMap : IEntityTypeConfiguration<ProcessoPad>
    {
        public void Configure(EntityTypeBuilder<ProcessoPad> builder)
        {
            builder.ToTable("ProcessoPad");
           
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();
            
            builder.Property(x => x.Id)
                .HasColumnName("Ordem")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(5);

            builder.Property(x => x.Numero)
                .HasColumnName("Numero")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(3);

            builder.Property(x => x.AnoFem)
                .HasColumnName("AnoFem")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(4);
            
            builder.Property(x => x.Municipio)
                .HasColumnName("municipio")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(20);
            
            builder.Property(x => x.Projeto)
                .HasColumnName("Projeto")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(100);

            builder.Property(x => x.TotalRecurso)
                .HasColumnName("TotalRecurso")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(10);
        }
    }

}