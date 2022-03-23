using AllHouse.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHouse.Application.Comands.HouseTasks.DeleteHouseTask
{
    public class UpdateHouseTaskCommand : IRequest<HouseTask>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
