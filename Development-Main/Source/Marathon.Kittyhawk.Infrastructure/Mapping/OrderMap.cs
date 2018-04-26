using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Order entity mapping for Entity Framework.
    /// </summary>
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            // Table & Column Mappings
            this.ToTable("Order");
            this.Property(t => t.PlannedMovementKey).HasColumnName("PlannedMovementKey").IsRequired();
            this.Property(t => t.ProductID).HasColumnName("ProductID").IsOptional();
            this.Property(t => t.OriginID).HasColumnName("OriginID").IsOptional();
            this.Property(t => t.DestinationID).HasColumnName("DestinationID").IsOptional();
            this.Property(t => t.FinalDestinationID).HasColumnName("FinalDestinationID").IsOptional();
            this.Property(t => t.VehicleID).HasColumnName("VehicleID").IsOptional();
            this.Property(t => t.MovementPlanID).HasColumnName("MovementPlanID").IsOptional();
            this.Property(t => t.OrderNumber).HasColumnName("OrderNumber").IsOptional();
            this.Property(t => t.FromDate).HasColumnName("FromDate").IsOptional();
            this.Property(t => t.ToDate).HasColumnName("ToDate").IsOptional();
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate").IsOptional();
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate").IsOptional();
            this.Property(t => t.Status).HasColumnName("Status").IsOptional();
            this.Property(t => t.RollType).HasColumnName("RollType").IsOptional();
            this.Property(t => t.Quantity).HasColumnName("Quantity").IsOptional();
            this.Property(t => t.QuantityUnit).HasColumnName("QuantityUnit").IsOptional();
            this.Property(t => t.BatchName).HasColumnName("BatchName").IsOptional();
            this.Property(t => t.PlannedTransport).HasColumnName("PlannedTransport").IsOptional();
            this.Property(t => t.Scheduler).HasColumnName("Scheduler").IsOptional();
            this.Property(t => t.Comment).HasColumnName("Comment").IsOptional();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();

            // Foreign Key Mappings
            this.HasOptional<Product>(t => t.Product).WithMany().HasForeignKey(f => f.ProductID);
            this.HasOptional<Location>(t => t.Origin).WithMany().HasForeignKey(f => f.OriginID);
            this.HasOptional<Location>(t => t.Destination).WithMany().HasForeignKey(f => f.DestinationID);
            this.HasOptional<Location>(t => t.FinalDestination).WithMany().HasForeignKey(f => f.FinalDestinationID);
            this.HasOptional<Vehicle>(t => t.Vehicle).WithMany().HasForeignKey(f => f.VehicleID);
            this.HasOptional<MovementPlan>(t => t.MovementPlan).WithMany().HasForeignKey(f => f.MovementPlanID);
        }
    }
}
