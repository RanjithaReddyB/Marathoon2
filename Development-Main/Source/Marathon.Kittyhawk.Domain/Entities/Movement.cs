using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents a movement entry.
    /// </summary>
    public class Movement : Entity
    {
        public int MovementDocumentKey { get; set; }
        public int MovementHeaderKey { get; set; }
        public Guid? DocumentBAID { get; set; }
        public Guid? ReceiptCompanyID { get; set; }
        public Guid? DeliveryCompanyID { get; set; }
        public Guid? CarrierID { get; set; }
        public Guid? ProductID { get; set; }
        public Guid? LocationID { get; set; }
        public Guid? OriginID { get; set; }
        public Guid? DestinationID { get; set; }
        public Guid? VehicleID { get; set; }
        public Guid? ReceiptDealID { get; set; }
        public Guid? DeliveryDealID { get; set; }
        public Guid? OriginContainerID { get; set; }
        public Guid? DestinationContainerID { get; set; }
        public Guid? TransportID { get; set; }
        public Guid? ComponentProductID { get; set; }
        public Guid? EndProductID { get; set; }
		public Guid? MovementFleetID { get; set; }
        public virtual BusinessAssociate DocumentBA { get; set; }
        public virtual BusinessAssociate ReceiptCompany { get; set; }
        public virtual BusinessAssociate DeliveryCompany { get; set; }
        public virtual BusinessAssociate Carrier { get; set; }
        public virtual Product Product { get; set; }
        public virtual Product ComponentProduct { get; set; }
        public virtual Product EndProduct { get; set; }
        public virtual Location Location { get; set; }
        public virtual Location Origin { get; set; }
        public virtual Location Destination { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual Deal ReceiptDeal { get; set; }
        public virtual Deal DeliveryDeal { get; set; }
        public virtual Container OriginContainer { get; set; }
        public virtual Container DestinationContainer { get; set; }
        public virtual Transport Transport { get; set; }
		public virtual Location MovementFleet { get; set; }
        public string MovementNumber { get; set; }
        public int? LineNumber { get; set; }
        public string ActivityType { get; set; }
        public string DocumentStatus { get; set; }
        public string MovementStatus { get; set; }
        public DateTime? DocumentDate { get; set; }
        public DateTime? DocumentChangedDate { get; set; }
        public DateTime? MovementDate { get; set; }
        public DateTime? MovementChangedDate { get; set; }
        public string MovementTemplate { get; set; }
        public string UserTemplate { get; set; }
        public string Actualizer { get; set; }
        public string MovementType { get; set; }
        public int? MovementExpenses { get; set; }
        public double? NetQuantity { get; set; }
        public double? GrossQuantity { get; set; }
        public string QuantityUnit { get; set; }
        public double? NetWeight { get; set; }
        public double? GrossWeight { get; set; }
        public string WeightUnit { get; set; }
        public double? SpecificGravity { get; set; }
        public double? APIGravity { get; set; }
        public string Description { get; set; }
        public string ExternalBatch { get; set; }
        public string TransportNumber { get; set; }
        public string MeterNumber { get; set; }
        public string TicketNumber { get; set; }
        public string TankNumber { get; set; }
        public string CountryOfOrigin { get; set; }
        public string Comment { get; set; }
        public string DriverNumber { get; set; }
        public string TransOrigin { get; set; }
		public Guid? DivertStateID { get; set; }
		public virtual Location DivertState { get; set; }
        public string DivertNumber { get; set; }
        public string LaneNumber { get; set; }
        public string TransactionBuildType { get; set; }
        public string TransactionSequenceNumber { get; set; }
        public bool? MpcOwnedRailCar { get; set; }
        public DateTime? EstablishedDateTime { get; set; }
        public string ExchangePartnerIndicator { get; set; }
        public string ControlCode { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? MovementDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public string LiftingNumber { get; set; }
        public string CompanyUseType { get; set; }
        public string Temperature { get; set; }
        public string Density { get; set; }
        public string RecipeCode { get; set; }
        public string YieldCommodity { get; set; }
        public string PONumber { get; set; }
        public string EstimateActual { get; set; }
        public DateTime? ReportDate { get; set; }
        public string ChangedBy { get; set; }
        public double? NetDisplayQuantity { get; set; }
        public double? GrossDisplayQuantity { get; set; }
		public virtual TerritoryManager TerritoryManager { get; set; }
		public Guid? TerritoryManagerID { get; set; }
		public string EndProductCode { get; set; }
        public string ComponentProductCode { get; set; }
		public string MovementFleetCode { get; set; }
        public string PLBatch { get; set; }
        public bool IsDeleted { get; set; }
        public Movement() { }
    }
}
