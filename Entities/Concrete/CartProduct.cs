using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CartProduct:IEntity
    {
        public int CartProductID { get; set; }
        public int VendorProductID { get; set; }
        public int Quantity { get; set; }
        public int CartID { get; set; }
    }
}
