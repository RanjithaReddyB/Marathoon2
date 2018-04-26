using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that provides the template for an inventory measurement.
    /// Cannot be instantiated directly and must be inherited.
    /// </summary>
    public abstract class InventoryEntity : Entity, ICloneable
    {
        public string ProcessIdentifier { get; set; }
        public Guid DataSourceID { get; set; }
        public virtual DataSource DataSource { get; set; }
        public bool IsDirty { get; set; }
        public bool IsPublished { get; set; }
        public bool IgnoreErrors { get; set; }
        public string ErrorStatus { get; set; }
        public Guid? FacilityID { get; set; }
        public Guid? ContainerID { get; set; }
        public Guid? ProductID { get; set; }
        public Guid? CompanyID { get; set; }
        public virtual Location Facility { get; set; }
        public virtual Container Container { get; set; }
        public virtual Product Product { get; set; }
        public virtual BusinessAssociate Company { get; set; }
        public string FacilityCode { get; set; }
        public string ContainerCode { get; set; }
        public string ProductCode { get; set; }
        public string CompanyCode { get; set; }
        public DateTime? MeasurementDateTime { get; set; }
        public double? GrossQuantity { get; set; }
        public string GrossQuantityUnit { get; set; }
        public double? NetQuantity { get; set; }
        public string NetQuantityUnit { get; set; }
        public double? Temperature { get; set; }
        public double? Gravity { get; set; }
        public double? Level { get; set; }
        public double? RemainingFill { get; set; }
        public string RemainingFillUnit { get; set; }
        public double? AvailableQuantity { get; set; }
        public string AvailableQuantityUnit { get; set; }
        public double? Flow { get; set; }
        public string FlowUnit { get; set; }
        public double? FlowTimeSpan { get; set; }
        public string FlowTimeSpanUnit { get; set; }
        public double? RVP { get; set; }
        public double? Ethanol { get; set; }
        public double? Viscosity { get; set; }
        public bool? IsThirdParty { get; set; }
        public string SourceID { get; set; }
        public DateTime? SourceDate { get; set; }
        public string SourceRecord { get; set; }
        public bool? OOSIndicator { get; set; }

        public InventoryEntity() { }

        /// <summary>
        /// Implements the ICloneable interface.
        /// </summary>
        /// <returns>Shallow copy of the object</returns>
        public virtual object Clone()
        {
            Inventory clone = this.MemberwiseClone() as Inventory;
            return clone;
        }
    }
}
