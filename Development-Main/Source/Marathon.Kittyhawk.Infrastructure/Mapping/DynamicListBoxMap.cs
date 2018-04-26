
using Marathon.Kittyhawk.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// DynamicLIstBox Mapping for EF
    /// </summary>
    public class DynamicListBoxMap : EntityTypeConfiguration<DynamicListBox>
    {
        public DynamicListBoxMap()
        {
            this.Property(t => t.Qualifier).HasMaxLength(20);
            this.Property(t => t.Type).HasMaxLength(40);
            this.Property(t => t.Description).HasMaxLength(80);
            this.Property(t => t.Abbreviation).HasMaxLength(40);
            this.Property(t => t.TableType).HasMaxLength(1);
            this.Property(t => t.Status).HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("DynamicListBox");
            this.Property(t => t.DynamicListBoxKey).HasColumnName("DynamicListBoxKey").IsRequired();
            this.Property(t => t.Qualifier).HasColumnName("Qualifier").IsRequired();
            this.Property(t => t.Type).HasColumnName("Type").IsOptional();
            this.Property(t => t.Description).HasColumnName("Description").IsRequired();
            this.Property(t => t.Abbreviation).HasColumnName("Abbreviation").IsOptional();
            this.Property(t => t.Order).HasColumnName("Order").IsRequired();
            this.Property(t => t.TableType).HasColumnName("TableType").IsRequired();
            this.Property(t => t.Status).HasColumnName("Status").IsRequired();
        }
    }
}
