using AllHouse.Domain.Entities;
using AllHouse.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHouse.Application.Queries.HouseMembers.GetAllHouseMembers
{
    public class GetAllHouseMembersQueryHandler : IRequestHandler<GetAllHouseMembersQuery, IEnumerable<HouseMember>>
    {
        private readonly IHouseMemberRepository _houseMemberRepository;
        public GetAllHouseMembersQueryHandler(IHouseMemberRepository houseMemberRepository)
        {
            _houseMemberRepository = houseMemberRepository;
        }
        public Task<IEnumerable<HouseMember>> Handle(GetAllHouseMembersQuery request, CancellationToken cancellationToken)
        {
            return _houseMemberRepository.GetAll();
        }
    }
}
