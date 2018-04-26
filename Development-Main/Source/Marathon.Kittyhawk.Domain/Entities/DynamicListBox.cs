namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// DynamicListBox Entity
    /// </summary>
    public class DynamicListBox : Entity
    {
        public int DynamicListBoxKey { get; set; }
        public string Qualifier { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Abbreviation { get; set; }
        public int Order { get; set; }
        public string TableType { get; set; }
        public string Status { get; set; }
        public bool IsDeleted { get; set; }
        public DynamicListBox() { }
    }
}
