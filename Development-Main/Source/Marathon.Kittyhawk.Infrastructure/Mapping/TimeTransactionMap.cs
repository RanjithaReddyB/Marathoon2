using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Time transaction entity mapping for Entity Framework.
    /// </summary>
    public class TimeTransactionMap : EntityTypeConfiguration<TimeTransaction>
    {
        public TimeTransactionMap()
        {
            // Table & Column Mappings
            this.ToTable("TimeTransaction");
            this.Property(t => t.TimeTransactionKey).HasColumnName("TimeTransactionKey").IsRequired();
            this.Property(t => t.TimeTransactionLogKey).HasColumnName("TimeTransactionLogKey").IsOptional();
            this.Property(t => t.DealID).HasColumnName("DealID").IsOptional();
            this.Property(t => t.Date).HasColumnName("Date").IsOptional();
            this.Property(t => t.Quantity).HasColumnName("Quantity").IsOptional();
            this.Property(t => t.QuantityUnit).HasColumnName("QuantityUnit").IsOptional();
            this.Property(t => t.ValueStatus).HasColumnName("ValueStatus").IsOptional();
            this.Property(t => t.ValueType).HasColumnName("ValueType").IsOptional();
            this.Property(t => t.TransactionType).HasColumnName("TransactionType").IsOptional();
            this.Property(t => t.Provision).HasColumnName("Provision").IsOptional();
            this.Property(t => t.Strategy).HasColumnName("Strategy").IsOptional();
            this.Property(t => t.PerUnitValue).HasColumnName("PerUnitValue").IsOptional();
            this.Property(t => t.PricedValue).HasColumnName("PricedValue").IsOptional();
            this.Property(t => t.FloatingValue).HasColumnName("FloatingValue").IsOptional();
            this.Property(t => t.TotalValue).HasColumnName("TotalValue").IsOptional();
            this.Property(t => t.Currency).HasColumnName("Currency").IsOptional();
            this.Property(t => t.PricedPercent).HasColumnName("PricedPercent").IsOptional();
            this.Property(t => t.ValuationDate).HasColumnName("ValuationDate").IsOptional();
            this.Property(t => t.RevisionDate).HasColumnName("RevisionDate").IsOptional();
            this.Property(t => t.ApplicationDate).HasColumnName("ApplicationDate").IsOptional();
            this.Property(t => t.RevisionLevel).HasColumnName("RevisionLevel").IsOptional();
            this.Property(t => t.Comment).HasColumnName("Comment").IsOptional();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();

            // Foreign Key Mappings
            this.HasOptional<Deal>(t => t.Deal).WithMany().HasForeignKey(f => f.DealID);
        }
    }
}
