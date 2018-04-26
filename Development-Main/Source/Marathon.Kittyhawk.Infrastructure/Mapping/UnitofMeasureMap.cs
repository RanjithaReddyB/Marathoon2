using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
	/// <summary>
	/// Unit of measure entity mapping for Entity Framework.
	/// </summary>
	public class UnitofMeasureMap : EntityTypeConfiguration<UnitofMeasure>
    {
        public UnitofMeasureMap()
        {
            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(80);

            this.Property(t => t.Abbreviation)
                .HasMaxLength(20);

            this.Property(t => t.Type)
                .HasMaxLength(10);

            this.Property(t => t.Status)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("UnitofMeasure");
            this.Property(t => t.UOMKey).HasColumnName("UOMKey").IsRequired();
            this.Property(t => t.Name).HasColumnName("Name").IsOptional();
            this.Property(t => t.Abbreviation).HasColumnName("Abbreviation").IsOptional();
            this.Property(t => t.Type).HasColumnName("Type").IsOptional();
            this.Property(t => t.Status).HasColumnName("Status").IsOptional();
            this.Property(t => t.Vehicle).HasColumnName("Vehicle").IsOptional();
            this.Property(t => t.TerminalUOM).HasColumnName("TerminalUOM").IsOptional();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();
        }
    }                   
}