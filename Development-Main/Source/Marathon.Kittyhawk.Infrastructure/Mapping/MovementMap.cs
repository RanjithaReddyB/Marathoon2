using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Movement entity mapping for Entity Framework.
    /// </summary>
    public class MovementMap : EntityTypeConfiguration<Movement>
    {
        public MovementMap()
        {
            // Table & Column Mappings
            this.ToTable("Movement");
            this.Property(t => t.MovementDocumentKey).HasColumnName("MovementDocumentKey").IsRequired();
            this.Property(t => t.MovementHeaderKey).HasColumnName("MovementHeaderKey").IsRequired();
            this.Property(t => t.DocumentBAID).HasColumnName("DocumentBAID").IsOptional();
            this.Property(t => t.ReceiptCompanyID).HasColumnName("ReceiptCompanyID").IsOptional();
            this.Property(t => t.DeliveryCompanyID).HasColumnName("DeliveryCompanyID").IsOptional();
            this.Property(t => t.CarrierID).HasColumnName("CarrierID").IsOptional();
            this.Property(t => t.ProductID).HasColumnName("ProductID").IsOptional();
            this.Property(t => t.LocationID).HasColumnName("LocationID").IsOptional();
            this.Property(t => t.OriginID).HasColumnName("OriginID").IsOptional();
            this.Property(t => t.DestinationID).HasColumnName("DestinationID").IsOptional();
            this.Property(t => t.VehicleID).HasColumnName("VehicleID").IsOptional();
            this.Property(t => t.ReceiptDealID).HasColumnName("ReceiptDealID").IsOptional();
            this.Property(t => t.DeliveryDealID).HasColumnName("DeliveryDealID").IsOptional();
            this.Property(t => t.OriginContainerID).HasColumnName("OriginContainerID").IsOptional();
            this.Property(t => t.DestinationContainerID).HasColumnName("DestinationContainerID").IsOptional();
            this.Property(t => t.TransportID).HasColumnName("TransportID").IsOptional();
            this.Property(t => t.ComponentProductID).HasColumnName("ComponentProductID").IsOptional();
            this.Property(t => t.EndProductID).HasColumnName("EndProductID").IsOptional();
			this.Property(t => t.MovementFleetID).HasColumnName("MovementFleetID").IsOptional();
			this.Property(t => t.MovementNumber).HasColumnName("MovementNumber").IsOptional();
            this.Property(t => t.LineNumber).HasColumnName("LineNumber").IsOptional();
            this.Property(t => t.ActivityType).HasColumnName("ActivityType").IsOptional();
            this.Property(t => t.DocumentStatus).HasColumnName("DocumentStatus").IsRequired().IsOptional();
            this.Property(t => t.MovementStatus).HasColumnName("MovementStatus").IsRequired().IsOptional();
            this.Property(t => t.DocumentDate).HasColumnName("DocumentDate").IsOptional();
            this.Property(t => t.DocumentChangedDate).HasColumnName("DocumentChangedDate").IsOptional();
            this.Property(t => t.MovementDate).HasColumnName("MovementDate").IsOptional();
            this.Property(t => t.MovementChangedDate).HasColumnName("MovementChangedDate").IsOptional();
            this.Property(t => t.MovementTemplate).HasColumnName("MovementTemplate").IsOptional();
            this.Property(t => t.UserTemplate).HasColumnName("UserTemplate").IsOptional();
            this.Property(t => t.Actualizer).HasColumnName("Actualizer").IsOptional();
            this.Property(t => t.MovementType).HasColumnName("MovementType").IsOptional();
            this.Property(t => t.MovementExpenses).HasColumnName("MovementExpenses").IsOptional();
            this.Property(t => t.NetQuantity).HasColumnName("NetQuantity").IsOptional();
            this.Property(t => t.GrossQuantity).HasColumnName("GrossQuantity").IsOptional();
            this.Property(t => t.QuantityUnit).HasColumnName("QuantityUnit").IsOptional();
            this.Property(t => t.NetWeight).HasColumnName("NetWeight").IsOptional();
            this.Property(t => t.GrossWeight).HasColumnName("GrossWeight").IsOptional();
            this.Property(t => t.WeightUnit).HasColumnName("WeightUnit").IsOptional();
            this.Property(t => t.SpecificGravity).HasColumnName("SpecificGravity").IsOptional();
            this.Property(t => t.APIGravity).HasColumnName("APIGravity").IsOptional();
            this.Property(t => t.Description).HasColumnName("Description").IsOptional();
            this.Property(t => t.ExternalBatch).HasColumnName("ExternalBatch").IsOptional();
            this.Property(t => t.TransportNumber).HasColumnName("TransportNumber").IsOptional();
            this.Property(t => t.MeterNumber).HasColumnName("MeterNumber").IsOptional();
            this.Property(t => t.TicketNumber).HasColumnName("TicketNumber").IsOptional();
            this.Property(t => t.TankNumber).HasColumnName("TankNumber").IsOptional();
            this.Property(t => t.CountryOfOrigin).HasColumnName("CountryOfOrigin").IsOptional();
            this.Property(t => t.Comment).HasColumnName("Comment").IsOptional();
            this.Property(t => t.DriverNumber).HasColumnName("DriverNumber").IsOptional();
            this.Property(t => t.TransOrigin).HasColumnName("TransOrigin").IsOptional();
            this.Property(t => t.DivertStateID).HasColumnName("DivertStateID").IsOptional();
            this.Property(t => t.DivertNumber).HasColumnName("DivertNumber").IsOptional();
            this.Property(t => t.LaneNumber).HasColumnName("LaneNumber").IsOptional();
            this.Property(t => t.TransactionBuildType).HasColumnName("TransactionBuildType").IsOptional();
            this.Property(t => t.TransactionSequenceNumber).HasColumnName("TransactionSequenceNumber").IsOptional();
            this.Property(t => t.MpcOwnedRailCar).HasColumnName("MpcOwnedRailCar").IsOptional();
            this.Property(t => t.EstablishedDateTime).HasColumnName("EstablishedDateTime").IsOptional();
            this.Property(t => t.ExchangePartnerIndicator).HasColumnName("ExchangePartnerIndicator").IsOptional();
            this.Property(t => t.ControlCode).HasColumnName("ControlCode").IsOptional();
            this.Property(t => t.StartDateTime).HasColumnName("StartDateTime").IsOptional();
            this.Property(t => t.MovementDateTime).HasColumnName("MovementDateTime").IsOptional();
            this.Property(t => t.EndDateTime).HasColumnName("EndDateTime").IsOptional();
            this.Property(t => t.LiftingNumber).HasColumnName("LiftingNumber").IsOptional();
            this.Property(t => t.CompanyUseType).HasColumnName("CompanyUseType").IsOptional();
            this.Property(t => t.Temperature).HasColumnName("Temperature").IsOptional();
            this.Property(t => t.Density).HasColumnName("Density").IsOptional();
            this.Property(t => t.RecipeCode).HasColumnName("RecipeCode").IsOptional();
            this.Property(t => t.YieldCommodity).HasColumnName("YieldCommodity").IsOptional();
            this.Property(t => t.PONumber).HasColumnName("PONumber").IsOptional();
            this.Property(t => t.EstimateActual).HasColumnName("EstimateActual").IsOptional();
            this.Property(t => t.ReportDate).HasColumnName("ReportDate").IsOptional();
            this.Property(t => t.ChangedBy).HasColumnName("ChangedBy").IsOptional();
            this.Property(t => t.NetDisplayQuantity).HasColumnName("NetDisplayQuantity").IsOptional();
            this.Property(t => t.GrossDisplayQuantity).HasColumnName("GrossDisplayQuantity").IsOptional();
			this.Property(t => t.TerritoryManagerID).HasColumnName("TerritoryManagerID").IsOptional();
			this.Property(t => t.EndProductCode).HasColumnName("EndProductCode").IsOptional();
            this.Property(t => t.ComponentProductCode).HasColumnName("ComponentProductCode").IsOptional();
			this.Property(t => t.MovementFleetCode).HasColumnName("MovementFleetCode").IsOptional();
            this.Property(t => t.PLBatch).HasColumnName("PLBatch").IsOptional();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();

            // Foreign Key Mappings
            this.HasOptional<BusinessAssociate>(t => t.DocumentBA).WithMany().HasForeignKey(f => f.DocumentBAID);
            this.HasOptional<BusinessAssociate>(t => t.ReceiptCompany).WithMany().HasForeignKey(f => f.ReceiptCompanyID);
            this.HasOptional<BusinessAssociate>(t => t.DeliveryCompany).WithMany().HasForeignKey(f => f.DeliveryCompanyID);
            this.HasOptional<BusinessAssociate>(t => t.Carrier).WithMany().HasForeignKey(f => f.CarrierID);
            this.HasOptional<Product>(t => t.Product).WithMany().HasForeignKey(f => f.ProductID);
            this.HasOptional<Product>(t => t.ComponentProduct).WithMany().HasForeignKey(f => f.ComponentProductID);
            this.HasOptional<Product>(t => t.EndProduct).WithMany().HasForeignKey(f => f.EndProductID);
            this.HasOptional<Location>(t => t.Location).WithMany().HasForeignKey(f => f.LocationID);
            this.HasOptional<Location>(t => t.Origin).WithMany().HasForeignKey(f => f.OriginID);
            this.HasOptional<Location>(t => t.Destination).WithMany().HasForeignKey(f => f.DestinationID);
            this.HasOptional<Vehicle>(t => t.Vehicle).WithMany().HasForeignKey(f => f.VehicleID);
            this.HasOptional<Deal>(t => t.ReceiptDeal).WithMany().HasForeignKey(f => f.ReceiptDealID);
            this.HasOptional<Deal>(t => t.DeliveryDeal).WithMany().HasForeignKey(f => f.DeliveryDealID);
            this.HasOptional<Container>(t => t.OriginContainer).WithMany().HasForeignKey(f => f.OriginContainerID);
            this.HasOptional<Container>(t => t.DestinationContainer).WithMany().HasForeignKey(f => f.DestinationContainerID);
            this.HasOptional<Transport>(t => t.Transport).WithMany().HasForeignKey(f => f.TransportID);
			this.HasOptional<Location>(t => t.DivertState).WithMany().HasForeignKey(f => f.DivertStateID);
			this.HasOptional<Location>(t => t.MovementFleet).WithMany().HasForeignKey(f => f.MovementFleetID);
			this.HasOptional<TerritoryManager>(t => t.TerritoryManager).WithMany().HasForeignKey(f => f.TerritoryManagerID);
		}
    }
}
