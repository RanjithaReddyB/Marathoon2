using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Inventory reconcile entity mapping for Entity Framework.
    /// </summary>
    public class InventoryReconcileMap : EntityTypeConfiguration<InventoryReconcile>
    {
        public InventoryReconcileMap()
        {
            // Table & Column Mappings
            this.ToTable("InventoryReconcile");
            this.Property(t => t.InventoryReconcileKey).HasColumnName("InventoryReconcileKey").IsRequired();
            this.Property(t => t.PlannedTransferKey).HasColumnName("PlannedTransferKey").IsOptional();
            this.Property(t => t.TransactionHeaderKey).HasColumnName("TransactionHeaderKey").IsOptional();
            this.Property(t => t.CompanyID).HasColumnName("CompanyID").IsOptional();
            this.Property(t => t.ProductID).HasColumnName("ProductID").IsOptional();
            this.Property(t => t.LocationID).HasColumnName("LocationID").IsOptional();
            this.Property(t => t.DealID).HasColumnName("DealID").IsOptional();
            this.Property(t => t.TransferID).HasColumnName("TransferID").IsOptional();
            this.Property(t => t.MovementTransactionID).HasColumnName("MovementTransactionID").IsOptional();
            this.Property(t => t.ReconcileDate).HasColumnName("ReconcileDate").IsOptional();
            this.Property(t => t.MovementDate).HasColumnName("MovementDate").IsOptional();
            this.Property(t => t.AccountingPeriod).HasColumnName("AccountingPeriod").IsOptional();
            this.Property(t => t.Status).HasColumnName("Status").IsOptional();
            this.Property(t => t.SupplyDemand).HasColumnName("SupplyDemand").IsOptional();
            this.Property(t => t.Reversed).HasColumnName("Reversed").IsOptional();
            this.Property(t => t.Pool).HasColumnName("Pool").IsOptional();
            this.Property(t => t.ReasonCode).HasColumnName("ReasonCode").IsOptional();
            this.Property(t => t.Quantity).HasColumnName("Quantity").IsOptional();
            this.Property(t => t.QuantityUnit).HasColumnName("QuantityUnit").IsOptional();
            this.Property(t => t.ReconcileGroup).HasColumnName("ReconcileGroup").IsOptional();
            this.Property(t => t.Comment).HasColumnName("Comment").IsOptional();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();

            // Foreign Key Mappings
            this.HasOptional<BusinessAssociate>(t => t.Company).WithMany().HasForeignKey(f => f.CompanyID);
            this.HasOptional<Product>(t => t.Product).WithMany().HasForeignKey(f => f.ProductID);
            this.HasOptional<Location>(t => t.Location).WithMany().HasForeignKey(f => f.LocationID);
            this.HasOptional<Deal>(t => t.Deal).WithMany().HasForeignKey(f => f.DealID);
            this.HasOptional<Transfer>(t => t.Transfer).WithMany().HasForeignKey(f => f.TransferID);
            this.HasOptional<MovementTransaction>(t => t.MovementTransaction).WithMany().HasForeignKey(f => f.MovementTransactionID);
        }
    }
}
