using Anima.ProjetoIntegrador.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Configurations
{
    public class FolhaRespostaConfiguration : IEntityTypeConfiguration<FolhaResposta>
    {
        public void Configure(EntityTypeBuilder<FolhaResposta> builder)
        {
            builder.ToTable("folha_resposta");

            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .IsRequired()
                .HasColumnName("id");

            builder
                .Property(x => x.AvaliacaoMatriculaId)
                .HasColumnName("avaliacao_matricula_id");

            builder
                 .Property(x => x.QuestaoId)
                 .HasColumnName("questao_id");

            builder
                 .Property(x => x.AlternativaId)
                 .HasColumnName("alternativa_id");
        }
    }
}
