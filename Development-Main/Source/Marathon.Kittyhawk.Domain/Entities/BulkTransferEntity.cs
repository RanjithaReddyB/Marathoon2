using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
	/// <summary>
	/// Entity class that provides the template for a bulk transfer.
	/// Cannot be instantiated directly and must be inherited.
	/// </summary>
	public abstract class BulkTransferEntity : Entity, ICloneable
	{
		public string ProcessIdentifier { get; set; }
		public Guid DataSourceID { get; set; }
		public virtual DataSource DataSource { get; set; }
		public bool IsDirty { get; set; }
		public bool IsPublished { get; set; }
		public bool IgnoreErrors { get; set; }
		public string ErrorStatus { get; set; }
		public string ActionCode { get; set; }
		public string ActivityIndicator { get; set; }
		public string LoadOrUnload { get; set; }
		public string BatchIdentifier { get; set; }
		public string TicketNumber { get; set; }
		public string ShortTicketNumber { get; set; }
		public Guid? FacilityID { get; set; }
		public Guid? OriginID { get; set; }
		public Guid? DestinationID { get; set; }
		public Guid? OriginContainerID { get; set; }
        public Guid? DestinationContainerID { get; set; }
        public Guid? ProductID { get; set; }
		public Guid? CustomerID { get; set; }
		public Guid? SupplierID { get; set; }
		public Guid? ShipperID { get; set; }
		public Guid? CarrierID { get; set; }
		public Guid? TransportID { get; set; }
		public Guid? VehicleID { get; set; }
		public virtual Location Facility { get; set; }
		public virtual Location Origin { get; set; }
		public virtual Location Destination { get; set; }
		public virtual Container OriginContainer { get; set; }
        public virtual Container DestinationContainer { get; set; }
        public virtual Product Product { get; set; }
		public virtual BusinessAssociate Customer { get; set; }
		public virtual BusinessAssociate Supplier { get; set; }
		public virtual BusinessAssociate Shipper { get; set; }
		public virtual BusinessAssociate Carrier { get; set; }
		public virtual Transport Transport { get; set; }
		public virtual Vehicle Vehicle { get; set; }
		public string OriginFacilityCode { get; set; }
		public string OriginContainerCode { get; set; }
		public string OriginProductCode { get; set; }
		public string DestinationFacilityCode { get; set; }
		public string DestinationContainerCode { get; set; }
		public string DestinationProductCode { get; set; }
		public string CustomerCode { get; set; }
		public string SupplierCode { get; set; }
		public string ShipperCode { get; set; }
		public string CarrierCode { get; set; }
		public string TransportCode { get; set; }
		public string VehicleCode { get; set; }
		public string CountryCode { get; set; }
		public string TransportType { get; set; }
		public DateTime? TransferStart { get; set; }
		public DateTime? TransferEnd { get; set; }
		public DateTime? ETA { get; set; }
		public string ProgressLandmark { get; set; }
		public DateTime? ProgressLandmarkTimestamp { get; set; }
		public double? ScheduledQuantity { get; set; }
		public string ScheduledQuantityUnit { get; set; }
		public double? GrossQuantity { get; set; }
		public string GrossQuantityUnit { get; set; }
		public double? NetQuantity { get; set; }
		public string NetQuantityUnit { get; set; }
		public double? Gravity { get; set; }
		public double? Temperature { get; set; }
		public double? RVP { get; set; }
		public string TransferType { get; set; }
		public string ContractNumber { get; set; }
		public string CarStatus { get; set; }
		public bool? IsThirdParty { get; set; }
		public bool? IsFreeRunner { get; set; }
		public bool? IsSupplierShipment { get; set; }
		public string Comments { get; set; }
		public string SourceID { get; set; }
		public DateTime? SourceDate { get; set; }
		public string SourceRecord { get; set; }
        //added for RailTrac
        public string YieldCommodityCode { get; set; }
        public string AutoMatchStatus { get; set; }

        public bool? IsConstructivePlacement { get; set; }
       
        //For Rail Track Interface
        public string LiftingNumber { get; set; }
        public string PONumber { get; set; }

        public double? Density { get; set; }
                
        public bool? IsRAPublish { get; set; }
        public int? DeliveryDealDetail { get; set; }
        public string DeliveryDealNumber { get; set; }
        public int? ReceiptDealDetail { get; set; }
        public string ReceiptDealNumber { get; set; }

        public BulkTransferEntity() { }       

        /// <summary>
        /// Implements the ICloneable interface.
        /// </summary>
        /// <returns>Shallow copy of the object</returns>
        public virtual object Clone()
		{
			BulkTransfer clone = this.MemberwiseClone() as BulkTransfer;
			return clone;
		}
	}
}
