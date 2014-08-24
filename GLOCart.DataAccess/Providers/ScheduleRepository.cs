using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GLOCart.DataAccess.Repository;
using GLOCart.Domain;
using GLOCart.Domain.DataAccessContracts;
using GLOCart.Domain.Repository;

namespace GLOCart.DataAccess.Providers
{
    public class ScheduleRepository : GenericRepository<Schedule>, IScheduleRepository
    {
    }
}
