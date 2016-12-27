using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DataAccess.DAL;
using System.Web.Security;


namespace BusinessLogic
{
    public class BAL
    {


        public int insert(Guid membershipUser, string gender, string addr, string street, string city, string state, int pin, int mN)
        {
            DAL obj = new DAL();

            try {
                return obj.insert(membershipUser, gender, addr, street, city, state, pin, mN);
            }
            catch (Exception ex)
            {
                return 0;
                //   throw new NotImplementedException();
            }
        }
        public int Balinsert1(string ResName, string ResAddr, string ManagerName, string ManagerAddr, string ManagerEmail, string DateOfBirth)
        {
            DAL obj = new DAL();
            return obj.dalinsert1(ResName, ResAddr, ManagerName, ManagerAddr, ManagerEmail, DateOfBirth);
        }
        public int Balinsert2(string EmployeeName, string EmployeeAddress, string EmployeeEmail)
        {
            DAL obj = new DAL();
            return obj.dalinsert2(EmployeeName, EmployeeAddress, EmployeeEmail);
        }
        

    }
}
