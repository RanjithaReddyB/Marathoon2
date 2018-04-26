using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Transport entity mapping for Entity Framework.
    /// </summary>
    public class TransportMap : EntityTypeConfiguration<Transport>
    {
        public TransportMap()
        {
            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(100);

            this.Property(t => t.TransportType)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Transport");
            this.Property(t => t.Name).HasColumnName("Name").IsRequired();
            this.Property(t => t.TransportType).HasColumnName("TransportType").IsRequired();
        }
    }
}
