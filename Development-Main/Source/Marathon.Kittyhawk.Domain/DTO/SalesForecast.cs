using System;

using System.Linq;


namespace Marathon.Kittyhawk.Domain.DTO
{
    /// <summary>
    /// SalesForecast DTO class representing the forecast summary object  used for sending the forecast data to SAP PI service
    /// </summary>
    public class SalesForecast
    {
        public string LocationAbbreviation { get; set; }
        public string CompanyAbbreviation { get; set; }
        public string ProductAbbreviation { get; set; }
        public string LocationOwnerBusinessAssociateAbbreviation { get; set; }
        public string FcstClass { get; set;}
        public string BusinessMonth { get; set; }
        public int MonthTotalVolume { get; set; }
        public int Day { get; set; }
        public int DayVolume { get; set; }
    }
}
