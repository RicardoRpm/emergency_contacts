using Application.DTOs;
using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Application.UseCases.Publicador;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services;

public class PublicadorService : IPublicadorService
{
    private GetAllPublicadores _getAllPublicadores;
    public PublicadorService(GetAllPublicadores getAllPublicadores)
    {
        _getAllPublicadores = getAllPublicadores;
    }

    public IQueryable<PublicadorDto> Entities => throw new NotImplementedException();

    public int AddAsync(PublicadorDto entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(PublicadorDto entity)
    {
        throw new NotImplementedException();
    }

    public async Task<List<PublicadorDto>> GetAllAsync()
    {
        return await _getAllPublicadores.ExecuteAsync();
    }

    public Task<PublicadorDto> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(PublicadorDto entity)
    {
        throw new NotImplementedException();
    }
}