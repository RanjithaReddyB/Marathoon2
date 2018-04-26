using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents a movement expense entry.
    /// </summary>
    public class MovementExpense : Entity
    {
        public int MovementExpenseKey { get; set; }
        public int? MovementExpenseLogKey { get; set; }
        public int? PlannedTransferKey { get; set; }
        public int? MovementHeaderKey { get; set; }
        public Guid? InternalBAID { get; set; }
        public Guid? ExternalBAID { get; set; }
        public Guid? ProductID { get; set; }
        public Guid? LocationID { get; set; }
        public Guid? TransferID { get; set; }
        public Guid? MovementID { get; set; }
        public virtual BusinessAssociate InternalBA { get; set; }
        public virtual BusinessAssociate ExternalBA { get; set; }
        public virtual Product Product { get; set; }
        public virtual Location Location { get; set; }
        public virtual Transfer Transfer { get; set; }
        public virtual Movement Movement { get; set; }
        public string TransactionType { get; set; }
        public string PaymentType { get; set; }
        public string Status { get; set; }
        public string Reversal { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ExpenseDate { get; set; }
        public double? Quantity { get; set; }
        public string QuantityUnit { get; set; }
        public double? PerUnitValue { get; set; }
        public double? TotalValue { get; set; }
        public string Currency { get; set; }
        public string Strategy { get; set; }
        public string Comment { get; set; }
        public bool IsDeleted { get; set; }

        public MovementExpense() { }
    }
}
