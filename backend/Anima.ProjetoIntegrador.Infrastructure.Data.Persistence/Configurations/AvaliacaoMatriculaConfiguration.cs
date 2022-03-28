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
                .HasMany<Avaliacao>();

            builder
                .HasMany<Matricula>();
        }
    }
}
