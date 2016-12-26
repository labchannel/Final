using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Security;
using System.Configuration;


namespace System.DataAccess.DAL
{
    public class DAL
    {
        private MembershipCreateStatus status;
        public int insert(Guid membershipUser, string gender, string addr, string street, string city, string state, int pin, int mN)
        {

               SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
                SqlCommand cmd = new SqlCommand("INSERT INTO[dbo].[aspnet_profileData] ([UserId],[Address],[street] ,[city],"+
                    "[ZipCode],[State],[Gender],[mobile])"+
                     " Values(@PKID,@adder,@street,@city,@pin,@state,@Ugender,@mobile)", conn);

                cmd.Parameters.Add("@PKID", SqlDbType.UniqueIdentifier).Value = membershipUser;
            cmd.Parameters.Add("@adder", SqlDbType.VarChar, 255).Value = addr;
            cmd.Parameters.Add("@street", SqlDbType.VarChar, 128).Value = street;
          
            cmd.Parameters.Add("@city", SqlDbType.VarChar, 255).Value = city;
            cmd.Parameters.Add("@pin", SqlDbType.Int).Value = pin;
            cmd.Parameters.Add("@state", SqlDbType.VarChar, 255).Value = state;
            cmd.Parameters.Add("@Ugender", SqlDbType.VarChar, 255).Value = gender;
           
                cmd.Parameters.Add("@mobile", SqlDbType.Int).Value = mN;

          
                conn.Open();

            int n=1;
             cmd.ExecuteNonQuery();
            cmd.Dispose();
            if (n > 0)
            {
               // status = MembershipCreateStatus.Success;
                return n;
            }
            else
            {
               // status = MembershipCreateStatus.UserRejected;
                return n;
            }



        }
        public int insert1(string ResName, string ResAddr, string ManagerName, string ManagerAddr, string ManagerEmail, string DateOfBirth)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LC_BLR_DEV_02\\SQLEXPRESS;Initial Catalog=aspnetdb;integrated security=true";
                con.Open();
                SqlCommand cmd = new SqlCommand("GetTenant", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ResName", ResName.Trim());
                cmd.Parameters.AddWithValue("@ResAddr", ResAddr.Trim());
                cmd.Parameters.AddWithValue("@ManagerName", ManagerName.Trim());
                cmd.Parameters.AddWithValue("@ManagerAddr", ManagerAddr.Trim());
                cmd.Parameters.AddWithValue("ManagerEmail", ManagerEmail.Trim());
                cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth.Trim());
                int n = cmd.ExecuteNonQuery();
                con.Close();
                if (n > 0)
                {
                    return n;
                }
                else
                {
                    return n;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public int insert2(string EmployeeName, string EmployeeAddress, string EmployeeEmail)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LC_BLR_DEV_02\\SQLEXPRESS;Initial Catalog=aspnetdb;integrated security=true";
                con.Open();
                SqlCommand cmd = new SqlCommand("Employee1", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeName", EmployeeName.Trim());
                cmd.Parameters.AddWithValue("@EmployeeAddress", EmployeeAddress.Trim());
                cmd.Parameters.AddWithValue("@EmployeeEmail", EmployeeEmail.Trim());
                int n = cmd.ExecuteNonQuery();
                con.Close();
                if (n > 0)
                {
                    return n;
                }
                else
                {
                    return n;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }   
}

}



     