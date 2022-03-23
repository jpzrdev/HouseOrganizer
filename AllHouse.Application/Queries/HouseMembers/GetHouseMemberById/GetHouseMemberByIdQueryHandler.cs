using AllHouse.Domain.Entities;
using AllHouse.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHouse.Application.Queries.HouseMembers.GetHouseMemberById
{
    public class GetHouseMemberByIdQueryHandler : IRequestHandler<GetHouseMemberByIdQuery, IEnumerable<HouseMember>>
    {
        private readonly IHouseMemberRepository _houseMemberRepository;
        public GetHouseMemberByIdQueryHandler(IHouseMemberRepository houseMemberRepository)
        {
            _houseMemberRepository = houseMemberRepository;
        }
        public Task<IEnumerable<HouseMember>> Handle(GetHouseMemberByIdQuery request, CancellationToken cancellationToken)
        {
            return _houseMemberRepository.GetAll();
        }
    }
}
