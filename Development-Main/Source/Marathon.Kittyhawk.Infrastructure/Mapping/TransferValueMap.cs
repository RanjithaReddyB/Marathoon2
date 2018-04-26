using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Transfer value entity mapping for Entity Framework.
    /// </summary>
    public class TransferValueMap : EntityTypeConfiguration<TransferValue>
    {
        public TransferValueMap()
        {
            // Table & Column Mappings
            this.ToTable("TransferValue");
            this.Property(t => t.PlannedTransferValueKey).HasColumnName("PlannedTransferValueKey").IsRequired();
            this.Property(t => t.PlannedTransferKey).HasColumnName("PlannedTransferKey").IsRequired();
            this.Property(t => t.TransferID).HasColumnName("TransferID").IsOptional();
            this.Property(t => t.ValueStatus).HasColumnName("ValueStatus").IsOptional();
            this.Property(t => t.ValueType).HasColumnName("ValueType").IsOptional();
            this.Property(t => t.TransactionType).HasColumnName("TransactionType").IsOptional();
            this.Property(t => t.Provision).HasColumnName("Provision").IsOptional();
            this.Property(t => t.PerUnitValue).HasColumnName("PerUnitValue").IsOptional();
            this.Property(t => t.PricedPerUnitValue).HasColumnName("PricedPerUnitValue").IsOptional();
            this.Property(t => t.FloatingPerUnitValue).HasColumnName("FloatingPerUnitValue").IsOptional();
            this.Property(t => t.TotalValue).HasColumnName("TotalValue").IsOptional();
            this.Property(t => t.PricedPercent).HasColumnName("PricedPercent").IsOptional();
            this.Property(t => t.SettlementCurrency).HasColumnName("SettlementCurrency").IsOptional();
            this.Property(t => t.ValueCreatedDate).HasColumnName("ValueCreatedDate").IsOptional();
            this.Property(t => t.ValueChangedDate).HasColumnName("ValueChangedDate").IsOptional();
            this.Property(t => t.LastValueDate).HasColumnName("LastValueDate").IsOptional();
            this.Property(t => t.ReferenceDate).HasColumnName("ReferenceDate").IsOptional();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();

            // Foreign Key Mappings
            this.HasOptional<Transfer>(t => t.Transfer).WithMany().HasForeignKey(f => f.TransferID);
        }
    }
}
