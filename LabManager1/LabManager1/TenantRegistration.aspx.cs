using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using DataAccess;

namespace LabManager
{
    public partial class TenantRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {           
            if (!IsPostBack)
            {

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string Name = TextBoxUN.Text;
            //int MN = TextBoxMN.Text;
            string Email = txtEmail.Text;
            string pwd = txtpwd.Text;
            string cwd = txtconfirmPWD.Text;
            string Gender = ddlGender.Text;
            string Addr = TextBoxAddr.Text;
            BAL obj = new BAL();
            int n = obj.Balinsert(Name, Email, pwd, cwd, Gender, Addr);
            if (n > 0)
            {
                Response.Write("Registration Successfull");
            }
            else
            {
                Response.Write("Registration is not Successfull");
            }


        }
    }
}