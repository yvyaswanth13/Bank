using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace BankApp
{
    public class IDaoImpl : Dao
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public IDaoImpl()
        {

            try
            {
                // Creating Connection  

                con = getCon();
                Console.WriteLine("Connection Established Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
        }

        private static SqlConnection getCon()
        {
            con = new SqlConnection("data source=.; database=eurofins; integrated security=SSPI");
            con.Open();

            return con;
        }
        public int deleteAcc(string AccNumber)
        {

            con = getCon();
            
            cmd = new SqlCommand("DELETE FROM dbo.bank WHERE AccNumber = @AccNumber ", con);
            cmd.Parameters.AddWithValue("@AccNumber", AccNumber);
           
            return cmd.ExecuteNonQuery();
        }

       
        public List<SBAccount> getAccDetails()
        {
            List<SBAccount> sba = new List<SBAccount>();
            try
            {
                con = getCon();
                
                cmd = new SqlCommand("select * from dbo.bank", con);
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    SBAccount ba = new SBAccount();
                    ba.SetAccountNumber(rdr.GetString(1));
                    ba.AccountHolderName = rdr.GetString(2);
                    ba.TypeofAccount = rdr.GetString(3);
                    ba.DateofCreation = DateTime.Now;//DateTime.Parse(rdr.GetString(4));
                    ba.Balance = Convert.ToInt32(rdr.GetString(5));


                    sba.Add(ba);
                }
                return sba;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return sba;
            }
        }

    
    
    


        public int insertAcc(SBAccount acc)
        {
            con = getCon();

           cmd= new SqlCommand("INSERT INTO dbo.bank (AccNumber,AccHolderName,AccType,DateOfCre,Balance) VALUES (@AccNumber,@AccHolderName,@AccType,@DateOfCre,@Balance)", con);

           
            cmd.Parameters.AddWithValue("@AccNumber",acc.GetAccountNumber() );
            cmd.Parameters.AddWithValue("@AccHolderName", acc.AccountHolderName);
            cmd.Parameters.AddWithValue("@AccType", acc.TypeofAccount);
            cmd.Parameters.AddWithValue("@DateOfCre", DateTime.Now.Date);
            cmd.Parameters.AddWithValue("@Balance", acc.Balance);



           return cmd.ExecuteNonQuery();

        }

        public int updateAccDetails(string AccNumber,String Acctype)
        {
            con = getCon();

            cmd = new SqlCommand("Update dbo.bank SET AccType = @AccType WHERE AccNumber = @AccNumber ", con);
            cmd.Parameters.AddWithValue("@AccNumber", AccNumber);
            cmd.Parameters.AddWithValue("@AccType", Acctype);
            return cmd.ExecuteNonQuery();
        }

        public List<SBAccount> getDisAccDetails()
        {
            List<SBAccount> sba = new List<SBAccount>();
            try
            {
                con = getCon();

                cmd = new SqlCommand("select * from dbo.bank", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                
                foreach (DataRow rdr in ds.Tables["dbo.bank"].Rows)
                {
                    SBAccount ba = new SBAccount();
                    ba.SetAccountNumber(rdr[1].ToString());
                    ba.AccountHolderName = rdr[2].ToString();
                    ba.TypeofAccount = rdr[3].ToString();
                    ba.DateofCreation = DateTime.Now;//DateTime.Parse(rdr.GetString(4));
                    ba.Balance = Convert.ToInt32(rdr[5].ToString());


                    sba.Add(ba);
                }
                return sba;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return sba;
            }
        }

    }
}
