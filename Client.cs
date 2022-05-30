using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankLibrary;
using BankDao;

namespace BankApp
{
    public class Client
    {
        enum typeAcc
        {
            Savings,
            Current
        };
        public SBAccount sBAccount;
        public static void Main()
        {

            
           // AccServ accServ = new AccServ();
            IDao d =new DaoImpl();
            //foreach (var acc in accServ.getDetails())
            foreach (var acc in d.getAccDetails())
            {
                Console.WriteLine("AccNO :" + acc.GetAccountNumber());
                //Console.WriteLine("AccHolderName :" + AccountHolderName);
                //Console.WriteLine("AccType :" + TypeofAccount);
                //Console.WriteLine("DOC :" + DateofCreation);
                //Console.WriteLine("Balance :" + Balance);
            }
           
            //int v = accServ.insertAcc(new SBAccount("100", "Roja", "Savings", DateTime.Now, 32000));

            Bank b = new IBank();
            Console.WriteLine("1.With Draw \n 2.Loan eligibility ");
            int input= Convert.ToInt32(Console.ReadLine());
            string accNo;
            if(input==1)
            {
                Console.WriteLine("Enter AccNo and Amount");
                accNo = Console.ReadLine();
                int amount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(b.withDraw(amount, accNo));
            }
            else if(input == 2)
            {
                Console.WriteLine("Enter AccNo , Amount and age");
                accNo = Console.ReadLine();
                int amount = Convert.ToInt32(Console.ReadLine());
                int age = Convert.ToInt32(Console.ReadLine());
                if (b.LoanEligibility(amount,age,accNo))
                {
                    Console.WriteLine("You Are Eligible");
                }
                else
                {
                    Console.WriteLine("Not Eligible");
                }
            }
            else
            {
                Console.WriteLine("wrong Input");
            }


            //int affected = accServ.updateAccDetails("100", "Current");
            // int delAff = accServ.deleteAcc("23156");
            //*************************************************************************************
            //    /*

            //    /*
            //     * List<SBAccount> sba = SBAccount.getAccountDetails();
            //foreach (SBAccount sbac in sba)
            //{

            //  //  Console.WriteLine(sbac.ToString());
            //    sbac.showAccountDetails();
            //    Console.WriteLine();

            //}
            //Console.WriteLine("Enter AccNo for Banking");
            //String AccNo = Console.ReadLine();
            //int WD;


            //try
            //{
            //    int AccNF = 0;
            //    foreach (SBAccount sbac in sba)
            //    {
            //        if (sbac.AccountNumber.Equals(AccNo))
            //        {
            //            AccNF++;
            //            Console.WriteLine("");
            //            Console.WriteLine(sbac.ToString());
            //            Console.WriteLine("Your AccNo for Banking :" + sbac.AccountNumber);
            //            Console.WriteLine("EnterBalance to withDraw");
            //            WD = Convert.ToInt32(Console.ReadLine());
            //            if(WD < 0)
            //            {
            //                throw new Exception("Transaction Fail");
            //            }
            //            if (WD < sbac.Balance)
            //            {
            //                Console.WriteLine("Your Transaction Successful");

            //                Console.WriteLine("Availble Balance : " + (sbac.Balance - WD));
            //            }
            //            else
            //            {
            //                Console.WriteLine("Insufficent Balance");
            //            }


            //        }
            //        //else
            //        //{
            //        //    Console.WriteLine("Wrong AccNO Transaction Failed");
            //        //    continue;
            //        //}
            //    }
            //    if(AccNF==0)
            //    {
            //        throw new AccountNoNotFound("AccountNo Not Exists");
            //    }
            //}
            //catch (AccountNoNotFound e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);

            //}


            ////  Console.WriteLine(sbac.ToString());




            // *  */
            //   //FileStream f = new FileStream("sample1.txt", FileMode.Append, FileAccess.Write);

            //    string[] lines = File.ReadAllLines("sample.txt");

            //    List<SBAccount> result = new List<SBAccount>();
            //    try
            //    {
            //        foreach (var lin in lines)
            //        {
            //            SBAccount sbaccount = new SBAccount();
            //            string[] s = lin.Split(",");
            //            sbaccount.Balance = Convert.ToInt32(s[4]);
            //            sbaccount.SetAccountNumber(s[0]);
            //            sbaccount.DateofCreation = DateTime.Now;
            //            sbaccount.AccountHolderName = s[1];

            //            result.Add(sbaccount);
            //        }
            //        SBAccount sa;

            //        String ta;
            //        bool exists;

            //        foreach (SBAccount li in result)
            //        {
            //            Console.WriteLine("Enter Tyoe Of Account");

            //            ta = Console.ReadLine();
            //            exists = Enum.IsDefined(typeof(typeAcc), value: ta);

            //            if (exists)
            //            {



            //                sa = new SBAccount(li.GetAccountNumber(), li.AccountHolderName, ta, li.DateofCreation, li.Balance);

            //                sa.showAccountDetails();

            //                SBTransaction sb = new SBTransaction();
            //                Console.WriteLine("Enter Transaction Amount should be Lessthan Balance");
            //                sb.getTransaction();
            //                sb.SetTransactionID("1912");
            //                sb.SetTransactionDate(DateTime.Now);
            //                sb.SetTAccountNumber(sa.GetAccountNumber());
            //                sb.SetNewBalance(sa.Balance);
            //                sb.showTransaction();
            //                Bank b = new IBank();
            //                Console.WriteLine("Enter Expecting loan Amount age ");
            //                int amount = Convert.ToInt32(Console.ReadLine());
            //                int age = Convert.ToInt32(Console.ReadLine());
            //                if (b.LoanEligibility(amount, age, sa.Balance))
            //                {

            //                    Console.WriteLine("YOu Intrest for month would be :" + b.emi(amount, 2, 2));
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Not Eligible For Loan");
            //                }

            //            }
            //            else
            //            {
            //                throw new AccountNoNotFound("Account Not Found");
            //            }
            //        }
            //    }
            //    catch (AccountNoNotFound ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //*************************************************************************************



        }
    }
}
