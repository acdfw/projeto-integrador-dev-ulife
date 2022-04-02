using Anima.ProjetoIntegrador.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Configurations
{
    public class TurmaConfiguration : IEntityTypeConfiguration<Turma>
    {
        public void Configure(EntityTypeBuilder<Turma> builder)
        {
            builder.ToTable("turma");

            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .IsRequired()
                .HasColumnName("id");

            builder
                .Property(x => x.Nome)
                .IsRequired()
                .HasColumnName("nome");

            builder
                .Property(x => x.ProfessorId)
                .IsRequired()
                .HasColumnName("professor_id");

            
        }
    }
}
