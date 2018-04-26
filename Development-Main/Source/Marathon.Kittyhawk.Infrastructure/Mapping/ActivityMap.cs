using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Activity entity mapping for Entity Framework.
    /// </summary>
    public class ActivityMap : EntityTypeConfiguration<Activity>
    {
        public ActivityMap()
        {
            // Properties
            this.Property(t => t.ActivityType)
                .HasMaxLength(100);

            this.Property(t => t.DurationUnit)
                .HasMaxLength(100);

            this.Property(t => t.Marker)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Activity");
            this.Property(t => t.DataSourceID).HasColumnName("DataSourceID").IsRequired();
            this.Property(t => t.ActivityType).HasColumnName("ActivityType").IsRequired();
            this.Property(t => t.StartDate).HasColumnName("StartDate").IsRequired();
            this.Property(t => t.EndDate).HasColumnName("EndDate").IsOptional();
            this.Property(t => t.Duration).HasColumnName("Duration").IsOptional();
            this.Property(t => t.DurationUnit).HasColumnName("DurationUnit").IsOptional();
            this.Property(t => t.RecordsProcessed).HasColumnName("RecordsProcessed").IsOptional();
            this.Property(t => t.DirtyRecords).HasColumnName("DirtyRecords").IsOptional();
            this.Property(t => t.Marker).HasColumnName("Marker").IsOptional();

            // Foreign Key Mappings
            this.HasRequired<DataSource>(t => t.DataSource).WithMany().HasForeignKey(f => f.DataSourceID);
        }
    }
}
