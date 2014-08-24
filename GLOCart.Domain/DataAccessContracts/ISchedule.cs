using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLOCart.Domain.DataAccessContracts
{
    public interface ISchedule
    {
        IEnumerable<Schedule> GetAllSchedules();

        Schedule GetSchedule(int scheduleId);

        IEnumerable<Schedule> GetUserSchedules(int userId);

        IEnumerable<ScheduleExpertTag> GetScheduleExperts(int scheduleId);

        IEnumerable<ScheduleTechTag> GetScheduleTechStack(int scheduleId);

        IEnumerable<User> GetScheduleAttendees(int scheduleId);
                
        int AddSchedule(Schedule schedule);

        void ModifySchedule(Schedule schedule);

        void DeleteSchedule(Schedule schedule);
    }
}
