using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Movement transaction value entity mapping for Entity Framework.
    /// </summary>
    public class MovementTransactionValueMap : EntityTypeConfiguration<MovementTransactionValue>
    {
        public MovementTransactionValueMap()
        {
            // Table & Column Mappings
            this.ToTable("MovementTransactionValue");
            this.Property(t => t.TransactionDetailKey).HasColumnName("TransactionDetailKey").IsRequired();
            this.Property(t => t.TransactionHeaderKey).HasColumnName("TransactionHeaderKey").IsRequired();
            this.Property(t => t.MovementTransactionID).HasColumnName("MovementTransactionID").IsOptional();
            this.Property(t => t.DealID).HasColumnName("DealID").IsOptional();
            this.Property(t => t.ValueStatus).HasColumnName("ValueStatus").IsOptional();
            this.Property(t => t.ValueType).HasColumnName("ValueType").IsOptional();
            this.Property(t => t.Actual).HasColumnName("Actual").IsOptional();
            this.Property(t => t.TransactionType).HasColumnName("TransactionType").IsOptional();
            this.Property(t => t.Provision).HasColumnName("Provision").IsOptional();
            this.Property(t => t.Strategy).HasColumnName("Strategy").IsOptional();
            this.Property(t => t.DetailQuantity).HasColumnName("DetailQuantity").IsOptional();
            this.Property(t => t.PerUnitValue).HasColumnName("PerUnitValue").IsOptional();
            this.Property(t => t.PricedInValue).HasColumnName("PricedInValue").IsOptional();
            this.Property(t => t.FloatingValue).HasColumnName("FloatingValue").IsOptional();
            this.Property(t => t.TotalValue).HasColumnName("TotalValue").IsOptional();
            this.Property(t => t.Currency).HasColumnName("Currency").IsOptional();
            this.Property(t => t.PricedPercent).HasColumnName("PricedPercent").IsOptional();
            this.Property(t => t.ValueCreatedDate).HasColumnName("ValueCreatedDate").IsOptional();
            this.Property(t => t.ValuationDate).HasColumnName("ValuationDate").IsOptional();
            this.Property(t => t.RevisionDate).HasColumnName("RevisionDate").IsOptional();
            this.Property(t => t.ReferenceDate).HasColumnName("ReferenceDate").IsOptional();
            this.Property(t => t.RevisionLevel).HasColumnName("RevisionLevel").IsOptional();
            this.Property(t => t.QuantityBasis).HasColumnName("QuantityBasis").IsOptional();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();

            // Foreign Key Mappings
            this.HasOptional<MovementTransaction>(t => t.MovementTransaction).WithMany().HasForeignKey(f => f.MovementTransactionID);
            this.HasOptional<Deal>(t => t.Deal).WithMany().HasForeignKey(f => f.DealID);
        }
    }
}
