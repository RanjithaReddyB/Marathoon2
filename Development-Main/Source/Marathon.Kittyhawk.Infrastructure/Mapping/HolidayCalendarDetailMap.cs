using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    public class HolidayCalendarDetailMap : EntityTypeConfiguration<HolidayCalendarDetail>
    {
        public HolidayCalendarDetailMap()
        {
            this.ToTable("HolidayCalendarDetail");

            this.Property(t => t.Name).HasMaxLength(100);
            this.Property(t => t.Code).HasMaxLength(25);

            this.Property(t => t.HolidayCalendarDetailKey).HasColumnName("HolidayCalendarDetailKey").IsRequired();
            this.Property(t => t.Name).HasColumnName("Name").IsOptional();
            this.Property(t => t.HolidayCalendarDetailDate).HasColumnName("HolidayCalendarDetailDate").IsRequired();
            this.Property(t => t.HolidayCalendarId).HasColumnName("HolidayCalendarId").IsOptional();
            this.Property(t => t.Code).HasColumnName("Code").IsOptional();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();

            this.HasOptional<HolidayCalendar>(t => t.HolidayCalendar).WithMany(m => m.HolidayCalendarDetails).HasForeignKey(f => f.HolidayCalendarId);
        }
    }
}
