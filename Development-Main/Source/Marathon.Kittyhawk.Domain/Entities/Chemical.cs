using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents a chemical entry.
    /// </summary>
    public class Chemical : Entity
    {
        public Guid? ProductID { get; set; }
        public Guid? ChildProductID { get; set; }
        public int? ChemicalPercentage { get; set; }
        public bool IsDeleted { get; set; }
        public virtual Product Product { get; set; }
        public virtual Product ChildProduct { get; set; }

        public Chemical() { }
    }
}
