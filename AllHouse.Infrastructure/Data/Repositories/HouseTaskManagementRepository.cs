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
    public class HouseTaskManagementRepository : IHouseTaskManagementRepository
    {
        private AllHouseContext _context;
        public HouseTaskManagementRepository(AllHouseContext context)
        {
            _context = context;
        }
        public async Task<HouseTaskManagement> Create(HouseTaskManagement item)
        {
            var entityEntry = await _context.HouseTaskManagements.AddAsync(item);
            await _context.SaveChangesAsync();

            return entityEntry.Entity;
        }

        public async Task<Guid> Delete(Guid id)
        {
            var entity = await _context.HouseTaskManagements.FindAsync(id);
            _context.HouseTaskManagements.Remove(entity);
            await _context.SaveChangesAsync();
            return entity.HouseTaskId;
        }

        public async Task<IEnumerable<HouseTaskManagement>> GetAll()
        {
            return await _context.HouseTaskManagements.ToListAsync();
        }

        public Task<IEnumerable<HouseTaskManagement>> GetAllByHouseMemberId(Guid houseMemberId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<HouseTaskManagement>> GetAllByHouseTaskId(Guid houseTaskId)
        {
            throw new NotImplementedException();
        }

        public async Task<HouseTaskManagement> GetById(Guid id)
        {
            return await _context.HouseTaskManagements.FindAsync(id);
        }

        public async Task<HouseTaskManagement> Update(HouseTaskManagement item)
        {
            var entityEntry = _context.HouseTaskManagements.Update(item);
            await _context.SaveChangesAsync();
            return entityEntry.Entity;
        }
    }
}
