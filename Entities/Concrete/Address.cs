
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Address:IEntity
    {
        public int AddressID { get; set; }
        public string HouseNo{ get; set; }
        public int Street { get; set; }
        public int CustomerID { get; set; }
        public string Area { get; set; }
        public int CityID { get; set; }
        public int ProvinceID { get; set; }


    }
}
