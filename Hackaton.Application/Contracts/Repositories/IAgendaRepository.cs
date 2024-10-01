using Hackaton.Domain;

namespace Hackaton.Application.Contracts.Repositories
{
    public interface IAgendaRepository : IBaseRepository<AgendaEntity>
    {
        public Task<IEnumerable<AgendaEntity>> GetAgendasByMedicoId(int medicoId);
    }
}
