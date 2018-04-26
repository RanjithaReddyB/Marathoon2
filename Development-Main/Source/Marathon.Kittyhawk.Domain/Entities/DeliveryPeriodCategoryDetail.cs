using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    public class DeliveryPeriodCategoryDetail : Entity
    {
        public int DeliveryPeriodCategoryDetailKey { get; set; }
        public Guid? DeliveryPeriodCategoryId { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime QuotePeriodStartDate { get; set; }
        public DateTime QuotePeriodEndDate { get; set; }
        public bool IsDeleted { get; set; }
        public virtual DeliveryPeriodCategory DeliveryPeriodCategory { get; set; }
        public DeliveryPeriodCategoryDetail() { }
    }
}
