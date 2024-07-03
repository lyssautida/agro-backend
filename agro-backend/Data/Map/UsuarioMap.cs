using agro_backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace agro_backend.Data.Map
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Senha).IsRequired().HasMaxLength(255);
            builder.Property(x => x.CriadoEm).IsRequired();
            builder.Property(x => x.AtualizadoEm);
            builder.Property(x => x.InativadoEm);
        }
    }
}
