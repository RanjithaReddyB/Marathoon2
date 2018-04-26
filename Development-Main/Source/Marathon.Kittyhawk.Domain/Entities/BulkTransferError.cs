using System;
using System.Collections.Generic;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents a bulk transfer error.  This is an aggregate class that
    /// is not persisted to the database, but rather is derived from raw bulk transfer data.
    /// </summary>
    public class BulkTransferError
    {
        public string SourceName { get; set; }
        public DateTime LastTimestamp { get; set; }
        public string Message { get; set; }
        public int Records { get; set; }

        public BulkTransferError() { }
    }

    /// <summary>
    /// Entity class that represents the bulk transfer errors from a particular record.  This class
    /// is used for intermediate processing to create a final list of errors and is not persisted
    /// to the database.
    /// </summary>
    public class RawBulkTransferError
    {
        public string Name { get; set; }
        public DateTime Timestamp { get; set; }
        public List<string> Messages { get; set; }
        public int Count { get; set; }

        public RawBulkTransferError() { }
    }
}
