using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents a time transaction entry.
    /// </summary>
    public class TimeTransaction : Entity
    {
        public int TimeTransactionKey { get; set; }
        public int? TimeTransactionLogKey { get; set; }
        public Guid? DealID { get; set; }
        public virtual Deal Deal { get; set; }
        public DateTime? Date { get; set; }
        public double? Quantity { get; set; }
        public string QuantityUnit { get; set; }
        public string ValueStatus { get; set; }
        public string ValueType { get; set; }
        public string TransactionType { get; set; }
        public string Provision { get; set; }
        public string Strategy { get; set; }
        public double? PerUnitValue { get; set; }
        public double? PricedValue { get; set; }
        public double? FloatingValue { get; set; }
        public double? TotalValue { get; set; }
        public string Currency { get; set; }
        public double? PricedPercent { get; set; }
        public DateTime? ValuationDate { get; set; }
        public DateTime? RevisionDate { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public int? RevisionLevel { get; set; }
        public string Comment { get; set; }
        public bool IsDeleted { get; set; }

        public TimeTransaction() { }
    }
}
