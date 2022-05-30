using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class SBAccount
    {
        private string accountNumber;

        public virtual List<SBAccount> Accounts { get; set; }
       
     private readonly CompanyDA _da;
        public SBAccount()
        {
        }

        public static explicit operator SBAccount(List<BankDao.SBAccount> v)
        {
            throw new NotImplementedException();
        }

        public SBAccount(CompanyDA da)
        {
            _da = da;
        }
       
        
        

        public SBAccount(string accountNumber, string accountHolderName, string typeofAccount, DateTime dateofCreation, int balance)
        {
            this.accountNumber = accountNumber;
            this.AccountHolderName = accountHolderName;
            this.TypeofAccount = typeofAccount;
            this.DateofCreation = dateofCreation;
            this.Balance = balance;
        }

        public string GetAccountNumber()
        {
            return accountNumber;
        }

        public void SetAccountNumber(string value)
        {
            accountNumber = value;
        }

        public string AccountHolderName { get; set; }
        public string TypeofAccount { get; set; }
        public DateTime DateofCreation { get; set; }
        public int Balance { get; set; }

        private static readonly List<SBAccount> sBAccounts = new List<SBAccount>();
        public static List<SBAccount> sba = sBAccounts;
        public static List<SBAccount> getAccountDetails()
        {

            sba.Add(new SBAccount("100", "Raja", "Savings", DateTime.Now, 32000));
            sba.Add(new SBAccount("900", "Sita", "Savings", DateTime.Now, 33000));
            sba.Add(new SBAccount("901", "Ram", "Savings", DateTime.Now, 450000));
            sba.Add(new SBAccount("902", "Bobby", "Savings", DateTime.Now, 10000));
            sba.Add(new SBAccount("903", "teja", "Savings", DateTime.Now, 90000));
            return sba;


        }
        public void showAccountDetails()
        {
            Console.WriteLine("AccNO :" + accountNumber);
            Console.WriteLine("AccHolderName :" + AccountHolderName);
            Console.WriteLine("AccType :" + TypeofAccount);
            Console.WriteLine("DOC :" + DateofCreation);
            Console.WriteLine("Balance :" + Balance);
        }
        public List<SBAccount> GetByType(string type_1)
        {
            List<SBAccount> result = new List<SBAccount>();

            foreach (SBAccount acc in _da.GetAccounts())
            {
                if (acc.TypeofAccount.Equals(type_1))
                {
                    result.Add(acc);
                }
            }
           
            return result;
        }
        public String GetById(String Id)
        {
            string result = null ;
            foreach (SBAccount acc in _da.GetAccounts())
            {
                if (acc.GetAccountNumber().Equals(Id))
                {
                    result = acc.AccountHolderName;
                }
            }
            return result;
        }
        public override string? ToString()
        {
            return String.Format("ACCNo: "+accountNumber + "  AccHolderName: " + AccountHolderName + "\tAccType: " + TypeofAccount + "\tDOC :" + DateofCreation + "\tBalance: " + Balance);
        }

      
    }

   
}