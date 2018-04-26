using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the movement repository.
    /// </summary>
    public interface IMovementRepository : IRepository<Movement>
    {
        Movement GetByMovementDocumentKeyAndMovementHeaderKey(int movementDocumentKey, int movementHeaderKey);
    }
}
