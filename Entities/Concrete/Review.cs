using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Abstract
{
    public class Review:IEntity
    {
        public int ReviewID { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public int CustomerID { get; set; }
        public int OrderedProductID { get; set; }
    }
}
