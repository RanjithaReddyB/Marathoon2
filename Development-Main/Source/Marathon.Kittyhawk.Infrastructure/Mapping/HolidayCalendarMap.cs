using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    public class HolidayCalendarMap : EntityTypeConfiguration<HolidayCalendar>
    {
        public HolidayCalendarMap()
        {
            this.ToTable("HolidayCalendar");

            this.Property(t => t.Name).HasMaxLength(50);
            this.Property(t => t.Description).HasMaxLength(100);
            this.Property(t => t.Common).HasMaxLength(1);

            this.Property(t => t.HolidayCalendarKey).HasColumnName("HolidayCalendarKey").IsRequired();
            this.Property(t => t.Name).HasColumnName("Name").IsRequired();
            this.Property(t => t.Description).HasColumnName("Description").IsRequired();
            this.Property(t => t.Common).HasColumnName("Common").IsRequired();
            this.Property(t => t.HolidayCalendarKey1).HasColumnName("HolidayCalendarKey1").IsOptional();
            this.Property(t => t.HolidayCalendarKey2).HasColumnName("HolidayCalendarKey2").IsOptional();
            this.Property(t => t.StartDate).HasColumnName("StartDate").IsRequired();
            this.Property(t => t.EndDate).HasColumnName("EndDate").IsRequired();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();
        }
    }
}
