using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabManager1
{
    public partial class portaladmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void blogin_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string un = txtUserName.Text;
                string pw = txtLoginpwd.Text;
                if (un == "portaladmin")
                {
                    if (pw == "12345")
                    {
                        Session["name"] = un;
                        Response.Redirect("~/TenantRegistration.aspx");
                    }
                    else
                    {
                        Label1.Text = "Incorrect Password";

                    }
                }

                else
                {
                    Label1.Text = "Invalid User";
                    //Response.Redirect("~/Login.aspx");
                }
            }
        }
    }
}