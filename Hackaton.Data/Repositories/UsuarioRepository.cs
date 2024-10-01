using Hackaton.Application.Contracts.Repositories;
using Hackaton.Application.ObjetoValor;
using Hackaton.Data.DataContext;
using Hackaton.Domain;
using Microsoft.EntityFrameworkCore;

namespace Hackaton.Data.Repositories
{
    public class UsuarioRepository : BaseRepository<UsuarioEntity>, IUsuarioRepository
    {
        public UsuarioRepository(DatabaseContext context) : base(context)
        {
        }

        public async Task<UsuarioEntity?> GetByCpfOrEmail(Cpf cpf, Email email)
        {
            return await _dbSet
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Cpf.Equals(cpf.Valor) || p.Email.Equals(email.Valor));
        }

        public async Task<UsuarioEntity?> GetByCrmAndStateAsync(string crm, string estado)
        {
            return await _dbSet
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Crm.Equals(crm) && p.Estado.Equals(estado));
        }
    }
}
