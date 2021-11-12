using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAssignment2.Model
{
    public class TimeEntryRepository : ITimeEntryRepository
    {
        List<TimeEntry> list = new List<TimeEntry>();
        TimeEntry obj = new TimeEntry();
        
        public bool Contains(long id)
        {
            foreach(var detail in list)
            {
                if (detail.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        public TimeEntry Create(TimeEntry timeEntry)
        {
            obj = timeEntry;
            list.Add(obj);
            return obj;
        }

        public void Delete(long id)
        {
            foreach(var detail in list)
            {
                if (detail.Id == id)
                {
                    list.Remove(detail);
                    break;
                }
            }
        }

        public TimeEntry Find(long id)
        {
            foreach(var detail in list)
            {
                if (detail.Id == id)
                {
                    obj = detail;
                    break;
                }
            }
            return obj;
        }

        public IEnumerable<TimeEntry> List()
        {
            
            return list;
        }

        public bool Update(long id, TimeEntry timeEntry)
        {
            foreach (var detail in list)
            {
                if (detail.Id == id)
                {
                    detail.Id = timeEntry.Id;
                    detail.ProjectId = timeEntry.ProjectId;
                    detail.UserId = timeEntry.UserId;
                    detail.Date = timeEntry.Date;
                    detail.Hours = timeEntry.Hours;
                    obj = detail;
                    return true;
                }
            }
            return false;
        }
    }
}
