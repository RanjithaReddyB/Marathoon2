using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Message queue entity mapping for Entity Framework.
    /// </summary>
    public class MessageMap : EntityTypeConfiguration<Message>
    {
        public MessageMap()
        {
            // Table & Column Mappings
            this.ToTable("MessageQueue");
            this.Property(t => t.ProcessIdentifier).HasColumnName("ProcessIdentifier").IsRequired();
            this.Property(t => t.Type).HasColumnName("Type").IsRequired();
            this.Property(t => t.Status).HasColumnName("Status").IsRequired();
            this.Property(t => t.Data).HasColumnName("Data").HasColumnType("xml").IsRequired();
        }
    }
}
