using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAssignment2.Model
{
    public interface ITimeEntryRepository
    {
        TimeEntry Create(TimeEntry timeEntry);

        TimeEntry Find(long id);

        bool Contains(long id);

        IEnumerable<TimeEntry> List();

        bool Update(long id, TimeEntry timeEntry);

        void Delete(long id);
    }
}
