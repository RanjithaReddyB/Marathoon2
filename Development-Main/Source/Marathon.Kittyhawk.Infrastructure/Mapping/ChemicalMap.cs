using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Chemical entity mapping for Entity Framework.
    /// </summary>
    public class ChemicalMap : EntityTypeConfiguration<Chemical>
    {
        public ChemicalMap()
        {
            // Table & Column Mappings
            this.ToTable("Chemical");
            this.Property(t => t.ProductID).HasColumnName("ProductID").IsOptional();
            this.Property(t => t.ChildProductID).HasColumnName("ChildProductID").IsOptional();
            this.Property(t => t.ChemicalPercentage).HasColumnName("ChemicalPercentage").IsOptional();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();

            // Foreign Key Mappings
            this.HasOptional<Product>(t => t.Product).WithMany().HasForeignKey(f => f.ProductID);
            this.HasOptional<Product>(t => t.ChildProduct).WithMany().HasForeignKey(f => f.ChildProductID);
        }
    }
}
