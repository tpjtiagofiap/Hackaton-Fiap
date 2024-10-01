using Hackaton.Application.Contracts.Repositories;
using Hackaton.Application.Contracts.UseCases.Usuarios;
using Hackaton.Application.Models.Usuario;
using Microsoft.AspNetCore.Mvc;

namespace Hackaton.Controllers
{
    [ApiController]
    [Route("/api/usuarios")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioCadastrarMedicoUseCase _usuarioCadastrarMedicoUseCase;

        public UsuarioController(
            IUsuarioCadastrarMedicoUseCase usuarioCadastrarMedicoUseCase
        )
        {
            _usuarioCadastrarMedicoUseCase = usuarioCadastrarMedicoUseCase;
        }

        [HttpPost("medico")]
        public async Task<IActionResult> CadastrarMedico(UsuarioCadastrarMedicoInputDto input)
        {
            return Ok(await _usuarioCadastrarMedicoUseCase.ExecuteAsync(input));
        }
    }
}
