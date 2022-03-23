using AllHouse.Domain.Entities;
using AllHouse.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHouse.Application.Comands.HouseTasksManagement.AutoAllocateHouseTaskToMembersCommand
{
    public class AutoAllocateHouseTaskToMembersCommand : IRequest<IEnumerable<HouseTaskManagement>>
    {
        public Guid HouseTaskId { get; set; }
        public IEnumerable<DayOfWeekEnum> DayOfWeeks { get; set; }
    }


}

