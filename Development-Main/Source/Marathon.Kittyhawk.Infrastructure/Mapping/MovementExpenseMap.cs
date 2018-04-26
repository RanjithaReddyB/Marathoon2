using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Movement expense entity mapping for Entity Framework.
    /// </summary>
    public class MovementExpenseMap : EntityTypeConfiguration<MovementExpense>
    {
        public MovementExpenseMap()
        {
            // Table & Column Mappings
            this.ToTable("MovementExpense");
            this.Property(t => t.MovementExpenseKey).HasColumnName("MovementExpenseKey").IsRequired();
            this.Property(t => t.MovementExpenseLogKey).HasColumnName("MovementExpenseLogKey").IsOptional();
            this.Property(t => t.PlannedTransferKey).HasColumnName("PlannedTransferKey").IsOptional();
            this.Property(t => t.MovementHeaderKey).HasColumnName("MovementHeaderKey").IsOptional();
            this.Property(t => t.InternalBAID).HasColumnName("InternalBAID").IsOptional();
            this.Property(t => t.ExternalBAID).HasColumnName("ExternalBAID").IsOptional();
            this.Property(t => t.ProductID).HasColumnName("ProductID").IsOptional();
            this.Property(t => t.LocationID).HasColumnName("LocationID").IsOptional();
            this.Property(t => t.TransferID).HasColumnName("TransferID").IsOptional();
            this.Property(t => t.MovementID).HasColumnName("MovementID").IsOptional();
            this.Property(t => t.TransactionType).HasColumnName("TransactionType").IsOptional();
            this.Property(t => t.PaymentType).HasColumnName("PaymentType").IsOptional();
            this.Property(t => t.Status).HasColumnName("Status").IsOptional();
            this.Property(t => t.Reversal).HasColumnName("Reversal").IsOptional();
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate").IsOptional();
            this.Property(t => t.ExpenseDate).HasColumnName("ExpenseDate").IsOptional();
            this.Property(t => t.Quantity).HasColumnName("Quantity").IsOptional();
            this.Property(t => t.QuantityUnit).HasColumnName("QuantityUnit").IsOptional();
            this.Property(t => t.PerUnitValue).HasColumnName("PerUnitValue").IsOptional();
            this.Property(t => t.TotalValue).HasColumnName("TotalValue").IsOptional();
            this.Property(t => t.Currency).HasColumnName("Currency").IsOptional();
            this.Property(t => t.Strategy).HasColumnName("Strategy").IsOptional();
            this.Property(t => t.Comment).HasColumnName("Comment").IsOptional();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();

            // Foreign Key Mappings
            this.HasOptional<BusinessAssociate>(t => t.InternalBA).WithMany().HasForeignKey(f => f.InternalBAID);
            this.HasOptional<BusinessAssociate>(t => t.ExternalBA).WithMany().HasForeignKey(f => f.ExternalBAID);
            this.HasOptional<Product>(t => t.Product).WithMany().HasForeignKey(f => f.ProductID);
            this.HasOptional<Location>(t => t.Location).WithMany().HasForeignKey(f => f.LocationID);
            this.HasOptional<Transfer>(t => t.Transfer).WithMany().HasForeignKey(f => f.TransferID);
            this.HasOptional<Movement>(t => t.Movement).WithMany().HasForeignKey(f => f.MovementID);
        }
    }
}
