using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLOCart.Domain
{
    public class Location : Entity
    {
        public int Id { get; set; }

        public string LocationName { get; set; }

        public string LocationDescription { get; set; }

        public int TimeZoneId { get; set; }

        public int CountryId { get; set; }
    }
}
