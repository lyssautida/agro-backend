namespace agro_backend.Models
{
    public class FazendaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Coordenadas { get; set; } 
        public int UsuarioId { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime? AtualizadoEm { get; set; }
        public DateTime? InativadoEm { get; set; }
    }
}
