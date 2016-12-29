using System.BusinessLogic.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace LabManager1
{
    public partial class tenantpage : System.Web.UI.Page
    {
       

            protected void Page_Load(object sender, EventArgs e)
            {
                    Gridview1.Visible = true;
            string un= Session["username"].ToString();
            
            
             
            }

            protected void Button1_Click(object sender, EventArgs e)
            {
                string ResName = txtResname.Text;
                string ResAddr = txtResaddr.Text;
                string ManagerName = txtMN.Text;
                string ManagerAddr = txtMA.Text;
                string ManagerEmail = txtMEmail.Text;
                string DateOfBirth = txtDOB.Text;
                BAL obj = new BAL();
                int n = obj.BalCreateRestDet(ResName, ResAddr, ManagerName, ManagerAddr, ManagerEmail, DateOfBirth);
                if (n > 0)
                {
                    Response.Write("Registration Successfull");
                }
                else
                {
                    Response.Write("Registration is not Successfull");
                }

            }

            protected void Button1_Click1(object sender, EventArgs e)
            {

            }
            protected void Calendar1_SelectionChanged(object sender, EventArgs e)
            {
                txtDOB.Text = Calendar1.SelectedDate.ToString("dd MMMM-yyyy");
                Calendar1.Visible = false;
            }

            protected void btnDate_Click(object sender, EventArgs e)
            {
                Calendar1.Visible = true;
            }

        protected void Button2_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Roles.DeleteCookie();
            Session.Clear();
            Response.Redirect("~/Login.aspx");
        }
    }
   
    }
