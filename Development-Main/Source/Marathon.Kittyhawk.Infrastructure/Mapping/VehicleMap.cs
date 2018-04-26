using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Vehicle entity mapping for Entity Framework.
    /// </summary>
    public class VehicleMap : EntityTypeConfiguration<Vehicle>
    {
        public VehicleMap()
        {
            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(200);

            this.Property(t => t.Type)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Vehicle");
            this.Property(t => t.VehicleKey).HasColumnName("VehicleKey").IsRequired();
            this.Property(t => t.Name).HasColumnName("Name").IsRequired();
            this.Property(t => t.Type).HasColumnName("Type").IsRequired();
            this.Property(t => t.MaxQuantity).HasColumnName("MaxQuantity").IsRequired();
            this.Property(t => t.YearBuilt).HasColumnName("YearBuilt").IsOptional();
            this.Property(t => t.Comments).HasColumnName("Comments").IsOptional();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();
        }
    }
}
