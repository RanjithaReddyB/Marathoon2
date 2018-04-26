namespace Marathon.Kittyhawk.Domain.Entities
{
    public class Currency : Entity
    {
        public int CurrencyKey { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public string Symbol { get; set; }
        public int ReadingPrecision { get; set; }
        public bool IsDeleted { get; set; }

        public Currency() { }
    }
}
