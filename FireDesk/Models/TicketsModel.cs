using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace FireDesk.Models
{
    public class TicketsModel
    {
        [Required]
        public int TicketID { get; set; }

        [Required]
        public string? Assunto { get; set; }

        [Required]
        public string? Descricao { get; set; }

        public string? Status { get; set; }

        [Required]
        public string? Tecnico { get; set; }

        public string? UsuarioAbertura { get; set; } = null;
        public string? UsuarioFechamento { get; set; } = null;

        [Required]
        public DateTime DataAbertura { get; set; }

        [Required]
        public string? Prioridade { get; set; }
    }
}