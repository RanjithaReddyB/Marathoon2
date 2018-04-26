using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents a deal obligation.
    /// </summary>
    public class DealObligation : Entity
    {
        public int DealHeaderKey { get; set; }
        public int DealDetailKey { get; set; }
		public int ObligationId { get; set; }
        public Guid? DealID { get; set; }
        public virtual Deal Deal { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public double? Quantity { get; set; }
        public bool IsDeleted { get; set; }

        public DealObligation() { }
    }
}




