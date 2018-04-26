using System;
using System.Collections.Generic;

namespace Marathon.Kittyhawk.Domain
{
    public class MovementTransactionValueKeys : IEqualityComparer<MovementTransactionValueKeys>
    {
        public int TransactionDetailKey { get; set; }
        
        public int GetHashCode(MovementTransactionValueKeys obj)
        {
            return obj.TransactionDetailKey.GetHashCode();
        }

        public bool Equals(MovementTransactionValueKeys x, MovementTransactionValueKeys y)
        {
            if (Object.ReferenceEquals(x, y)) return true;

            if (Object.ReferenceEquals(x, null) ||
                Object.ReferenceEquals(y, null))
                return false;

            return x.TransactionDetailKey == y.TransactionDetailKey;
        }
    }
}
