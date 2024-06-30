using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Entity> Entities { get; } = new();
    }
}
