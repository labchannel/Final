using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class BAL
    {
        public int Balinsert(string Name, string Email, string pwd, string cwd, string Gender, string Addr)
        {
            DAL obj = new DAL();
            return obj.insert(Name, Email, pwd, cwd, Gender, Addr);
        }
    }
}
