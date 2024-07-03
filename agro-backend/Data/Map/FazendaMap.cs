using agro_backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace agro_backend.Data.Map
{
    public class FazendaMap : IEntityTypeConfiguration<FazendaModel>
    {
        public void Configure(EntityTypeBuilder<FazendaModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Coordenadas).IsRequired().HasMaxLength(1000);
            builder.Property(x => x.UsuarioId).IsRequired();
            builder.Property(x => x.CriadoEm).IsRequired();
            builder.Property(x => x.AtualizadoEm);
            builder.Property(x => x.InativadoEm);
        }
    }
}
