using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Accounting transaction entity mapping for Entity Framework.
    /// </summary>
    public class AccountingTransactionMap : EntityTypeConfiguration<AccountingTransaction>
    {
        public AccountingTransactionMap()
        {
            // Table & Column Mappings
            this.ToTable("AccountingTransaction");
            this.Property(t => t.AccountDetailKey).HasColumnName("AccountDetailKey").IsRequired();
            this.Property(t => t.AccountCodeKey).HasColumnName("AccountCodeKey").IsOptional();
            this.Property(t => t.AccountCodeLogKey).HasColumnName("AccountCodeLogKey").IsOptional();
            this.Property(t => t.PlannedTransferKey).HasColumnName("PlannedTransferKey").IsOptional();
            this.Property(t => t.MovementHeaderKey).HasColumnName("MovementHeaderKey").IsOptional();
            this.Property(t => t.TransactionHeaderKey).HasColumnName("TransactionHeaderKey").IsOptional();
            this.Property(t => t.InvoiceHeaderKey).HasColumnName("InvoiceHeaderKey").IsOptional();
            this.Property(t => t.InvoiceDetailKey).HasColumnName("InvoiceDetailKey").IsOptional();
            this.Property(t => t.InvoiceType).HasColumnName("InvoiceType").IsOptional();
            this.Property(t => t.OurCompanyID).HasColumnName("OurCompanyID").IsOptional();
            this.Property(t => t.TheirCompanyID).HasColumnName("TheirCompanyID").IsOptional();
            this.Property(t => t.ProductID).HasColumnName("ProductID").IsOptional();
            this.Property(t => t.ChildProductID).HasColumnName("ChildProductID").IsOptional();
            this.Property(t => t.LocationID).HasColumnName("LocationID").IsOptional();
            this.Property(t => t.OriginID).HasColumnName("OriginID").IsOptional();
            this.Property(t => t.DestinationID).HasColumnName("DestinationID").IsOptional();
            this.Property(t => t.DealID).HasColumnName("DealID").IsOptional();
            this.Property(t => t.TransferID).HasColumnName("TransferID").IsOptional();
            this.Property(t => t.MovementID).HasColumnName("MovementID").IsOptional();
            this.Property(t => t.MovementTransactionID).HasColumnName("MovementTransactionID").IsOptional();
            this.Property(t => t.MovementExpenseID).HasColumnName("MovementExpenseID").IsOptional();
            this.Property(t => t.TimeTransactionID).HasColumnName("TimeTransactionID").IsOptional();
            this.Property(t => t.InvoiceID).HasColumnName("InvoiceID").IsOptional();
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate").IsOptional();
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate").IsOptional();
            this.Property(t => t.TransactionDate).HasColumnName("TransactionDate").IsOptional();
            this.Property(t => t.LogDate).HasColumnName("LogDate").IsOptional();
            this.Property(t => t.AccountingPeriod).HasColumnName("AccountingPeriod").IsOptional();
            this.Property(t => t.AccountNumber).HasColumnName("AccountNumber").IsOptional();
            this.Property(t => t.AccountDescription).HasColumnName("AccountDescription").IsOptional();
            this.Property(t => t.AccountType).HasColumnName("AccountType").IsOptional();
            this.Property(t => t.DebitCredit).HasColumnName("DebitCredit").IsOptional();
            this.Property(t => t.Value).HasColumnName("Value").IsOptional();
            this.Property(t => t.Currency).HasColumnName("Currency").IsOptional();
            this.Property(t => t.Quantity).HasColumnName("Quantity").IsOptional();
            this.Property(t => t.QuantityUnit).HasColumnName("QuantityUnit").IsOptional();
            this.Property(t => t.Reversed).HasColumnName("Reversed").IsOptional();
            this.Property(t => t.SourceTable).HasColumnName("SourceTable").IsOptional();
            this.Property(t => t.SourceID).HasColumnName("SourceID").IsOptional();
            this.Property(t => t.SupplyDemand).HasColumnName("SupplyDemand").IsOptional();
            this.Property(t => t.WePayTheyPay).HasColumnName("WePayTheyPay").IsOptional();
            this.Property(t => t.AccountCodeStatus).HasColumnName("AccountCodeStatus").IsOptional();
            this.Property(t => t.TaxStatus).HasColumnName("TaxStatus").IsOptional();
            this.Property(t => t.Intradivisional).HasColumnName("Intradivisional").IsOptional();
            this.Property(t => t.IsNetOut).HasColumnName("IsNetOut").IsOptional();
            this.Property(t => t.Comment).HasColumnName("Comment").IsOptional();
            this.Property(t => t.GrossQuantity).HasColumnName("GrossQuantity").IsOptional();
            this.Property(t => t.NetQuantity).HasColumnName("NetQuantity").IsOptional();
            this.Property(t => t.TransactionTypeID).HasColumnName("TransactionTypeID").IsOptional();
            this.Property(t => t.CostType).HasColumnName("CostType").IsOptional();
            this.Property(t => t.OldStyleValue).HasColumnName("OldStyleValue").IsOptional();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();

            // Foreign Key Mappings
            this.HasOptional<BusinessAssociate>(t => t.OurCompany).WithMany().HasForeignKey(f => f.OurCompanyID);
            this.HasOptional<BusinessAssociate>(t => t.TheirCompany).WithMany().HasForeignKey(f => f.TheirCompanyID);
            this.HasOptional<Product>(t => t.Product).WithMany().HasForeignKey(f => f.ProductID);
            this.HasOptional<Product>(t => t.ChildProduct).WithMany().HasForeignKey(f => f.ChildProductID);
            this.HasOptional<Location>(t => t.Location).WithMany().HasForeignKey(f => f.LocationID);
            this.HasOptional<Location>(t => t.Origin).WithMany().HasForeignKey(f => f.OriginID);
            this.HasOptional<Location>(t => t.Destination).WithMany().HasForeignKey(f => f.DestinationID);
            this.HasOptional<Deal>(t => t.Deal).WithMany().HasForeignKey(f => f.DealID);
            this.HasOptional<Transfer>(t => t.Transfer).WithMany().HasForeignKey(f => f.TransferID);
            this.HasOptional<Movement>(t => t.Movement).WithMany().HasForeignKey(f => f.MovementID);
            this.HasOptional<MovementTransaction>(t => t.MovementTransaction).WithMany().HasForeignKey(f => f.MovementTransactionID);
            this.HasOptional<MovementExpense>(t => t.MovementExpense).WithMany().HasForeignKey(f => f.MovementExpenseID);
            this.HasOptional<TimeTransaction>(t => t.TimeTransaction).WithMany().HasForeignKey(f => f.TimeTransactionID);
            this.HasOptional<Invoice>(t => t.Invoice).WithMany().HasForeignKey(f => f.InvoiceID);
            this.HasOptional<TransactionType>(t => t.TransactionType).WithMany().HasForeignKey(f => f.TransactionTypeID);
        }
    }
}
