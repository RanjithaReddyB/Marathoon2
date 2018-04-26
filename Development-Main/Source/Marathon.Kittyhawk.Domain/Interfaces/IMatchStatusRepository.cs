using Marathon.Kittyhawk.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    public interface IMatchStatusRepository : IRepository<MatchStatus>
    {
        List<MatchStatus> GetAll(int minRowNumber = 0);
        int GetRowNumberById(Guid id);
    }
}
