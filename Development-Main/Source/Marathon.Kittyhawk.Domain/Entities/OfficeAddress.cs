using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents a address.
    /// </summary>
    public class OfficeAddress : Entity
    {
        public int OfficeKey { get; set; }
        public int AddressKey { get; set; }
        public string AddressType { get; set; }
        public Guid? BAID { get; set; }
        public virtual BusinessAssociate BA { get; set; }
        public string OfficePhone { get; set; }
        public string OfficeFax { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressCountry { get; set; }
        public string AddressZip { get; set; }
        public bool IsDeleted { get; set; }

        public OfficeAddress() { }
    }
}






