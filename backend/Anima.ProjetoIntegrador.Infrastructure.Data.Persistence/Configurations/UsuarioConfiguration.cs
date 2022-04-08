using Anima.ProjetoIntegrador.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Anima.ProjetoIntegrador.Infrastructure.Data.Persistence.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuario");

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
                .Property(x => x.Login)
                .IsRequired()
                .HasColumnName("login");


            builder
                .Property(x => x.Senha)
                .IsRequired()
                .HasColumnName("senha");

            builder
                .Property(x => x.Role)
                .IsRequired()
                .HasColumnName("role");
        }
    }
}
