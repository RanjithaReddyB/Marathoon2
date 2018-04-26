using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents a bulk transfer.  This entity pulls from the
    /// "history" table which contains older transfers moved off of the primary table.
    /// </summary>
    public class BulkTransferHistory : BulkTransferEntity
    {
        public BulkTransferHistory() { }
    }
}
