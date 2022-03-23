using AllHouse.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHouse.Domain.Interfaces.Repositories
{
    public interface IHouseTaskManagementRepository : IBaseRepository<HouseTaskManagement>
    {
        Task<IEnumerable<HouseTaskManagement>> GetAllByHouseTaskId(Guid houseTaskId);
        Task<IEnumerable<HouseTaskManagement>> GetAllByHouseMemberId(Guid houseMemberId);
    }
}
