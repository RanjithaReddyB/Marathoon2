using System;
using System.Collections.Generic;

namespace Marathon.Kittyhawk.Domain
{
    public class OrderKeys : IEqualityComparer<OrderKeys>
    {
        public int PlannedMovementKey { get; set; }
                
        public int GetHashCode(OrderKeys obj)
        {
            return obj.PlannedMovementKey.GetHashCode();
        }

        public bool Equals(OrderKeys x, OrderKeys y)
        {
            if (Object.ReferenceEquals(x, y)) return true;

            if (Object.ReferenceEquals(x, null) ||
                Object.ReferenceEquals(y, null))
                return false;

            return x.PlannedMovementKey == y.PlannedMovementKey;
        }
    }
}
