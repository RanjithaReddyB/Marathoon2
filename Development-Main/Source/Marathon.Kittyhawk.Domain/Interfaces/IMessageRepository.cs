using System.Collections.Generic;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the message queue repository.
    /// </summary>
    public interface IMessageRepository : IRepository<Message>
    {
        bool HasQueuedMessages(string dataType);
        int GetQueuedMessageCount(string dataType);
        Message GetNextMessage(string dataType);
        void ResetMessageStatus(string dataType);
        List<Message> GetByProcessIdentifier(string processIdentifier);
        List<Message> GetMessages();
    }
}
