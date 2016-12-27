using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabManager1.Tenanat
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string EmployeeName = txtEmpName.Text;
            string EmployeeAddress = txtEmpAddr.Text;
            string EmployeeEmail = txtEmpEmail.Text;
            BAL obj = new BAL();
            int n = obj.Balinsert2(EmployeeName, EmployeeAddress, EmployeeEmail);
            if (n > 0)
            {
                Response.Write("Registration Successfull");
               Response.Redirect("tenantpage.aspx");
            }
            else
            {
                Response.Write("Registration is not Successfull");

            }

        }


    }
}