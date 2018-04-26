using Marathon.Kittyhawk.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    public class MatchStatusMap : EntityTypeConfiguration<MatchStatus>
    {
        public MatchStatusMap()
        {
            this.ToTable("MatchStatus");
            this.Property(t => t.User).HasColumnName("User").IsOptional();
            this.Property(t => t.FacilityId).HasColumnName("FacilityId").IsOptional();
            this.Property(t => t.OriginId).HasColumnName("OriginId").IsOptional();
            this.Property(t => t.DestinationId).HasColumnName("DestinationId").IsOptional();
            this.Property(t => t.LocationType).HasColumnName("LocationType").IsOptional();
            this.Property(t => t.OriginLocationType).HasColumnName("OriginLocationType").IsOptional();
            this.Property(t => t.DestinationLocationType).HasColumnName("DestinationLocationType").IsOptional();
            this.Property(t => t.CarrierId).HasColumnName("CarrierId").IsOptional();
            this.Property(t => t.CustomerId).HasColumnName("CustomerId").IsOptional();
            this.Property(t => t.SupplierId).HasColumnName("SupplierId").IsOptional();
            this.Property(t => t.IssuedById).HasColumnName("IssuedById").IsOptional();
            this.Property(t => t.ProductId).HasColumnName("ProductId").IsOptional();
            this.Property(t => t.MovementType).HasColumnName("MovementType").IsOptional();
            this.Property(t => t.Commodity).HasColumnName("Commodity").IsOptional();
            this.Property(t => t.Status).HasColumnName("MatchStatus").IsOptional();
            this.Property(t => t.Comments).HasColumnName("Comments").IsOptional();
            this.Property(t => t.UpdatedOn).HasColumnName("UpdatedOn").IsOptional();
            this.Property(t => t.RowNumber).HasColumnName("RowNumber").IsOptional();

            this.HasOptional<Location>(t => t.Facility).WithMany().HasForeignKey(f => f.FacilityId);
            this.HasOptional<Location>(t => t.Origin).WithMany().HasForeignKey(f => f.OriginId);
            this.HasOptional<Location>(t => t.Destination).WithMany().HasForeignKey(f => f.DestinationId);
            this.HasOptional<BusinessAssociate>(t => t.Carrier).WithMany().HasForeignKey(f => f.CarrierId);
            this.HasOptional<BusinessAssociate>(t => t.Customer).WithMany().HasForeignKey(f => f.CustomerId);
            this.HasOptional<BusinessAssociate>(t => t.Supplier).WithMany().HasForeignKey(f => f.SupplierId);
            this.HasOptional<BusinessAssociate>(t => t.IssuedBy).WithMany().HasForeignKey(f => f.IssuedById);
            this.HasOptional<Product>(t => t.Product).WithMany().HasForeignKey(f => f.ProductId);
        }
    }
}
