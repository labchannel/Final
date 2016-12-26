using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Globalization;
using System.Threading;

namespace LabManager1
{
    public partial class StaffPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cultures = Session["ClientCulture"].ToString();
            lbusername.Text = Request.QueryString["name"];
            if (Roles.IsUserInRole("Administrator"))
            {
                lbrole.Text = "Administrator";

            }
            else if (Roles.IsUserInRole("Manager"))
            {
                lbrole.Text = "Manager";

            }
            else {
                lbrole.Text = "Staff";
            }
        }
        protected override void InitializeCulture()
        {
            string cultures = Session["ClientCulture"].ToString();



            string selectedLanguage = Session["ClientCulture"].ToString();
            UICulture = selectedLanguage;
            Culture = selectedLanguage;

            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(selectedLanguage);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(selectedLanguage);


            base.InitializeCulture();
        }

        protected void bLogout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Roles.DeleteCookie();
            Session.Clear();
            Response.Redirect("~/Login.aspx");
        }
        
    }
}