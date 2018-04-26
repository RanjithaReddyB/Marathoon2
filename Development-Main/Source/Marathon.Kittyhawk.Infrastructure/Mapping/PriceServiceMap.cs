using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    public class PriceServiceMap : EntityTypeConfiguration<PriceService>
    {
        public PriceServiceMap()
        {
            this.Property(t => t.Name).HasMaxLength(80);
            this.Property(t => t.Abbreviation).HasMaxLength(50);
            this.Property(t => t.Description).HasMaxLength(100);
            this.Property(t => t.Code).HasMaxLength(5);
            this.Property(t => t.Status).HasMaxLength(1);
            this.Property(t => t.Type).HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("PriceService");
            this.Property(t => t.PriceServiceKey).HasColumnName("PriceServiceKey").IsRequired();
            this.Property(t => t.Name).HasColumnName("Name").IsRequired();
            this.Property(t => t.Abbreviation).HasColumnName("Abbreviation").IsRequired();
            this.Property(t => t.Description).HasColumnName("Description").IsRequired();
            this.Property(t => t.Code).HasColumnName("Code").IsOptional();
            this.Property(t => t.Status).HasColumnName("Status").IsRequired();
            this.Property(t => t.Type).HasColumnName("Type").IsRequired();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();            
        }
    }
}
