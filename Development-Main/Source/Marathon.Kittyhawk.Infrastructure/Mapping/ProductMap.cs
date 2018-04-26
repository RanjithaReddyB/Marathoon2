using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Product entity mapping for Entity Framework.
    /// </summary>
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.Abbreviation)
                .HasMaxLength(50);

            this.Property(t => t.Commodity)
                .HasMaxLength(80);

            this.Property(t => t.SubGroup)
                .HasMaxLength(80);

            this.Property(t => t.SweetSour)
                .HasMaxLength(80);

            this.Property(t => t.SAPMaterialRaw)
                .HasMaxLength(50);

            this.Property(t => t.SAPMaterialRefined)
                .HasMaxLength(50);

            this.Property(t => t.RawCommodityCode)
				.HasMaxLength(255);

			this.Property(t => t.RefinedCommodityCode)
				.HasMaxLength(255);

			this.Property(t => t.DecimalPrecision)
                .IsMaxLength();

            this.Property(t => t.ProvisionUOM)
                .IsMaxLength();

            this.Property(t => t.Status)
                .IsMaxLength();

            this.Property(t => t.Type)
                .IsMaxLength();

            this.Property(t => t.SubType)
                .IsMaxLength();

            this.Property(t => t.UOMEnergyAbbreviation)
                .IsMaxLength();

            this.Property(t => t.ProductPerUOMEnergyAbbreviation)
                .IsMaxLength();

            this.Property(t => t.UOMAbbreviation)
                .IsMaxLength();

            this.Property(t => t.DensityPerUOMAbbreviation)
                .IsMaxLength();

            this.Property(t => t.CommodityID)
                .IsMaxLength();

            this.Property(t => t.CountryOfOrigin)
                .IsMaxLength();

            this.Property(t => t.TradingUOM)
                .IsMaxLength();


            // Table & Column Mappings
            this.ToTable("Product");
            this.Property(t => t.ProductKey).HasColumnName("ProductKey").IsRequired();
            this.Property(t => t.Name).HasColumnName("Name").IsRequired();
            this.Property(t => t.Abbreviation).HasColumnName("Abbreviation").IsRequired();
            this.Property(t => t.Gravity).HasColumnName("Gravity").IsRequired();
            this.Property(t => t.Energy).HasColumnName("Energy").IsRequired();
            this.Property(t => t.Density).HasColumnName("Density").IsRequired();
            this.Property(t => t.Commodity).HasColumnName("Commodity").IsRequired();
            this.Property(t => t.SubGroup).HasColumnName("SubGroup").IsOptional();
            this.Property(t => t.SweetSour).HasColumnName("SweetSour").IsOptional();
            this.Property(t => t.SAPMaterialRaw).HasColumnName("SAPMaterialRaw").IsOptional();
            this.Property(t => t.SAPMaterialRefined).HasColumnName("SAPMaterialRefined").IsOptional();
            this.Property(t => t.RawCommodityCode).HasColumnName("RawCommodityCode").IsOptional();
            this.Property(t => t.RefinedCommodityCode).HasColumnName("RefinedCommodityCode").IsOptional();
            this.Property(t => t.DecimalPrecision).HasColumnName("DecimalPrecision").IsOptional();
            this.Property(t => t.ProvisionUOM).HasColumnName("ProvisionUOM").IsOptional();
            this.Property(t => t.Status).HasColumnName("Status").IsOptional();
            this.Property(t => t.Type).HasColumnName("Type").IsOptional();
            this.Property(t => t.SubType).HasColumnName("SubType").IsOptional();
            this.Property(t => t.DisplayEnergy).HasColumnName("DisplayEnergy").IsOptional();
            this.Property(t => t.DisplayUOMEnergy).HasColumnName("DisplayUOMEnergy").IsOptional();
            this.Property(t => t.UOMEnergyAbbreviation).HasColumnName("UOMEnergyAbbreviation").IsOptional();
            this.Property(t => t.DisplayPerUOMEnergy).HasColumnName("DisplayPerUOMEnergy").IsOptional();
            this.Property(t => t.ProductPerUOMEnergyAbbreviation).HasColumnName("ProductPerUOMEnergyAbbreviation").IsOptional();
            this.Property(t => t.DensityUOM).HasColumnName("DensityUOM").IsOptional();
            this.Property(t => t.UOMAbbreviation).HasColumnName("UOMAbbreviation").IsOptional();
            this.Property(t => t.DensityPerUOM).HasColumnName("DensityPerUOM").IsOptional();
            this.Property(t => t.DensityPerUOMAbbreviation).HasColumnName("DensityPerUOMAbbreviation").IsOptional();
            this.Property(t => t.CommodityID).HasColumnName("CommodityID").IsOptional();
            this.Property(t => t.CountryOfOrigin).HasColumnName("CountryOfOrigin").IsOptional();
            this.Property(t => t.TradingUOM).HasColumnName("TradingUOM").IsOptional();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();
        }
    }
}
