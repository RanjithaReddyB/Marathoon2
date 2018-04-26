namespace Marathon.Kittyhawk.Domain.Entities
{
    public class PriceService : Entity
    {
        public int PriceServiceKey { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public bool IsDeleted { get; set; }

        public PriceService() { }        
    }
}
