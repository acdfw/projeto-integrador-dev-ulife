using Anima.ProjetoIntegrador.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Configurations
{
    public class AvaliacaoConfiguration : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.ToTable("avaliacao");

            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .IsRequired()
                .HasColumnName("id");

            builder
                .Property(x => x.TurmaId)
                .HasColumnName("turma_id");

            builder
                .Property(x => x.ProvaId)
                .HasColumnName("prova_id");
            
            builder
                .Property(x => x.Nome)
                .HasColumnName("nome");

            builder
                .HasMany<Turma>();
        }
    }
}
