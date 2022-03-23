using AllHouse.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHouse.Infrastructure.Data.Context
{
    public class AllHouseContext : DbContext
    {
        public AllHouseContext(DbContextOptions<AllHouseContext> options) : base(options) { }

        public DbSet<HouseTask> HouseTasks { get; set; }
        public DbSet<HouseMember> HouseMembers { get; set; }
        public DbSet<HouseTaskManagement> HouseTaskManagements { get; set; }


    }
}
