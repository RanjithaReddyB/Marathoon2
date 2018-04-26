using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents a territory manager.
    /// </summary>
    public class TerritoryManager : Entity
    {
        public string TMCode { get; set; }
        public string TMCodeDescription { get; set; }
        public string SalesArea { get; set; }
        public Guid? ContactID { get; set; }
        public virtual Contact Contact { get; set; }
        public bool IsDeleted { get; set; }

        public TerritoryManager() { }
    }
}


