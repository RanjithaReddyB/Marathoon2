using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// IBEX transaction entity mapping for Entity Framework.
    /// </summary>
    public class IBEXTransactionMap : EntityTypeConfiguration<IBEXTransaction>
    {
        public IBEXTransactionMap()
        {
            // Properties
            this.Property(t => t.ProcessIdentifier)
                .HasMaxLength(100);

            this.Property(t => t.DataType)
                .HasMaxLength(20);

            this.Property(t => t.CntryCode)
                .HasMaxLength(20);

            this.Property(t => t.CoAbrv)
                .HasMaxLength(20);

            this.Property(t => t.Com)
                .HasMaxLength(20);

            this.Property(t => t.Company)
                .HasMaxLength(20);

            this.Property(t => t.ControlCode)
                .HasMaxLength(20);

            this.Property(t => t.CrudeCode)
                .HasMaxLength(20);

            this.Property(t => t.CustNo)
                .HasMaxLength(20);

            this.Property(t => t.ExchContractNo)
                .HasMaxLength(20);

            this.Property(t => t.InvoiceNo)
                .HasMaxLength(20);

            this.Property(t => t.MarathonOrderNo)
                .HasMaxLength(20);

            this.Property(t => t.PlBatch)
                .HasMaxLength(20);

            this.Property(t => t.RecipeCode)
                .HasMaxLength(20);

            this.Property(t => t.RecNo)
                .HasMaxLength(20);

            this.Property(t => t.ReferenceCommodity)
                .HasMaxLength(20);

            this.Property(t => t.RefineryBusMo)
                .HasMaxLength(20);

            this.Property(t => t.RefLoc)
                .HasMaxLength(20);

            this.Property(t => t.RptDate)
                .HasMaxLength(20);

            this.Property(t => t.RptLoc)
                .HasMaxLength(20);

            this.Property(t => t.RRCarTruck)
                .HasMaxLength(20);

            this.Property(t => t.SCAC)
                .HasMaxLength(20);

            this.Property(t => t.ShipDate)
                .HasMaxLength(20);

            this.Property(t => t.TicketNo)
                .HasMaxLength(20);

            this.Property(t => t.TransOrigin)
                .HasMaxLength(20);

            this.Property(t => t.TransportMode)
                .HasMaxLength(20);

            this.Property(t => t.TransportRqst)
                .HasMaxLength(20);

            this.Property(t => t.UMEA)
                .HasMaxLength(20);

            this.Property(t => t.DestState)
                .HasMaxLength(20);

            this.Property(t => t.ExchCustNo)
                .HasMaxLength(20);

            this.Property(t => t.FreightTerms)
                .HasMaxLength(20);

            this.Property(t => t.TypeLossGain)
                .HasMaxLength(20);

            this.Property(t => t.TimeIn)
                .HasMaxLength(20);

            this.Property(t => t.TimeOut)
                .HasMaxLength(20);

            this.Property(t => t.ExstarsTicketNo)
                .HasMaxLength(50);

            this.Property(t => t.TankNo)
                .HasMaxLength(20);

            this.Property(t => t.TermMeterNo)
                .HasMaxLength(20);

            this.Property(t => t.TypeCoUse)
                .HasMaxLength(20);

            this.Property(t => t.ShipRcpt)
                .HasMaxLength(20);

            this.Property(t => t.IsSales)
                .HasMaxLength(20);

            this.Property(t => t.IsTransportation)
                .HasMaxLength(20);

            this.Property(t => t.Origin)
                .HasMaxLength(20);

            this.Property(t => t.Destination)
                .HasMaxLength(20);

            this.Property(t => t.DealNo)
                .HasMaxLength(20);

            this.Property(t => t.DealType)
                .HasMaxLength(20);

            this.Property(t => t.Carrier)
                .HasMaxLength(20);

            this.Property(t => t.MovementDocNo)
                .HasMaxLength(20);

            this.Property(t => t.MovementTransNo)
                .HasMaxLength(20);

            this.Property(t => t.MovementDocType)
                .HasMaxLength(100);

            this.Property(t => t.CreatedByUser)
                .HasMaxLength(100);

            this.Property(t => t.Product)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("IBEXTransaction");
            this.Property(t => t.ProcessIdentifier).HasColumnName("ProcessIdentifier").IsRequired();
            this.Property(t => t.IsPublished).HasColumnName("IsPublished").IsRequired();
            this.Property(t => t.DataType).HasColumnName("DataType").IsRequired();
            this.Property(t => t.CntryCode).HasColumnName("CntryCode").IsOptional();
            this.Property(t => t.CoAbrv).HasColumnName("CoAbrv").IsOptional();
            this.Property(t => t.Com).HasColumnName("Com").IsOptional();
            this.Property(t => t.Company).HasColumnName("Company").IsOptional();
            this.Property(t => t.ControlCode).HasColumnName("ControlCode").IsOptional();
            this.Property(t => t.CrudeCode).HasColumnName("CrudeCode").IsOptional();
            this.Property(t => t.CustNo).HasColumnName("CustNo").IsOptional();
            this.Property(t => t.ExchContractNo).HasColumnName("ExchContractNo").IsOptional();
            this.Property(t => t.Gravity).HasColumnName("Gravity").IsRequired();
            this.Property(t => t.GrossQty).HasColumnName("GrossQty").IsRequired();
            this.Property(t => t.GrossQtyGal).HasColumnName("GrossQtyGal").IsRequired();
            this.Property(t => t.InvoiceNo).HasColumnName("InvoiceNo").IsOptional();
            this.Property(t => t.LbsGalConv).HasColumnName("LbsGalConv").IsRequired();
            this.Property(t => t.MarathonOrderNo).HasColumnName("MarathonOrderNo").IsOptional();
            this.Property(t => t.NetQty).HasColumnName("NetQty").IsRequired();
            this.Property(t => t.NetQtyGal).HasColumnName("NetQtyGal").IsRequired();
            this.Property(t => t.PlBatch).HasColumnName("PlBatch").IsOptional();
            this.Property(t => t.RecipeCode).HasColumnName("RecipeCode").IsOptional();
            this.Property(t => t.RecNo).HasColumnName("RecNo").IsOptional();
            this.Property(t => t.ReferenceCommodity).HasColumnName("ReferenceCommodity").IsOptional();
            this.Property(t => t.RefineryBusMo).HasColumnName("RefineryBusMo").IsOptional();
            this.Property(t => t.RefLoc).HasColumnName("RefLoc").IsOptional();
            this.Property(t => t.RptDate).HasColumnName("RptDate").IsOptional();
            this.Property(t => t.RptLoc).HasColumnName("RptLoc").IsOptional();
            this.Property(t => t.RRCarTruck).HasColumnName("RRCarTruck").IsOptional();
            this.Property(t => t.SCAC).HasColumnName("SCAC").IsOptional();
            this.Property(t => t.ShipDate).HasColumnName("ShipDate").IsOptional();
            this.Property(t => t.TicketNo).HasColumnName("TicketNo").IsOptional();
            this.Property(t => t.TransOrigin).HasColumnName("TransOrigin").IsOptional();
            this.Property(t => t.TransportMode).HasColumnName("TransportMode").IsOptional();
            this.Property(t => t.TransportRqst).HasColumnName("TransportRqst").IsOptional();
            this.Property(t => t.UMEA).HasColumnName("UMEA").IsOptional();
            this.Property(t => t.DestState).HasColumnName("DestState").IsOptional();
            this.Property(t => t.ExchCustNo).HasColumnName("ExchCustNo").IsOptional();
            this.Property(t => t.FreightTerms).HasColumnName("FreightTerms").IsOptional();
            this.Property(t => t.TypeLossGain).HasColumnName("TypeLossGain").IsOptional();
            this.Property(t => t.TimeIn).HasColumnName("TimeIn").IsOptional();
            this.Property(t => t.TimeOut).HasColumnName("TimeOut").IsOptional();
            this.Property(t => t.ExstarsTicketNo).HasColumnName("ExstarsTicketNo").IsOptional();
            this.Property(t => t.TankNo).HasColumnName("TankNo").IsOptional();
            this.Property(t => t.TermMeterNo).HasColumnName("TermMeterNo").IsOptional();
            this.Property(t => t.TypeCoUse).HasColumnName("TypeCoUse").IsOptional();
            this.Property(t => t.ShipRcpt).HasColumnName("ShipRcpt").IsOptional();
            this.Property(t => t.IsSales).HasColumnName("IsSales").IsOptional();
            this.Property(t => t.IsTransportation).HasColumnName("IsTransportation").IsOptional();
            this.Property(t => t.Origin).HasColumnName("Origin").IsOptional();
            this.Property(t => t.Destination).HasColumnName("Destination").IsOptional();
            this.Property(t => t.DealNo).HasColumnName("DealNo").IsOptional();
            this.Property(t => t.DealType).HasColumnName("DealType").IsOptional();
            this.Property(t => t.Carrier).HasColumnName("Carrier").IsOptional();
            this.Property(t => t.MovementDocNo).HasColumnName("MovementDocNo").IsOptional();
            this.Property(t => t.MovementTransNo).HasColumnName("MovementTransNo").IsOptional();
            this.Property(t => t.MovementDocType).HasColumnName("MovementDocType").IsOptional();
            this.Property(t => t.CreatedByUser).HasColumnName("CreatedByUser").IsOptional();
            this.Property(t => t.Product).HasColumnName("Product").IsOptional();
        }
    }
}
