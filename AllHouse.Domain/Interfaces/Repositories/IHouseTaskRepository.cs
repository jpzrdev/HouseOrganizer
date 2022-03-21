using AllHouse.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHouse.Domain.Interfaces.Repositories
{
    public interface IHouseTaskRepository
    {
        Task<IEnumerable<HouseTask>> GetAllHouseTasks();
        Task<HouseTask> GetHouseTaskById(Guid id);
        Task<HouseTask> CreateHouseTask(HouseTask houseTask);
        Task<HouseTask> UpdateHouseTask(HouseTask houseTask);
        Task DeleteHouseTask(Guid id);
    }
}
