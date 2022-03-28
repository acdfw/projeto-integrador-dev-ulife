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
    public class AlternativaConfiguration : IEntityTypeConfiguration<Alternativa>
    {
        public void Configure(EntityTypeBuilder<Alternativa> builder)
        {
            builder.ToTable("alternativa");

            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .IsRequired()
                .HasColumnName("id");

            builder
                .Property(x => x.QuestaoId)
                .IsRequired()
                .HasColumnName("questao_id");

            builder
                .Property(x => x.Texto)
                .IsRequired()
                .HasColumnName("texto");

            builder
                .Property(x => x.AlternativaCorreta)
                .IsRequired()
                .HasColumnName("alternativa_correta");


        }
    }
}
