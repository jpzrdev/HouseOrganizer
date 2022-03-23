using AllHouse.Application.Comands.HouseTasksManagement.AutoAllocateHouseTaskToMembersCommand;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AllHouse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseTaskManagementController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HouseTaskManagementController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AllocateHouseTasks(AutoAllocateHouseTaskToMembersCommand autoAllocateHouseTaskToMembersCommand)
        {
            return Ok(await _mediator.Send(autoAllocateHouseTaskToMembersCommand));
        }

    }
}
