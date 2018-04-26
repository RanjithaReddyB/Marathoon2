using Marathon.Kittyhawk.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    public class AllocationManagerFilterMap : EntityTypeConfiguration<AllocationManagerFilter>
    {
        public AllocationManagerFilterMap()
        {
            this.ToTable("AllocationManagerFilter");
            this.Property(t => t.User).HasColumnName("User").IsOptional();
            this.Property(t => t.FacilityId).HasColumnName("FacilityId").IsOptional();
            this.Property(t => t.ProductId).HasColumnName("ProductId").IsOptional();
            this.Property(t => t.Commodity).HasColumnName("Commodity").IsOptional();
            this.Property(t => t.UpdatedOn).HasColumnName("UpdatedOn").IsOptional();
            
            this.HasOptional<Location>(t => t.Facility).WithMany().HasForeignKey(f => f.FacilityId);
            this.HasOptional<Product>(t => t.Product).WithMany().HasForeignKey(f => f.ProductId);
        }
    }
}
