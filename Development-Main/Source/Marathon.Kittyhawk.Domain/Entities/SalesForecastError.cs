using System;
using System.Collections.Generic;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents an Sales Forecast transaction error.  This is an aggregate class that
    /// is not persisted to the database, but rather is derived from raw transaction data.
    /// </summary>
    public class SalesForecastError
    {
        public DateTime LastTimestamp { get; set; }
        public string Message { get; set; }
        public int Records { get; set; }
        public SalesForecastError() { }
    }

    /// <summary>
    /// Entity class that represents the Sales forecast errors from a particular record.  This class
    /// is used for intermediate processing to create a final list of errors and is not persisted
    /// to the database.
    /// </summary>
    public class RawSalesForecastError
    {
        public DateTime Timestamp { get; set; }
        public List<string> Messages { get; set; }
        public int Count { get; set; }

        public RawSalesForecastError() { }
    }
}
