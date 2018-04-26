using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents a movement transaction entry.
    /// </summary>
    public class MovementTransaction : Entity
    {
        public int TransactionHeaderKey { get; set; }
        public int? PlannedTransferKey { get; set; }
        public int? MovementHeaderKey { get; set; }
        public Guid? ProductID { get; set; }
        public Guid? ChildProductID { get; set; }
        public Guid? LocationID { get; set; }
        public Guid? DestinationID { get; set; }
        public Guid? PlannedOriginID { get; set; }
        public Guid? PlannedDestinationID { get; set; }
        public Guid? TransferID { get; set; }
        public Guid? MovementID { get; set; }
        public virtual Product Product { get; set; }
        public virtual Product ChildProduct { get; set; }
        public virtual Location Location { get; set; }
        public virtual Location Destination { get; set; }
        public virtual Location PlannedOrigin { get; set; }
        public virtual Location PlannedDestination { get; set; }
        public virtual Transfer Transfer { get; set; }
        public virtual Movement Movement { get; set; }
        public string Status { get; set; }
        public string SupplyDemand { get; set; }
		public string ReportingCommodityCode { get; set; }
        public DateTime? MovementDate { get; set; }
        public DateTime? TransactionDate { get; set; }
        public double? NetQuantity { get; set; }
        public double? GrossQuantity { get; set; }
        public string QuantityUnit { get; set; }
        public double? NetWeight { get; set; }
        public string WeightUnit { get; set; }
        public double? SpecificGravity { get; set; }
        public double? APIGravity { get; set; }
        public string MovementType { get; set; }
		public bool IsInventory { get; set; }
        public string Comment { get; set; }
        public Guid? OriginalMovementOriginID { get; set; }
        public Guid? OriginalMovementMovementFleetID { get; set; }
        public Guid? OriginalMovementCarrierID { get; set; }
        public Guid? OriginalMovementEndProductID { get; set; }
        public Guid? OriginalMovementComponentProductID { get; set; }
        public virtual Location OriginalMovementOrigin { get; set; }
        public virtual BusinessAssociate OriginalMovementCarrier { get; set; }
        public virtual Product OriginalMovementEndProduct { get; set; }
        public virtual Product OriginalMovementComponentProduct { get; set; }
        public virtual Location OriginalMovementMovementFleet { get; set; }
        public string OriginalMovementLiftingNumber { get; set; }
        public string OriginalMovementPONumber { get; set; }
        public string OriginalMovementDensity { get; set; }
        public string OriginalMovementDriverNumber { get; set; }
        public string OriginalMovementYieldCommodity { get; set; }
        public string OriginalMovementTankNumber { get; set; }
        public string OriginalMovementRecipeCode { get; set; }
        public bool? OriginalMovementMpcOwnedRailCar { get; set; }
        public string OriginalMovementTransportNumber { get; set; }
        public string OriginalMovementExternalBatch { get; set; }
        public string OriginalMovementPLBatch { get; set; }
        public double? NetDisplayQuantity { get; set; }
        public double? GrossDisplayQuantity { get; set; }
        public bool IsDeleted { get; set; }
        public MovementTransaction() { }
    }
}
