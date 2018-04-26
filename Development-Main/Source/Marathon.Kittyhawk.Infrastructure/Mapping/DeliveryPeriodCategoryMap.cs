using Marathon.Kittyhawk.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    public class DeliveryPeriodCategoryMap : EntityTypeConfiguration<DeliveryPeriodCategory>
    {
        public DeliveryPeriodCategoryMap()
        {
            this.ToTable("DeliveryPeriodCategory");

            this.Property(t => t.QuotePeriodRule).HasMaxLength(100);

            this.Property(t => t.DeliveryPeriodCategoryKey).HasColumnName("DeliveryPeriodCategoryKey").IsRequired();
            this.Property(t => t.Name).HasColumnName("Name").IsRequired();
            this.Property(t => t.QuotePeriodRule).HasColumnName("QuotePeriodRule").IsOptional();
            this.Property(t => t.HolidayCalendarID).HasColumnName("HolidayCalendarID").IsOptional();
            this.Property(t => t.RelativePeriod).HasColumnName("RelativePeriod").IsRequired();
            this.Property(t => t.GapsExistInPeriods).HasColumnName("GapsExistInPeriods").IsRequired();
            this.Property(t => t.IsBalanceOfMonth).HasColumnName("IsBalanceOfMonth").IsRequired();
            this.Property(t => t.HasNonMonthlyPeriods).HasColumnName("HasNonMonthlyPeriods").IsRequired();
            this.Property(t => t.RevisionDate).HasColumnName("RevisionDate").IsRequired();
            this.Property(t => t.RevisionUser).HasColumnName("RevisionUser").IsRequired();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();

            // Foreign Key Mappings
            this.HasOptional<HolidayCalendar>(t => t.HolidayCalendar).WithMany().HasForeignKey(f => f.HolidayCalendarID);
        }
    }
}
