using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Core.Entities
{
    public class CarModel
    {
        public string Id { get; set; } 

        public string Name { get; set; }

        public string About { get; set; }

        public bool IsActive { get; set; }
    }
}
