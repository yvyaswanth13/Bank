using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public interface Dao
    {
        public List<SBAccount> getAccDetails();
        public int insertAcc(SBAccount acc);
        public int updateAccDetails(String AccNumber, String Acctype);
        public int deleteAcc(String AccNumber);
        public List<SBAccount> getDisAccDetails();
    }
}
