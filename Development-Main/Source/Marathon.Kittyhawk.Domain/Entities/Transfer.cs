using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents a transfer entry.
    /// </summary>
    public class Transfer : Entity
    {
        public int PlannedTransferKey { get; set; }
        public int? PlannedMovementKey { get; set; }
        public Guid? CarrierID { get; set; }
        public Guid? ConsigneeID { get; set; }
        public Guid? ProductID { get; set; }
        public Guid? LocationID { get; set; }
        public Guid? OriginID { get; set; }
        public Guid? DestinationID { get; set; }
        public Guid? DealID { get; set; }
        public Guid? OrderID { get; set; }
        public virtual BusinessAssociate Carrier { get; set; }
        public virtual BusinessAssociate Consignee { get; set; }
        public virtual Product Product { get; set; }
        public virtual Location Location { get; set; }
        public virtual Location Origin { get; set; }
        public virtual Location Destination { get; set; }
        public virtual Deal Deal { get; set; }
        public virtual Order Order { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? ChangedDate { get; set; }
        public DateTime? EstimatedStartDate { get; set; }
        public DateTime? EstimatedEndDate { get; set; }
        public string SchedulingPeriod { get; set; }
        public string Status { get; set; }
        public string CustomStatus { get; set; }
        public string SupplyDemand { get; set; }
        public string TransportMethod { get; set; }
        public int? SequenceNumber { get; set; }
        public double? TotalQuantity { get; set; }
        public double? ActualQuantity { get; set; }
        public double? RemainingQuantity { get; set; }
        public string QuantityUnit { get; set; }
        public double? TotalWeight { get; set; }
        public double? ActualWeight { get; set; }
        public string WeightUnit { get; set; }
        public double? Price { get; set; }
        public string Strategy { get; set; }
        public string Currency { get; set; }
        public string IsObligationTransfer { get; set; }
        public string NetNominate { get; set; }
        public string InternallyVerified { get; set; }
        public string ExternallyVerified { get; set; }
        public string ExcludeFromNomination { get; set; }
        public string Comment { get; set; }
        public string ForecastType { get; set; }
        public bool IsDeleted { get; set; }

        public Transfer() { }
    }
}
