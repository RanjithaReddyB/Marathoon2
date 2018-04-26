using System;

namespace Marathon.Kittyhawk.Domain.Entities
{
    /// <summary>
    /// Entity class that represents a message queue.
    /// </summary>
    public class Message : Entity
    {
        public string ProcessIdentifier { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Data { get; set; }

        public Message() { }
    }
}
