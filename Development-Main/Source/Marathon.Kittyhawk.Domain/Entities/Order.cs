using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents a order entry.
    /// </summary>
    public class Order : Entity
    {
        public int PlannedMovementKey { get; set; }
        public Guid? ProductID { get; set; }
        public Guid? OriginID { get; set; }
        public Guid? DestinationID { get; set; }
        public Guid? FinalDestinationID { get; set; }
        public Guid? VehicleID { get; set; }
        public Guid? MovementPlanID { get; set; }
        public virtual Product Product { get; set; }
        public virtual Location Origin { get; set; }
        public virtual Location Destination { get; set; }
        public virtual Location FinalDestination { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual MovementPlan MovementPlan { get; set; }
        public string OrderNumber { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string Status { get; set; }
        public string RollType { get; set; }
        public double? Quantity { get; set; }
        public string QuantityUnit { get; set; }
        public string BatchName { get; set; }
        public string PlannedTransport { get; set; }
        public string Scheduler { get; set; }
        public string Comment { get; set; }
        public bool IsDeleted { get; set; }

        public Order() { }
    }
}
