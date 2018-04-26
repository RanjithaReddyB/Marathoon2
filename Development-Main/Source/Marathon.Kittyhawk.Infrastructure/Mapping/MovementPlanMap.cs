using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Movement plan entity mapping for Entity Framework.
    /// </summary>
    public class MovementPlanMap : EntityTypeConfiguration<MovementPlan>
    {
        public MovementPlanMap()
        {
            // Table & Column Mappings
            this.ToTable("MovementPlan");
            this.Property(t => t.RoutePlanHeaderKey).HasColumnName("RoutePlanHeaderKey").IsRequired();
            this.Property(t => t.OriginProductID).HasColumnName("OriginProductID").IsOptional();
            this.Property(t => t.DestinationProductID).HasColumnName("DestinationProductID").IsOptional();
            this.Property(t => t.OriginLocationID).HasColumnName("OriginLocationID").IsOptional();
            this.Property(t => t.DestinationLocationID).HasColumnName("DestinationLocationID").IsOptional();
            this.Property(t => t.Leg1CarrierID).HasColumnName("Leg1CarrierID").IsOptional();
            this.Property(t => t.Leg2CarrierID).HasColumnName("Leg2CarrierID").IsOptional();
            this.Property(t => t.Leg3CarrierID).HasColumnName("Leg3CarrierID").IsOptional();
            this.Property(t => t.Leg4CarrierID).HasColumnName("Leg4CarrierID").IsOptional();
            this.Property(t => t.Leg5CarrierID).HasColumnName("Leg5CarrierID").IsOptional();
            this.Property(t => t.Leg1OriginDealID).HasColumnName("Leg1OriginDealID").IsOptional();
            this.Property(t => t.Leg1DestinationDealID).HasColumnName("Leg1DestinationDealID").IsOptional();
            this.Property(t => t.Leg2OriginDealID).HasColumnName("Leg2OriginDealID").IsOptional();
            this.Property(t => t.Leg2DestinationDealID).HasColumnName("Leg2DestinationDealID").IsOptional();
            this.Property(t => t.Leg3OriginDealID).HasColumnName("Leg3OriginDealID").IsOptional();
            this.Property(t => t.Leg3DestinationDealID).HasColumnName("Leg3DestinationDealID").IsOptional();
            this.Property(t => t.Leg4OriginDealID).HasColumnName("Leg4OriginDealID").IsOptional();
            this.Property(t => t.Leg4DestinationDealID).HasColumnName("Leg4DestinationDealID").IsOptional();
            this.Property(t => t.Leg5OriginDealID).HasColumnName("Leg5OriginDealID").IsOptional();
            this.Property(t => t.Leg5DestinationDealID).HasColumnName("Leg5DestinationDealID").IsOptional();
            this.Property(t => t.Name).HasColumnName("Name").IsOptional();
            this.Property(t => t.Type).HasColumnName("Type").IsOptional();
            this.Property(t => t.Status).HasColumnName("Status").IsOptional();
            this.Property(t => t.NumberOfLegs).HasColumnName("NumberOfLegs").IsOptional();
            this.Property(t => t.FromDate).HasColumnName("FromDate").IsOptional();
            this.Property(t => t.ToDate).HasColumnName("ToDate").IsOptional();
            this.Property(t => t.Leg1TransportType).HasColumnName("Leg1TransportType").IsOptional();
            this.Property(t => t.Leg2TransportType).HasColumnName("Leg2TransportType").IsOptional();
            this.Property(t => t.Leg3TransportType).HasColumnName("Leg3TransportType").IsOptional();
            this.Property(t => t.Leg4TransportType).HasColumnName("Leg4TransportType").IsOptional();
            this.Property(t => t.Leg5TransportType).HasColumnName("Leg5TransportType").IsOptional();
            this.Property(t => t.Comment).HasColumnName("Comment").IsOptional();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();

            // Foreign Key Mappings
            this.HasOptional<Product>(t => t.OriginProduct).WithMany().HasForeignKey(f => f.OriginProductID);
            this.HasOptional<Product>(t => t.DestinationProduct).WithMany().HasForeignKey(f => f.DestinationProductID);
            this.HasOptional<Location>(t => t.OriginLocation).WithMany().HasForeignKey(f => f.OriginLocationID);
            this.HasOptional<Location>(t => t.DestinationLocation).WithMany().HasForeignKey(f => f.DestinationLocationID);
            this.HasOptional<BusinessAssociate>(t => t.Leg1Carrier).WithMany().HasForeignKey(f => f.Leg1CarrierID);
            this.HasOptional<BusinessAssociate>(t => t.Leg2Carrier).WithMany().HasForeignKey(f => f.Leg2CarrierID);
            this.HasOptional<BusinessAssociate>(t => t.Leg3Carrier).WithMany().HasForeignKey(f => f.Leg3CarrierID);
            this.HasOptional<BusinessAssociate>(t => t.Leg4Carrier).WithMany().HasForeignKey(f => f.Leg4CarrierID);
            this.HasOptional<BusinessAssociate>(t => t.Leg5Carrier).WithMany().HasForeignKey(f => f.Leg5CarrierID);
            this.HasOptional<Deal>(t => t.Leg1OriginDeal).WithMany().HasForeignKey(f => f.Leg1OriginDealID);
            this.HasOptional<Deal>(t => t.Leg1DestinationDeal).WithMany().HasForeignKey(f => f.Leg1DestinationDealID);
            this.HasOptional<Deal>(t => t.Leg2OriginDeal).WithMany().HasForeignKey(f => f.Leg2OriginDealID);
            this.HasOptional<Deal>(t => t.Leg2DestinationDeal).WithMany().HasForeignKey(f => f.Leg2DestinationDealID);
            this.HasOptional<Deal>(t => t.Leg3OriginDeal).WithMany().HasForeignKey(f => f.Leg3OriginDealID);
            this.HasOptional<Deal>(t => t.Leg3DestinationDeal).WithMany().HasForeignKey(f => f.Leg3DestinationDealID);
            this.HasOptional<Deal>(t => t.Leg4OriginDeal).WithMany().HasForeignKey(f => f.Leg4OriginDealID);
            this.HasOptional<Deal>(t => t.Leg4DestinationDeal).WithMany().HasForeignKey(f => f.Leg4DestinationDealID);
            this.HasOptional<Deal>(t => t.Leg5OriginDeal).WithMany().HasForeignKey(f => f.Leg5OriginDealID);
            this.HasOptional<Deal>(t => t.Leg5DestinationDeal).WithMany().HasForeignKey(f => f.Leg5DestinationDealID);
        }
    }
}
