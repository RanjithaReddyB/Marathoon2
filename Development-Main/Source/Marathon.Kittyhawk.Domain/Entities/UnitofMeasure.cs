using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents unit of measure.
    /// </summary>
    public class UnitofMeasure : Entity
    {
        public int UOMKey { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public bool? Vehicle { get; set; }
        public string TerminalUOM { get; set; }
        public bool IsDeleted { get; set; }

		public UnitofMeasure() { }
    }
}







