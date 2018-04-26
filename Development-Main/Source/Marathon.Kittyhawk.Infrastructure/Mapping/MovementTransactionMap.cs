using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Movement transaction entity mapping for Entity Framework.
    /// </summary>
    public class MovementTransactionMap : EntityTypeConfiguration<MovementTransaction>
    {
        public MovementTransactionMap()
        {
            // Table & Column Mappings
            this.ToTable("MovementTransaction");
            this.Property(t => t.TransactionHeaderKey).HasColumnName("TransactionHeaderKey").IsRequired();
            this.Property(t => t.PlannedTransferKey).HasColumnName("PlannedTransferKey").IsOptional();
            this.Property(t => t.MovementHeaderKey).HasColumnName("MovementHeaderKey").IsOptional();
            this.Property(t => t.ProductID).HasColumnName("ProductID").IsOptional();
            this.Property(t => t.ChildProductID).HasColumnName("ChildProductID").IsOptional();
            this.Property(t => t.LocationID).HasColumnName("LocationID").IsOptional();
            this.Property(t => t.DestinationID).HasColumnName("DestinationID").IsOptional();
            this.Property(t => t.PlannedOriginID).HasColumnName("PlannedOriginID").IsOptional();
            this.Property(t => t.PlannedDestinationID).HasColumnName("PlannedDestinationID").IsOptional();
            this.Property(t => t.TransferID).HasColumnName("TransferID").IsOptional();
            this.Property(t => t.MovementID).HasColumnName("MovementID").IsOptional();
            this.Property(t => t.Status).HasColumnName("Status").IsOptional();
            this.Property(t => t.SupplyDemand).HasColumnName("SupplyDemand").IsOptional();
            this.Property(t => t.ReportingCommodityCode).HasColumnName("ReportingCommodityCode").IsOptional();
            this.Property(t => t.MovementDate).HasColumnName("MovementDate").IsOptional();
            this.Property(t => t.TransactionDate).HasColumnName("TransactionDate").IsOptional();
            this.Property(t => t.NetQuantity).HasColumnName("NetQuantity").IsOptional();
            this.Property(t => t.GrossQuantity).HasColumnName("GrossQuantity").IsOptional();
            this.Property(t => t.QuantityUnit).HasColumnName("QuantityUnit").IsOptional();
            this.Property(t => t.NetWeight).HasColumnName("NetWeight").IsOptional();
            this.Property(t => t.WeightUnit).HasColumnName("WeightUnit").IsOptional();
            this.Property(t => t.SpecificGravity).HasColumnName("SpecificGravity").IsOptional();
            this.Property(t => t.APIGravity).HasColumnName("APIGravity").IsOptional();
            this.Property(t => t.MovementType).HasColumnName("MovementType").IsOptional();
			this.Property(t => t.IsInventory).HasColumnName("IsInventory").IsOptional();
			this.Property(t => t.Comment).HasColumnName("Comment").IsOptional();
            this.Property(t => t.OriginalMovementOriginID).HasColumnName("OriginalMovementOriginID").IsOptional();
            this.Property(t => t.OriginalMovementCarrierID).HasColumnName("OriginalMovementCarrierID").IsOptional();
            this.Property(t => t.OriginalMovementComponentProductID).HasColumnName("OriginalMovementComponentProductID").IsOptional();
            this.Property(t => t.OriginalMovementEndProductID).HasColumnName("OriginalMovementEndProductID").IsOptional();
            this.Property(t => t.OriginalMovementMovementFleetID).HasColumnName("OriginalMovementMovementFleetID").IsOptional();
            this.Property(t => t.OriginalMovementLiftingNumber).HasColumnName("OriginalMovementLiftingNumber").IsOptional();
            this.Property(t => t.OriginalMovementPONumber).HasColumnName("OriginalMovementPONumber").IsOptional();
            this.Property(t => t.OriginalMovementDensity).HasColumnName("OriginalMovementDensity").IsOptional();
            this.Property(t => t.OriginalMovementDriverNumber).HasColumnName("OriginalMovementDriverNumber").IsOptional();
            this.Property(t => t.OriginalMovementYieldCommodity).HasColumnName("OriginalMovementYieldCommodity").IsOptional();
            this.Property(t => t.OriginalMovementTankNumber).HasColumnName("OriginalMovementTankNumber").IsOptional();
            this.Property(t => t.OriginalMovementRecipeCode).HasColumnName("OriginalMovementRecipeCode").IsOptional();
            this.Property(t => t.OriginalMovementMpcOwnedRailCar).HasColumnName("OriginalMovementMpcOwnedRailCar").IsOptional();
            this.Property(t => t.OriginalMovementTransportNumber).HasColumnName("OriginalMovementTransportNumber").IsOptional();
            this.Property(t => t.OriginalMovementExternalBatch).HasColumnName("OriginalMovementExternalBatch").IsOptional();
            this.Property(t => t.OriginalMovementPLBatch).HasColumnName("OriginalMovementPLBatch").IsOptional();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();
            this.Property(t => t.NetDisplayQuantity).HasColumnName("NetDisplayQuantity").IsOptional();
            this.Property(t => t.GrossDisplayQuantity).HasColumnName("GrossDisplayQuantity").IsOptional();

            // Foreign Key Mappings
            this.HasOptional<Product>(t => t.Product).WithMany().HasForeignKey(f => f.ProductID);
            this.HasOptional<Product>(t => t.ChildProduct).WithMany().HasForeignKey(f => f.ChildProductID);
            this.HasOptional<Location>(t => t.Location).WithMany().HasForeignKey(f => f.LocationID);
            this.HasOptional<Location>(t => t.Destination).WithMany().HasForeignKey(f => f.DestinationID);
            this.HasOptional<Location>(t => t.PlannedOrigin).WithMany().HasForeignKey(f => f.PlannedOriginID);
            this.HasOptional<Location>(t => t.PlannedDestination).WithMany().HasForeignKey(f => f.PlannedDestinationID);
            this.HasOptional<Transfer>(t => t.Transfer).WithMany().HasForeignKey(f => f.TransferID);
            this.HasOptional<Movement>(t => t.Movement).WithMany().HasForeignKey(f => f.MovementID);
            this.HasOptional<Location>(t => t.OriginalMovementOrigin).WithMany().HasForeignKey(f => f.OriginalMovementOriginID);
            this.HasOptional<BusinessAssociate>(t => t.OriginalMovementCarrier).WithMany().HasForeignKey(f => f.OriginalMovementCarrierID);
            this.HasOptional<Product>(t => t.OriginalMovementComponentProduct).WithMany().HasForeignKey(f => f.OriginalMovementComponentProductID);
            this.HasOptional<Product>(t => t.OriginalMovementEndProduct).WithMany().HasForeignKey(f => f.OriginalMovementEndProductID);
            this.HasOptional<Location>(t => t.OriginalMovementMovementFleet).WithMany().HasForeignKey(f => f.OriginalMovementMovementFleetID);
        }
    }
}
