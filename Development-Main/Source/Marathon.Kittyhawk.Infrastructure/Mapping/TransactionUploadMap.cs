using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
	public class TransactionUploadMap : EntityTypeConfiguration<TransactionUpload>
	{
		public TransactionUploadMap()
		{
			// Properties

			this.Property(t => t.ProcessIdentifier)
				.HasMaxLength(40);

			this.Property(t => t.ActionCode)
				.HasMaxLength(6);

			this.Property(t => t.TransOrigin)
				.HasMaxLength(20);

			this.Property(t => t.TicketNumber)
				.HasMaxLength(16);

			this.Property(t => t.ShortTicketNumber)
				.HasMaxLength(6);

			this.Property(t => t.BatchIdentifier)
			   .HasMaxLength(15);

			this.Property(t => t.TransactionType)
				.HasMaxLength(12);

			this.Property(t => t.TransferType)
				.HasMaxLength(22);

			this.Property(t => t.LiftingNumber)
				.HasMaxLength(15);

			this.Property(t => t.FacilityCode)
				.HasMaxLength(6);

			this.Property(t => t.OriginFacilityCode)
				.HasMaxLength(6);

			this.Property(t => t.OriginContainerCode)
				.HasMaxLength(5);

			this.Property(t => t.DestinationFacilityCode)
				.HasMaxLength(6);

			this.Property(t => t.DestinationContainerCode)
				.HasMaxLength(5);

			this.Property(t => t.ProductCode)
				.HasMaxLength(6);

			this.Property(t => t.ComponentProductCode)
			   .HasMaxLength(3);

			this.Property(t => t.EndProductCode)
			   .HasMaxLength(5);

			this.Property(t => t.RecipeCode)
			   .HasMaxLength(3);

			this.Property(t => t.CustomerCode)
				.HasMaxLength(6);

			this.Property(t => t.SupplierCode)
				.HasMaxLength(6);

			this.Property(t => t.CarrierCode)
				.HasMaxLength(4);

			this.Property(t => t.TransportCode)
				.HasMaxLength(15);

			this.Property(t => t.CustomerNumber)
				.HasMaxLength(6);

			this.Property(t => t.CountryCode)
				.HasMaxLength(2);

			this.Property(t => t.TransportMode)
				.HasMaxLength(29);

			this.Property(t => t.GrossQuantity)
				.HasPrecision(11, 2);

			this.Property(t => t.GrossQuantityUnit)
				.HasMaxLength(9);

			this.Property(t => t.NetQuantity)
				.HasPrecision(11, 2);

			this.Property(t => t.NetQuantityUnit)
				.HasMaxLength(9);

			this.Property(t => t.Temperature)
				.HasPrecision(4, 1);

			this.Property(t => t.Density)
				.HasPrecision(5, 3);

			this.Property(t => t.ContractNumber)
				.HasMaxLength(15);

			this.Property(t => t.MeterNumber)
				.HasMaxLength(2);

			this.Property(t => t.FleetCode)
				.HasMaxLength(6);

			this.Property(t => t.MpcRailcar)
				.HasMaxLength(1);

			this.Property(t => t.Comments)
				.HasMaxLength(100);

			this.Property(t => t.UploadSequenceNumber)
				.HasMaxLength(12);

			this.Property(t => t.TransactionBuildType)
				.HasMaxLength(50);

            this.Property(t => t.MatchStatus)
                .HasMaxLength(50);

            this.Property(t => t.CommodityType)
                .HasMaxLength(1);

			// Table & Column Mappings
			this.ToTable("TransactionUpload");

			// KH System Properties
			this.Property(t => t.CreateDate).HasColumnName("CreateDate").IsOptional();
			this.Property(t => t.CreatedByUser).HasColumnName("CreatedByUser").IsOptional();
			this.Property(t => t.UpdatedByUser).HasColumnName("UpdatedByUser").IsOptional();
			this.Property(t => t.SentToPIDate).HasColumnName("SentToPIDate").IsOptional();
			this.Property(t => t.DataSourceID).HasColumnName("DataSourceID").IsRequired();
			this.Property(t => t.ProcessIdentifier).HasColumnName("ProcessIdentifier").IsRequired();
			this.Property(t => t.IsDirty).HasColumnName("IsDirty").IsRequired();
			this.Property(t => t.ErrorStatus).HasColumnName("ErrorStatus").IsRequired();
			this.Property(t => t.IsPublished).HasColumnName("IsPublished").IsRequired();
			this.Property(t => t.IgnoreErrors).HasColumnName("IgnoreErrors").IsRequired();
			this.Property(t => t.ActionCode).HasColumnName("ActionCode").IsRequired();

			// BOL Properties
			this.Property(t => t.ControlCode).HasColumnName("ControlCode").IsRequired();
			this.Property(t => t.TransOrigin).HasColumnName("TransOrigin").IsOptional();
            this.Property(t => t.OriginalTicketNumber).HasColumnName("OriginalTicketNumber").IsOptional();
            this.Property(t => t.TicketNumber).HasColumnName("TicketNumber").IsOptional();
			this.Property(t => t.ShortTicketNumber).HasColumnName("ShortTicketNumber").IsOptional();
			this.Property(t => t.BatchIdentifier).HasColumnName("BatchIdentifier").IsOptional();
			this.Property(t => t.TransactionType).HasColumnName("TransactionType").IsRequired();
			this.Property(t => t.TransferType).HasColumnName("TransferType").IsOptional();
			this.Property(t => t.LiftingNumber).HasColumnName("LiftingNumber").IsOptional();
			this.Property(t => t.FacilityID).HasColumnName("FacilityID").IsOptional();
			this.Property(t => t.OriginID).HasColumnName("OriginID").IsOptional();
			this.Property(t => t.DestinationID).HasColumnName("DestinationID").IsOptional();
            this.Property(t => t.FleetID).HasColumnName("FleetId").IsOptional();
			this.Property(t => t.ProductID).HasColumnName("ProductID").IsOptional();
			this.Property(t => t.ComponentProductID).HasColumnName("ComponentProductID").IsOptional();
			this.Property(t => t.EndProductID).HasColumnName("EndProductID").IsOptional();
			this.Property(t => t.CustomerID).HasColumnName("CustomerID").IsOptional();
			this.Property(t => t.SupplierID).HasColumnName("SupplierID").IsOptional();
			this.Property(t => t.CarrierID).HasColumnName("CarrierID").IsOptional();
			this.Property(t => t.FacilityCode).HasColumnName("FacilityCode").IsOptional();
			this.Property(t => t.OriginFacilityCode).HasColumnName("OriginFacilityCode").IsOptional();
			this.Property(t => t.OriginContainerCode).HasColumnName("OriginContainerCode").IsOptional();
			this.Property(t => t.DestinationFacilityCode).HasColumnName("DestinationFacilityCode").IsOptional();
			this.Property(t => t.DestinationContainerCode).HasColumnName("DestinationContainerCode").IsOptional();
            this.Property(t => t.FleetCode).HasColumnName("FleetCode").IsOptional();
			this.Property(t => t.ProductCode).HasColumnName("ProductCode").IsOptional();
			this.Property(t => t.ComponentProductCode).HasColumnName("ComponentProductCode").IsOptional();
			this.Property(t => t.EndProductCode).HasColumnName("EndProductCode").IsOptional();
			this.Property(t => t.RecipeCode).HasColumnName("RecipeCode").IsOptional();
			this.Property(t => t.CustomerCode).HasColumnName("CustomerCode").IsOptional();
			this.Property(t => t.SupplierCode).HasColumnName("SupplierCode").IsOptional();
			this.Property(t => t.CarrierCode).HasColumnName("CarrierCode").IsOptional();
			this.Property(t => t.TransportCode).HasColumnName("TransportCode").IsOptional();
			this.Property(t => t.CustomerNumber).HasColumnName("CustomerNumber").IsOptional();
			this.Property(t => t.CountryCode).HasColumnName("CountryCode").IsOptional();
			this.Property(t => t.TransportMode).HasColumnName("TransportMode").IsOptional();
			this.Property(t => t.TransferStart).HasColumnName("TransferStart").IsOptional();
			this.Property(t => t.TransferEnd).HasColumnName("TransferEnd").IsOptional();
			this.Property(t => t.ShipDate).HasColumnName("ShipDate").IsOptional();
			this.Property(t => t.StartDate).HasColumnName("StartDate").IsOptional();
			this.Property(t => t.ReportDate).HasColumnName("ReportDate").IsOptional();
			this.Property(t => t.GrossQuantity).HasColumnName("GrossQuantity").IsOptional();
			this.Property(t => t.GrossQuantityUnit).HasColumnName("GrossQuantityUnit").IsOptional();
			this.Property(t => t.NetQuantity).HasColumnName("NetQuantity").IsOptional();
			this.Property(t => t.NetQuantityUnit).HasColumnName("NetQuantityUnit").IsOptional();
			this.Property(t => t.Gravity).HasColumnName("Gravity").IsOptional();
			this.Property(t => t.Temperature).HasColumnName("Temperature").IsOptional();
			this.Property(t => t.Density).HasColumnName("Density").IsOptional();
			this.Property(t => t.ContractNumber).HasColumnName("ContractNumber").IsOptional();
			this.Property(t => t.PONumber).HasColumnName("PONumber").IsOptional();
			this.Property(t => t.DriverNumber).HasColumnName("DriverNumber").IsOptional();
			this.Property(t => t.MeterNumber).HasColumnName("MeterNumber").IsOptional();
			this.Property(t => t.LaneNumber).HasColumnName("LaneNumber").IsOptional();
			this.Property(t => t.MpcRailcar).HasColumnName("MpcRailcar").IsOptional();
			this.Property(t => t.Comments).HasColumnName("Comments").IsOptional();
			this.Property(t => t.UploadSequenceNumber).HasColumnName("UploadSequenceNumber").IsRequired();
			this.Property(t => t.TransactionBuildType).HasColumnName("TransactionBuildType").IsOptional();
			this.Property(t => t.UploadEstablishedDate).HasColumnName("UploadEstablishedDate").IsOptional();
			this.Property(t => t.DeliveryDealDetail).HasColumnName("DeliveryDealDetail").IsOptional();
            this.Property(t => t.DeliveryDealNumber).HasColumnName("DeliveryDealNumber").IsOptional();
            this.Property(t => t.ReceiptDealDetail).HasColumnName("ReceiptDealDetail").IsOptional();
            this.Property(t => t.ReceiptDealNumber).HasColumnName("ReceiptDealNumber").IsOptional();
            this.Property(t => t.SourceRecord).HasColumnName("SourceRecord").HasColumnType("xml").IsRequired();
            this.Property(t => t.Dest).HasColumnName("Dest").IsOptional();
            this.Property(t => t.RefLoc).HasColumnName("RefLoc").IsOptional();
            this.Property(t => t.RptLoc).HasColumnName("RptLoc").IsOptional();
            this.Property(t => t.MeasurementDateTime).HasColumnName("MeasurementDateTime").IsOptional();
            this.Property(t => t.MatchStatus).HasColumnName("MatchStatus").IsOptional();
            this.Property(t => t.GroupId).HasColumnName("GroupId").IsOptional();
            this.Property(t => t.UploadEstablishedUser).HasColumnName("UploadEstablishedUser").IsOptional();
            this.Property(t => t.CrossReferenceErrorStatus).HasColumnName("CrossReferenceErrorStatus").IsOptional();
            this.Property(t => t.AllocationManagerErrorStatus).HasColumnName("AllocationManagerErrorStatus").IsOptional();
            this.Property(t => t.Usage).HasColumnName("Usage").IsOptional();
            this.Property(t => t.CommodityType).HasColumnName("CommodityType").IsOptional();
            this.Property(t => t.Taboot).HasColumnName("Taboot").IsOptional();

            // Foreign Key Mappings
            this.HasRequired<DataSource>(t => t.DataSource).WithMany().HasForeignKey(f => f.DataSourceID);
			this.HasOptional<Location>(t => t.Facility).WithMany().HasForeignKey(f => f.FacilityID);
			this.HasOptional<Location>(t => t.Origin).WithMany().HasForeignKey(f => f.OriginID);
			this.HasOptional<Location>(t => t.Destination).WithMany().HasForeignKey(f => f.DestinationID);
            this.HasOptional<Location>(t => t.Fleet).WithMany().HasForeignKey(f => f.FleetID);
            this.HasOptional<Product>(t => t.Product).WithMany().HasForeignKey(f => f.ProductID);
			this.HasOptional<Product>(t => t.ComponentProduct).WithMany().HasForeignKey(f => f.ComponentProductID);
			this.HasOptional<Product>(t => t.EndProduct).WithMany().HasForeignKey(f => f.EndProductID);
			this.HasOptional<BusinessAssociate>(t => t.Customer).WithMany().HasForeignKey(f => f.CustomerID);
			this.HasOptional<BusinessAssociate>(t => t.Supplier).WithMany().HasForeignKey(f => f.SupplierID);
			this.HasOptional<BusinessAssociate>(t => t.Carrier).WithMany().HasForeignKey(f => f.CarrierID);            
        }
	}
}
