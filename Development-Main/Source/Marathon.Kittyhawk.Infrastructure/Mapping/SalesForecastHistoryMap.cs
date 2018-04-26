using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;


namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    public class SalesForecastHistoryMap : EntityTypeConfiguration<SalesForecastHistory>
    {
        public SalesForecastHistoryMap()
        {
            this.Property(t => t.ProcessIdentifier)
               .HasMaxLength(100);

            this.Property(t => t.LocationCode).HasMaxLength(10);
            this.Property(t => t.CompanyCode).HasMaxLength(10);
            this.Property(t => t.ProductCode).HasMaxLength(10);
            this.Property(t => t.TropicCom).HasMaxLength(10);
            this.Property(t => t.CommodityGroup).HasMaxLength(10);
            this.Property(t => t.EndProductCom).HasMaxLength(10);
            this.Property(t => t.ForecastOrg).HasMaxLength(10);
            this.Property(t => t.ForecastClass).HasMaxLength(10);
            this.Property(t => t.ForecastDistrict).HasMaxLength(10);
            this.Property(t => t.BusinessMonth).HasMaxLength(10);
            this.Property(t => t.ModeOfTransport).HasMaxLength(100);
            this.ToTable("SalesForecastHistory");
            this.Ignore(t => t.LocationCompanyCode);
            this.Property(t => t.IsNew).HasColumnName("IsNew").IsRequired();
            this.Property(t => t.ProcessIdentifier).HasColumnName("ProcessIdentifier").IsRequired();
            this.Property(t => t.DataSourceID).HasColumnName("DataSourceID").IsRequired();
            this.Property(t => t.IsDirty).HasColumnName("IsDirty").IsRequired();
            this.Property(t => t.IsPublished).HasColumnName("IsPublished").IsRequired();
            this.Property(t => t.IgnoreErrors).HasColumnName("IgnoreErrors").IsRequired();
            this.Property(t => t.ErrorStatus).HasColumnName("ErrorStatus").IsRequired();
            this.Property(t => t.LocationCode).HasColumnName("LocationCode").IsOptional();
            this.Property(t => t.LocationID).HasColumnName("LocationID").IsOptional();
            this.Property(t => t.CompanyCode).HasColumnName("CompanyCode").IsOptional();
            this.Property(t => t.CompanyID).HasColumnName("CompanyID").IsOptional();
            this.Property(t => t.ProductCode).HasColumnName("ProductCode").IsOptional();
            this.Property(t => t.ProductID).HasColumnName("ProductID").IsOptional();
            this.Property(t => t.LocationOwnerID).HasColumnName("LocationOwnerID").IsOptional();
            this.Property(t => t.ModeOfTransport).HasColumnName("ModeOfTransport").IsOptional(); 
            this.Property(t => t.TropicCom).HasColumnName("TropicCom").IsOptional();
            this.Property(t => t.CommodityGroup).HasColumnName("CommodityGroup").IsOptional();
            this.Property(t => t.EndProductCom).HasColumnName("EndProductCom").IsOptional();
            this.Property(t => t.ForecastOrg).HasColumnName("ForecastOrg").IsOptional();
            this.Property(t => t.ForecastClass).HasColumnName("ForecastClass").IsOptional();
            this.Property(t => t.ForecastDistrict).HasColumnName("ForecastDistrict").IsOptional();
            this.Property(t => t.Date).HasColumnName("Date").IsOptional();
            this.Property(t => t.BusinessMonth).HasColumnName("BusinessMonth").IsOptional();
            this.Property(t => t.MonthTotalVolume).HasColumnName("MonthTotalVolume").IsOptional();
            this.Property(t => t.Day).HasColumnName("Day").IsOptional();
            this.Property(t => t.DayVolume).HasColumnName("DayVolume").IsOptional();
            this.Property(t => t.SourceRecord).HasColumnName("SourceRecord").HasColumnType("xml").IsOptional();
             
            this.HasOptional<Product>(t => t.Product).WithMany().HasForeignKey(f => f.ProductID);
            this.HasOptional<BusinessAssociate>(t => t.Company).WithMany().HasForeignKey(f => f.CompanyID);
            this.HasOptional<BusinessAssociate>(t => t.LocationOwner).WithMany().HasForeignKey(f => f.LocationOwnerID);
            this.HasOptional<Location>(t => t.Location).WithMany().HasForeignKey(f => f.LocationID);
        }
    }
}
