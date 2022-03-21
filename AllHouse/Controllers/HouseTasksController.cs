using AllHouse.Application.Comands.HouseTasks.CreateHouseTask;
using AllHouse.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AllHouse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseTasksController : ControllerBase
    {
        private IMediator _mediator;

        public HouseTasksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_mediator.Send(new GetAllHouseTasksQuery()).Result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHouseTask([FromBody] CreateHouseTaskCommand createHouseTaskCommand)
        {
            return Ok(_mediator.Send(createHouseTaskCommand).Result);
        }
    }
}
