using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GLOCart.Domain;
using GLOCart.Domain.DataAccessContracts;

namespace GLOCart.DataAccess.Providers
{
    public class ScheduleProvider: ISchedule
    {

        public IEnumerable<Schedule> GetAllSchedules()
        {
            throw new NotImplementedException();
        }

        public Schedule GetSchedule(int scheduleId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Schedule> GetUserSchedules(int userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ScheduleExpertTag> GetScheduleExperts(int scheduleId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ScheduleTechTag> GetScheduleTechStack(int scheduleId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetScheduleAttendees(int scheduleId)
        {
            throw new NotImplementedException();
        }

        public int AddSchedule(Schedule schedule)
        {
            throw new NotImplementedException();
        }

        public void ModifySchedule(Schedule schedule)
        {
            throw new NotImplementedException();
        }

        public void DeleteSchedule(Schedule schedule)
        {
            throw new NotImplementedException();
        }
    }
}
