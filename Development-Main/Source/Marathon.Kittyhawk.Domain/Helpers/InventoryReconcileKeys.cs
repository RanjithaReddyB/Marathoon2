using System;
using System.Collections.Generic;

namespace Marathon.Kittyhawk.Domain
{
    public class InventoryReconcileKeys : IEqualityComparer<InventoryReconcileKeys>
    {
        public int InventoryReconcileKey { get; set; }        

        public int GetHashCode(InventoryReconcileKeys obj)
        {
            return obj.InventoryReconcileKey.GetHashCode();
        }

        public bool Equals(InventoryReconcileKeys x, InventoryReconcileKeys y)
        {
            if (Object.ReferenceEquals(x, y)) return true;

            if (Object.ReferenceEquals(x, null) ||
                Object.ReferenceEquals(y, null))
                return false;

            return x.InventoryReconcileKey == y.InventoryReconcileKey;
        }
    }
}
