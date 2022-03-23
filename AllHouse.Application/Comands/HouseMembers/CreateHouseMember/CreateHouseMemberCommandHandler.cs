using AllHouse.Domain.Entities;
using AllHouse.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHouse.Application.Comands.HouseMembers.CreateHouseMember
{
    public class CreateHouseMemberCommandHandler : IRequestHandler<CreateHouseMemberCommand, HouseMember>
    {
        private readonly IHouseMemberRepository _houseMemberRepository;
        public CreateHouseMemberCommandHandler(IHouseMemberRepository houseMemberRepository)
        {
            _houseMemberRepository = houseMemberRepository;
        }
        public async Task<HouseMember> Handle(CreateHouseMemberCommand request, CancellationToken cancellationToken)
        {
            var houseMember = new HouseMember
            {
                Name = request.Name,
                Nick = request.Nick,
                IsActive = true
            };

            return await _houseMemberRepository.Create(houseMember);
        }
    }
}
