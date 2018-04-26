using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Territory Manager entity mapping for Entity Framework.
    /// </summary>
    public class TerritoryManagerMap : EntityTypeConfiguration<TerritoryManager>
    {
        public TerritoryManagerMap()
        {
            // Properties
            this.Property(t => t.TMCode)
                .HasMaxLength(40);

            this.Property(t => t.TMCodeDescription)
                .HasMaxLength(80);

            this.Property(t => t.SalesArea)
                .IsMaxLength();

            // Table & Column Mappings
            this.ToTable("TerritoryManager");
            this.Property(t => t.TMCode).HasColumnName("TMCode").IsOptional();
            this.Property(t => t.TMCodeDescription).HasColumnName("TMCodeDescription").IsOptional();
            this.Property(t => t.SalesArea).HasColumnName("SalesArea").IsOptional();
            this.Property(t => t.ContactID).HasColumnName("ContactID").IsOptional();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();

            // Foreign Key Mappings
            this.HasOptional<Contact>(t => t.Contact).WithMany().HasForeignKey(f => f.ContactID);
        }
    }
}
