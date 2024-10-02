using Hackaton.Application.Contracts.UseCases.Agenda;
using Hackaton.Application.Enums;
using Hackaton.Application.Models.Agenda.Cadastrar;
using Hackaton.Application.Models.Agenda.Editar;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hackaton.Controllers
{
    [ApiController]
    [Route("/api/agenda")]
    public class AgendaController : ControllerBase
    {
        private readonly IAgendaCadastrarUseCase _agendaCadastrarUseCase;
        private readonly IAgendaEditarUseCase _agendaEditarUseCase;
        private readonly IAgendaExcluirUseCase _agendaExcluirUseCase;

        public AgendaController(
            IAgendaCadastrarUseCase agendaCadastrarUseCase,
            IAgendaEditarUseCase agendaEditarUseCase,
            IAgendaExcluirUseCase agendaExcluirUseCase)
        {
            _agendaCadastrarUseCase = agendaCadastrarUseCase;
            _agendaEditarUseCase = agendaEditarUseCase;
            _agendaExcluirUseCase = agendaExcluirUseCase;
        }

        [Authorize(Roles = nameof(EPerfil.Medico))]
        [HttpPost("cadastrar")]
        public async Task<ActionResult<AgendaCadastrarOutputDto>> CadastrarHorario(AgendaCadastrarInputDto input)
        {
            var id = int.Parse(User.Claims.FirstOrDefault(c => c.Type == "Id").Value);
            return Ok(await _agendaCadastrarUseCase.ExecuteAsync(input, id));
        }

        [Authorize(Roles = nameof(EPerfil.Medico))]
        [HttpPost("editar")]
        public async Task<ActionResult<AgendaCadastrarOutputDto>> EditarHorario(AgendaEditarInputDto input)
        {
            var id = int.Parse(User.Claims.FirstOrDefault(c => c.Type == "Id").Value);
            return Ok(await _agendaEditarUseCase.ExecuteAsync(input, id));
        }

        [Authorize(Roles = nameof(EPerfil.Medico))]
        [HttpGet("excluir/{agendaId:int}")]
        public async Task<ActionResult<AgendaCadastrarOutputDto>> ExcluirHorario(int agendaId)
        {
            var id = int.Parse(User.Claims.FirstOrDefault(c => c.Type == "Id").Value);
            await _agendaExcluirUseCase.ExecuteAsync(agendaId, id);

            return Ok("Horário excluído com sucesso");
        }
    }
}
