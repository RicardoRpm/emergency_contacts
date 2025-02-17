using Application.DTOs;
using Application.Interfaces.Repositories;
using AutoMapper;
using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Publicador
{
    public class GetAllPublicadores
    {
        private readonly IPublicadorRepository _publicadorRepository;
        private readonly IMapper _mapper;
        public GetAllPublicadores(IPublicadorRepository publicadorRepository, IMapper mapper)
        {
            _publicadorRepository = publicadorRepository;
            _mapper = mapper;
        }

        public async Task<List<PublicadorDto>> ExecuteAsync()
        {
            var publicadores = await _publicadorRepository.GetAllAsync();
            return _mapper.Map<List<PublicadorDto>>(publicadores);
        } 
    }
}