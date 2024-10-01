﻿using Hackaton.Domain;

namespace Hackaton.Application.Contracts.Repositories
{
    public interface IUsuarioRepository : IBaseRepository<UsuarioEntity>
    {
        Task<UsuarioEntity?> GetByCrmAndStateAsync(string crm, string estado);
    }
}
