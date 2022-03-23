using AllHouse.Domain.Entities;
using AllHouse.Domain.Enums;
using AllHouse.Domain.Interfaces.Repositories;
using AllHouse.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHouse.Application.Services
{
    public class HouseTaskManagementService : IHouseTaskManagementService
    {
        private readonly IHouseTaskRepository _houseTaskRepository;
        private readonly IHouseMemberRepository _houseMemberRepository;
        private readonly IHouseTaskManagementRepository _houseTaskManagementRepository;
        public HouseTaskManagementService(
            IHouseTaskRepository houseTaskRepository,
            IHouseMemberRepository houseMemberRepository,
            IHouseTaskManagementRepository houseTaskManagementRepository)
        {
            _houseMemberRepository = houseMemberRepository;
            _houseTaskRepository = houseTaskRepository;
            _houseTaskManagementRepository = houseTaskManagementRepository;
        }

        public async Task<IEnumerable<HouseTaskManagement>> AutoAllocateHouseTaskToMembersInWeekly(Guid houseTaskId, IEnumerable<DayOfWeekEnum> daysToDistribute)
        {
            var houseTask = await _houseTaskRepository.GetById(houseTaskId);
            var houseMembers = await _houseMemberRepository.GetAll();
            var unavailableHouseMembers = new List<HouseMember>();

            var returnList = new List<HouseTaskManagement>();


            foreach (var day in daysToDistribute)
            {
                var houseMembersShuffle = houseMembers.Where(x => x.IsActive).OrderBy(x => Guid.NewGuid());
                foreach (var houseMember in houseMembersShuffle)
                {

                    if (unavailableHouseMembers.Count() == houseMembers.Count())
                    {
                        unavailableHouseMembers.Clear();
                    }

                    if (!unavailableHouseMembers.Contains(houseMember))
                    {
                        unavailableHouseMembers.Add(houseMember);
                        var houseTaskManagement = new HouseTaskManagement
                        {
                            HouseTaskId = houseTask.Id,
                            HouseMemberId = houseMember.Id,
                            DayOfWeek = day
                        };
                        returnList.Add(await _houseTaskManagementRepository.Create(houseTaskManagement));
                        break;
                    }
                    
                }
            }

            return returnList;
        }
    }
}
