using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Bill
    {
        public int BillId { get; set; }
        public string BillSerialNo { get; set; }
        public string BillQueueNo { get; set; }
        public DateTime Date { get; set; }
        public string TaxAdmin { get; set; }
        public DateTime Hour { get; set; }
        public string Submitter { get; set; }
        public string Receiver { get; set; }
    }
}
