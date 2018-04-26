using System;
using System.Linq;

namespace Marathon.Kittyhawk.Domain.DTO
{
    public class MdgContact
    {
        public int? BusinessAssociateId { get; set; }
        public int? LocaleId { get; set; }
        public string AddressType { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
    }
}
