using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Refinery inventory error entity mapping for Entity Framework.
    /// </summary>
    public class RefineryInventoryErrorMap : EntityTypeConfiguration<RefineryInventoryError>
    {
        public RefineryInventoryErrorMap()
        {
            // Properties
            this.Property(t => t.ProcessIdentifier)
                .HasMaxLength(100);

            this.Property(t => t.Refinery)
                .HasMaxLength(100);

            this.Property(t => t.Tank)
                .HasMaxLength(100);

            this.Property(t => t.Message)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("RefineryInventoryError");
            this.Property(t => t.ProcessIdentifier).HasColumnName("ProcessIdentifier").IsRequired();
            this.Property(t => t.Refinery).HasColumnName("Refinery").IsRequired();
            this.Property(t => t.Tank).HasColumnName("Tank").IsRequired();
            this.Property(t => t.Message).HasColumnName("Message").IsRequired();
        }
    }
}
