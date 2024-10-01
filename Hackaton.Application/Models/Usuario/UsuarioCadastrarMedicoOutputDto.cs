using System.ComponentModel.DataAnnotations;

namespace Hackaton.Application.Models.Usuario
{
    public class UsuarioCadastrarMedicoOutputDto
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public string Crm { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
    }
}
