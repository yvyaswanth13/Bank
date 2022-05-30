using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class CompanyDA
    {
        private List<SBAccount>? accounts;

        public virtual List<SBAccount> GetAccounts()
        {
            return accounts;
        }

        public virtual void SetAccounts(List<SBAccount> value)
        {
            accounts = value;
        }

    }
}
