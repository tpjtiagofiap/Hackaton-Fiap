using Hackaton.Application.Contracts.Repositories;
using Hackaton.Data.DataContext;
using Hackaton.Domain;

namespace Hackaton.Data.Repositories
{
    public class AgendaRepository : BaseRepository<AgendaEntity>, IAgendaRepository
    {
        public AgendaRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
