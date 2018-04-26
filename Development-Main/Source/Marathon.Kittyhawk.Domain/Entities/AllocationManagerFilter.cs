using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    public class AllocationManagerFilter : Entity
    {
        public Guid? FacilityId { get; set; }
        public Guid? ProductId { get; set; }
        public string Commodity { get; set; }
        public string User { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public virtual Location Facility { get; set; }
        public virtual Product Product { get; set; }

        public AllocationManagerFilter() { }
    }
}
