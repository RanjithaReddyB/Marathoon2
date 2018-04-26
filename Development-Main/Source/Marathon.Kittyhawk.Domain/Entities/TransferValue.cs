using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents a transfer value entry.
    /// </summary>
    public class TransferValue : Entity
    {
        public int PlannedTransferValueKey { get; set; }
        public int PlannedTransferKey { get; set; }
        public Guid? TransferID { get; set; }
        public virtual Transfer Transfer { get; set; }
        public string ValueStatus { get; set; }
        public string ValueType { get; set; }
        public string TransactionType { get; set; }
        public string Provision { get; set; }
        public double? PerUnitValue { get; set; }
        public double? PricedPerUnitValue { get; set; }
        public double? FloatingPerUnitValue { get; set; }
        public double? TotalValue { get; set; }
        public double? PricedPercent { get; set; }
        public string SettlementCurrency { get; set; }
        public DateTime? ValueCreatedDate { get; set; }
        public DateTime? ValueChangedDate { get; set; }
        public DateTime? LastValueDate { get; set; }
        public DateTime? ReferenceDate { get; set; }
        public bool IsDeleted { get; set; }
        public TransferValue() { }
    }
}
