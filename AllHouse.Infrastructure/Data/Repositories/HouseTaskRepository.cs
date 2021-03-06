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
        public HouseTaskRepository(AllHouseContext context)
        {
            _context = context;
        }

        public async Task<HouseTask> Create(HouseTask item)
        {
            var entityEntry = await _context.HouseTasks.AddAsync(item);
            await _context.SaveChangesAsync();

            return entityEntry.Entity;
        }

        public async Task<Guid> Delete(Guid id)
        {
            var houseTask = await _context.HouseTasks.FindAsync(id);
            _context.HouseTasks.Remove(houseTask);
            await _context.SaveChangesAsync();
            return houseTask.Id;

        }

        public async Task<IEnumerable<HouseTask>> GetAll()
        {
            return await _context.HouseTasks.ToListAsync();
        }

        public async Task<HouseTask> GetById(Guid id)
        {
            return await _context.HouseTasks.FindAsync(id);
        }

        public async Task<HouseTask> Update(HouseTask item)
        {
            var entityEntry = _context.HouseTasks.Update(item);
            await _context.SaveChangesAsync();
            return entityEntry.Entity;
        }
    }
}
