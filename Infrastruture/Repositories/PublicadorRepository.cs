using Application.Interfaces.Repositories;
using Domain.Entites;
using Infrastruture.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastruture.Repositories
{
    public class PublicadorRepository : IPublicadorRepository
    {
        private readonly AppDbContext _appContext;

        public PublicadorRepository(AppDbContext appContext)
        {
            _appContext = appContext;   
        }

        public IQueryable<Publicador> Entities => throw new NotImplementedException();

        public Task<Publicador> AddAsync(Publicador entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Publicador entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Publicador>> GetAllAsync()
        {
            return await _appContext.Publicador.ToListAsync();
        }

        public Task<Publicador> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Publicador entity)
        {
            throw new NotImplementedException();
        }
    }
}
