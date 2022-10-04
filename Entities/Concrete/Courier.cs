using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Courier:IEntity
    {
        public int CourierID { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
    }
}
