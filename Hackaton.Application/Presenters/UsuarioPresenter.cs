using Hackaton.Application.Contracts.Presenters;
using Hackaton.Application.Models.Usuario;
using Hackaton.Domain;

namespace Hackaton.Application.Presenters
{
    public class UsuarioPresenter : IUsuarioPresenter
    {
        public UsuarioCadastrarMedicoOutputDto FromEntityToCadastroMedicoOutput(UsuarioEntity usuario)
        {
            return new UsuarioCadastrarMedicoOutputDto
            {
                Id = usuario.Id,
                Cpf = usuario.Cpf,
                Crm = usuario.Crm,
                Email = usuario.Email,
                Estado = usuario.Estado,
                Nome = usuario.Nome,
            };
        }
    }
}
