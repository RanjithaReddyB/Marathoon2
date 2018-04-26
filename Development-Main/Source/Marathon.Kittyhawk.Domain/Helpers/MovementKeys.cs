using System;
using System.Collections.Generic;

namespace Marathon.Kittyhawk.Domain
{
    public class MovementKeys : IEqualityComparer<MovementKeys>
    {
        public int MovementDocumentKey { get; set; }
        public int MovementHeaderKey { get; set; }
        
        public int GetHashCode(MovementKeys obj)
        {
            return obj.MovementDocumentKey.GetHashCode() ^ obj.MovementHeaderKey.GetHashCode();
        }

        public bool Equals(MovementKeys x, MovementKeys y)
        {
            if (Object.ReferenceEquals(x, y)) return true;

            if (Object.ReferenceEquals(x, null) ||
                Object.ReferenceEquals(y, null))
                return false;

            return x.MovementDocumentKey == y.MovementDocumentKey && x.MovementHeaderKey == y.MovementHeaderKey;
        }        
    }
}
