using System;
using System.Collections.Generic;

namespace Marathon.Kittyhawk.Domain
{
    public class InvoiceKeys : IEqualityComparer<InvoiceKeys>
    {
        public int InvoiceHeaderKey { get; set; }
        public int? InvoiceDetailKey { get; set; }
        
        public int GetHashCode(InvoiceKeys obj)
        {
            return obj.InvoiceHeaderKey.GetHashCode() ^ obj.InvoiceDetailKey.GetHashCode();
        }

        public bool Equals(InvoiceKeys x, InvoiceKeys y)
        {
            if (Object.ReferenceEquals(x, y)) return true;

            if (Object.ReferenceEquals(x, null) ||
                Object.ReferenceEquals(y, null))
                return false;

            return x.InvoiceHeaderKey == y.InvoiceHeaderKey && x.InvoiceDetailKey == y.InvoiceDetailKey;
        }
    }
}
