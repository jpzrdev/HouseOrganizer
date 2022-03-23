using AllHouse.Domain.Entities;
using AllHouse.Domain.Interfaces.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHouse.Application.Comands.HouseTasksManagement.AutoAllocateHouseTaskToMembersCommand
{
    internal class AutoAllocateHouseTaskToMembersCommandHandler : IRequestHandler<AutoAllocateHouseTaskToMembersCommand, IEnumerable<HouseTaskManagement>>
    {
        private readonly IHouseTaskManagementService _houseTaskManagementService;
        public AutoAllocateHouseTaskToMembersCommandHandler(IHouseTaskManagementService houseTaskManagementService)
        {
            _houseTaskManagementService = houseTaskManagementService;
        }
        public Task<IEnumerable<HouseTaskManagement>> Handle(AutoAllocateHouseTaskToMembersCommand request, CancellationToken cancellationToken)
        {
            return _houseTaskManagementService.AutoAllocateHouseTaskToMembersInWeekly(request.HouseTaskId, request.DayOfWeeks);
        }
    }
}
