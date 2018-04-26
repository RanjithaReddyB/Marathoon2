using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Error entity mapping for Entity Framework.
    /// </summary>
    public class ErrorMap : EntityTypeConfiguration<Error>
    {
        public ErrorMap()
        {
            // Properties
            this.Property(t => t.User)
                .HasMaxLength(100);

            this.Property(t => t.EventType)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Error");
            this.Property(t => t.User).HasColumnName("UserName").IsRequired();
            this.Property(t => t.EventType).HasColumnName("EventType").IsRequired();
            this.Property(t => t.EventDetail).HasColumnName("EventDetail").IsOptional();
            this.Property(t => t.Description).HasColumnName("Description").IsOptional();
            this.Property(t => t.StackTrace).HasColumnName("StackTrace").IsOptional();
        }
    }
}
