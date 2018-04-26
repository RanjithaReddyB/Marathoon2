using Marathon.Kittyhawk.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    public class CommodityMap : EntityTypeConfiguration<Commodity>
    {
        public CommodityMap()
        {
            // Table & Column Mappings
            this.ToTable("Commodity");

            this.Property(t => t.Name).HasMaxLength(100);
            this.Property(t => t.Status).HasMaxLength(1);

            this.Property(t => t.CommodityKey).HasColumnName("CommodityKey").IsRequired();
            this.Property(t => t.Name).HasColumnName("Name").IsRequired();
            this.Property(t => t.Status).HasColumnName("Status").IsRequired();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();
        }
    }
}
