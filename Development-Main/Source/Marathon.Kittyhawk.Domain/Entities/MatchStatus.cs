using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    public class MatchStatus : Entity
    {       
        public Guid? FacilityId { get; set; }
        public Guid? OriginId { get; set; }
        public Guid? DestinationId { get; set; }
        public string LocationType { get; set; }
        public string OriginLocationType { get; set; }
        public string DestinationLocationType { get; set; }
        public string MovementType { get; set; }
        public Guid? CarrierId { get; set; }
        public Guid? CustomerId { get; set; }
        public Guid? SupplierId { get; set; }        
        public Guid? IssuedById { get; set; }
        public Guid? ProductId { get; set; }
        public string Commodity { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int RowNumber { get; set; }
        public string User { get; set; }
        public virtual Location Facility { get; set; }
        public virtual Location Origin { get; set; }
        public virtual Location Destination { get; set; }
        public virtual BusinessAssociate Carrier { get; set; }
        public virtual BusinessAssociate Customer { get; set; }
        public virtual BusinessAssociate Supplier { get; set; }        
        public virtual BusinessAssociate IssuedBy { get; set; }
        public virtual Product Product { get; set; }        

        public MatchStatus() { }
    }
}
