using System.Collections.Generic;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the user repository.
    /// </summary>
    public interface IUserRepository : IRepository<User>
    {
    }
}
