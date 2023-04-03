﻿using Domain.Entities;
using Domain.Entities.OportunityEntities;

namespace Application.Abstraction
{
    public interface IOportunityRepository
    {
        public Task CreateAsync(Oportunity oportunity);
        public Task UpdateAsync(int id,Oportunity oportunity);
        public Task Delete(int id);
        public Task<int> GetOportunitiesNumber();
        public Task<Oportunity> GetAsync(int id);
        public Task<IEnumerable<Oportunity>> GetAllAsync();
        public Task<IEnumerable<Oportunity>> GetOportunitiesPageAsync(int page);
        public Task AddApplicantAsync(int oportunityId, int userId,int positionId);
        public Task<List<User>> GetOportunityApplicantsForPositionAsync(int oportunityId, int positionId);
        public Task<List<Oportunity>> GetAvailableOportunitiesAsync();
    }
}
