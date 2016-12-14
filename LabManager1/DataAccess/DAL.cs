using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccess
{
    public class DAL
    {
        public int insert(string Name, string Email, string pwd, string cwd, string Gender, string Addr)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LC_BLR_DEV_02\\SQLEXPRESS;Initial Catalog=LManager;integrated security=true";
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Email from Registration1 where Email=@Email", con);
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

