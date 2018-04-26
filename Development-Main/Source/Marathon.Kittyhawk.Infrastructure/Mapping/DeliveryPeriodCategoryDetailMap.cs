using Marathon.Kittyhawk.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    public class DeliveryPeriodCategoryDetailMap : EntityTypeConfiguration<DeliveryPeriodCategoryDetail>
    {
        public DeliveryPeriodCategoryDetailMap()
        {
            this.ToTable("DeliveryPeriodCategoryDetail");

            this.Property(t => t.DeliveryPeriodCategoryDetailKey).HasColumnName("DeliveryPeriodCategoryDetailKey").IsRequired();
            this.Property(t => t.DeliveryPeriodCategoryId).HasColumnName("DeliveryPeriodCategoryId").IsRequired();
            this.Property(t => t.Name).HasColumnName("Name").IsRequired();
            this.Property(t => t.Abbreviation).HasColumnName("Abbreviation").IsRequired();
            this.Property(t => t.StartDate).HasColumnName("StartDate").IsOptional();
            this.Property(t => t.EndDate).HasColumnName("EndDate").IsOptional();
            this.Property(t => t.QuotePeriodStartDate).HasColumnName("QuotePeriodStartDate").IsRequired();
            this.Property(t => t.QuotePeriodEndDate).HasColumnName("QuotePeriodEndDate").IsRequired();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();

            // Foreign Key Mappings
            this.HasRequired<DeliveryPeriodCategory>(t => t.DeliveryPeriodCategory).WithMany(m => m.DeliveryPeriodCategoryDetails).HasForeignKey(f => f.DeliveryPeriodCategoryId);
        }
    }
}
