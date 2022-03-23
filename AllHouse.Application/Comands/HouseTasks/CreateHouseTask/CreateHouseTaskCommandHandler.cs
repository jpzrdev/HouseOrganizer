using AllHouse.Domain.Entities;
using AllHouse.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHouse.Application.Comands.HouseTasks.CreateHouseTask
{
    public class CreateHouseTaskCommandHandler : IRequestHandler<CreateHouseTaskCommand, HouseTask>
    {
        private readonly IHouseTaskRepository _houseTaskRepository;
        public CreateHouseTaskCommandHandler(IHouseTaskRepository houseTaskRepository)
        {
            _houseTaskRepository = houseTaskRepository;
        }
        public async Task<HouseTask> Handle(CreateHouseTaskCommand request, CancellationToken cancellationToken)
        {
            var houseTask = new HouseTask()
            {
                Name = request.Name
            };

            return await _houseTaskRepository.Create(houseTask);
        }
    }
}
