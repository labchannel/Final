using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Security;
using System.Configuration;


namespace System.DataAccess.DAL
{/// <summary>
/// DAL
/// </summary>
    public class DAL
    {
        private MembershipCreateStatus status;

      private  static string constr = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
  
        SqlConnection conn = new SqlConnection(constr);
     
        public void Open()
        {
            
            if (conn.State == ConnectionState.Closed) {
                conn.Open();

            }
            
        }

        public void Close()
        {
            //check if con open, then only close
            
            if (conn.State== ConnectionState.Open)
            { conn.Close();

            }
                

        }
        public int CreateTenant(Guid membershipUser, string gender, string addr, string street, string city, string state, int pin, string mN)
        {
            
            SqlCommand cmd = new SqlCommand("INSERT INTO[dbo].[aspnet_profileData] ([UserId],[Address],[street] ,[city]," +
                    "[ZipCode],[State],[Gender],[mobile])" +
                     " Values(@PKID,@adder,@street,@city,@pin,@state,@Ugender,@mobile)", conn);

            cmd.Parameters.Add("@PKID", SqlDbType.UniqueIdentifier).Value = membershipUser;
            cmd.Parameters.Add("@adder", SqlDbType.VarChar, 255).Value = addr;
            cmd.Parameters.Add("@street", SqlDbType.VarChar, 128).Value = street;

            cmd.Parameters.Add("@city", SqlDbType.VarChar, 255).Value = city;
            cmd.Parameters.Add("@pin", SqlDbType.Int).Value = pin;
            cmd.Parameters.Add("@state", SqlDbType.VarChar, 255).Value = state;
            cmd.Parameters.Add("@Ugender", SqlDbType.VarChar, 255).Value = gender;

            cmd.Parameters.Add("@mobile", SqlDbType.VarChar, 50).Value = mN;




            int n = 1;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
           // obj.closeCon(conn);
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

        public int CreateRestDet(string ResName, string ResAddr, string ManagerName, string ManagerAddr, string ManagerEmail, string DateOfBirth)
        {
            try

            {
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
                //log
                throw ex;
            }


        }
        public int CreateEmpDet(string EmployeeName, string EmployeeAddress, string EmployeeEmail)
        {
         //   SqlConnection conn = obj.connection();
            try
            {

                //obj.openCon(conn);
                SqlCommand cmd = new SqlCommand("INSERT INTO[dbo].[aspnet_Employee] ([EName],[EAddress],[EEmail])" +
                       " Values(@EmployeeName,@EmployeeAddress,@EmployeeEmail)", conn);
                cmd.Parameters.AddWithValue("@EmployeeName", EmployeeName.Trim());
                cmd.Parameters.AddWithValue("@EmployeeAddress", EmployeeAddress.Trim());
                cmd.Parameters.AddWithValue("@EmployeeEmail", EmployeeEmail.Trim());
                int n = cmd.ExecuteNonQuery();
              //  obj.closeCon(conn);
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

        public int dalgrdupd(string emailadress, int baluserid)
        {
         
            try
            {
              
                SqlCommand cmd = new SqlCommand("update aspnet_Employee set EAddress='" + emailadress + "'where EID='" + baluserid + "'", conn);
                int n = cmd.ExecuteNonQuery();
             
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
        public DataSet dalgrdbnd(string name)
        {
        
            int results = 0;
            SqlCommand cmd = new SqlCommand("SELECT mRID FROM aspnet_manager where MName='" + name + "'", conn);
            SqlDataReader myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                results = Convert.ToInt32(myReader.GetValue(0).ToString());
            }
            int @mrid = results;
            // int @mrid = cmd.ExecuteNonQuery();
            cmd.Dispose();
            myReader.Close();

            SqlDataAdapter da = new SqlDataAdapter("Select EID, EName,EAddress,EEmail from aspnet_Employee where RID='" + @mrid + "'", conn);

            DataSet ds = new DataSet();
            da.Fill(ds);
          //  obj.closeCon(conn);


            return ds;

        }
        public int dalgrddel(int id)
        {
           // SqlConnection conn = obj.connection();
            try
            {
          //      obj.openCon(conn);
                SqlCommand cmd = new SqlCommand("Delete from aspnet_Employee where EID=@id", conn);

                cmd.Parameters.Add("@id", SqlDbType.Int, 32).Value = id;
                int n = cmd.ExecuteNonQuery();
              //  obj.closeCon(conn);

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
        public int dalgrdnewselres(string name)
        {
          
            try
            {
               
                int results = 0;
                SqlCommand cmdR = new SqlCommand("SELECT mRID FROM aspnet_manager where MName='" + name + "'", conn);
                SqlDataReader myReader = cmdR.ExecuteReader();
                while (myReader.Read())
                {
                    results = Convert.ToInt32(myReader.GetValue(0).ToString());
                }
                cmdR.Dispose();
                myReader.Close();
         
                return results;
            }
            catch
            {
                return 0;
            }
        }
        public int dalinstnewEmp(string name, string textadd, string textemail, int mrid)
        {
           
            try
            {
              
                SqlCommand cmd =
                       new SqlCommand(
                       "insert into aspnet_Employee(EName,EAddress,EEmail,RID) values('" + name + "','" +
                       textadd + "','" + textemail + "', @mrid)", conn);
                cmd.Parameters.Add("@mrid", SqlDbType.Int).Value = mrid;
                int results = cmd.ExecuteNonQuery();
                cmd.Dispose();

            
                return results;
            }
            catch
            {
                return 0;
            }
        }
        public SqlDataAdapter dalgetStaffId(int value)
        {
         

            SqlCommand cmd = new SqlCommand("Select * FROM aspnet_Employee WHERE CustomerId = @CustomerId");

            cmd.Parameters.AddWithValue("@CustomerId", value);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();

        
            return da;

        }

    }

}