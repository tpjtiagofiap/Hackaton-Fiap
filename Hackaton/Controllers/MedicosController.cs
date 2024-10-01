using Hackaton.Application.Contracts.UseCases.Medicos;
using Hackaton.Application.Models.Medicos;
using Microsoft.AspNetCore.Mvc;

namespace Hackaton.Controllers
{
    [ApiController]
    [Route("/api/medicos")]
    public class MedicosController : ControllerBase
    {
        private readonly IMedicoBuscarTodosUseCase _medicoBuscarTodosUseCase;

        public MedicosController(
            IMedicoBuscarTodosUseCase medicoBuscarTodosUseCase
        )
        {
            _medicoBuscarTodosUseCase = medicoBuscarTodosUseCase;
        }

        [HttpGet("todos")]
        public async Task<ActionResult<IEnumerable<MedicoOutputDto>>> BuscarTodosAsync()
        {
            return Ok(await _medicoBuscarTodosUseCase.ExecuteAsync());
        }
    }
}
