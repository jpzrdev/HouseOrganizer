using AllHouse.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHouse.Domain.Entities
{
    public class HouseTaskManagement
    {
        public Guid Id { get; set; }
        public Guid HouseTaskId { get; set; }
        public HouseTask HouseTask { get; set; }
        public Guid HouseMemberId { get; set; }
        public HouseMember HouseMember { get; set; }
        public DayOfWeekEnum DayOfWeek { get; set; }
    }
}
