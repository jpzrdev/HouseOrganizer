using AllHouse.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHouse.Application.Comands.HouseTasks.CreateHouseTask
{
    public class CreateHouseTaskCommand : IRequest<HouseTask>
    {
        public string Name { get; set; }
    }
}
