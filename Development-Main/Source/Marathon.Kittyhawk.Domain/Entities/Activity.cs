using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents integration activity.
    /// </summary>
    public class Activity : Entity
    {
        public Guid DataSourceID { get; set; }
        public virtual DataSource DataSource { get; set; }
        public string ActivityType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double? Duration { get; set; }
        public string DurationUnit { get; set; }
        public int? RecordsProcessed { get; set; }
        public int? DirtyRecords { get; set; }
        public string Marker { get; set; }

        public Activity() { }
    }
}
