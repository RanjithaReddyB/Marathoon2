using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Business associate entity mapping for Entity Framework.
    /// </summary>
    public class BusinessAssociateMap : EntityTypeConfiguration<BusinessAssociate>
    {
        public BusinessAssociateMap()
        {
            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(100);

            this.Property(t => t.Abbreviation)
                .HasMaxLength(50);

            this.Property(t => t.ClassOfTrade)
                .HasMaxLength(80);

            this.Property(t => t.NetOutCustomer)
                .HasMaxLength(1);

            this.Property(t => t.FederalTax)
                .HasMaxLength(50);

            this.Property(t => t.SCAC)
                .HasMaxLength(50);

            this.Property(t => t.LegacyID)
                .HasMaxLength(50);

            this.Property(t => t.SAPVendor)
                .HasMaxLength(50);

            this.Property(t => t.SAPCustomer)
                .HasMaxLength(50);

            this.Property(t => t.SAPCompany)
                .HasMaxLength(50);           

            this.Property(t => t.SupplierID)
                .HasMaxLength(255);

            this.Property(t => t.TermSupplierID)
                .IsMaxLength();

            this.Property(t => t.Taboot)
                .IsMaxLength();

            this.Property(t => t.TerminalCustomerName)
                .IsMaxLength();

            this.Property(t => t.TransID)
                .IsMaxLength();

            this.Property(t => t.PIDXCompanyCode)
                .IsMaxLength();

            this.Property(t => t.EPARegistrationNumber)
                .IsMaxLength();

            this.Property(t => t.CarrierReportingOfficeIndicator)
                .IsMaxLength();

            this.Property(t => t.ModeOfTransport)
                .IsMaxLength();

            this.Property(t => t.DisadvantagedBusinessEnterprise)
                .IsMaxLength();

            this.Property(t => t.SAPARDocType)
                .IsMaxLength();

            this.Property(t => t.SCOA)
                .IsMaxLength();

            this.Property(t => t.RelationshipType)
                .IsMaxLength();

            this.Property(t => t.Status)
                .IsMaxLength();

            this.Property(t => t.Type)
                .IsMaxLength();

            this.Property(t => t.DisplayID)
                .IsMaxLength();

            this.Property(t => t.DisplayName)
                .IsMaxLength();

            this.Property(t => t.CreationUserID)
                .IsMaxLength();

            this.Property(t => t.UserDBMnkr)
             .HasMaxLength(80);

            this.Property(t => t.PrimaryContact)
                .IsMaxLength();
            this.Property(t => t.InvoiceDisplayName)
                .IsMaxLength();


            // Table & Column Mappings
            this.ToTable("BusinessAssociate");
            this.Property(t => t.BAKey).HasColumnName("BAKey").IsRequired();
            this.Property(t => t.Name).HasColumnName("Name").IsRequired();
            this.Property(t => t.Abbreviation).HasColumnName("Abbreviation").IsRequired();
            this.Property(t => t.ClassOfTrade).HasColumnName("ClassOfTrade").IsOptional();
            this.Property(t => t.NetOutCustomer).HasColumnName("NetOutCustomer").IsRequired().IsFixedLength();
            this.Property(t => t.FederalTax).HasColumnName("FederalTax").IsOptional();
            this.Property(t => t.SCAC).HasColumnName("SCAC").IsOptional();
            this.Property(t => t.LegacyID).HasColumnName("LegacyID").IsOptional();
            this.Property(t => t.SAPVendor).HasColumnName("SAPVendor").IsOptional();
            this.Property(t => t.SAPCustomer).HasColumnName("SAPCustomer").IsOptional();
            this.Property(t => t.SAPCompany).HasColumnName("SAPCompany").IsOptional();            
            this.Property(t => t.SupplierID).HasColumnName("SupplierID").IsOptional();
            this.Property(t => t.TermSupplierID).HasColumnName("TermSupplierID").IsOptional();
            this.Property(t => t.Taboot).HasColumnName("Taboot").IsOptional();
            this.Property(t => t.TerminalCustomerName).HasColumnName("TerminalCustomerName").IsOptional();
            this.Property(t => t.TransID).HasColumnName("TransID").IsOptional();
            this.Property(t => t.ActiveForDownload).HasColumnName("ActiveForDownload").IsOptional();
            this.Property(t => t.POPrompt).HasColumnName("POPrompt").IsOptional();
            this.Property(t => t.PIDXCompanyCode).HasColumnName("PIDXCompanyCode").IsOptional();
            this.Property(t => t.EPARegistrationNumber).HasColumnName("EPARegistrationNumber").IsOptional();
            this.Property(t => t.CarrierReportingOfficeIndicator).HasColumnName("CarrierReportingOfficeIndicator").IsOptional();
            this.Property(t => t.ModeOfTransport).HasColumnName("ModeOfTransport").IsOptional();
            this.Property(t => t.CommonCarrier).HasColumnName("CommonCarrier").IsOptional();
            this.Property(t => t.DisadvantagedBusinessEnterprise).HasColumnName("DisadvantagedBusinessEnterprise").IsOptional();
            //this.Property(t => t.ActualExpirationDate).HasColumnName("ActualExpirationDate").IsOptional();
            this.Property(t => t.SAPARDocType).HasColumnName("SAPARDocType").IsOptional();
            this.Property(t => t.SCOA).HasColumnName("SCOA").IsOptional();
            this.Property(t => t.RelationshipType).HasColumnName("RelationshipType").IsOptional();
            this.Property(t => t.Status).HasColumnName("Status").IsOptional();
            this.Property(t => t.Type).HasColumnName("Type").IsOptional();
            this.Property(t => t.DisplayID).HasColumnName("DisplayID").IsOptional();
            this.Property(t => t.DisplayName).HasColumnName("DisplayName").IsOptional();
            this.Property(t => t.CreationDate).HasColumnName("CreationDate").IsOptional();
            this.Property(t => t.CreationUserID).HasColumnName("CreationUserID").IsOptional();
            this.Property(t => t.UserDBMnkr).HasColumnName("UserDBMnkr").IsOptional();
            this.Property(t => t.PrimaryContact).HasColumnName("PrimaryContact").IsOptional();
            this.Property(t => t.ContractCode).HasColumnName("ContractCode").IsOptional();
            this.Property(t => t.InvoiceDisplayName).HasColumnName("InvoiceDisplayName").IsOptional();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();
            this.Property(t => t.CreditAnalystKey).HasColumnName("CreditAnalystKey").IsOptional();
            this.Property(t => t.CreditAnalystID).HasColumnName("CreditAnalystID").IsOptional();
            this.Property(t => t.DefaultTerritoryManagerCode).HasColumnName("DefaultTerritoryManagerCode").IsOptional();
            this.Property(t => t.DefaultTerritoryManagerID).HasColumnName("DefaultTerritoryManagerID").IsOptional();

            // Foreign Key Mappings
            this.HasOptional<Contact>(t => t.CreditAnalyst).WithMany().HasForeignKey(f => f.CreditAnalystID);
            this.HasOptional<TerritoryManager>(t => t.DefaultTerritoryManager).WithMany().HasForeignKey(f => f.DefaultTerritoryManagerID);
        }
    }
}
