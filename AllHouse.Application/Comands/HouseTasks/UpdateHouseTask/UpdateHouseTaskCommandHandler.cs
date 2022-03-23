using AllHouse.Application.Comands.HouseTasks.DeleteHouseTask;
using AllHouse.Domain.Entities;
using AllHouse.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHouse.Application.Comands.HouseTasks.UpdateHouseTask
{
    internal class UpdateHouseTaskCommandHandler : IRequestHandler<UpdateHouseTaskCommand, HouseTask>
    {
        private IHouseTaskRepository _houseTaskRepository;
        public UpdateHouseTaskCommandHandler(IHouseTaskRepository houseTaskRepository)
        {
            _houseTaskRepository = houseTaskRepository;
        }
        public async Task<HouseTask> Handle(UpdateHouseTaskCommand request, CancellationToken cancellationToken)
        {
            var houseTask = await _houseTaskRepository.GetById(request.Id);
            houseTask.Name = request.Name;
            return await _houseTaskRepository.Update(houseTask);

        }
    }
}
