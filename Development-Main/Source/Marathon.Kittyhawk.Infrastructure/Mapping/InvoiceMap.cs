using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Invoice entity mapping for Entity Framework.
    /// </summary>
    public class InvoiceMap : EntityTypeConfiguration<Invoice>
    {
        public InvoiceMap()
        {
            // Table & Column Mappings
            this.ToTable("Invoice");
            this.Property(t => t.InvoiceHeaderKey).HasColumnName("InvoiceHeaderKey").IsRequired();
            this.Property(t => t.InvoiceDetailKey).HasColumnName("InvoiceDetailKey").IsOptional();
            this.Property(t => t.OurCompanyID).HasColumnName("OurCompanyID").IsOptional();
            this.Property(t => t.TheirCompanyID).HasColumnName("TheirCompanyID").IsOptional();
            this.Property(t => t.ProductID).HasColumnName("ProductID").IsOptional();
            this.Property(t => t.LocationID).HasColumnName("LocationID").IsOptional();
            this.Property(t => t.OriginID).HasColumnName("OriginID").IsOptional();
            this.Property(t => t.DestinationID).HasColumnName("DestinationID").IsOptional();
            this.Property(t => t.DealID).HasColumnName("DealID").IsOptional();
            this.Property(t => t.InvoiceNumber).HasColumnName("InvoiceNumber").IsOptional();
            this.Property(t => t.LineNumber).HasColumnName("LineNumber").IsOptional();
            this.Property(t => t.InvoiceType).HasColumnName("InvoiceType").IsOptional();
            this.Property(t => t.Status).HasColumnName("Status").IsOptional();
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate").IsOptional();
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate").IsOptional();
            this.Property(t => t.InvoiceDate).HasColumnName("InvoiceDate").IsOptional();
            this.Property(t => t.DueDate).HasColumnName("DueDate").IsOptional();
            this.Property(t => t.PaymentDate).HasColumnName("PaymentDate").IsOptional();
            this.Property(t => t.PostedDate).HasColumnName("PostedDate").IsOptional();
            this.Property(t => t.AttachedDate).HasColumnName("AttachedDate").IsOptional();
            this.Property(t => t.AccountingPeriod).HasColumnName("AccountingPeriod").IsOptional();
            this.Property(t => t.TotalValue).HasColumnName("TotalValue").IsOptional();
            this.Property(t => t.PaidAmount).HasColumnName("PaidAmount").IsOptional();
            this.Property(t => t.LineAmount).HasColumnName("LineAmount").IsOptional();
            this.Property(t => t.Currency).HasColumnName("Currency").IsOptional();
            this.Property(t => t.Quantity).HasColumnName("Quantity").IsOptional();
            this.Property(t => t.QuantityUnit).HasColumnName("QuantityUnit").IsOptional();
            this.Property(t => t.TransactionType).HasColumnName("TransactionType").IsOptional();
            this.Property(t => t.PaymentType).HasColumnName("PaymentType").IsOptional();
            this.Property(t => t.Approved).HasColumnName("Approved").IsOptional();
            this.Property(t => t.BOL).HasColumnName("BOL").IsOptional();
            this.Property(t => t.OriginalInvoice).HasColumnName("OriginalInvoice").IsOptional();
            this.Property(t => t.OriginalSource).HasColumnName("OriginalSource").IsOptional();
            this.Property(t => t.OriginalAmount).HasColumnName("OriginalAmount").IsOptional();
            this.Property(t => t.Comment).HasColumnName("Comment").IsOptional();
            this.Property(t => t.ShipDate).HasColumnName("ShipDate").IsOptional();
            this.Property(t => t.CorrectedInvoiceNumber).HasColumnName("CorrectedInvoiceNumber").IsOptional();
            this.Property(t => t.InvoiceTerms).HasColumnName("InvoiceTerms").IsOptional();
            this.Property(t => t.DiscountAmount).HasColumnName("DiscountAmount").IsOptional();
            this.Property(t => t.DiscountDate).HasColumnName("DiscountDate").IsOptional();
            this.Property(t => t.Price).HasColumnName("Price").IsOptional();
            this.Property(t => t.Ticket).HasColumnName("Ticket").IsOptional();
            this.Property(t => t.InvoiceParent).HasColumnName("InvoiceParent").IsOptional();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();

            // Foreign Key Mappings
            this.HasOptional<BusinessAssociate>(t => t.OurCompany).WithMany().HasForeignKey(f => f.OurCompanyID);
            this.HasOptional<BusinessAssociate>(t => t.TheirCompany).WithMany().HasForeignKey(f => f.TheirCompanyID);
            this.HasOptional<Deal>(t => t.Deal).WithMany().HasForeignKey(f => f.DealID);
            this.HasOptional<Product>(t => t.Product).WithMany().HasForeignKey(f => f.ProductID);
            this.HasOptional<Location>(t => t.Location).WithMany().HasForeignKey(f => f.LocationID);
            this.HasOptional<Location>(t => t.Origin).WithMany().HasForeignKey(f => f.OriginID);
            this.HasOptional<Location>(t => t.Destination).WithMany().HasForeignKey(f => f.DestinationID);
        }
    }
}
