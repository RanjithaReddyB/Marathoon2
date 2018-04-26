using System;
using System.Collections.Generic;

namespace Marathon.Kittyhawk.Domain.Entities
{
    public class TransactionUploadEntity : Entity, ICloneable 
    {
        // KH System Properties
        public DateTime? CreateDate { get; set; }
        public string CreatedByUser { get; set; }
        public string UpdatedByUser { get; set; }
        public DateTime? SentToPIDate { get; set; }
        public Guid DataSourceID { get; set; }
        public virtual DataSource DataSource { get; set; }
        public string ProcessIdentifier { get; set; }
        public bool IsDirty { get; set; }
        public string ErrorStatus { get; set; }
        public bool IsPublished { get; set; }
        public bool IgnoreErrors { get; set; }
        public string ActionCode { get; set; }

        // BOL Properties
        public string IssuedByCode { get; set; }
        public Guid? IssuedByID { get; set; }
        public virtual BusinessAssociate IssuedBy { get; set; }
        public int ControlCode { get; set; }
        public string TransOrigin { get; set; }
        public string OriginalTicketNumber { get; set; }
        public string TicketNumber { get; set; }
        public string ShortTicketNumber { get; set; }
        public string BatchIdentifier { get; set; }
        public string TransactionType { get; set; }
        public string TransferType { get; set; }
        public string LiftingNumber { get; set; }
        public Guid? FacilityID { get; set; }
        public Guid? OriginID { get; set; }
        public Guid? DestinationID { get; set; }
        public Guid? FleetID { get; set; }
        public Guid? ProductID { get; set; }
        public Guid? ComponentProductID { get; set; }
        public Guid? EndProductID { get; set; }
        public Guid? CustomerID { get; set; }
        public Guid? SupplierID { get; set; }
        public Guid? CarrierID { get; set; }
        public virtual Location Facility { get; set; }
        public virtual Location Origin { get; set; }
        public virtual Location Destination { get; set; }
        public virtual Location Fleet { get; set; }
        public virtual Product Product { get; set; }
        public virtual Product ComponentProduct { get; set; }
        public virtual Product EndProduct { get; set; }
        public virtual BusinessAssociate Customer { get; set; }
        public virtual BusinessAssociate Supplier { get; set; }
        public virtual BusinessAssociate Carrier { get; set; }
        public string FacilityCode { get; set; }
        public string OriginFacilityCode { get; set; }
        public string OriginContainerCode { get; set; }
        public string DestinationFacilityCode { get; set; }
        public string DestinationContainerCode { get; set; }
        public string FleetCode { get; set; }
        public string ProductCode { get; set; }
        public string ComponentProductCode { get; set; }
        public string EndProductCode { get; set; }
        public string RecipeCode { get; set; }
        public string CustomerCode { get; set; }
        public string SupplierCode { get; set; }
        public string CarrierCode { get; set; }
        public string TransportCode { get; set; }
        public string CustomerNumber { get; set; }
        public string CountryCode { get; set; }
        public string TransportMode { get; set; }
        public DateTime? TransferStart { get; set; }
        public DateTime? TransferEnd { get; set; }
        public DateTime? ShipDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ReportDate { get; set; }
        public decimal? GrossQuantity { get; set; }
        public string GrossQuantityUnit { get; set; }
        public decimal? NetQuantity { get; set; }
        public string NetQuantityUnit { get; set; }
        public double? Gravity { get; set; }
        public decimal? Temperature { get; set; }
        public decimal? Density { get; set; }
        public string ContractNumber { get; set; }
        public string PONumber { get; set; }
        public int? DriverNumber { get; set; }
        public string MeterNumber { get; set; }
        public int? LaneNumber { get; set; }
        public string MpcRailcar { get; set; }
        public string Comments { get; set; }
        public string UploadSequenceNumber { get; set; }
        public string TransactionBuildType { get; set; }
        public DateTime? UploadEstablishedDate { get; set; }
        public int? DeliveryDealDetail { get; set; }
        public string DeliveryDealNumber { get; set; }
        public int? ReceiptDealDetail { get; set; }
        public string ReceiptDealNumber { get; set; }
        public string SourceRecord { get; set; }
        public string Dest { get; set; }
        public string RefLoc { get; set; }
        public string RptLoc { get; set; }
        public DateTime? MeasurementDateTime { get; set; }        
        public Guid? GroupId { get; set; }
        public string MatchStatus { get; set; }
        public string UploadEstablishedUser { get; set; }
        public string CrossReferenceErrorStatus { get; set; }
        public string AllocationManagerErrorStatus { get; set; }        
        public string Usage { get; set; }
        public string CommodityType { get; set; }
        public string Taboot { get; set; }

        public TransactionUploadEntity()
        {

        }

        /// <summary>
        /// Implements the ICloneable interface.
        /// </summary>
        /// <returns>Shallow copy of the object</returns>
        public virtual object Clone()
        {
            TransactionUpload clone = this.MemberwiseClone() as TransactionUpload;
            return clone;
        }
    }
}
