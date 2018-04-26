namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents a vehicle.
    /// </summary>
    public class Vehicle : Entity
    {
        public int VehicleKey { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double MaxQuantity { get; set; }
        public int? YearBuilt { get; set; }
        public string Comments { get; set; }
        public bool IsDeleted { get; set; }

        public Vehicle() { }
    }
}
