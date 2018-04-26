namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents an IBEX transaction.  This entity pulls from the
    /// "history" table which contains older transfers moved off of the primary table.
    /// </summary>
    public class IBEXTransactionHistory : IBEXTransactionEntity
    {
        public IBEXTransactionHistory() { }
    }
}
