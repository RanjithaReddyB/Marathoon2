using System;
using System.Collections.Generic;

namespace Marathon.Kittyhawk.Domain
{
    public class InventorySubledgerKeys : IEqualityComparer<InventorySubledgerKeys>
    {
        public int InventorySubledgerKey { get; set; }

        public int GetHashCode(InventorySubledgerKeys obj)
        {
            return obj.InventorySubledgerKey.GetHashCode();
        }

        public bool Equals(InventorySubledgerKeys x, InventorySubledgerKeys y)
        {
            if (Object.ReferenceEquals(x, y)) return true;

            if (Object.ReferenceEquals(x, null) ||
                Object.ReferenceEquals(y, null))
                return false;

            return x.InventorySubledgerKey == y.InventorySubledgerKey;
        }
    }
}
