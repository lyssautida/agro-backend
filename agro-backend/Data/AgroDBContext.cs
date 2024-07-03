using agro_backend.Data.Map;
using agro_backend.Models;
using agro_models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Reflection.Emit;


namespace agro_backend.Data
{
    public class AgroDBContext : DbContext
    {
        protected readonly IConfiguration Configuration;  

        public AgroDBContext(IConfiguration configuration, DbSet<UsuarioModel> usuarios, DbSet<FazendaModel> fazendas, DbSet<TalhaoModel> talhoes)
        {
            Configuration = configuration;
            Usuarios = usuarios;
            Fazendas = fazendas;
            Talhoes = talhoes;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString("AgroDataBase"));
        }

        public AgroDBContext(DbContextOptions<AgroDBContext> options) : base(options) { }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<FazendaModel> Fazendas { get; set; }
        public DbSet<TalhaoModel> Talhoes { get; set; }

        /* protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
              modelBuilder.ApplyConfiguration(new UsuarioMap());
              modelBuilder.ApplyConfiguration(new FazendaMap());
              modelBuilder.ApplyConfiguration(new TalhaoMap());
              base.OnModelCreating(modelBuilder);
          }*/
    }
}
