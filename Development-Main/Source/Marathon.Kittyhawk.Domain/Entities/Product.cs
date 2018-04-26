namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents a product.
    /// </summary>
    public class Product : Entity
    {
        public int ProductKey { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public double Gravity { get; set; }
        public double Energy { get; set; }
        public double Density { get; set; }
        public string Commodity { get; set; }
        public string SubGroup { get; set; }
        public string SweetSour { get; set; }
        public string SAPMaterialRaw { get; set; }
        public string SAPMaterialRefined { get; set; }
		public string RawCommodityCode { get; set; }
		public string RefinedCommodityCode { get; set; }
        public string DecimalPrecision { get; set; }
        public string ProvisionUOM { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public double? DisplayEnergy { get; set; }
        public double? DisplayUOMEnergy { get; set; }
        public string UOMEnergyAbbreviation { get; set; }
        public double? DisplayPerUOMEnergy { get; set; }
        public string ProductPerUOMEnergyAbbreviation { get; set; }
        public double? DensityUOM { get; set; }
        public string UOMAbbreviation { get; set; }
        public double? DensityPerUOM { get; set; }
        public string DensityPerUOMAbbreviation { get; set; }
        public string CommodityID { get; set; }
        public string CountryOfOrigin { get; set; }
        public string TradingUOM { get; set; }
        public bool IsDeleted { get; set; }

        public Product() { }
    }
}
