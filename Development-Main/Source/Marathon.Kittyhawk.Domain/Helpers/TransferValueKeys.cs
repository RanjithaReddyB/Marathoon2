using System;
using System.Collections.Generic;

namespace Marathon.Kittyhawk.Domain
{
    public class TransferValueKeys : IEqualityComparer<TransferValueKeys>
    {
        public int PlannedTransferValueKey { get; set; }
        
        public int GetHashCode(TransferValueKeys obj)
        {
            return obj.PlannedTransferValueKey.GetHashCode();
        }

        public bool Equals(TransferValueKeys x, TransferValueKeys y)
        {
            if (Object.ReferenceEquals(x, y)) return true;

            if (Object.ReferenceEquals(x, null) ||
                Object.ReferenceEquals(y, null))
                return false;

            return x.PlannedTransferValueKey == y.PlannedTransferValueKey;
        }
    }
}
