using System;
using System.Collections.Generic;

namespace Marathon.Kittyhawk.Domain
{
    public class MonthEndInventoryKeys : IEqualityComparer<MonthEndInventoryKeys>
    {
        public int InventorySubledgerKey { get; set; }
        
        public int GetHashCode(MonthEndInventoryKeys obj)
        {
            return obj.InventorySubledgerKey.GetHashCode();
        }

        public bool Equals(MonthEndInventoryKeys x, MonthEndInventoryKeys y)
        {
            if (Object.ReferenceEquals(x, y)) return true;

            if (Object.ReferenceEquals(x, null) ||
                Object.ReferenceEquals(y, null))
                return false;

            return x.InventorySubledgerKey == y.InventorySubledgerKey;
        }
    }
}
