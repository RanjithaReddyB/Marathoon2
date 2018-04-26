using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents a position group entry.
    /// </summary>
    public class PositionGroup : Entity
    {
        public int PositionGroupKey { get; set; }
        public Guid? ProductID { get; set; }
        public Guid? LocationID { get; set; }
        public virtual Product Product { get; set; }
        public virtual Location Location { get; set; }
        public int? Depth { get; set; }
        public int? TopLevelID { get; set; }
        public int? BottomLevelID { get; set; }
        public int? Level1ID { get; set; }
        public int? Level2ID { get; set; }
        public int? Level3ID { get; set; }
        public int? Level4ID { get; set; }
        public int? Level5ID { get; set; }
        public string TopLevelName { get; set; }
        public string BottomLevelName { get; set; }
        public string Level1Name { get; set; }
        public string Level2Name { get; set; }
        public string Level3Name { get; set; }
        public string Level4Name { get; set; }
        public string Level5Name { get; set; }
        public bool IsDeleted { get; set; }

        public PositionGroup() { }
    }
}
