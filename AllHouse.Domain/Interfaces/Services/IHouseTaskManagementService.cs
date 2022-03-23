using AllHouse.Domain.Entities;
using AllHouse.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHouse.Domain.Interfaces.Services
{
    public interface IHouseTaskManagementService
    {
        Task<IEnumerable<HouseTaskManagement>> AutoAllocateHouseTaskToMembersInWeekly(Guid houseTaskId, IEnumerable<DayOfWeekEnum> daysToDistribuit);
    }
}
