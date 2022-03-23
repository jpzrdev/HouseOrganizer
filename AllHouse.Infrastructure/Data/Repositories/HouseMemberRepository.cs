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
    public class HouseMemberRepository : IHouseMemberRepository
    {
        private AllHouseContext _context;
        public HouseMemberRepository(AllHouseContext context)
        {
            _context = context;
        }

        public async Task<HouseMember> Create(HouseMember item)
        {
            var entityEntry = await _context.HouseMembers.AddAsync(item);
            await _context.SaveChangesAsync();

            return entityEntry.Entity;
        }

        public async Task<Guid> Delete(Guid id)
        {
            var entity = await _context.HouseMembers.FindAsync(id);
            _context.HouseMembers.Remove(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<IEnumerable<HouseMember>> GetAll()
        {
            return await _context.HouseMembers.Include(x => x.Tasks).ToListAsync();
        }

        public async Task<HouseMember> GetById(Guid id)
        {
            return await _context.HouseMembers.FindAsync(id);
        }

        public async Task<HouseMember> Update(HouseMember item)
        {
            var entityEntry = _context.HouseMembers.Update(item);
            await _context.SaveChangesAsync();
            return entityEntry.Entity;
        }
    }
}
