using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHouse.Application.Comands.HouseTasks.DeleteHouseTask
{
    public class DeleteHouseTaskCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
    }
}
