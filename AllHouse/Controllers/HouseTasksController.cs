using AllHouse.Application.Comands.HouseTasks.CreateHouseTask;
using AllHouse.Application.Comands.HouseTasks.DeleteHouseTask;
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
            return Ok(await _mediator.Send(new GetAllHouseTasksQuery()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid houseTaskId)
        {
            return Ok(await _mediator.Send(new GetHouseTaskByIdQuery(houseTaskId)));
        }

        [HttpPost]
        public async Task<IActionResult> CreateHouseTask([FromBody] CreateHouseTaskCommand createHouseTaskCommand)
        {
            return Ok(await _mediator.Send(createHouseTaskCommand));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateHouseTask([FromBody] UpdateHouseTaskCommand updateHouseTaskCommand)
        {
            return Ok(await _mediator.Send(updateHouseTaskCommand));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteHouseTask([FromBody] DeleteHouseTaskCommand deleteHouseMemberCommand)
        {
            return Ok(await _mediator.Send(deleteHouseMemberCommand));
        }
    }
}
