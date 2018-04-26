using System;
using System.Collections.Generic;

namespace Marathon.Kittyhawk.Domain
{
    public class DealObligationKeys : IEqualityComparer<DealObligationKeys>
    {
        public int DealHeaderKey { get; set; }
        public int DealDetailKey { get; set; }
        public int ObligationId { get; set; }        

        public int GetHashCode(DealObligationKeys obj)
        {
            return obj.DealHeaderKey.GetHashCode() ^ obj.DealDetailKey.GetHashCode() ^ obj.ObligationId.GetHashCode();
        }

        public bool Equals(DealObligationKeys x, DealObligationKeys y)
        {
            if (Object.ReferenceEquals(x, y)) return true;

            if (Object.ReferenceEquals(x, null) ||
                Object.ReferenceEquals(y, null))
                return false;

            return x.DealHeaderKey == y.DealHeaderKey && x.DealDetailKey == y.DealDetailKey && x.ObligationId == y.ObligationId;
        }
    }
}
