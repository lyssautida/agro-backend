namespace agro_models.Models
{
    public class TalhaoModel
    {
        public int Id { get; set;}
        public string Nome { get; set;}
        public string Coordenadas { get; set;}
        public int FazendaId { get; set;}
        public DateTime CriadoEm { get; set; }
        public DateTime? AtualizadoEm { get; set; }
        public DateTime? InativadoEm { get; set; }
    }
}