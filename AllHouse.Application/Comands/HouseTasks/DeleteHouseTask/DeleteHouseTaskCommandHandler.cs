using AllHouse.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHouse.Application.Comands.HouseTasks.DeleteHouseTask
{
    internal class DeleteHouseTaskCommandHandler : IRequestHandler<DeleteHouseTaskCommand, Guid>
    {
        private IHouseTaskRepository _houseTaskRepository;
        public DeleteHouseTaskCommandHandler(IHouseTaskRepository houseTaskRepository)
        {
            _houseTaskRepository = houseTaskRepository;
        }

        public async Task<Guid> Handle(DeleteHouseTaskCommand request, CancellationToken cancellationToken)
        {
            return await _houseTaskRepository.Delete(request.Id);
        }
    }
}
