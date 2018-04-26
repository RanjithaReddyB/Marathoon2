using System;
using System.Collections.Generic;

namespace Marathon.Kittyhawk.Domain
{
    public class MovementTransactionKeys : IEqualityComparer<MovementTransactionKeys>
    {
        public int TransactionHeaderKey { get; set; }
        public int? ChildProduct { get; set; }

        public int GetHashCode(MovementTransactionKeys obj)
        {
            return obj.TransactionHeaderKey.GetHashCode() ^ obj.ChildProduct.GetHashCode();
        }

        public bool Equals(MovementTransactionKeys x, MovementTransactionKeys y)
        {
            if (Object.ReferenceEquals(x, y)) return true;

            if (Object.ReferenceEquals(x, null) ||
                Object.ReferenceEquals(y, null))
                return false;

            return x.TransactionHeaderKey == y.TransactionHeaderKey && x.ChildProduct == y.ChildProduct;
        }
    }
}
