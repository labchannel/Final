using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Security;


namespace System.DataAccess.DAL
{
    public class DAL: MembershipUser
    {

   
        public int createUser(string Name, string Email, string pwd, string cwd, string Gender, string Addr)
        {
            SqlConnection con = new SqlConnection();
           // con.ConnectionString = con;
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into men ", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", Name);
            //cmd.Parameters.AddWithValue("@Mobilenum", MN);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@pwd", pwd);
            cmd.Parameters.AddWithValue("@Cwd", cwd);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@Addr", Addr);
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
    }
}

