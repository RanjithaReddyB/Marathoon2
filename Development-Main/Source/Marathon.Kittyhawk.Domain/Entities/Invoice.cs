using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents an invoice entry.
    /// </summary>
    public class Invoice : Entity
	{
        public int InvoiceHeaderKey { get; set; }
        public int? InvoiceDetailKey { get; set; }
        public Guid? OurCompanyID { get; set; }
        public Guid? TheirCompanyID { get; set; }
        public Guid? ProductID { get; set; }
        public Guid? LocationID { get; set; }
        public Guid? OriginID { get; set; }
        public Guid? DestinationID { get; set; }
        public Guid? DealID { get; set; }
        public virtual BusinessAssociate OurCompany { get; set; }
        public virtual BusinessAssociate TheirCompany { get; set; }
        public virtual Deal Deal { get; set; }
        public virtual Product Product { get; set; }
        public virtual Location Location { get; set; }
        public virtual Location Origin { get; set; }
        public virtual Location Destination { get; set; }
        public string InvoiceNumber { get; set; }
        public int LineNumber { get; set; }
        public string InvoiceType { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? PostedDate { get; set; }
        public DateTime? AttachedDate { get; set; }
        public string AccountingPeriod { get; set; }
        public double? TotalValue { get; set; }
        public double? PaidAmount { get; set; }
        public double? LineAmount { get; set; }
        public string Currency { get; set; }
        public double? Quantity { get; set; }
        public string QuantityUnit { get; set; }
        public string TransactionType { get; set; }
        public string PaymentType { get; set; }
        public string Approved { get; set; }
        public string BOL { get; set; }
        public string OriginalInvoice { get; set; }
        public string OriginalSource { get; set; }
        public double? OriginalAmount { get; set; }
        public string Comment { get; set; }
        public DateTime? ShipDate { get; set; }
        public string CorrectedInvoiceNumber { get; set; }
        public string InvoiceTerms { get; set; }
        public string DiscountAmount { get; set; }
        public DateTime? DiscountDate { get; set; }
        public double? Price { get; set; }
        public string Ticket { get; set; }
        public string InvoiceParent { get; set; }
        public bool IsDeleted { get; set; }

        public Invoice() { }
    }
}
