using System;
using System.Collections.Generic;

namespace Marathon.Kittyhawk.Domain
{
    public class DealKeys : IEqualityComparer<DealKeys>
    {
        public int DealHeaderKey { get; set; }
        public int DealDetailKey { get; set; }        

        public int GetHashCode(DealKeys obj)
        {
            return obj.DealHeaderKey.GetHashCode() ^ obj.DealDetailKey.GetHashCode();
        }

        public bool Equals(DealKeys x, DealKeys y)
        {
            if (Object.ReferenceEquals(x, y)) return true;

            if (Object.ReferenceEquals(x, null) ||
                Object.ReferenceEquals(y, null))
                return false;

            return x.DealHeaderKey == y.DealHeaderKey && x.DealDetailKey == y.DealDetailKey;
        }
    }
}
