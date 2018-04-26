using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents a transaction Upload.  This entity pulls from the
    /// "history" table which contains older transfers moved off of the primary table.
    /// </summary>
    public class TransactionUploadHistory : TransactionUploadEntity
    {
        public TransactionUploadHistory() { }
    }
}
