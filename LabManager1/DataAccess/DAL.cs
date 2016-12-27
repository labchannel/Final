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
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        public int insert(Guid membershipUser, string gender, string addr, string street, string city, string state, int pin, int mN)
        {

             //  SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
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

        public int dalinsert1(string ResName, string ResAddr, string ManagerName, string ManagerAddr, string ManagerEmail, string DateOfBirth)
        {
            try
            {
                //SqlConnection con = new SqlConnection();
               // con.ConnectionString = "Data Source=LC_BLR_DEV_02\\SQLEXPRESS;Initial Catalog=aspnetdb;integrated security=true";
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO[dbo].[aspnet_tenantData] ([RName],[RAddress],[MName] ,[MAddress]," +
                     "[MEmail],[DOB])" +
                      " Values(@ResName,@ResAddr,@ManagerName,@ManagerAddr, @ManagerEmail, @DateOfBirth)", conn);
                cmd.Parameters.AddWithValue("@ResName", ResName.Trim());
                cmd.Parameters.AddWithValue("@ResAddr", ResAddr.Trim());
                cmd.Parameters.AddWithValue("@ManagerName", ManagerName.Trim());
                cmd.Parameters.AddWithValue("@ManagerAddr", ManagerAddr.Trim());
                cmd.Parameters.AddWithValue("@ManagerEmail", ManagerEmail.Trim());
                cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth.Trim());
                int n = cmd.ExecuteNonQuery();
                conn.Close();
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
        public int dalinsert2(string EmployeeName, string EmployeeAddress, string EmployeeEmail)
        {
            try
            {
             
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO[dbo].[aspnet_Employee] ([EName],[EAddress],[EEmail])" +
                       " Values(@EmployeeName,@EmployeeAddress,@EmployeeEmail)", conn);
                cmd.Parameters.AddWithValue("@EmployeeName", EmployeeName.Trim());
                cmd.Parameters.AddWithValue("@EmployeeAddress", EmployeeAddress.Trim());
                cmd.Parameters.AddWithValue("@EmployeeEmail", EmployeeEmail.Trim());
                int n = cmd.ExecuteNonQuery();
                conn.Close();
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



        /*  public MyMembershipUser CreateUser(string Name, string Email, string pwd, int Mn, string Gender, string Addr) { 
 SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

     con.Open();
     SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[aspnet_Membership]([UserId],[Password],[MobilePIN],[Email],[Gender],[Address])VALUES(?,?,?,?,?,?)) ", con);

     cmd.Parameters.AddWithValue("@Name", Name);
     cmd.Parameters.AddWithValue("@pwd", pwd);
     cmd.Parameters.AddWithValue("@Mobilenum", Mn);
     cmd.Parameters.AddWithValue("@Email", Email);
     cmd.Parameters.AddWithValue("@Gender", Gender);
     cmd.Parameters.AddWithValue("@Addr", Addr);
     int n = cmd.ExecuteNonQuery();
     con.Close();
    

 }*/


     