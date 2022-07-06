using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class BillDetails
    {
        public int BillDetailsId { get; set; }
        public string Explain { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total { get; set; }
    }
}
