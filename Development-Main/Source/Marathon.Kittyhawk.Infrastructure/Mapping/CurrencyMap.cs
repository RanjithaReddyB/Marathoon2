using Marathon.Kittyhawk.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    public class CurrencyMap : EntityTypeConfiguration<Currency>
    {
        public CurrencyMap()
        {
            // Table & Column Mappings
            this.ToTable("Currency");
            this.Property(t => t.Name).HasMaxLength(80);
            this.Property(t => t.Abbreviation).HasMaxLength(50);
            this.Property(t => t.Symbol).HasMaxLength(3);

            this.Property(t => t.CurrencyKey).HasColumnName("CurrencyKey").IsRequired();
            this.Property(t => t.Name).HasColumnName("Name").IsRequired();
            this.Property(t => t.Abbreviation).HasColumnName("Abbreviation").IsRequired();
            this.Property(t => t.Symbol).HasColumnName("Symbol").IsRequired();
            this.Property(t => t.ReadingPrecision).HasColumnName("ReadingPrecision").IsRequired();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();
        }
    }
}
