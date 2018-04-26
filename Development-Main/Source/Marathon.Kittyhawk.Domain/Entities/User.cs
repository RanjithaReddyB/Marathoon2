namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents a user.
    /// </summary>
    public class User : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool FeedsOutOfDate { get; set; }
        public bool BulkTransferErrors { get; set; }
        public bool InventoryErrors { get; set; }
        public bool IBEXTransactionErrors { get; set; }

        public User() { }
    }
}
