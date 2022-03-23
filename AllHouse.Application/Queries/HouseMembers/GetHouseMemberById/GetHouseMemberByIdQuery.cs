using AllHouse.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHouse.Application.Queries.HouseMembers.GetHouseMemberById
{
    public class GetHouseMemberByIdQuery : IRequest<IEnumerable<HouseMember>>
    {
        public Guid Id { get; set; }
        public GetHouseMemberByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
