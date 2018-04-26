using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents an inventory reconcile entry.
    /// </summary>
    public class InventoryReconcile : Entity
    {
        public int InventoryReconcileKey { get; set; }
        public int? PlannedTransferKey { get; set; }
        public int? TransactionHeaderKey { get; set; }
        public Guid? CompanyID { get; set; }
        public Guid? ProductID { get; set; }
        public Guid? LocationID { get; set; }
        public Guid? DealID { get; set; }
        public Guid? TransferID { get; set; }
        public Guid? MovementTransactionID { get; set; }
        public virtual BusinessAssociate Company { get; set; }
        public virtual Product Product { get; set; }
        public virtual Location Location { get; set; }
        public virtual Deal Deal { get; set; }
        public virtual Transfer Transfer { get; set; }
        public virtual MovementTransaction MovementTransaction { get; set; }
        public DateTime? ReconcileDate { get; set; }
        public DateTime? MovementDate { get; set; }
        public string AccountingPeriod { get; set; }
        public string Status { get; set; }
        public string SupplyDemand { get; set; }
        public string Reversed { get; set; }
        public string Pool { get; set; }
        public string ReasonCode { get; set; }
        public double? Quantity { get; set; }
        public string QuantityUnit { get; set; }
        public string ReconcileGroup { get; set; }
        public string Comment { get; set; }
        public bool IsDeleted { get; set; }

        public InventoryReconcile() { }
    }
}
