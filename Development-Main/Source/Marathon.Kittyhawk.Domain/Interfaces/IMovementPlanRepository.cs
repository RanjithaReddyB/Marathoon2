using System.Collections.Generic;
using Marathon.Kittyhawk.Domain.Entities;
using System;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the movement plan repository.
    /// </summary>
    public interface IMovementPlanRepository : IRepository<MovementPlan>
    {
        MovementPlan GetBySRAID(int ID);
        List<MovementPlan> GetAll(bool loadRelationships);
        List<MovementPlan> GetByTransportTypeProductOriginAndDestination(string transportType, string status, Guid? productId, Guid? originId, Guid? destinationId, DateTime? transferDate);
    }
}
