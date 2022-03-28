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
    public class MatriculaConfiguration : IEntityTypeConfiguration<Matricula>
    {
        public void Configure(EntityTypeBuilder<Matricula> builder)
        {
            builder.ToTable("matricula");

            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .IsRequired()
                .HasColumnName("id");

            builder
                .Property(x => x.AlunoId)
                .IsRequired()
                .HasColumnName("aluno_id");

            
        }
    }
}
