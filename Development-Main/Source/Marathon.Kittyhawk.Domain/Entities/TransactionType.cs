namespace Marathon.Kittyhawk.Domain.Entities
{
    public class TransactionType : Entity
    {
        public int TransactionTypeKey { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Category { get; set; }
        public bool IsDeleted { get; set; }
        public string TransactionGroups { get; set; }
        
    }
}
