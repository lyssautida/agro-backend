using agro_backend.Data.Map;
using agro_backend.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace agro_backend.Data
{
    public class AgroDBContext : DbContext
    {
        public AgroDBContext(DbContextOptions<AgroDBContext> options) : base(options) { }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<FazendaModel> Fazendas { get; set; }
        public DbSet<TalhaoModel> Talhoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new FazendaMap());
            base.OnModelCreating(modelBuilder);
        }
    } 
}
