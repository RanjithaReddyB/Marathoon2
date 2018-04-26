using System;
using System.Collections.Generic;

namespace Marathon.Kittyhawk.Domain.Entities
{
	/// <summary>
	/// Entity class that represents a business associate.
	/// </summary>
	public class BusinessAssociate : Entity
	{
		public int BAKey { get; set; }
		public string Name { get; set; }
		public string Abbreviation { get; set; }
		public string ClassOfTrade { get; set; }
		public string NetOutCustomer { get; set; }
		public string FederalTax { get; set; }
		public string SCAC { get; set; }
		public string LegacyID { get; set; }
		public string SAPVendor { get; set; }
		public string SAPCustomer { get; set; }
		public string SAPCompany { get; set; }		
		public string SupplierID { get; set; }
		public string TermSupplierID { get; set; }
		public string Taboot { get; set; }
		public string TerminalCustomerName { get; set; }
		public string TransID { get; set; }
		public bool? ActiveForDownload { get; set; }
		public bool? POPrompt { get; set; }
		public string PIDXCompanyCode { get; set; }
		public string EPARegistrationNumber { get; set; }
		public string CarrierReportingOfficeIndicator { get; set; }
		public string ModeOfTransport { get; set; }
		public bool? CommonCarrier { get; set; }
		public string DisadvantagedBusinessEnterprise { get; set; }
		//public DateTime? ActualExpirationDate { get; set; }
		public string SAPARDocType { get; set; }
		public string SCOA { get; set; }
		public string RelationshipType { get; set; }
		public string ModeOfTransportDesc { get; set; }
		public string TransIdDesc { get; set; }
		public string Status { get; set; }
		public string Type { get; set; }
		public string DisplayID { get; set; }
		public string DisplayName { get; set; }
		public DateTime? CreationDate { get; set; }
		public string CreationUserID { get; set; }
		public string PrimaryContact { get; set; }
		public string ContractCode { get; set; }
		//public string ModeOfTransportDesc { get; set; }
		//public string TransIdDesc { get; set; }
		public string InvoiceDisplayName { get; set; }
        public int? CreditAnalystKey { get; set; }
        public Guid? CreditAnalystID { get; set; }
        public virtual Contact CreditAnalyst { get; set; }
        public bool IsDeleted { get; set; }
		public virtual ICollection<OfficeAddress> OfficeAddresses { get; set; }
        public string UserDBMnkr { get; set; }
        public string DefaultTerritoryManagerCode { get; set; }
        public Guid? DefaultTerritoryManagerID { get; set; }
        public virtual TerritoryManager DefaultTerritoryManager { get; set; }
        public BusinessAssociate() { }
	}
}
