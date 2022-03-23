using AllHouse.Application.Comands.HouseMembers.GetAllHouseMembers;
using AllHouse.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHouse.Application.Comands.HouseMembers.CreateHouseMember
{
    public class DeleteHouseMemberCommandHandler : IRequestHandler<DeleteHouseMemberCommand, Guid>
    {
        private readonly IHouseMemberRepository _houseMemberRepository;
        public DeleteHouseMemberCommandHandler(IHouseMemberRepository houseMemberRepository)
        {
            _houseMemberRepository = houseMemberRepository;
        }
        public async Task<Guid> Handle(DeleteHouseMemberCommand request, CancellationToken cancellationToken)
        {
            return await _houseMemberRepository.Delete(request.Id);
        }
    }
}
