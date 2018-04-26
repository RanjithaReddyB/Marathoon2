namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents a transport.
    /// </summary>
    public class Transport : Entity
    {
        public string Name { get; set; }
        public string TransportType { get; set; }

        public Transport() { }
    }
}
