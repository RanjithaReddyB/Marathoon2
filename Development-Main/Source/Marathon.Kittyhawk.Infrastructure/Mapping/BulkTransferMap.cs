using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Bulk transfer entity mapping for Entity Framework.
    /// </summary>
    public class BulkTransferMap : EntityTypeConfiguration<BulkTransfer>
    {
        public BulkTransferMap()
        {
            // Properties
            this.Property(t => t.ProcessIdentifier)
                .HasMaxLength(100);

            this.Property(t => t.ActionCode)
                .HasMaxLength(100);

            this.Property(t => t.ActivityIndicator)
                .HasMaxLength(100);

            this.Property(t => t.LoadOrUnload)
                .HasMaxLength(100);

            this.Property(t => t.BatchIdentifier)
                .HasMaxLength(100);

            this.Property(t => t.TicketNumber)
                .HasMaxLength(100);

            this.Property(t => t.ShortTicketNumber)
                .HasMaxLength(100);

            this.Property(t => t.OriginFacilityCode)
                .HasMaxLength(100);

            this.Property(t => t.OriginContainerCode)
                .HasMaxLength(100);

            this.Property(t => t.OriginProductCode)
                .HasMaxLength(100);

            this.Property(t => t.DestinationFacilityCode)
                .HasMaxLength(100);

            this.Property(t => t.DestinationContainerCode)
                .HasMaxLength(100);

            this.Property(t => t.DestinationProductCode)
                .HasMaxLength(100);

            this.Property(t => t.CustomerCode)
                .HasMaxLength(100);

            this.Property(t => t.SupplierCode)
                .HasMaxLength(100);

            this.Property(t => t.ShipperCode)
                .HasMaxLength(100);

            this.Property(t => t.CarrierCode)
                .HasMaxLength(100);

            this.Property(t => t.TransportCode)
                .HasMaxLength(100);

            this.Property(t => t.VehicleCode)
                .HasMaxLength(100);

            this.Property(t => t.CountryCode)
                .HasMaxLength(100);

            this.Property(t => t.TransportType)
                .HasMaxLength(100);

            this.Property(t => t.ProgressLandmark)
                .HasMaxLength(100);

            this.Property(t => t.ScheduledQuantityUnit)
                .HasMaxLength(100);

            this.Property(t => t.GrossQuantityUnit)
                .HasMaxLength(100);

            this.Property(t => t.NetQuantityUnit)
                .HasMaxLength(100);

            this.Property(t => t.TransferType)
                .HasMaxLength(100);

            this.Property(t => t.ContractNumber)
                .HasMaxLength(100);

            this.Property(t => t.CarStatus)
                .HasMaxLength(100);

            this.Property(t => t.SourceID)
                .HasMaxLength(100);

            this.Property(t => t.LiftingNumber)
               .HasMaxLength(100);

            this.Property(t => t.PONumber)
                .HasMaxLength(100);

            this.Property(t => t.YieldCommodityCode)
                .HasMaxLength(100);

            this.Property(t => t.AutoMatchStatus)
              .HasMaxLength(100);


            // Table & Column Mappings
            this.ToTable("BulkTransfer");
            this.Property(t => t.ProcessIdentifier).HasColumnName("ProcessIdentifier").IsRequired();
            this.Property(t => t.DataSourceID).HasColumnName("DataSourceID").IsRequired();
            this.Property(t => t.IsDirty).HasColumnName("IsDirty").IsRequired();
            this.Property(t => t.IsPublished).HasColumnName("IsPublished").IsRequired();
            this.Property(t => t.IgnoreErrors).HasColumnName("IgnoreErrors").IsRequired();
            this.Property(t => t.ErrorStatus).HasColumnName("ErrorStatus").IsRequired();
            this.Property(t => t.ActionCode).HasColumnName("ActionCode").IsRequired();
            this.Property(t => t.ActivityIndicator).HasColumnName("ActivityIndicator").IsRequired();
            this.Property(t => t.LoadOrUnload).HasColumnName("LoadOrUnload").IsRequired();
            this.Property(t => t.BatchIdentifier).HasColumnName("BatchIdentifier").IsOptional();
            this.Property(t => t.TicketNumber).HasColumnName("TicketNumber").IsOptional();
            this.Property(t => t.ShortTicketNumber).HasColumnName("ShortTicketNumber").IsOptional();
            this.Property(t => t.FacilityID).HasColumnName("FacilityID").IsOptional();
            this.Property(t => t.OriginID).HasColumnName("OriginID").IsOptional();
            this.Property(t => t.DestinationID).HasColumnName("DestinationID").IsOptional();
            this.Property(t => t.OriginContainerID).HasColumnName("OriginContainerID").IsOptional();
            this.Property(t => t.DestinationContainerID).HasColumnName("DestinationContainerID").IsOptional();
            this.Property(t => t.ProductID).HasColumnName("ProductID").IsOptional();
            this.Property(t => t.CustomerID).HasColumnName("CustomerID").IsOptional();
            this.Property(t => t.SupplierID).HasColumnName("SupplierID").IsOptional();
            this.Property(t => t.ShipperID).HasColumnName("ShipperID").IsOptional();
            this.Property(t => t.CarrierID).HasColumnName("CarrierID").IsOptional();
            this.Property(t => t.TransportID).HasColumnName("TransportID").IsOptional();
            this.Property(t => t.VehicleID).HasColumnName("VehicleID").IsOptional();
            this.Property(t => t.OriginFacilityCode).HasColumnName("OriginFacilityCode").IsOptional();
            this.Property(t => t.OriginContainerCode).HasColumnName("OriginContainerCode").IsOptional();
            this.Property(t => t.OriginProductCode).HasColumnName("OriginProductCode").IsOptional();
            this.Property(t => t.DestinationFacilityCode).HasColumnName("DestinationFacilityCode").IsOptional();
            this.Property(t => t.DestinationContainerCode).HasColumnName("DestinationContainerCode").IsOptional();
            this.Property(t => t.DestinationProductCode).HasColumnName("DestinationProductCode").IsOptional();
            this.Property(t => t.CustomerCode).HasColumnName("CustomerCode").IsOptional();
            this.Property(t => t.SupplierCode).HasColumnName("SupplierCode").IsOptional();
            this.Property(t => t.ShipperCode).HasColumnName("ShipperCode").IsOptional();
            this.Property(t => t.CarrierCode).HasColumnName("CarrierCode").IsOptional();
            this.Property(t => t.TransportCode).HasColumnName("TransportCode").IsOptional();
            this.Property(t => t.VehicleCode).HasColumnName("VehicleCode").IsOptional();
            this.Property(t => t.CountryCode).HasColumnName("CountryCode").IsOptional();
            this.Property(t => t.TransportType).HasColumnName("TransportType").IsOptional();
            this.Property(t => t.TransferStart).HasColumnName("TransferStart").IsOptional();
            this.Property(t => t.TransferEnd).HasColumnName("TransferEnd").IsOptional();
            this.Property(t => t.ETA).HasColumnName("ETA").IsOptional();
            this.Property(t => t.ProgressLandmark).HasColumnName("ProgressLandmark").IsOptional();
            this.Property(t => t.ProgressLandmarkTimestamp).HasColumnName("ProgressLandmarkTimestamp").IsOptional();
            this.Property(t => t.ScheduledQuantity).HasColumnName("ScheduledQuantity").IsOptional();
            this.Property(t => t.ScheduledQuantityUnit).HasColumnName("ScheduledQuantityUnit").IsOptional();
            this.Property(t => t.GrossQuantity).HasColumnName("GrossQuantity").IsOptional();
            this.Property(t => t.GrossQuantityUnit).HasColumnName("GrossQuantityUnit").IsOptional();
            this.Property(t => t.NetQuantity).HasColumnName("NetQuantity").IsOptional();
            this.Property(t => t.NetQuantityUnit).HasColumnName("NetQuantityUnit").IsOptional();
            this.Property(t => t.Gravity).HasColumnName("Gravity").IsOptional();
            this.Property(t => t.Density).HasColumnName("Density").IsOptional();
            this.Property(t => t.Temperature).HasColumnName("Temperature").IsOptional();
            this.Property(t => t.RVP).HasColumnName("RVP").IsOptional();
            this.Property(t => t.TransferType).HasColumnName("TransferType").IsOptional();
            this.Property(t => t.ContractNumber).HasColumnName("ContractNumber").IsOptional();
            this.Property(t => t.CarStatus).HasColumnName("CarStatus").IsOptional();
            this.Property(t => t.IsThirdParty).HasColumnName("IsThirdParty").IsOptional();
            this.Property(t => t.IsFreeRunner).HasColumnName("IsFreeRunner").IsOptional();
            this.Property(t => t.IsSupplierShipment).HasColumnName("IsSupplierShipment").IsOptional();
            this.Property(t => t.Comments).HasColumnName("Comments").IsOptional();
            this.Property(t => t.SourceID).HasColumnName("SourceID").IsOptional();
            this.Property(t => t.SourceDate).HasColumnName("SourceDate").IsOptional();
            this.Property(t => t.SourceRecord).HasColumnName("SourceRecord").HasColumnType("xml").IsOptional();
            this.Property(t => t.LiftingNumber).HasColumnName("LiftingNumber").IsOptional();
            this.Property(t => t.PONumber).HasColumnName("PONumber").IsOptional();
            this.Property(t => t.YieldCommodityCode).HasColumnName("YieldCommodityCode").IsOptional();
            this.Property(t => t.AutoMatchStatus).HasColumnName("AutoMatchStatus").IsOptional();
            this.Property(t => t.IsConstructivePlacement).HasColumnName("IsConstructivePlacement").IsOptional();
            this.Property(t => t.IsRAPublish).HasColumnName("IsRAPublish").IsOptional();
            this.Property(t => t.DeliveryDealDetail).HasColumnName("DeliveryDealDetail").IsOptional();
            this.Property(t => t.DeliveryDealNumber).HasColumnName("DeliveryDealNumber").IsOptional();
            this.Property(t => t.ReceiptDealDetail).HasColumnName("ReceiptDealDetail").IsOptional();
            this.Property(t => t.ReceiptDealNumber).HasColumnName("ReceiptDealNumber").IsOptional();
            // Foreign Key Mappings
            this.HasRequired<DataSource>(t => t.DataSource).WithMany().HasForeignKey(f => f.DataSourceID);
            this.HasOptional<Location>(t => t.Facility).WithMany().HasForeignKey(f => f.FacilityID);
            this.HasOptional<Location>(t => t.Origin).WithMany().HasForeignKey(f => f.OriginID);
            this.HasOptional<Location>(t => t.Destination).WithMany().HasForeignKey(f => f.DestinationID);
            this.HasOptional<Container>(t => t.OriginContainer).WithMany().HasForeignKey(f => f.OriginContainerID);
            this.HasOptional<Container>(t => t.DestinationContainer).WithMany().HasForeignKey(f => f.DestinationContainerID);
            this.HasOptional<Product>(t => t.Product).WithMany().HasForeignKey(f => f.ProductID);
            this.HasOptional<BusinessAssociate>(t => t.Customer).WithMany().HasForeignKey(f => f.CustomerID);
            this.HasOptional<BusinessAssociate>(t => t.Supplier).WithMany().HasForeignKey(f => f.SupplierID);
            this.HasOptional<BusinessAssociate>(t => t.Shipper).WithMany().HasForeignKey(f => f.ShipperID);
            this.HasOptional<BusinessAssociate>(t => t.Carrier).WithMany().HasForeignKey(f => f.CarrierID);
            this.HasOptional<Transport>(t => t.Transport).WithMany().HasForeignKey(f => f.TransportID);
            this.HasOptional<Vehicle>(t => t.Vehicle).WithMany().HasForeignKey(f => f.VehicleID);
        }
    }
}
