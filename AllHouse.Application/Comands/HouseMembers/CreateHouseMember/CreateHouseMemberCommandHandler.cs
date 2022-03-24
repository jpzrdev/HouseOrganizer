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
    public class CreateHouseMemberCommandHandler : IRequestHandler<CreateHouseMemberCommand, CreateHouseMemberResponse>
    {
        private readonly IHouseMemberRepository _houseMemberRepository;
        public CreateHouseMemberCommandHandler(IHouseMemberRepository houseMemberRepository)
        {
            _houseMemberRepository = houseMemberRepository;
        }
        public async Task<CreateHouseMemberResponse> Handle(CreateHouseMemberCommand request, CancellationToken cancellationToken)
        {
            var houseMember = new HouseMember
            {
                Name = request.Name,
                Nick = request.Nick,
                IsActive = true
            };

            var houseMemberEntity = await _houseMemberRepository.Create(houseMember);

            var createHouseMemberReponse = new CreateHouseMemberResponse
            {
                Id = houseMemberEntity.Id,
                Name = houseMemberEntity.Name,
                Nick = houseMemberEntity.Nick,
                IsActive = houseMemberEntity.IsActive
            };

            return createHouseMemberReponse;
        }
    }
}
