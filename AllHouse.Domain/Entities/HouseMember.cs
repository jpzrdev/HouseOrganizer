using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHouse.Domain.Entities
{
    public class HouseMember
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Nick { get; set; }
        public bool IsActive { get; set; }
        public ICollection<HouseTaskManagement> Tasks { get; set; }
    }
}
