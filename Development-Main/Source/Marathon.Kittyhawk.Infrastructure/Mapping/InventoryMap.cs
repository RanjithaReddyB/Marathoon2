using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Inventory entity mapping for Entity Framework.
    /// </summary>
    public class InventoryMap : EntityTypeConfiguration<Inventory>
    {
        public InventoryMap()
        {
            // Properties
            this.Property(t => t.ProcessIdentifier)
                .HasMaxLength(100);

            this.Property(t => t.FacilityCode)
                .HasMaxLength(100);

            this.Property(t => t.ContainerCode)
                .HasMaxLength(100);

            this.Property(t => t.ProductCode)
                .HasMaxLength(100);

            this.Property(t => t.CompanyCode)
                .HasMaxLength(100);

            this.Property(t => t.GrossQuantityUnit)
                .HasMaxLength(100);

            this.Property(t => t.NetQuantityUnit)
                .HasMaxLength(100);

            this.Property(t => t.RemainingFillUnit)
                .HasMaxLength(100);

            this.Property(t => t.AvailableQuantityUnit)
                .HasMaxLength(100);

            this.Property(t => t.FlowUnit)
                .HasMaxLength(100);

            this.Property(t => t.FlowTimeSpanUnit)
                .HasMaxLength(100);

            this.Property(t => t.SourceID)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Inventory");
            this.Property(t => t.ProcessIdentifier).HasColumnName("ProcessIdentifier").IsRequired();
            this.Property(t => t.DataSourceID).HasColumnName("DataSourceID").IsRequired();
            this.Property(t => t.IsDirty).HasColumnName("IsDirty").IsRequired();
            this.Property(t => t.IsPublished).HasColumnName("IsPublished").IsRequired();
            this.Property(t => t.IgnoreErrors).HasColumnName("IgnoreErrors").IsRequired();
            this.Property(t => t.ErrorStatus).HasColumnName("ErrorStatus").IsRequired();
            this.Property(t => t.FacilityID).HasColumnName("FacilityID").IsOptional();
            this.Property(t => t.ContainerID).HasColumnName("ContainerID").IsOptional();
            this.Property(t => t.ProductID).HasColumnName("ProductID").IsOptional();
            this.Property(t => t.CompanyID).HasColumnName("CompanyID").IsOptional();
            this.Property(t => t.FacilityCode).HasColumnName("FacilityCode").IsOptional();
            this.Property(t => t.ContainerCode).HasColumnName("ContainerCode").IsOptional();
            this.Property(t => t.ProductCode).HasColumnName("ProductCode").IsOptional();
            this.Property(t => t.CompanyCode).HasColumnName("CompanyCode").IsOptional();
            this.Property(t => t.MeasurementDateTime).HasColumnName("MeasurementDateTime").IsOptional();
            this.Property(t => t.GrossQuantity).HasColumnName("GrossQuantity").IsOptional();
            this.Property(t => t.GrossQuantityUnit).HasColumnName("GrossQuantityUnit").IsOptional();
            this.Property(t => t.NetQuantity).HasColumnName("NetQuantity").IsOptional();
            this.Property(t => t.NetQuantityUnit).HasColumnName("NetQuantityUnit").IsOptional();
            this.Property(t => t.Temperature).HasColumnName("Temperature").IsOptional();
            this.Property(t => t.Gravity).HasColumnName("Gravity").IsOptional();
            this.Property(t => t.Level).HasColumnName("InventoryLevel").IsOptional();
            this.Property(t => t.RemainingFill).HasColumnName("RemainingFill").IsOptional();
            this.Property(t => t.RemainingFillUnit).HasColumnName("RemainingFillUnit").IsOptional();
            this.Property(t => t.AvailableQuantity).HasColumnName("AvailableQuantity").IsOptional();
            this.Property(t => t.AvailableQuantityUnit).HasColumnName("AvailableQuantityUnit").IsOptional();
            this.Property(t => t.Flow).HasColumnName("Flow").IsOptional();
            this.Property(t => t.FlowUnit).HasColumnName("FlowUnit").IsOptional();
            this.Property(t => t.FlowTimeSpan).HasColumnName("FlowTimeSpan").IsOptional();
            this.Property(t => t.FlowTimeSpanUnit).HasColumnName("FlowTimeSpanUnit").IsOptional();
            this.Property(t => t.RVP).HasColumnName("RVP").IsOptional();
            this.Property(t => t.Ethanol).HasColumnName("Ethanol").IsOptional();
            this.Property(t => t.Viscosity).HasColumnName("Viscosity").IsOptional();
            this.Property(t => t.IsThirdParty).HasColumnName("IsThirdParty").IsOptional();
            this.Property(t => t.SourceID).HasColumnName("SourceID").IsOptional();
            this.Property(t => t.SourceDate).HasColumnName("SourceDate").IsOptional();
            this.Property(t => t.SourceRecord).HasColumnName("SourceRecord").HasColumnType("xml").IsOptional();
            this.Property(t => t.OOSIndicator).HasColumnName("OOSIndicator").IsOptional();

            // Foreign Key Mappings
            this.HasRequired<DataSource>(t => t.DataSource).WithMany().HasForeignKey(f => f.DataSourceID);
            this.HasOptional<Location>(t => t.Facility).WithMany().HasForeignKey(f => f.FacilityID);
            this.HasOptional<Container>(t => t.Container).WithMany().HasForeignKey(f => f.ContainerID);
            this.HasOptional<Product>(t => t.Product).WithMany().HasForeignKey(f => f.ProductID);
            this.HasOptional<BusinessAssociate>(t => t.Company).WithMany().HasForeignKey(f => f.CompanyID);
        }
    }
}
