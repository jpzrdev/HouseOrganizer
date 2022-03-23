using AllHouse.Domain.Entities;
using AllHouse.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHouse.Application.Queries.Tasks.GetAllTasks
{
    public class GetAllHouseTasksQueryHandler : IRequestHandler<GetAllHouseTasksQuery, IEnumerable<HouseTask>>
    {
        private IHouseTaskRepository _houseTaskRepository;
        public GetAllHouseTasksQueryHandler(IHouseTaskRepository houseTaskRepository)
        {
            _houseTaskRepository = houseTaskRepository;
        }

        public async Task<IEnumerable<HouseTask>> Handle(GetAllHouseTasksQuery request, CancellationToken cancellationToken)
        {
            return await _houseTaskRepository.GetAll(); ;
        }
    }
}
