﻿using Hackaton.Application.Models.Usuario;

namespace Hackaton.Application.Contracts.UseCases.Usuarios
{
    public interface IUsuarioCadastrarMedicoUseCase
    {
        Task<UsuarioCadastrarMedicoOutputDto> ExecuteAsync(UsuarioCadastrarMedicoInputDto input);
    }
}
