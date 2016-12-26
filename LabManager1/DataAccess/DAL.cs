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


     