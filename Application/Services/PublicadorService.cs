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
    private readonly AddPublicador _addPublicador;
    public PublicadorService(GetAllPublicadores getAllPublicadores, AddPublicador addPublicador)
    {
        _getAllPublicadores = getAllPublicadores;
        _addPublicador = addPublicador;
    }

    public IQueryable<PublicadorDto> Entities => throw new NotImplementedException();

    public int AddAsync(PublicadorDto entity)
    {
        return _addPublicador.ExecuteAsync(entity);
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