using AllHouse.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHouse.Application.Comands.HouseMembers.CreateHouseMember
{
    public class CreateHouseMemberCommand : IRequest<CreateHouseMemberResponse>
    {
        public string Name { get; set; }
        public string Nick { get; set; }
    }
}
