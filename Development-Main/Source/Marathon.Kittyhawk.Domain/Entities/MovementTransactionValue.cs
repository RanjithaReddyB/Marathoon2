using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents a movement transaction value entry.
    /// </summary>
    public class MovementTransactionValue : Entity
    {
        public int TransactionDetailKey { get; set; }
        public int TransactionHeaderKey { get; set; }
        public Guid? MovementTransactionID { get; set; }
        public Guid? DealID { get; set; }
        public virtual MovementTransaction MovementTransaction { get; set; }
        public virtual Deal Deal { get; set; }
        public string ValueStatus { get; set; }
        public string ValueType { get; set; }
        public string Actual { get; set; }
        public string TransactionType { get; set; }
        public string Provision { get; set; }
        public string Strategy { get; set; }
        public double? DetailQuantity { get; set; }
        public double? PerUnitValue { get; set; }
        public double? PricedInValue { get; set; }
        public double? FloatingValue { get; set; }
        public double? TotalValue { get; set; }
        public string Currency { get; set; }
        public double? PricedPercent { get; set; }
        public DateTime? ValueCreatedDate { get; set; }
        public DateTime? ValuationDate { get; set; }
        public DateTime? RevisionDate { get; set; }
        public DateTime? ReferenceDate { get; set; }
        public int? RevisionLevel { get; set; }
        public string QuantityBasis { get; set; }
        public bool IsDeleted { get; set; }

        public MovementTransactionValue() { }
    }
}
