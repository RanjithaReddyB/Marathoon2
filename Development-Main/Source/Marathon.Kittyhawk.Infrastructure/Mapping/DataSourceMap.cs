using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Data source entity mapping for Entity Framework.
    /// </summary>
    public class DataSourceMap : EntityTypeConfiguration<DataSource>
    {
        public DataSourceMap()
        {
            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(100);

            this.Property(t => t.System)
                .HasMaxLength(100);

            this.Property(t => t.DataType)
                .HasMaxLength(100);

            this.Property(t => t.ConnectionType)
                .HasMaxLength(100);

            this.Property(t => t.Schedule)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("DataSource");
            this.Property(t => t.Name).HasColumnName("Name").IsRequired();
            this.Property(t => t.System).HasColumnName("System").IsRequired();
            this.Property(t => t.Description).HasColumnName("Description").IsRequired();
            this.Property(t => t.DataType).HasColumnName("DataType").IsRequired();
            this.Property(t => t.ConnectionType).HasColumnName("ConnectionType").IsRequired();
            this.Property(t => t.ConnectionDetail).HasColumnName("ConnectionDetail").IsRequired();
            this.Property(t => t.Schedule).HasColumnName("Schedule").IsRequired();
        }
    }
}
