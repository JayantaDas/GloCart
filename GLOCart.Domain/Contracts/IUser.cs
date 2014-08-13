using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLOCart.Domain.Contracts
{
    public interface IUser
    {
        IEnumerable<Experts> GetAllUsers();

        User GetUser(int userId);

        Experts getUserExpert(int userId);
        
        int AddUser(User user); 
    }
}
