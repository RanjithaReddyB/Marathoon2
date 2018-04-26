using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    public class HolidayCalendarDetail : Entity
    {
        public int HolidayCalendarDetailKey { get; set; }
        public string Name { get; set; }
        public DateTime? HolidayCalendarDetailDate { get; set; }
        public Guid? HolidayCalendarId { get; set; }
        public string Code { get; set; }        
        public bool IsDeleted { get; set; }
        public virtual HolidayCalendar HolidayCalendar { get; set; }

        public HolidayCalendarDetail() { }
    }
}
