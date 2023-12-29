using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace FireDesk.Models
{
    public class TecnicosModel
    {
        public int TecnicoID { get; set; }

        [Required]
        public string? NomeTecnico { get; set; }

        [Required]
        public string? CPF { get; set; }
    }
}