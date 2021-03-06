using AllHouse.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHouse.Application.Queries
{
    public class GetHouseTaskByIdQuery : IRequest<HouseTask>
    {
        public Guid Id { get; set; }

        public GetHouseTaskByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
