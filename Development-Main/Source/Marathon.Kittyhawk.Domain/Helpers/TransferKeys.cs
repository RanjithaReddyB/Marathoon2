using System;
using System.Collections.Generic;

namespace Marathon.Kittyhawk.Domain
{
    public class TransferKeys : IEqualityComparer<TransferKeys>
    {
        public int PlannedTransferKey { get; set; }
        
        public int GetHashCode(TransferKeys obj)
        {
            return obj.PlannedTransferKey.GetHashCode();
        }

        public bool Equals(TransferKeys x, TransferKeys y)
        {
            if (Object.ReferenceEquals(x, y)) return true;

            if (Object.ReferenceEquals(x, null) ||
                Object.ReferenceEquals(y, null))
                return false;

            return x.PlannedTransferKey == y.PlannedTransferKey;
        }
    }
}
