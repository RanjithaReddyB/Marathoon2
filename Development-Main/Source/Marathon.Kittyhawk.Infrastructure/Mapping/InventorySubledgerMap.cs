using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Inventory subledger entity mapping for Entity Framework.
    /// </summary>
    public class InventorySubledgerMap : EntityTypeConfiguration<InventorySubledger>
    {
        public InventorySubledgerMap()
        {
            // Table & Column Mappings
            this.ToTable("InventorySubledger");
            this.Property(t => t.InventorySubledgerKey).HasColumnName("InventorySubledgerKey").IsRequired();
            this.Property(t => t.ProductID).HasColumnName("ProductID").IsOptional();
            this.Property(t => t.DealID).HasColumnName("DealID").IsOptional();
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate").IsOptional();
            this.Property(t => t.AccountingPeriod).HasColumnName("AccountingPeriod").IsOptional();
            this.Property(t => t.Strategy).HasColumnName("Strategy").IsOptional();
            this.Property(t => t.PerUnitLocked).HasColumnName("PerUnitLocked").IsOptional();
            this.Property(t => t.Quantity).HasColumnName("Quantity").IsOptional();
            this.Property(t => t.QuantityUnit).HasColumnName("QuantityUnit").IsOptional();
            this.Property(t => t.Weight).HasColumnName("Weight").IsOptional();
            this.Property(t => t.WeightUnit).HasColumnName("WeightUnit").IsOptional();
            this.Property(t => t.Value).HasColumnName("Value").IsOptional();
            this.Property(t => t.PerUnitValue).HasColumnName("PerUnitValue").IsOptional();
            this.Property(t => t.Currency).HasColumnName("Currency").IsOptional();
            this.Property(t => t.Comment).HasColumnName("Comment").IsOptional();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();

            // Foreign Key Mappings
            this.HasOptional<Product>(t => t.Product).WithMany().HasForeignKey(f => f.ProductID);
            this.HasOptional<Deal>(t => t.Deal).WithMany().HasForeignKey(f => f.DealID);
        }
    }
}
