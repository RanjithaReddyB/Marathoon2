using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
	/// <summary>
	/// Entity class that represents a container.
	/// </summary>
	public class Container : Entity
	{
		public int ContainerKey { get; set; }
		public string Name { get; set; }
		public virtual Location Location { get; set; }
		public Guid? LocationID { get; set; }
		public string Status { get; set; }
		public double? Capacity { get; set; }
		public virtual UnitofMeasure CapacityUOM { get; set; }
		public Guid? CapacityUOMID { get; set; }
		public double? Bottom { get; set; }
		public virtual UnitofMeasure BottomUOM { get; set; }
		public Guid? BottomUOMID { get; set; }
		public double? Target { get; set; }
		public virtual UnitofMeasure TargetUOM { get; set; }
		public Guid? TargetUOMID { get; set; }
		public bool IsOutOfService { get; set; }
		public bool IsRackTank { get; set; }
		public bool IsPhysical { get; set; }
		public bool IsManifold { get; set; }
		public bool IsGaugeManual { get; set; }
		public bool IsDeleted { get; set; }

		public Container() { }
	}
}
