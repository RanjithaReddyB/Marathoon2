using Marathon.Kittyhawk.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    public class TransactionTypeMap : EntityTypeConfiguration<TransactionType>
    {
        public TransactionTypeMap()
        {
            this.ToTable("TransactionType");

            this.Property(t => t.Status).HasMaxLength(1);

            this.Property(t => t.TransactionTypeKey).HasColumnName("TransactionTypeKey").IsRequired();
            this.Property(t => t.Description).HasColumnName("Description").IsRequired();
            this.Property(t => t.Status).HasColumnName("Status").IsRequired();
            this.Property(t => t.Category).HasColumnName("Category").IsOptional();
            this.Property(t => t.TransactionGroups).HasColumnName("TransactionGroups").IsOptional();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();
        }
    }
}
