using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Container entity mapping for Entity Framework.
    /// </summary>
    public class ContainerMap : EntityTypeConfiguration<Container>
    {
        public ContainerMap()
        {
            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(100);

            this.Property(t => t.Status)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("Container");
            this.Property(t => t.ContainerKey).HasColumnName("ContainerKey").IsRequired();
            this.Property(t => t.Name).HasColumnName("Name").IsRequired();
            this.Property(t => t.LocationID).HasColumnName("LocationID").IsRequired();
            this.Property(t => t.Status).HasColumnName("Status").IsRequired();
            this.Property(t => t.Capacity).HasColumnName("Capacity").IsOptional();
            this.Property(t => t.CapacityUOMID).HasColumnName("CapacityUOMID").IsOptional();
            this.Property(t => t.Bottom).HasColumnName("Bottom").IsOptional();
            this.Property(t => t.BottomUOMID).HasColumnName("BottomUOMID").IsOptional();
            this.Property(t => t.Target).HasColumnName("Target").IsOptional();
            this.Property(t => t.IsOutOfService).HasColumnName("IsOutOfService").IsRequired();
            this.Property(t => t.TargetUOMID).HasColumnName("TargetUOMID").IsOptional();
            this.Property(t => t.IsRackTank).HasColumnName("IsRackTank").IsRequired();
            this.Property(t => t.IsPhysical).HasColumnName("IsPhysical").IsRequired();
            this.Property(t => t.IsManifold).HasColumnName("IsManifold").IsRequired();
            this.Property(t => t.IsGaugeManual).HasColumnName("IsGaugeManual").IsRequired();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();

            // Foreign Key Mappings
            this.HasRequired<Location>(t => t.Location).WithMany().HasForeignKey(f => f.LocationID);
            this.HasOptional<UnitofMeasure>(t => t.CapacityUOM).WithMany().HasForeignKey(f => f.CapacityUOMID);
            this.HasOptional<UnitofMeasure>(t => t.BottomUOM).WithMany().HasForeignKey(f => f.BottomUOMID);
            this.HasOptional<UnitofMeasure>(t => t.TargetUOM).WithMany().HasForeignKey(f => f.TargetUOMID);
        }
    }
}
