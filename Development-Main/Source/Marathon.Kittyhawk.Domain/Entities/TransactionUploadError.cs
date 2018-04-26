using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marathon.Kittyhawk.Domain.Entities
{
    public class TransactionUploadError
    {
        /// <summary>
        /// Entity class that represents a transaction upload error.  This is an aggregate class that
        /// is not persisted to the database, but rather is derived from raw transaction upload data.
        /// </summary>     
        public string SourceName { get; set; }
        public DateTime LastTimestamp { get; set; }
        public string Message { get; set; }
        public int Records { get; set; }

        public TransactionUploadError() { }
    }
}


/// <summary>
/// Entity class that represents the bulk transfer errors from a particular record.  This class
/// is used for intermediate processing to create a final list of errors and is not persisted
/// to the database.
/// </summary>
public class RawTransactionUploadError
{
    public DateTime Timestamp { get; set; }
    public List<string> Messages { get; set; }
    public int Count { get; set; }

    public RawTransactionUploadError() { }
}
