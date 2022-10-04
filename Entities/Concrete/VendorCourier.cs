using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class VendorCourier:IEntity
    {
        public int VendorCourierID { get; set; }
        public int VendorID { get; set; }
        public int CourierID { get; set; }

    }
}
