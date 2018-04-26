using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents an month-end inventory entry.
    /// </summary>
    public class MonthEndInventory : Entity
    {
        public int InventorySubledgerKey { get; set; }
        public Guid? CompanyID { get; set; }
        public Guid? ProductID { get; set; }
        public Guid? LocationID { get; set; }
        public Guid? DealID { get; set; }
        public virtual BusinessAssociate Company { get; set; }
        public virtual Product Product { get; set; }
        public virtual Location Location { get; set; }
        public virtual Deal Deal { get; set; }
        public DateTime? InventoryDate { get; set; }
        public string AccountingPeriod { get; set; }
        public DateTime? AccountingPeriodStartDate { get; set; }
        public DateTime? AccountingPeriodEndDate { get; set; }
        public double? RawQuantity { get; set; }
        public double? RawGrossQuantity { get; set; }
        public double? RefinedQuantity { get; set; }
        public double? RefinedGrossQuantity { get; set; }
        public double? TransferQuantity { get; set; }
        public double? TransferGrossQuantity { get; set; }
        public double? TotalQuantity { get; set; }
        public double? TotalVolume { get; set; }
        public string UnitOfMeasure { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public bool IsDeleted { get; set; }

        public MonthEndInventory() { }
    }
}
