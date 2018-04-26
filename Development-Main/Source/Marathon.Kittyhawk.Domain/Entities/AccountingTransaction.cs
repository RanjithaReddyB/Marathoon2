using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents an accounting transaction entry.
    /// </summary>
    public class AccountingTransaction : Entity
    {
        public int AccountDetailKey { get; set; }
        public int? AccountCodeKey { get; set; }
        public int? AccountCodeLogKey { get; set; }
        public int? PlannedTransferKey { get; set; }
        public int? MovementHeaderKey { get; set; }
        public int? TransactionHeaderKey { get; set; }
        public int? InvoiceHeaderKey { get; set; }
        public int? InvoiceDetailKey { get; set; }
        public string InvoiceType { get; set; }
        public Guid? OurCompanyID { get; set; }
        public Guid? TheirCompanyID { get; set; }
        public Guid? ProductID { get; set; }
        public Guid? ChildProductID { get; set; }
        public Guid? LocationID { get; set; }
        public Guid? OriginID { get; set; }
        public Guid? DestinationID { get; set; }
        public Guid? DealID { get; set; }
        public Guid? TransferID { get; set; }
        public Guid? MovementID { get; set; }
        public Guid? MovementTransactionID { get; set; }
        public Guid? MovementExpenseID { get; set; }
        public Guid? TimeTransactionID { get; set; }
        public Guid? InvoiceID { get; set; }
        public virtual BusinessAssociate OurCompany { get; set; }
        public virtual BusinessAssociate TheirCompany { get; set; }
        public virtual Product Product { get; set; }
        public virtual Product ChildProduct { get; set; }
        public virtual Location Location { get; set; }
        public virtual Location Origin { get; set; }
        public virtual Location Destination { get; set; }
        public virtual Deal Deal { get; set; }
        public virtual Transfer Transfer { get; set; }
        public virtual Movement Movement { get; set; }
        public virtual MovementTransaction MovementTransaction { get; set; }
        public virtual MovementExpense MovementExpense { get; set; }
        public virtual TimeTransaction TimeTransaction { get; set; }
        public virtual Invoice Invoice { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? LogDate { get; set; }
        public string AccountingPeriod { get; set; }
        public string AccountNumber { get; set; }
        public string AccountDescription { get; set; }
        public string AccountType { get; set; }
        public string DebitCredit { get; set; }
        public double? Value { get; set; }
        public string Currency { get; set; }
        public double? Quantity { get; set; }
        public string QuantityUnit { get; set; }
        public string Reversed { get; set; }
        public string SourceTable { get; set; }
        public int? SourceID { get; set; }
        public string SupplyDemand { get; set; }
        public string WePayTheyPay { get; set; }
        public string AccountCodeStatus { get; set; }
        public string TaxStatus { get; set; }
        public string Intradivisional { get; set; }
        public string IsNetOut { get; set; }
        public string Comment { get; set; }
        public string GrossQuantity { get; set; }
        public string NetQuantity { get; set; }
		public Guid? TransactionTypeID { get; set; }
        public virtual TransactionType TransactionType { get; set; }
        public string CostType { get; set; }
        public double? OldStyleValue { get; set; }
        public bool IsDeleted { get; set; }

        public AccountingTransaction() { }
    }
}
