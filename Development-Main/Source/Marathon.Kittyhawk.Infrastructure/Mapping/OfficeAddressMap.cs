using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Address entity mapping for Entity Framework.
    /// </summary>
    public class OfficeAddressMap : EntityTypeConfiguration<OfficeAddress>
    {
        public OfficeAddressMap()
        {
            // Properties
            this.Property(t => t.AddressType)
                .HasMaxLength(10);

            this.Property(t => t.OfficePhone)
                .HasMaxLength(25);

            this.Property(t => t.OfficeFax)
                .HasMaxLength(25);

            this.Property(t => t.AddressLine1)
                .HasMaxLength(50);

            this.Property(t => t.AddressLine2)
                .HasMaxLength(50);

            this.Property(t => t.AddressCity)
                .HasMaxLength(50);

            this.Property(t => t.AddressState)
                .HasMaxLength(50);

            this.Property(t => t.AddressCountry)
                .HasMaxLength(50);

            this.Property(t => t.AddressZip)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("OfficeAddress");
            this.Property(t => t.OfficeKey).HasColumnName("OfficeKey").IsRequired();
            this.Property(t => t.AddressKey).HasColumnName("AddressKey").IsRequired();
            this.Property(t => t.AddressType).HasColumnName("AddressType").IsOptional();
            this.Property(t => t.BAID).HasColumnName("BAID").IsOptional();
            this.Property(t => t.OfficePhone).HasColumnName("OfficePhone").IsOptional();
            this.Property(t => t.OfficeFax).HasColumnName("OfficeFax").IsOptional();
            this.Property(t => t.AddressLine1).HasColumnName("AddressLine1").IsOptional();
            this.Property(t => t.AddressLine2).HasColumnName("AddressLine2").IsOptional();
            this.Property(t => t.AddressCity).HasColumnName("AddressCity").IsOptional();
            this.Property(t => t.AddressState).HasColumnName("AddressState").IsOptional();
            this.Property(t => t.AddressCountry).HasColumnName("AddressCountry").IsOptional();
            this.Property(t => t.AddressZip).HasColumnName("AddressZip").IsOptional();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();

            // Foreign Key Mappings
            this.HasOptional<BusinessAssociate>(t => t.BA).WithMany(t => t.OfficeAddresses).HasForeignKey(f => f.BAID);
        }
    }
}

