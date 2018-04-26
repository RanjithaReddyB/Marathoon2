using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents an IBEX transaction error.  This is an aggregate class that
    /// is not persisted to the database, but rather is derived from raw transaction data.
    /// </summary>
    public class IBEXTransactionError
    {
        public DateTime LastTimestamp { get; set; }
        public string Message { get; set; }
        public int Records { get; set; }

        public IBEXTransactionError() { }
    }
}
