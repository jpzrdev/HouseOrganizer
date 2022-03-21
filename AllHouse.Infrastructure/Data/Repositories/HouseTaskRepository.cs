using AllHouse.Domain.Entities;
using AllHouse.Domain.Interfaces.Repositories;
using AllHouse.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHouse.Infrastructure.Data.Repositories
{
    public class HouseTaskRepository : IHouseTaskRepository
    {
        private AllHouseContext _context;
        public HouseTaskRepository(AllHouseContext dbcontext)
        {
            _context = dbcontext;
        }

        public async Task<HouseTask> CreateHouseTask(HouseTask houseTask)
        {
            var entityHouseTask = await _context.HouseTasks.AddAsync(houseTask);
            await _context.SaveChangesAsync();

            return entityHouseTask.Entity;
        }

        public async Task DeleteHouseTask(Guid id)
        {
            var houseTask = await _context.HouseTasks.FindAsync(id);

            if (houseTask == null)
                return;

            _context.HouseTasks.Remove(houseTask);
            await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<HouseTask>> GetAllHouseTasks()
        {
            return await _context.HouseTasks.ToListAsync();
        }

        public async Task<HouseTask> GetHouseTaskById(Guid id)
        {
            return await _context.HouseTasks.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<HouseTask> UpdateHouseTask(HouseTask houseTask)
        {
            var entityHouseTask = _context.HouseTasks.Update(houseTask);
            await _context.SaveChangesAsync();
            return entityHouseTask.Entity;
        }
    }
}
