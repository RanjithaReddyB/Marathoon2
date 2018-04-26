using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Transfer entity mapping for Entity Framework.
    /// </summary>
    public class TransferMap : EntityTypeConfiguration<Transfer>
    {
        public TransferMap()
        {
            // Table & Column Mappings
            this.ToTable("Transfer");
            this.Property(t => t.PlannedTransferKey).HasColumnName("PlannedTransferKey").IsRequired();
            this.Property(t => t.PlannedMovementKey).HasColumnName("PlannedMovementKey").IsOptional();
            this.Property(t => t.CarrierID).HasColumnName("CarrierID").IsOptional();
            this.Property(t => t.ConsigneeID).HasColumnName("ConsigneeID").IsOptional();
            this.Property(t => t.ProductID).HasColumnName("ProductID").IsOptional();
            this.Property(t => t.LocationID).HasColumnName("LocationID").IsOptional();
            this.Property(t => t.OriginID).HasColumnName("OriginID").IsOptional();
            this.Property(t => t.DestinationID).HasColumnName("DestinationID").IsOptional();
            this.Property(t => t.DealID).HasColumnName("DealID").IsOptional();
            this.Property(t => t.OrderID).HasColumnName("OrderID").IsOptional();
            this.Property(t => t.FromDate).HasColumnName("FromDate").IsOptional();
            this.Property(t => t.ToDate).HasColumnName("ToDate").IsOptional();
            this.Property(t => t.ChangedDate).HasColumnName("ChangedDate").IsOptional();
            this.Property(t => t.EstimatedStartDate).HasColumnName("EstimatedStartDate").IsOptional();
            this.Property(t => t.EstimatedEndDate).HasColumnName("EstimatedEndDate").IsOptional();
            this.Property(t => t.SchedulingPeriod).HasColumnName("SchedulingPeriod").IsOptional();
            this.Property(t => t.Status).HasColumnName("Status").IsOptional();
            this.Property(t => t.CustomStatus).HasColumnName("CustomStatus").IsOptional();
            this.Property(t => t.SupplyDemand).HasColumnName("SupplyDemand").IsOptional();
            this.Property(t => t.TransportMethod).HasColumnName("TransportMethod").IsOptional();
            this.Property(t => t.SequenceNumber).HasColumnName("SequenceNumber").IsOptional();
            this.Property(t => t.TotalQuantity).HasColumnName("TotalQuantity").IsOptional();
            this.Property(t => t.ActualQuantity).HasColumnName("ActualQuantity").IsOptional();
            this.Property(t => t.RemainingQuantity).HasColumnName("RemainingQuantity").IsOptional();
            this.Property(t => t.QuantityUnit).HasColumnName("QuantityUnit").IsOptional();
            this.Property(t => t.TotalWeight).HasColumnName("TotalWeight").IsOptional();
            this.Property(t => t.ActualWeight).HasColumnName("ActualWeight").IsOptional();
            this.Property(t => t.WeightUnit).HasColumnName("WeightUnit").IsOptional();
            this.Property(t => t.Price).HasColumnName("Price").IsOptional();
            this.Property(t => t.Strategy).HasColumnName("Strategy").IsOptional();
            this.Property(t => t.Currency).HasColumnName("Currency").IsOptional();
            this.Property(t => t.IsObligationTransfer).HasColumnName("IsObligationTransfer").IsOptional();
            this.Property(t => t.NetNominate).HasColumnName("NetNominate").IsOptional();
            this.Property(t => t.InternallyVerified).HasColumnName("InternallyVerified").IsOptional();
            this.Property(t => t.ExternallyVerified).HasColumnName("ExternallyVerified").IsOptional();
            this.Property(t => t.ExcludeFromNomination).HasColumnName("ExcludeFromNomination").IsOptional();
            this.Property(t => t.Comment).HasColumnName("Comment").IsOptional();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();
            this.Property(t => t.ForecastType).HasColumnName("ForecastType").IsOptional();

            // Foreign Key Mappings
            this.HasOptional<BusinessAssociate>(t => t.Carrier).WithMany().HasForeignKey(f => f.CarrierID);
            this.HasOptional<BusinessAssociate>(t => t.Consignee).WithMany().HasForeignKey(f => f.ConsigneeID);
            this.HasOptional<Product>(t => t.Product).WithMany().HasForeignKey(f => f.ProductID);
            this.HasOptional<Location>(t => t.Location).WithMany().HasForeignKey(f => f.LocationID);
            this.HasOptional<Location>(t => t.Origin).WithMany().HasForeignKey(f => f.OriginID);
            this.HasOptional<Location>(t => t.Destination).WithMany().HasForeignKey(f => f.DestinationID);
            this.HasOptional<Deal>(t => t.Deal).WithMany().HasForeignKey(f => f.DealID);
            this.HasOptional<Order>(t => t.Order).WithMany().HasForeignKey(f => f.OrderID);
        }
    }
}
