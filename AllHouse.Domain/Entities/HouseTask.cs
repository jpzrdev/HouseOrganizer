using AllHouse.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHouse.Domain.Entities
{
    public class HouseTask
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public HouseTaskDifficulty Difficulty { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool IsActive { get; set; }
        public ICollection<HouseTaskManagement> HouseMembers { get; set; }

    }
}
