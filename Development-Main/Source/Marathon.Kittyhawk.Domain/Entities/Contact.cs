using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    public class Contact : Entity
    {
        public int ContactKey { get; set; }
        public int? UserKey { get; set; }
        public Guid? BAID { get; set; }
        public virtual BusinessAssociate BA { get; set; }
        public Guid? OfficeAddressID { get; set; }
		public virtual OfficeAddress OfficeAddress { get; set; }
		public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string ContactPhoneNo { get; set; }
        public string ContactFaxNo { get; set; }
        public string ContactTitle { get; set; }
        public string ContactDepartment { get; set; }
        public string PicCode { get; set; }
        public string ContactEmailAddress { get; set; }
		public bool? CarrierReportingIndicator { get; set; }
        public string EmployeeNumber { get; set; }
        public int? TraderManagerKey { get; set; }
        public Guid? TraderManagerID { get; set; }
        public virtual Contact TraderManager { get; set; }
        public bool IsDeleted { get; set; }          
         
        public Contact() { }
    }
}


      
