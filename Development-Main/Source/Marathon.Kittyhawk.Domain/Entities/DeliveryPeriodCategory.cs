using System;
using System.Collections.Generic;

namespace Marathon.Kittyhawk.Domain.Entities
{
    public class DeliveryPeriodCategory : Entity
    {
        public int DeliveryPeriodCategoryKey { get; set; }
        public string Name { get; set; }
        public string QuotePeriodRule { get; set; }
        public Guid? HolidayCalendarID { get; set; }
        public bool RelativePeriod { get; set; }
        public bool GapsExistInPeriods { get; set; }
        public bool IsBalanceOfMonth { get; set; }
        public bool HasNonMonthlyPeriods { get; set; }
        public DateTime RevisionDate { get; set; }
        public int RevisionUser { get; set; }
        public bool IsDeleted { get; set; }
        public virtual HolidayCalendar HolidayCalendar { get; set; }
        public virtual ICollection<DeliveryPeriodCategoryDetail> DeliveryPeriodCategoryDetails { get; set; }

        public DeliveryPeriodCategory() { }
    }
}
