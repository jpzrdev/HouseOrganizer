using AllHouse.Domain.Entities;
using AllHouse.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHouse.Application.Queries
{
    internal class GetHouseTaskByIdQueryHandler : IRequestHandler<GetHouseTaskByIdQuery, HouseTask>
    {
        private IHouseTaskRepository _houseTaskRepository;
        public GetHouseTaskByIdQueryHandler(IHouseTaskRepository houseTaskRepository)
        {
            _houseTaskRepository = houseTaskRepository;
        }
        public Task<HouseTask> Handle(GetHouseTaskByIdQuery request, CancellationToken cancellationToken)
        {
            var houseTaskEntity = _houseTaskRepository.GetById(request.Id);
            return houseTaskEntity;
        }
    }
}
