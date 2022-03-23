using AllHouse.Application.Comands.HouseMembers.CreateHouseMember;
using AllHouse.Application.Comands.HouseMembers.GetAllHouseMembers;
using AllHouse.Application.Comands.HouseMembers.UpdateHouseMember;
using AllHouse.Application.Queries.HouseMembers.GetAllHouseMembers;
using AllHouse.Application.Queries.HouseMembers.GetHouseMemberById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AllHouse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseMemberController : Controller
    {
        private IMediator _mediator;

        public HouseMemberController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetAllHouseMembersQuery()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _mediator.Send(new GetHouseMemberByIdQuery(id)));
        }

        [HttpPost]
        public async Task<IActionResult> CreateHouseTask([FromBody] CreateHouseMemberCommand createHouseTaskCommand)
        {
            return Ok(await _mediator.Send(createHouseTaskCommand));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateHouseTask([FromBody] UpdateHouseMemberCommand updateHouseTaskCommand)
        {
            return Ok(await _mediator.Send(updateHouseTaskCommand));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteHouseTask([FromBody] DeleteHouseMemberCommand deleteHouseMemberCommand)
        {
            return Ok(await _mediator.Send(deleteHouseMemberCommand));
        }
    }
}
