using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Deal Obligation entity mapping for Entity Framework.
    /// </summary>
    public class DealObligationMap : EntityTypeConfiguration<DealObligation>
    {
        public DealObligationMap()
        {
            // Table & Column Mappings
            this.ToTable("DealObligation");
            this.Property(t => t.DealHeaderKey).HasColumnName("DealHeaderKey").IsRequired();
            this.Property(t => t.DealDetailKey).HasColumnName("DealDetailKey").IsRequired();
            this.Property(t => t.ObligationId).HasColumnName("ObligationID").IsRequired();
            this.Property(t => t.DealID).HasColumnName("DealID").IsOptional();
            this.Property(t => t.FromDate).HasColumnName("FromDate").IsOptional();
            this.Property(t => t.ToDate).HasColumnName("ToDate").IsOptional();
            this.Property(t => t.Quantity).HasColumnName("Quantity").IsOptional();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();

            // Foreign Key Mappings
            this.HasOptional<Deal>(t => t.Deal).WithMany(t => t.DealObligations).HasForeignKey(f => f.DealID);
		}
    }
}



