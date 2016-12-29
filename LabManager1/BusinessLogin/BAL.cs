using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DataAccess.DAL;
using System.Web.Security;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;



namespace System.BusinessLogic.BAL
{/// <summary>
/// BAL
/// </summary>
    public class BAL
    {
        string constr = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
       



        public void CreateTenants()
        {
            try
            {
                //create instance of DAL obj
                //call the open passing the correct connection str
                //call the appropriate dal method
                //
            }
            catch (Exception ex)
            {

            }
            finally
            {
                //call the dal obj close
            }
        }

        public int balCreateTenant(Guid membershipUser, string gender, string addr, string street, string city, string state, int pin, string mN)
        {

            DAL obj = new DAL();

            try
            {
                obj.Open();

                return obj.CreateTenant(membershipUser, gender, addr, street, city, state, pin, mN);

            }
            catch (Exception ex)
            {
                return 0;
                throw ex;
            }
            finally
            {

                obj.Close();

            }
        }
        public int BalCreateRestDet(string ResName, string ResAddr, string ManagerName, string ManagerAddr, string ManagerEmail, string DateOfBirth)
        {
            DAL obj = new DAL();
            try {
                obj.Open();

                return obj.CreateRestDet(ResName, ResAddr, ManagerName, ManagerAddr, ManagerEmail, DateOfBirth); 
             }
            catch (Exception ex)
            {
                return 0;
                throw ex;
            }
            finally
            {

                obj.Close();

            }
        }



        public int BalCreateEmpDet(string EmployeeName, string EmployeeAddress, string EmployeeEmail)
        {
            DAL obj = new DAL();
            try {
                obj.Open();

                return obj.CreateEmpDet(EmployeeName, EmployeeAddress, EmployeeEmail);
                 }
            catch (Exception ex)
            {
                return 0;
                throw ex;
            }
            finally
            {

                obj.Close();

            }
        }
        public int grdupd(string email, int userid)
        {
            DAL obj = new DAL();
            try
            {
                obj.Open();

                return obj.dalgrdupd(email, userid);
    }
    catch (Exception ex)
    {
        return 0;
        throw ex;
    }
    finally
    {

        obj.Close();

    }
}

        public DataSet Balgrdbind(string name)
        {
            DAL obj = new DAL();
            try
            {
                obj.Open();

                return obj.dalgrdbnd(name);

            }
              catch (Exception ex)
                {
       
                 throw ex;
                  }
              finally
              {

                 obj.Close();

    }
}

        public int BALgrddel(int id)
        {
            DAL obj = new DAL();
            try
            {
                obj.Open();

                return obj.dalgrddel(id);
    }
    catch (Exception ex)
    {
        return 0;
        throw ex;
    }
    finally
    {

        obj.Close();

    }
}

        public int balgrdnewsel(string name)
        {
            DAL obj = new DAL();
            try
            {
                obj.Open();

                return obj.dalgrdnewselres(name);
    }
    catch (Exception ex)
    {
        return 0;
        throw ex;
    }
    finally
    {

        obj.Close();

    }
}

        public int balinstemp(string name, string textadd, string textemail, int mrid)
        {
            DAL obj = new DAL();
            try
            {
                obj.Open();


                return obj.dalinstnewEmp(name, textadd, textemail, mrid);
    }
    catch (Exception ex)
    {
        return 0;
        throw ex;
    }
    finally
    {

        obj.Close();

    }
}
    }
}
