﻿using Application.Abstraction;
using MediatR;

namespace Application.Commands.MeetingCommands
{
    public class AddGuestsHandler : IRequestHandler<AddGuestsCommand>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddGuestsHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(AddGuestsCommand request, CancellationToken cancellationToken)
        {
            //await _unitOfWork.MeetingRepository.AddGuestsAsync(request.MeetingId, (IEnumerable<User>)request.UsersId);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
