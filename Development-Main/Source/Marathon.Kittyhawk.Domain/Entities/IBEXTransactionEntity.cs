namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that provides the template for an IBEX transaction.
    /// Cannot be instantiated directly and must be inherited.
    /// </summary>
    public abstract class IBEXTransactionEntity : Entity
    {
        public string ProcessIdentifier { get; set; }
        public bool IsPublished { get; set; }
        public string DataType { get; set; }
        public string CntryCode { get; set; }
        public string CoAbrv { get; set; }
        public string Com { get; set; }
        public string Company { get; set; }
        public string ControlCode { get; set; }
        public string CrudeCode { get; set; }
        public string CustNo { get; set; }
        public string ExchContractNo { get; set; }
        public double Gravity { get; set; }
        public double GrossQty { get; set; }
        public double GrossQtyGal { get; set; }
        public string InvoiceNo { get; set; }
        public double LbsGalConv { get; set; }
        public string MarathonOrderNo { get; set; }
        public double NetQty { get; set; }
        public double NetQtyGal { get; set; }
        public string PlBatch { get; set; }
        public string RecipeCode { get; set; }
        public string RecNo { get; set; }
        public string ReferenceCommodity { get; set; }
        public string RefineryBusMo { get; set; }
        public string RefLoc { get; set; }
        public string RptDate { get; set; }
        public string RptLoc { get; set; }
        public string RRCarTruck { get; set; }
        public string SCAC { get; set; }
        public string ShipDate { get; set; }
        public string TicketNo { get; set; }
        public string TransOrigin { get; set; }
        public string TransportMode { get; set; }
        public string TransportRqst { get; set; }
        public string UMEA { get; set; }
        public string DestState { get; set; }
        public string ExchCustNo { get; set; }
        public string FreightTerms { get; set; }
        public string TypeLossGain { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
        public string ExstarsTicketNo { get; set; }
        public string TankNo { get; set; }
        public string TermMeterNo { get; set; }
        public string TypeCoUse { get; set; }
        public string ShipRcpt { get; set; }
        public string IsSales { get; set; }
        public string IsTransportation { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string DealNo { get; set; }
        public string DealType { get; set; }
        public string Carrier { get; set; }
        public string Product { get; set; }
        public string MovementDocNo { get; set; }
        public string MovementTransNo { get; set; }
        public string MovementDocType { get; set; }
        public string SubType { get; set; }
        public string CommodityCode { get; set; }
        public string CreatedByUser { get; set; }

        public IBEXTransactionEntity() { }
    }
}
