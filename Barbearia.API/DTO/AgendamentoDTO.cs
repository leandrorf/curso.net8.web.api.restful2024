using Barbearia.API.Models;
using System.ComponentModel.DataAnnotations;

namespace Barbearia.API.DTO
{
    public class AgendamentoDTO
    {
        public int AgendamentoID { get; set; }

        [Required]
        public DateTime DataHora { get; set; }

        public string? Observacoes { get; set; }

        [Required]
        public int Status { get; set; }

        [Required]
        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }

        public virtual ICollection<Servico> Servicos { get; set; }
    }
}