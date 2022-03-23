using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHouse.Application.Comands.HouseMembers.CreateHouseMember
{
    public class CreateHouseMemberResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Nick { get; set; }
        public bool IsActive { get; set; }
    }
}
