using Hackaton.Application.Models.Usuario;
using Hackaton.Domain;

namespace Hackaton.Application.Contracts.Presenters
{
    public interface IUsuarioPresenter
    {
        UsuarioCadastrarMedicoOutputDto FromEntityToCadastroMedicoOutput(UsuarioEntity usuario);
    }
}
