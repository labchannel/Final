using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StaffWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Serviceforstaff : IServiceforstaff
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
     public StaffData GetstaffId(int value)
        {
            string constr = ConfigurationManager.ConnectionStrings["cn1"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("Select * FROM aspnet_Employee WHERE CustomerId = @CustomerId");

            cmd.Parameters.AddWithValue("@CustomerId", value);
            cmd.Connection = con;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            StaffData StaffTable = new StaffData();
            da.Fill(ds);
            con.Close();
            return StaffTable;
        }

        public StaffData StaffDetails(int staffId)
        {
            string constr = ConfigurationManager.ConnectionStrings["cn1"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("Select * FROM aspnet_Employee WHERE EId = @CustomerId");

            cmd.Parameters.AddWithValue("@CustomerId", staffId);
            cmd.Connection = con;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            StaffData StaffTable = new StaffData();
            da.Fill(StaffTable.StaffSet);
            con.Close();
            return StaffTable;
        }
    }
}
