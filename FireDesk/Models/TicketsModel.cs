namespace FireDesk.Models
{
    public class TicketsModel
    {
        public int TicketID { get; set; }
        public string? Assunto { get; set; }
        public string? Descricao { get; set; }
        public string? Status { get; set; }
        public string? Tecnico { get; set; }
        public string? UsuarioAbertura { get; set; }
    }
}