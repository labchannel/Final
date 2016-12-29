using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.BusinessLogic.BAL;
using System.DataAccess;

using System.Text;

namespace LabManager1.API
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StaffService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select StaffService.svc or StaffService.svc.cs at the Solution Explorer and start debugging.
    public class StaffService : IStaffService
    {
        public void DoWork()
        {
        }

        public string GetData(int value)
        {
            throw new NotImplementedException();
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            throw new NotImplementedException();
        }
        public StaffData GetstaffId(int value)
        {
            string constr = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
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
            string constr = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
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
