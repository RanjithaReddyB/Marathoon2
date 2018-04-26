using System;
using System.Collections.Generic;

namespace Marathon.Kittyhawk.Domain
{
    public class MovementExpenseKeys : IEqualityComparer<MovementExpenseKeys>
    {
        public int MovementExpenseKey { get; set; }
        public int? MovementExpenseLogKey { get; set; }
        
        public int GetHashCode(MovementExpenseKeys obj)
        {
            return obj.MovementExpenseKey.GetHashCode() ^ obj.MovementExpenseLogKey.GetHashCode();
        }

        public bool Equals(MovementExpenseKeys x, MovementExpenseKeys y)
        {
            if (Object.ReferenceEquals(x, y)) return true;

            if (Object.ReferenceEquals(x, null) ||
                Object.ReferenceEquals(y, null))
                return false;

            return x.MovementExpenseKey == y.MovementExpenseKey && x.MovementExpenseLogKey == y.MovementExpenseLogKey;
        }
    }
}
