using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents an inventory measurement.  This entity pulls from the 
    /// "history" table which contains older measurements moved off of the primary table.
    /// </summary>
    public class InventoryHistory : InventoryEntity
    {
        public InventoryHistory() { }
    }
}
