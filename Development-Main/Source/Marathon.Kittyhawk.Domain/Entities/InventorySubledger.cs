using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents an inventory subledger entry.
    /// </summary>
    public class InventorySubledger : Entity
    {
        public int InventorySubledgerKey { get; set; }
        public Guid? ProductID { get; set; }
        public Guid? DealID { get; set; }
        public virtual Product Product { get; set; }
        public virtual Deal Deal { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string AccountingPeriod { get; set; }
        public string Strategy { get; set; }
        public string PerUnitLocked { get; set; }
        public double? Quantity { get; set; }
        public string QuantityUnit { get; set; }
        public double? Weight { get; set; }
        public string WeightUnit { get; set; }
        public double? Value { get; set; }
        public double? PerUnitValue { get; set; }
        public string Currency { get; set; }
        public string Comment { get; set; }
        public bool IsDeleted { get; set; }

        public InventorySubledger() { }
    }
}
