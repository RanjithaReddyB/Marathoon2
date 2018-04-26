using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Log entity mapping for Entity Framework.
    /// </summary>
    public class LogMap : EntityTypeConfiguration<Log>
    {
        public LogMap()
        {
            // Properties
            this.Property(t => t.User)
                .HasMaxLength(100);

            this.Property(t => t.EventType)
                .HasMaxLength(100);

            this.Property(t => t.EventDetail)
                .HasMaxLength(100);

            this.Property(t => t.MetricDescription)
                .HasMaxLength(100);

            this.Property(t => t.MetricUnit)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Log");
            this.Property(t => t.User).HasColumnName("UserName").IsRequired();
            this.Property(t => t.EventType).HasColumnName("EventType").IsRequired();
            this.Property(t => t.EventDetail).HasColumnName("EventDetail").IsOptional();
            this.Property(t => t.Description).HasColumnName("Description").IsOptional();
            this.Property(t => t.Metric).HasColumnName("Metric").IsOptional();
            this.Property(t => t.MetricDescription).HasColumnName("MetricDescription").IsOptional();
            this.Property(t => t.MetricUnit).HasColumnName("MetricUnit").IsOptional();
        }
    }
}
