using System;
using System.Linq;

namespace Marathon.Kittyhawk.Domain.Entities
{
    public abstract class SalesForecastEntity : Entity, ICloneable
    {
        public string ProcessIdentifier { get; set; }
        public Guid DataSourceID { get; set; }
        public bool IsDirty { get; set; }
        public bool IsPublished { get; set; }
        public bool IgnoreErrors { get; set; }
        public bool IsNew { get; set; }
        public string ErrorStatus { get; set; }        
        public string LocationCompanyCode { get; set; }    
        public Guid? LocationID { get; set; }
        public Guid? CompanyID { get; set; }
        public Guid? ProductID { get; set; }
        public Guid? LocationOwnerID { get; set; }
        public string LocationCode { get; set; }
        public string CompanyCode {get;set;}        
        public string ProductCode {get;set;}
        public virtual Location Location { get; set; }
        public virtual BusinessAssociate Company { get; set; }
        public virtual Product Product { get; set; }
        public virtual BusinessAssociate LocationOwner { get; set; }
        public string  ModeOfTransport { get; set; }
        public string TropicCom {get;set;}
        public string CommodityGroup {get;set;}
        public string EndProductCom {get;set;}
        public string ForecastOrg { get; set; }
        public string ForecastClass { get; set; }
        public string ForecastDistrict { get; set; }
        public DateTime Date { get; set; }
        public string BusinessMonth {get;set;}
        public int MonthTotalVolume {get;set;}
        public int Day { get; set; }
        public int DayVolume { get; set; }
        public string SourceRecord { get; set; }
        
       
        public SalesForecastEntity()
        {
        }
        /// <summary>
        /// Implements the ICloneable interface.
        /// </summary>
        /// <returns>Shallow copy of the object</returns>
        public virtual object Clone()
        {
            SalesForecast clone = this.MemberwiseClone() as SalesForecast;
            return clone;
        }
    }
}
