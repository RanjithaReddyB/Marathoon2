using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Deal entity mapping for Entity Framework.
    /// </summary>
    public class DealMap : EntityTypeConfiguration<Deal>
    {
        public DealMap()
        {
            // Table & Column Mappings
            this.ToTable("Deal");
            this.Property(t => t.DealHeaderKey).HasColumnName("DealHeaderKey").IsRequired();
            this.Property(t => t.DealDetailKey).HasColumnName("DealDetailKey").IsRequired();
            this.Property(t => t.DealDetailID).HasColumnName("DealDetailID").IsOptional();
            this.Property(t => t.TheirCompanyID).HasColumnName("TheirCompanyID").IsOptional();
            this.Property(t => t.DivisionID).HasColumnName("DivisionID").IsOptional();
            this.Property(t => t.CarrierID).HasColumnName("CarrierID").IsOptional();
            this.Property(t => t.ShipperID).HasColumnName("ShipperID").IsOptional();
            this.Property(t => t.ProductID).HasColumnName("ProductID").IsOptional();
            this.Property(t => t.LocationID).HasColumnName("LocationID").IsOptional();
            this.Property(t => t.OriginID).HasColumnName("OriginID").IsOptional();
            this.Property(t => t.DestinationID).HasColumnName("DestinationID").IsOptional();
            this.Property(t => t.VehicleID).HasColumnName("VehicleID").IsOptional();
            this.Property(t => t.TraderManagerID).HasColumnName("TraderManagerID").IsOptional();
            this.Property(t => t.DealNumber).HasColumnName("DealNumber").IsOptional();
            this.Property(t => t.FromDate).HasColumnName("FromDate").IsOptional();
            this.Property(t => t.ToDate).HasColumnName("ToDate").IsOptional();
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate").IsOptional();
            this.Property(t => t.RevisionDate).HasColumnName("RevisionDate").IsOptional();
            this.Property(t => t.DetailFromDate).HasColumnName("DetailFromDate").IsOptional();
            this.Property(t => t.DetailToDate).HasColumnName("DetailToDate").IsOptional();
            this.Property(t => t.DetailCreatedDate).HasColumnName("DetailCreatedDate").IsOptional();
            this.Property(t => t.DetailRevisionDate).HasColumnName("DetailRevisionDate").IsOptional();
            this.Property(t => t.TheirContact).HasColumnName("TheirContact").IsOptional();
            this.Property(t => t.InternalContact).HasColumnName("InternalContact").IsOptional();
            this.Property(t => t.Status).HasColumnName("Status").IsOptional();
            this.Property(t => t.DetailStatus).HasColumnName("DetailStatus").IsOptional();
            this.Property(t => t.DealType).HasColumnName("DealType").IsOptional();
            this.Property(t => t.DealTemplate).HasColumnName("DealTemplate").IsOptional();
            this.Property(t => t.TransportMethod).HasColumnName("TransportMethod").IsOptional();
            this.Property(t => t.DealTerm).HasColumnName("DealTerm").IsOptional();
            this.Property(t => t.SupplyDemand).HasColumnName("SupplyDemand").IsOptional();
            this.Property(t => t.Direction).HasColumnName("Direction").IsOptional();
            this.Property(t => t.SubType).HasColumnName("SubType").IsOptional();
            this.Property(t => t.DomesticForeign).HasColumnName("DomesticForeign").IsOptional();
            this.Property(t => t.IsTransportation).HasColumnName("IsTransportation").IsOptional();
            this.Property(t => t.IsPhysical).HasColumnName("IsPhysical").IsOptional();
            this.Property(t => t.Quantity).HasColumnName("Quantity").IsOptional();
            this.Property(t => t.QuantityUnit).HasColumnName("QuantityUnit").IsOptional();
            this.Property(t => t.QuantityFrequency).HasColumnName("QuantityFrequency").IsOptional();
            this.Property(t => t.SchedulingQuantityTerm).HasColumnName("SchedulingQuantityTerm").IsOptional();
            this.Property(t => t.Description).HasColumnName("Description").IsOptional();
            this.Property(t => t.Strategy).HasColumnName("Strategy").IsOptional();
            this.Property(t => t.PaymentTerms).HasColumnName("PaymentTerms").IsOptional();
            this.Property(t => t.GeneralTerms).HasColumnName("GeneralTerms").IsOptional();
            this.Property(t => t.CreditType).HasColumnName("CreditType").IsOptional();
            this.Property(t => t.PandC).HasColumnName("PandC").IsOptional();
            this.Property(t => t.TaxClass).HasColumnName("TaxClass").IsOptional();
            this.Property(t => t.DeliveryTerm).HasColumnName("DeliveryTerm").IsOptional();
            this.Property(t => t.TitleTransfer).HasColumnName("TitleTransfer").IsOptional();
            this.Property(t => t.Measurement).HasColumnName("Measurement").IsOptional();
            this.Property(t => t.TransportProvider).HasColumnName("TransportProvider").IsOptional();
            this.Property(t => t.Comment).HasColumnName("Comment").IsOptional();
            this.Property(t => t.HeaderHoldFromLoading).HasColumnName("HeaderHoldFromLoading").IsOptional();
            this.Property(t => t.DetailHoldFromLoading).HasColumnName("DetailHoldFromLoading").IsOptional();
            this.Property(t => t.JobNumber).HasColumnName("JobNumber").IsOptional();
            this.Property(t => t.PetroExExtension).HasColumnName("PetroExExtension").IsOptional();
            this.Property(t => t.GuaranteedSupply).HasColumnName("GuaranteedSupply").IsOptional();
            this.Property(t => t.Discretionary).HasColumnName("Discretionary").IsOptional();
            this.Property(t => t.ContractType).HasColumnName("ContractType").IsOptional();
            this.Property(t => t.SCOA).HasColumnName("SCOA").IsOptional();
            this.Property(t => t.ClassOfTrade).HasColumnName("ClassOfTrade").IsOptional();
            this.Property(t => t.TerritoryManagerID).HasColumnName("TerritoryManagerID").IsOptional();
            this.Property(t => t.NotifyCustomer).HasColumnName("NotifyCustomer").IsOptional();
            this.Property(t => t.WarningCustomer).HasColumnName("WarningCustomer").IsOptional();
            this.Property(t => t.WarningTrader).HasColumnName("WarningTrader").IsOptional();
            this.Property(t => t.WarningTraderAt).HasColumnName("WarningTraderAt").IsOptional();
            this.Property(t => t.HeaderCap).HasColumnName("HeaderCap").IsOptional();
            this.Property(t => t.DealValue).HasColumnName("DealValue").IsOptional();
            this.Property(t => t.PreAuthorized).HasColumnName("PreAuthorized").IsOptional();
            this.Property(t => t.ContractApprover).HasColumnName("ContractApprover").IsOptional();
            this.Property(t => t.FreightTerms).HasColumnName("FreightTerms").IsOptional();
            this.Property(t => t.PoNumber).HasColumnName("PoNumber").IsOptional();
            this.Property(t => t.OutOfTolerance).HasColumnName("OutOfTolerance").IsOptional();
            this.Property(t => t.RackPrompt).HasColumnName("RackPrompt").IsOptional();
            this.Property(t => t.NextAgreement).HasColumnName("NextAgreement").IsOptional();
            this.Property(t => t.DetailCap).HasColumnName("DetailCap").IsOptional();
            this.Property(t => t.QuantityNetOrGross).HasColumnName("QuantityNetOrGross").IsOptional();
            this.Property(t => t.NotifyTrader).HasColumnName("NotifyTrader").IsOptional();
            this.Property(t => t.VolumeToleranceDirection).HasColumnName("VolumeToleranceDirection").IsOptional();
            this.Property(t => t.VolumeToleranceQuantity).HasColumnName("VolumeToleranceQuantity").IsOptional();
            this.Property(t => t.ToleranceUsage).HasColumnName("ToleranceUsage").IsOptional();
			this.Property(t => t.MaxRevisionLevel).HasColumnName("MaxRevisionLevel").IsOptional();
			this.Property(t => t.ApprovalStatus).HasColumnName("ApprovalStatus").IsOptional().HasMaxLength(1);
			this.Property(t => t.ApprovalDate).HasColumnName("ApprovalDate").IsOptional();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();

            // Foreign Key Mappings
            this.HasOptional<BusinessAssociate>(t => t.TheirCompany).WithMany().HasForeignKey(f => f.TheirCompanyID);
            this.HasOptional<BusinessAssociate>(t => t.Division).WithMany().HasForeignKey(f => f.DivisionID);
            this.HasOptional<BusinessAssociate>(t => t.Carrier).WithMany().HasForeignKey(f => f.CarrierID);
            this.HasOptional<BusinessAssociate>(t => t.Shipper).WithMany().HasForeignKey(f => f.ShipperID);
            this.HasOptional<Product>(t => t.Product).WithMany().HasForeignKey(f => f.ProductID);
            this.HasOptional<Location>(t => t.Location).WithMany().HasForeignKey(f => f.LocationID);
            this.HasOptional<Location>(t => t.Origin).WithMany().HasForeignKey(f => f.OriginID);
            this.HasOptional<Location>(t => t.Destination).WithMany().HasForeignKey(f => f.DestinationID);
            this.HasOptional<Vehicle>(t => t.Vehicle).WithMany().HasForeignKey(f => f.VehicleID);
            this.HasOptional<Contact>(t => t.TraderManager).WithMany().HasForeignKey(f => f.TraderManagerID);
            this.HasOptional<TerritoryManager>(t => t.TerritoryManager).WithMany().HasForeignKey(f => f.TerritoryManagerID);
        }
    }
}
