﻿using Application.Abstraction;
using Domain.Entities;
using MediatR;

namespace Application.Queries.TeamQueries
{
    public class GetTeamMembersHandler : IRequestHandler<GetTeamMembersQuery, IEnumerable<User>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetTeamMembersHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<User>> Handle(GetTeamMembersQuery request, CancellationToken cancellationToken)
        {
            var members = await _unitOfWork.TeamRepository.GetMembersAsync(request.TeamId);
            return members;
        }
    }
}
