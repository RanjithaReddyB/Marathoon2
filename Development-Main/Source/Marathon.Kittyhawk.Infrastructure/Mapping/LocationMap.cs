using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Infrastructure.Mapping
{
    /// <summary>
    /// Location entity mapping for Entity Framework.
    /// </summary>
    public class LocationMap : EntityTypeConfiguration<Location>
    {
        public LocationMap()
        {
            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(150);

            this.Property(t => t.Abbreviation)
                .HasMaxLength(120);

            this.Property(t => t.Type)
                .HasMaxLength(80);

            this.Property(t => t.City)
                .HasMaxLength(50);

            this.Property(t => t.StateOrProvince)
                .HasMaxLength(50);

            this.Property(t => t.Country)
                .HasMaxLength(50);

            this.Property(t => t.SAPProfitCenter4500)
                .HasMaxLength(50);

            this.Property(t => t.SAPProfitCenter4502)
                .HasMaxLength(50);

            this.Property(t => t.SAPProfitCenter4504)
                .HasMaxLength(50);

            //this.Property(t => t.LocationType)
            //.IsMaxLength();

            this.Property(t => t.StreetAddressAttribute)
                .IsMaxLength();

            this.Property(t => t.CityAttribute)
                .IsMaxLength();

            this.Property(t => t.FipsCityCode)
                .IsMaxLength();

            this.Property(t => t.StateAttribute)
                .IsMaxLength();

            this.Property(t => t.ZipAttribute)
                .IsMaxLength();

            this.Property(t => t.FipsCountyCode)
                .IsMaxLength();

            //this.Property(t => t.Latitude)
            //.IsMaxLength();

            //this.Property(t => t.Longitude)
            //.IsMaxLength();

            this.Property(t => t.CityLimitIndicator)
                .IsMaxLength();

            this.Property(t => t.LocationUnitCode)
				.HasMaxLength(255);

			this.Property(t => t.TASTermID)
                .IsMaxLength();

            this.Property(t => t.TermCommType)
                .IsMaxLength();

            this.Property(t => t.DestinationLocationID)
				.HasMaxLength(255);

			this.Property(t => t.StationNumber)
                .IsMaxLength();

            this.Property(t => t.AvailableForDownload)
                .IsMaxLength();

            this.Property(t => t.TerminalSPLC)
                .IsMaxLength();

            this.Property(t => t.TerminalOperatorID)
                .IsMaxLength();

            this.Property(t => t.TerminalCompanyID)
                .IsMaxLength();

            this.Property(t => t.HourOffset)
                .IsMaxLength();

            this.Property(t => t.TDSTerminalID)
                .IsMaxLength();

            this.Property(t => t.PhoneNo)
                .IsMaxLength();

            this.Property(t => t.InterfaceCountryCode)
                .IsMaxLength();

            this.Property(t => t.Status)
                .IsMaxLength();

            this.Property(t => t.County)
                .IsMaxLength();

            this.Property(t => t.CountyCode)
               .IsMaxLength();

            this.Property(t => t.FipsCountryCode)
                .IsMaxLength();

            this.Property(t => t.TCNNumber)
                .IsMaxLength();

            this.Property(t => t.TerminalOperator)
                .IsMaxLength();


            // Table & Column Mappings
            this.ToTable("Location");
            this.Property(t => t.LocationKey).HasColumnName("LocationKey").IsRequired();
            this.Property(t => t.Name).HasColumnName("Name").IsRequired();
            this.Property(t => t.Abbreviation).HasColumnName("Abbreviation").IsRequired();
            this.Property(t => t.Type).HasColumnName("Type").IsRequired();
            this.Property(t => t.City).HasColumnName("City").IsOptional();
            this.Property(t => t.StateOrProvince).HasColumnName("StateOrProvince").IsOptional();
            this.Property(t => t.Country).HasColumnName("Country").IsOptional();
            this.Property(t => t.SAPProfitCenter4500).HasColumnName("SAPProfitCenter4500").IsOptional();
            this.Property(t => t.SAPProfitCenter4502).HasColumnName("SAPProfitCenter4502").IsOptional();
            this.Property(t => t.SAPProfitCenter4504).HasColumnName("SAPProfitCenter4504").IsOptional();
            //this.Property(t => t.LocationType).HasColumnName("LocationType").IsOptional();
            this.Property(t => t.StreetAddressAttribute).HasColumnName("StreetAddressAttribute").IsOptional();
            this.Property(t => t.CityAttribute).HasColumnName("CityAttribute").IsOptional();
            this.Property(t => t.FipsCityCode).HasColumnName("FipsCityCode").IsOptional();
            this.Property(t => t.StateAttribute).HasColumnName("StateAttribute").IsOptional();
            this.Property(t => t.ZipAttribute).HasColumnName("ZipAttribute").IsOptional();
            this.Property(t => t.FipsCountyCode).HasColumnName("FipsCountyCode").IsOptional();
            //this.Property(t => t.Latitude).HasColumnName("Latitude").IsOptional();
            //this.Property(t => t.Longitude).HasColumnName("Longitude").IsOptional();
            this.Property(t => t.CityLimitIndicator).HasColumnName("CityLimitIndicator").IsOptional();
            this.Property(t => t.LocationUnitCode).HasColumnName("LocationUnitCode").IsOptional();
            this.Property(t => t.TASTermID).HasColumnName("TASTermID").IsOptional();
            this.Property(t => t.TermCommType).HasColumnName("TermCommType").IsOptional();
            //this.Property(t => t.Downloadable).HasColumnName("Downloadable").IsOptional();
            this.Property(t => t.DestinationLocationID).HasColumnName("DestinationLocationID").IsOptional();
            this.Property(t => t.StationNumber).HasColumnName("StationNumber").IsOptional();
            this.Property(t => t.AvailableForDownload).HasColumnName("AvailableForDownload").IsOptional();
            this.Property(t => t.TerminalSPLC).HasColumnName("TerminalSPLC").IsOptional();
            this.Property(t => t.TerminalOperatorID).HasColumnName("TerminalOperatorID").IsOptional();
            this.Property(t => t.TerminalCompanyID).HasColumnName("TerminalCompanyID").IsOptional();
            this.Property(t => t.MPCOwnership).HasColumnName("MPCOwnership").IsOptional();
            this.Property(t => t.HourOffset).HasColumnName("HourOffset").IsOptional();
            this.Property(t => t.TDSTerminalID).HasColumnName("TDSTerminalID").IsOptional();
            this.Property(t => t.Fleet).HasColumnName("Fleet").IsOptional();
            this.Property(t => t.PhoneNo).HasColumnName("PhoneNo").IsOptional();
            this.Property(t => t.InterfaceCountryCode).HasColumnName("InterfaceCountryCode").IsOptional();
            this.Property(t => t.LocationTypeIsPhysical).HasColumnName("LocationTypeIsPhysical").IsOptional();
            this.Property(t => t.Status).HasColumnName("Status").IsOptional();
            this.Property(t => t.County).HasColumnName("County").IsOptional();
            this.Property(t => t.CountyCode).HasColumnName("CountyCode").IsOptional();
            this.Property(t => t.FipsCountryCode).HasColumnName("FipsCountryCode").IsOptional();
            this.Property(t => t.TCNNumber).HasColumnName("TCNNumber").IsOptional();
            this.Property(t => t.TerminalOperator).HasColumnName("TerminalOperator").IsOptional();
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted").IsRequired();
        }
    }
}
