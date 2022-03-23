using AllHouse.Domain.Entities;
using AllHouse.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHouse.Application.Comands.HouseMembers.UpdateHouseMember
{
    public class UpdateHouseMemberCommandHandler : IRequestHandler<UpdateHouseMemberCommand, HouseMember>
    {
        private readonly IHouseMemberRepository _houseMemberRepository;
        public UpdateHouseMemberCommandHandler(IHouseMemberRepository houseMemberRepository)
        {
            _houseMemberRepository = houseMemberRepository;
        }
        public async Task<HouseMember> Handle(UpdateHouseMemberCommand request, CancellationToken cancellationToken)
        {
            var entity = await _houseMemberRepository.GetById(request.Id);
            entity.Name = request.Name;
            entity.Nick = request.Nick;
            return await _houseMemberRepository.Update(entity);
        }
    }
}
