using System;
using System.Collections.Generic;

namespace Marathon.Kittyhawk.Domain
{
    public class AccountingTransactionKeys : IEqualityComparer<AccountingTransactionKeys>
    {
        public int AccountDetailKey { get; set; }
        public int? AccountCodeKey { get; set; }
        public int? AccountCodeLogKey { get; set; }
        public int? ChildProduct { get; set; }
        
        public int GetHashCode(AccountingTransactionKeys obj)
        {
            return obj.AccountDetailKey.GetHashCode() ^ obj.AccountCodeKey.GetHashCode() ^ obj.AccountCodeLogKey.GetHashCode() ^ obj.ChildProduct.GetHashCode();
        }

        public bool Equals(AccountingTransactionKeys x, AccountingTransactionKeys y)
        {
            if (Object.ReferenceEquals(x, y)) return true;

            if (Object.ReferenceEquals(x, null) ||
                Object.ReferenceEquals(y, null))
                return false;

            return x.AccountDetailKey == y.AccountDetailKey && x.AccountCodeKey == y.AccountCodeKey && x.AccountCodeLogKey == y.AccountCodeLogKey && x.ChildProduct == y.ChildProduct;
        }
    }
}
