namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents a refinery inventory error.
    /// </summary>
    public class RefineryInventoryError : Entity
    {
        public string ProcessIdentifier { get; set; }
        public string Refinery { get; set; }
        public string Tank { get; set; }
        public string Message { get; set; }

        public RefineryInventoryError() { }
    }
}
