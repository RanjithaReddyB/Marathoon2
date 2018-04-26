using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Month-end inventory entity mapping for Entity Framework.
    /// </summary>
    public class MonthEndInventoryMap : EntityTypeConfiguration<MonthEndInventory>
    {
        public MonthEndInventoryMap()
        {
            // Table & Column Mappings
            this.ToTable("MonthEndInventory");
            this.Property(t => t.InventorySubledgerKey).HasColumnName("InventorySubledgerKey").IsRequired();
            this.Property(t => t.CompanyID).HasColumnName("CompanyID").IsOptional();
            this.Property(t => t.ProductID).HasColumnName("ProductID").IsOptional();
            this.Property(t => t.LocationID).HasColumnName("LocationID").IsOptional();
            this.Property(t => t.DealID).HasColumnName("DealID").IsOptional();
            this.Property(t => t.InventoryDate).HasColumnName("InventoryDate").IsOptional();
            this.Property(t => t.Month).HasColumnName("Month").IsOptional();
            this.Property(t => t.Year).HasColumnName("Year").IsOptional();
            this.Property(t => t.AccountingPeriod).HasColumnName("AccountingPeriod").IsOptional();
            this.Property(t => t.AccountingPeriodStartDate).HasColumnName("AccountingPeriodStartDate").IsOptional();
            this.Property(t => t.AccountingPeriodEndDate).HasColumnName("AccountingPeriodEndDate").IsOptional();
            this.Property(t => t.RawQuantity).HasColumnName("RawQuantity").IsOptional();
            this.Property(t => t.RawGrossQuantity).HasColumnName("RawGrossQuantity").IsOptional();
            this.Property(t => t.RefinedQuantity).HasColumnName("RefinedQuantity").IsOptional();
            this.Property(t => t.RefinedGrossQuantity).HasColumnName("RefinedGrossQuantity").IsOptional();
            this.Property(t => t.TransferQuantity).HasColumnName("TransferQuantity").IsOptional();
            this.Property(t => t.TransferGrossQuantity).HasColumnName("TransferGrossQuantity").IsOptional();
            this.Property(t => t.TotalQuantity).HasColumnName("TotalQuantity").IsOptional();
            this.Property(t => t.TotalVolume).HasColumnName("TotalVolume").IsOptional();
            this.Property(t => t.UnitOfMeasure).HasColumnName("UnitOfMeasure").IsOptional();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();

            // Foreign Key Mappings
            this.HasOptional<BusinessAssociate>(t => t.Company).WithMany().HasForeignKey(f => f.CompanyID);
            this.HasOptional<Product>(t => t.Product).WithMany().HasForeignKey(f => f.ProductID);
            this.HasOptional<Location>(t => t.Location).WithMany().HasForeignKey(f => f.LocationID);
            this.HasOptional<Deal>(t => t.Deal).WithMany().HasForeignKey(f => f.DealID);
        }
    }
}
