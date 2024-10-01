using Hackaton.Application.Contracts.Presenters;
using Hackaton.Application.Contracts.Repositories;
using Hackaton.Application.Contracts.UseCases.Medicos;
using Hackaton.Application.Models.Medicos;

namespace Hackaton.Application.UseCases.Medicos
{
    public class MedicoBuscarTodosUseCase : IMedicoBuscarTodosUseCase
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IUsuarioPresenter _usuarioPresenter;

        public MedicoBuscarTodosUseCase(
            IUsuarioRepository usuarioRepository,
            IUsuarioPresenter usuarioPresenter
        )
        {
            _usuarioRepository = usuarioRepository;
            _usuarioPresenter = usuarioPresenter;
        }

        public async Task<IEnumerable<MedicoOutputDto>> ExecuteAsync()
        {
            var data = await _usuarioRepository.GetAllMedicos();

            return data.Select(p => _usuarioPresenter.FromEntityToMedicoOutput(p)).ToList();
        }
    }
}
