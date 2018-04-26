using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Position group entity mapping for Entity Framework.
    /// </summary>
    public class PositionGroupMap : EntityTypeConfiguration<PositionGroup>
    {
        public PositionGroupMap()
        {
            // Table & Column Mappings
            this.ToTable("PositionGroup");
            this.Property(t => t.PositionGroupKey).HasColumnName("PositionGroupKey").IsRequired();
            this.Property(t => t.ProductID).HasColumnName("ProductID").IsOptional();
            this.Property(t => t.LocationID).HasColumnName("LocationID").IsOptional();
            this.Property(t => t.Depth).HasColumnName("Depth").IsOptional();
            this.Property(t => t.TopLevelID).HasColumnName("TopLevelID").IsOptional();
            this.Property(t => t.BottomLevelID).HasColumnName("BottomLevelID").IsOptional();
            this.Property(t => t.Level1ID).HasColumnName("Level1ID").IsOptional();
            this.Property(t => t.Level2ID).HasColumnName("Level2ID").IsOptional();
            this.Property(t => t.Level3ID).HasColumnName("Level3ID").IsOptional();
            this.Property(t => t.Level4ID).HasColumnName("Level4ID").IsOptional();
            this.Property(t => t.Level5ID).HasColumnName("Level5ID").IsOptional();
            this.Property(t => t.TopLevelName).HasColumnName("TopLevelName").IsOptional();
            this.Property(t => t.BottomLevelName).HasColumnName("BottomLevelName").IsOptional();
            this.Property(t => t.Level1Name).HasColumnName("Level1Name").IsOptional();
            this.Property(t => t.Level2Name).HasColumnName("Level2Name").IsOptional();
            this.Property(t => t.Level3Name).HasColumnName("Level3Name").IsOptional();
            this.Property(t => t.Level4Name).HasColumnName("Level4Name").IsOptional();
            this.Property(t => t.Level5Name).HasColumnName("Level5Name").IsOptional();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();

            // Foreign Key Mappings
            this.HasOptional<Product>(t => t.Product).WithMany().HasForeignKey(f => f.ProductID);
            this.HasOptional<Location>(t => t.Location).WithMany().HasForeignKey(f => f.LocationID);
        }
    }
}
