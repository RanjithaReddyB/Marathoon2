using System;
using System.Collections.Generic;

namespace Marathon.Kittyhawk.Domain.Entities
{
    public class HolidayCalendar : Entity
    {
        public int HolidayCalendarKey { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Common { get; set; }
        public int? HolidayCalendarKey1 { get; set; }
        public int? HolidayCalendarKey2 { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsDeleted { get; set; }
		public virtual ICollection<HolidayCalendarDetail> HolidayCalendarDetails { get; set; }

        public HolidayCalendar() { }
    }
}