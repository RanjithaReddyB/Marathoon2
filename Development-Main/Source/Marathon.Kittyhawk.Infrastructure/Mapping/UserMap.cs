using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        /// <summary>
        /// User entity mapping for Entity Framework.
        /// </summary>
        public UserMap()
        {
            // Properties
            this.Property(t => t.FirstName)
                .HasMaxLength(100);

            this.Property(t => t.LastName)
                .HasMaxLength(100);

            this.Property(t => t.Email)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("User");
            this.Property(t => t.FirstName).HasColumnName("FirstName").IsRequired();
            this.Property(t => t.LastName).HasColumnName("LastName").IsRequired();
            this.Property(t => t.Email).HasColumnName("Email").IsRequired();
            this.Property(t => t.FeedsOutOfDate).HasColumnName("FeedsOutOfDate").IsRequired();
            this.Property(t => t.BulkTransferErrors).HasColumnName("BulkTransferErrors").IsRequired();
            this.Property(t => t.InventoryErrors).HasColumnName("InventoryErrors").IsRequired();
            this.Property(t => t.IBEXTransactionErrors).HasColumnName("IBEXTransactionErrors").IsRequired();
        }
    }
}
