using System;
using System.Linq;

namespace Marathon.Kittyhawk.Domain.DTO
{
    public class MdgCustomer
    {
        public int? BusinessAssociateId { get; set; }
        public string AccountGroup { get; set; }
        public string LegalName { get; set; }
        public string CustomerNumber { get; set; }
        public string LegacyId { get; set; }
    }
}
