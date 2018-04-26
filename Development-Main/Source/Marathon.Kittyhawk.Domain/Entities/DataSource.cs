namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents a data source.
    /// </summary>
    public class DataSource : Entity
    {
        public string Name { get; set; }
        public string System { get; set; }
        public string Description { get; set; }
        public string DataType { get; set; }
        public string ConnectionType { get; set; }
        public string ConnectionDetail { get; set; }
        public string Schedule { get; set; }

        public DataSource() { }
    }
}
