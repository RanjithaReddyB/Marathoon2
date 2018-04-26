using System;
using System.Collections.Generic;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents a deal entry.
    /// </summary>
    public class Deal : Entity
    {
        public int DealHeaderKey { get; set; }
        public int DealDetailKey { get; set; }
        public int? DealDetailID { get; set; }
        public Guid? TheirCompanyID { get; set; }
        public Guid? DivisionID { get; set; }
        public Guid? CarrierID { get; set; }
        public Guid? ShipperID { get; set; }
        public Guid? ProductID { get; set; }
        public Guid? LocationID { get; set; }
        public Guid? OriginID { get; set; }
        public Guid? DestinationID { get; set; }
        public Guid? VehicleID { get; set; }
        public Guid? TraderManagerID { get; set; }
        public virtual BusinessAssociate TheirCompany { get; set; }
        public virtual BusinessAssociate Division { get; set; }
        public virtual BusinessAssociate Carrier { get; set; }
        public virtual BusinessAssociate Shipper { get; set; }
        public virtual Product Product { get; set; }
        public virtual Location Location { get; set; }
        public virtual Location Origin { get; set; }
        public virtual Location Destination { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual Contact TraderManager { get; set; }
        public string DealNumber { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? RevisionDate { get; set; }
        public DateTime? DetailFromDate { get; set; }
        public DateTime? DetailToDate { get; set; }
        public DateTime? DetailCreatedDate { get; set; }
        public DateTime? DetailRevisionDate { get; set; }
        public string TheirContact { get; set; }
        public string InternalContact { get; set; }
        public string Status { get; set; }
        public string DetailStatus { get; set; }
        public string DealType { get; set; }
        public string DealTemplate { get; set; }
        public string TransportMethod { get; set; }
        public string DealTerm { get; set; }
        public string SupplyDemand { get; set; }
        public string Direction { get; set; }
        public string SubType { get; set; }
        public string DomesticForeign { get; set; }
        public string IsTransportation { get; set; }
        public string IsPhysical { get; set; }
        public double? Quantity { get; set; }
        public string QuantityUnit { get; set; }
        public string QuantityFrequency { get; set; }
        public string SchedulingQuantityTerm { get; set; }
        public string Description { get; set; }
        public string Strategy { get; set; }
        public string PaymentTerms { get; set; }
        public string GeneralTerms { get; set; }
        public string CreditType { get; set; }
        public string PandC { get; set; }
        public string TaxClass { get; set; }
        public string DeliveryTerm { get; set; }
        public string TitleTransfer { get; set; }
        public string Measurement { get; set; }
        public string TransportProvider { get; set; }
        public string Comment { get; set; }
        public bool? HeaderHoldFromLoading { get; set; }
        public bool? DetailHoldFromLoading { get; set; }
        public string JobNumber { get; set; }
        public string PetroExExtension { get; set; }
        public bool? GuaranteedSupply { get; set; }
        public string Discretionary { get; set; }
        public string ContractType { get; set; }
        public string SCOA { get; set; }
        public string ClassOfTrade { get; set; }
        public virtual TerritoryManager TerritoryManager { get; set; }
		public Guid? TerritoryManagerID { get; set; }
        public bool? NotifyCustomer { get; set; }
        public bool? WarningCustomer { get; set; }
        public bool? WarningTrader { get; set; }
        public string WarningTraderAt { get; set; }
        public string HeaderCap { get; set; }
        public string DealValue { get; set; }
        public string PreAuthorized { get; set; }
        public string ContractApprover { get; set; }
        public string FreightTerms { get; set; }
        public string PoNumber { get; set; }
        public string OutOfTolerance { get; set; }
        public string RackPrompt { get; set; }
        public string NextAgreement { get; set; }
        public string DetailCap { get; set; }
        public string QuantityNetOrGross { get; set; }
        public string NotifyTrader { get; set; }
        public string VolumeToleranceDirection { get; set; }
        public double? VolumeToleranceQuantity { get; set; }
        public string ToleranceUsage { get; set; }
		public int? MaxRevisionLevel { get; set; }
		public string ApprovalStatus { get; set; }
		public DateTime? ApprovalDate { get; set; }
        public bool IsDeleted { get; set; }
		public virtual ICollection<DealObligation> DealObligations { get; set; }

		public Deal() { }
    }
}
