namespace Marathon.Kittyhawk.Domain.Entities
{
    public class Commodity : Entity
    {
        public int CommodityKey { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public bool IsDeleted { get; set; }

        public Commodity() { }
    }
}