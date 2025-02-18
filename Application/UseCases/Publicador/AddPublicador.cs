using Application.DTOs;
using Application.Interfaces.Repositories;
using AutoMapper;
using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Publicador;

public class AddPublicador
{
    private readonly IPublicadorRepository _publicadorRepository;
    private readonly IMapper _mapper;
    public AddPublicador(IPublicadorRepository publicadorRepository, IMapper mapper) 
    { 
        _mapper = mapper;
        _publicadorRepository = publicadorRepository;
    }

    public int ExecuteAsync(PublicadorDto publicadorDto)
    {
        return _publicadorRepository.AddAsync(_mapper.Map<PublicadorDto, Domain.Entites.Publicador>(publicadorDto));
    }
}
