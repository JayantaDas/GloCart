using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLOCart.Domain
{
    public class User
    {
        public int UserId { get; set; }

        public string UserDisplayName { get; set; }

        public string UserLogonName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserEmail { get; set; }

        public string ProfileImagePath { get; set; }

        public int UserLocationId { get; set; }

        public string UserGroup { get; set; }
    }
}
