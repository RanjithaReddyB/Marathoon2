using System;
using System.Collections.Generic;

namespace Marathon.Kittyhawk.Domain
{
    public class TimeTransactionKeys : IEqualityComparer<TimeTransactionKeys>
    {
        public int TimeTransactionKey { get; set; }
        public int? TimeTransactionLogKey { get; set; }
        
        public int GetHashCode(TimeTransactionKeys obj)
        {
            return obj.TimeTransactionKey.GetHashCode() ^ obj.TimeTransactionLogKey.GetHashCode();
        }

        public bool Equals(TimeTransactionKeys x, TimeTransactionKeys y)
        {
            if (Object.ReferenceEquals(x, y)) return true;

            if (Object.ReferenceEquals(x, null) ||
                Object.ReferenceEquals(y, null))
                return false;

            return x.TimeTransactionKey == y.TimeTransactionKey && x.TimeTransactionLogKey == y.TimeTransactionLogKey;
        }
    }
}
