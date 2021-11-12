using ClassLibrary1;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using WebApiAssignment2.Model;

namespace WebApiAssignment2.Controllers
{
    [Route("api/timeEntry")]
    public class TimeEntryController : Controller
    {
        Class1
        private ITimeEntryRepository timeEntryRepository;

        public TimeEntryController(ITimeEntryRepository _timeEntryRepository)
        {
            timeEntryRepository = _timeEntryRepository;
        }
        [HttpGet("{id:int?}")]
        public IEnumerable<TimeEntry> Get(int id,string sort, string order)
        {
            if (id == 0)
                return timeEntryRepository.List();
            else
            {
                TimeEntry timeEntry= timeEntryRepository.List().Single(x => x.UserId == id);
                List<TimeEntry> list = new List<TimeEntry>();
                list.Add(timeEntry);
                return list;
            }
            if (sort != null && order != null)
            {
                return timeEntryRepository.List().OrderByDescending(x => x.GetType().GetProperty(sort, BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.IgnoreCase).GetValue(x, null)).ToList();

            }
            else
            {
                return timeEntryRepository.List();
            }
        }
        [RequireHttps]
        public IEnumerable<TimeEntry> Get( string sort, string order)
        {
            
            if (sort != null && order != null)
            {
                return timeEntryRepository.List().OrderByDescending(x => x.GetType().GetProperty(sort, BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.IgnoreCase).GetValue(x, null)).ToList();

            }
            else
            {
                return timeEntryRepository.List();
            }
        }
        [HttpPost]
        public IActionResult Post([FromBody]TimeEntry timeEntry)
        {
            var addedTimeEntry = timeEntryRepository.Create(timeEntry);
            return CreatedAtRoute("timeEntry",new { Controller="TimeEntry",id=addedTimeEntry.Id},addedTimeEntry);
        }
        [HttpPut("{id:int}")]
        public void Put(int id,[FromBody] TimeEntry timeEntry)
        {
            bool updated = timeEntryRepository.Update(id,timeEntry);
            
        }
        [HttpDelete("{id:int}")]
        public void Delete(int id)
        {
            timeEntryRepository.Delete(id);
        }
    }
}
