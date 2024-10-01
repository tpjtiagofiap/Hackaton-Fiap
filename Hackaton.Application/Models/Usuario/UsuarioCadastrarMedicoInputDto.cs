using System.ComponentModel.DataAnnotations;

namespace Hackaton.Application.Models.Usuario
{
    public class UsuarioCadastrarMedicoInputDto
    {
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [MinLength(4)]
        public string Senha { get; set; } = string.Empty;

        [Required]
        public string Cpf { get; set; } = string.Empty;

        [Required]
        public string Crm { get; set; } = string.Empty;

        [Required]
        [MinLength(2)]
        [MaxLength(2)]
        public string Estado { get; set; } = string.Empty;

        [Required]
        public string Nome { get; set; } = string.Empty;
    }
}
