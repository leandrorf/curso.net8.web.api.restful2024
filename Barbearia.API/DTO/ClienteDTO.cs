using System.ComponentModel.DataAnnotations;

namespace Barbearia.API.DTO
{
    public class ClienteDTO
    {
        public int ClienteId { get; set; }

        [Required]
        public string? Nome { get; set; }

        [Required]
        public string? Telefone { get; set; }

        [EmailAddress( ErrorMessage = "Favor digitar um e-mail válido." )]
        public string? Email { get; set; }

        [Required]
        [Display( Name = "Data de Nascimento" )]
        public DateTime DataNascimento { get; set; }
    }
}