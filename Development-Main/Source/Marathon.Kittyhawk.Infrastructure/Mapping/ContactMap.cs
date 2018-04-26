using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Contact entity mapping for Entity Framework.
    /// </summary>
    public class ContactMap : EntityTypeConfiguration<Contact>
    {
        public ContactMap()
        {
            // Properties
            this.Property(t => t.FirstName)
                .HasMaxLength(20);

            this.Property(t => t.LastName)
                .HasMaxLength(20);

            this.Property(t => t.NickName)
               .HasMaxLength(20);

            this.Property(t => t.ContactPhoneNo)
                .HasMaxLength(25);

            this.Property(t => t.ContactFaxNo)
                .HasMaxLength(25);

            this.Property(t => t.ContactTitle)
               .HasMaxLength(50);

            this.Property(t => t.ContactDepartment)
                .HasMaxLength(50);

            this.Property(t => t.PicCode)
                .HasMaxLength(80);

            this.Property(t => t.ContactEmailAddress)
               .HasMaxLength(50);


            // Table & Column Mappings
            this.ToTable("Contact");
            this.Property(t => t.ContactKey).HasColumnName("ContactKey").IsRequired();
            this.Property(t => t.UserKey).HasColumnName("UserKey").IsOptional();
            this.Property(t => t.BAID).HasColumnName("BAID").IsOptional();
            this.Property(t => t.OfficeAddressID).HasColumnName("OfficeAddressID").IsOptional();
            this.Property(t => t.FirstName).HasColumnName("FirstName").IsOptional();
            this.Property(t => t.LastName).HasColumnName("LastName").IsOptional();
            this.Property(t => t.NickName).HasColumnName("NickName").IsOptional();
            this.Property(t => t.ContactPhoneNo).HasColumnName("ContactPhoneNo").IsOptional();
            this.Property(t => t.ContactFaxNo).HasColumnName("ContactFaxNo").IsOptional();
            this.Property(t => t.ContactTitle).HasColumnName("ContactTitle ").IsOptional();
            this.Property(t => t.ContactDepartment).HasColumnName("ContactDepartment").IsOptional();
            this.Property(t => t.PicCode).HasColumnName("PicCode").IsOptional();
            this.Property(t => t.ContactEmailAddress).HasColumnName("ContactEmailAddress").IsOptional();
            this.Property(t => t.CarrierReportingIndicator).HasColumnName("CarrierReportingIndicator").IsOptional();
            this.Property(t => t.EmployeeNumber).HasColumnName("EmployeeNumber").IsOptional();
            this.Property(t => t.TraderManagerKey).HasColumnName("TraderManagerKey").IsOptional();
            this.Property(t => t.TraderManagerID).HasColumnName("TraderManagerID").IsOptional();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();

            // Foreign Key Mappings
            this.HasOptional<BusinessAssociate>(t => t.BA).WithMany().HasForeignKey(f => f.BAID);
			this.HasOptional<OfficeAddress>(t => t.OfficeAddress).WithMany().HasForeignKey(f => f.OfficeAddressID);
            this.HasOptional<Contact>(t => t.TraderManager).WithMany().HasForeignKey(f => f.TraderManagerID);
		}
    }
}




