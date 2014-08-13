using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLOCart.Domain
{
    public class AdvisoryWatch
    {
        public int Id { get; set; }

        public int AdvisoryId { get; set; }

        public int UserId { get; set; }

        public DateTime DateAdded { get; set; }
    }
}
