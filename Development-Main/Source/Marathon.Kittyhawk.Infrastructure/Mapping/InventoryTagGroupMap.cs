using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Inventory tag group entity mapping for Entity Framework.
    /// </summary>
    public class InventoryTagGroupMap : EntityTypeConfiguration<InventoryTagGroup>
    {
        public InventoryTagGroupMap()
        {
            // Properties
            this.Property(t => t.Container)
                .HasMaxLength(20);

            this.Property(t => t.CommodityCode)
                .HasMaxLength(20);

            this.Property(t => t.FlowRate)
                .HasMaxLength(20);

            this.Property(t => t.APIGravity)
                .HasMaxLength(20);

            this.Property(t => t.TotalLevel)
                .HasMaxLength(20);

            this.Property(t => t.BSWLevel)
                .HasMaxLength(20);

            this.Property(t => t.Temperature)
                .HasMaxLength(20);

            this.Property(t => t.GrossVolume)
                .HasMaxLength(20);

            this.Property(t => t.NetVolume)
                .HasMaxLength(20);

            this.Property(t => t.VolumeTotal)
                .HasMaxLength(20);

			this.Property(t => t.Viscosity)
                .HasMaxLength(20);

            this.Property(t => t.OOS)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("InventoryTagGroup");
            this.Property(t => t.DataSourceID).HasColumnName("DataSourceID").IsRequired();
            this.Property(t => t.Container).HasColumnName("Container").IsRequired();
            this.Property(t => t.CommodityCode).HasColumnName("CommodityCode").IsRequired();
            this.Property(t => t.FlowRate).HasColumnName("FlowRate").IsOptional();
            this.Property(t => t.APIGravity).HasColumnName("APIGravity").IsOptional();
            this.Property(t => t.TotalLevel).HasColumnName("TotalLevel").IsOptional();
            this.Property(t => t.BSWLevel).HasColumnName("BSWLevel").IsOptional();
            this.Property(t => t.Temperature).HasColumnName("Temperature").IsOptional();
            this.Property(t => t.GrossVolume).HasColumnName("GrossVolume").IsOptional();
            this.Property(t => t.NetVolume).HasColumnName("NetVolume").IsOptional();
            this.Property(t => t.VolumeTotal).HasColumnName("VolumeTotal").IsOptional();
            this.Property(t => t.Viscosity).HasColumnName("Viscosity").IsOptional();
            this.Property(t => t.OOS).HasColumnName("OOS").IsOptional();

            // Foreign Key Mappings
            this.HasRequired<DataSource>(t => t.DataSource).WithMany().HasForeignKey(f => f.DataSourceID);
        }
    }
}
