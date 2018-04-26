using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents an inventory tag group.
    /// </summary>
    public class InventoryTagGroup : Entity
    {
        public Guid DataSourceID { get; set; }
        public virtual DataSource DataSource { get; set; }
        public string Container { get; set; }
        public string CommodityCode { get; set; }
        public string FlowRate { get; set; }
        public string APIGravity { get; set; }
        public string TotalLevel { get; set; }
        public string BSWLevel { get; set; }
        public string Temperature { get; set; }
        public string GrossVolume { get; set; }
        public string NetVolume { get; set; }
        public string VolumeTotal { get; set; }
        public string Viscosity { get; set; }
        public string OOS { get; set; }

        public InventoryTagGroup() { }
    }
}
