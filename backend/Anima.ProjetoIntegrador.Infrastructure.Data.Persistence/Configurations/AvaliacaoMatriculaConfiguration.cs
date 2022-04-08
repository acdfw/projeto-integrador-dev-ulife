using Anima.ProjetoIntegrador.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Configurations
{
    public class AvaliacaoMatriculaConfiguration : IEntityTypeConfiguration<AvaliacaoMatricula>
    {
        public void Configure(EntityTypeBuilder<AvaliacaoMatricula> builder)
        {
            builder.ToTable("avaliacao_matricula");

            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .IsRequired()
                .HasColumnName("id");

            builder
                .Property(x => x.MatriculaId)
                .HasColumnName("matricula_id");

            builder
                 .Property(x => x.AvaliacaoId)
                 .HasColumnName("avaliacao_id");

            builder
                 .Property(x => x.Nota)
                 .HasColumnName("nota");

            builder
                .HasMany<Avaliacao>();

            builder
                .HasMany<Matricula>();
        }
    }
}
