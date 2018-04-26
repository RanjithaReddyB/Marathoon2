namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents a location.
    /// </summary>
    public class Location : Entity
    {
        public int LocationKey { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public string Type { get; set; }
        public string City { get; set; }
        public string StateOrProvince { get; set; }
        public string Country { get; set; }
        public string SAPProfitCenter4500 { get; set; }
        public string SAPProfitCenter4502 { get; set; }
        public string SAPProfitCenter4504 { get; set; }
        //public string LocationType { get; set; }
        public string StreetAddressAttribute { get; set; }
        public string CityAttribute { get; set; }
        public string FipsCityCode { get; set; }
        public string StateAttribute { get; set; }
        public string ZipAttribute { get; set; }
        public string FipsCountyCode { get; set; }
        //public string Latitude { get; set; }
        //public string Longitude { get; set; }
        public string CityLimitIndicator { get; set; }
        public string LocationUnitCode { get; set; }
        public string TASTermID { get; set; }
        public string TermCommType { get; set; }
        //public bool? Downloadable { get; set; }
        public string DestinationLocationID { get; set; }
        public string StationNumber { get; set; }
        public string AvailableForDownload { get; set; }
        public string TerminalSPLC { get; set; }
        public string TerminalOperatorID { get; set; }
        public string TerminalCompanyID { get; set; }
        public bool? MPCOwnership { get; set; }
        public string HourOffset { get; set; }
        public string TDSTerminalID { get; set; }
        public int? Fleet { get; set; }
        public string PhoneNo { get; set; }
        public string InterfaceCountryCode { get; set; }
        public bool? LocationTypeIsPhysical { get; set; }
        public string Status { get; set; }
        public string County { get; set; }
        public string CountyCode { get; set; }
        public string FipsCountryCode { get; set; }
        public string TCNNumber { get; set; }
        public string TerminalOperator { get; set; }
        public string LocationTypes { get; set; }
        public bool IsDeleted { get; set; }
        public Location() { }
    }
}
