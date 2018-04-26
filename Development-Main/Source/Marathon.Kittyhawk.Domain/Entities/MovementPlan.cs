using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents a movement plan entry.
    /// </summary>
    public class MovementPlan : Entity
    {
        public int RoutePlanHeaderKey { get; set; }
        public Guid? OriginProductID { get; set; }
        public Guid? DestinationProductID { get; set; }
        public Guid? OriginLocationID { get; set; }
        public Guid? DestinationLocationID { get; set; }
        public Guid? Leg1CarrierID { get; set; }
        public Guid? Leg2CarrierID { get; set; }
        public Guid? Leg3CarrierID { get; set; }
        public Guid? Leg4CarrierID { get; set; }
        public Guid? Leg5CarrierID { get; set; }
        public Guid? Leg1OriginDealID { get; set; }
        public Guid? Leg1DestinationDealID { get; set; }
        public Guid? Leg2OriginDealID { get; set; }
        public Guid? Leg2DestinationDealID { get; set; }
        public Guid? Leg3OriginDealID { get; set; }
        public Guid? Leg3DestinationDealID { get; set; }
        public Guid? Leg4OriginDealID { get; set; }
        public Guid? Leg4DestinationDealID { get; set; }
        public Guid? Leg5OriginDealID { get; set; }
        public Guid? Leg5DestinationDealID { get; set; }
        public virtual Product OriginProduct { get; set; }
        public virtual Product DestinationProduct { get; set; }
        public virtual Location OriginLocation { get; set; }
        public virtual Location DestinationLocation { get; set; }
        public virtual BusinessAssociate Leg1Carrier { get; set; }
        public virtual BusinessAssociate Leg2Carrier { get; set; }
        public virtual BusinessAssociate Leg3Carrier { get; set; }
        public virtual BusinessAssociate Leg4Carrier { get; set; }
        public virtual BusinessAssociate Leg5Carrier { get; set; }
        public virtual Deal Leg1OriginDeal { get; set; }
        public virtual Deal Leg1DestinationDeal { get; set; }
        public virtual Deal Leg2OriginDeal { get; set; }
        public virtual Deal Leg2DestinationDeal { get; set; }
        public virtual Deal Leg3OriginDeal { get; set; }
        public virtual Deal Leg3DestinationDeal { get; set; }
        public virtual Deal Leg4OriginDeal { get; set; }
        public virtual Deal Leg4DestinationDeal { get; set; }
        public virtual Deal Leg5OriginDeal { get; set; }
        public virtual Deal Leg5DestinationDeal { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public int? NumberOfLegs { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Leg1TransportType { get; set; }
        public string Leg2TransportType { get; set; }
        public string Leg3TransportType { get; set; }
        public string Leg4TransportType { get; set; }
        public string Leg5TransportType { get; set; }
        public string Comment { get; set; }
        public bool IsDeleted { get; set; }

        public MovementPlan() { }
    }
}
