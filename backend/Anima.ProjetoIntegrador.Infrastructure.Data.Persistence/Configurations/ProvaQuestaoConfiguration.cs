using Anima.ProjetoIntegrador.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Configurations
{
    public class ProvaQuestaoConfiguration : IEntityTypeConfiguration<ProvaQuestao>
    {
        public void Configure(EntityTypeBuilder<ProvaQuestao> builder)
        {
            builder.ToTable("prova_questao");

            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .IsRequired()
                .HasColumnName("id");

            builder
                .Property(x => x.ProvaId)
                .HasColumnName("prova_id");

            builder
                .Property(x => x.QuestaoId)
                .HasColumnName("questao_id");

            builder
                .HasMany<Questao>();
        }
    }
}
