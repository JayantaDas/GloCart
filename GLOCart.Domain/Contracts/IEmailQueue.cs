using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLOCart.Domain.Contracts
{
    public interface IEmailQueue
    {
        IEnumerable<EmailerQueue> GetAllEmailerAlerts();
        
        int AddEmailToQueue(EmailerQueue alert);
        
        IEnumerable<EmailerQueue> GelEmailersByAdvisory(int advisoryId);

        IEnumerable<EmailerQueue> GelEmailersByAdvisorySchedule(int advisoryId, int ScheduleId);

        IEnumerable<EmailerQueue> GelEmailersByAttendees(IEnumerable<ScheduleAttendee> scheduleAttendees);

        void ProcessEmailerQueue(IEnumerable<EmailerQueue> emailerQueue);
    }
}
