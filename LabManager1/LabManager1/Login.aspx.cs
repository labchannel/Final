using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Globalization;
using System.Threading;


namespace LabManager
{/// <summary>
///checking user's credential
/// </summary>
    public partial class Login : System.Web.UI.Page
    {
        static string dropDownUniqueID;
        protected void Page_Load(object sender, EventArgs e)
        {
            var u = Membership.GetUser(User.Identity.Name);
        }
        public static void SendForm(string uniqueID)
        {
            dropDownUniqueID = uniqueID;
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("TenantRegistration.aspx");
        }

        protected void blogin_Click(object sender, EventArgs e)
        {
            string @u = txtUserName.Text;
            string @p =txtLoginpwd.Text;
            if (IsValid)
            {
                if (Membership.ValidateUser(@u, @p))
                {
                    // Validate the user password
                    if (ChkRemberme.Checked)
                    {
                        FormsAuthenticationTicket tkt = new FormsAuthenticationTicket(@u, true, 10 * 60);
                        String encryptedTkt = FormsAuthentication.Encrypt(tkt);
                        HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTkt);
                        cookie.Expires = tkt.Expiration;
                        HttpContext.Current.Request.Cookies.Set(cookie);
                        FormsAuthentication.SetAuthCookie(@u, true);
                       
                    }
                
                    else
                    {
                        FormsAuthentication.SetAuthCookie(@u, true);
                    }
                   Label1.Text=Convert.ToString(Roles.GetRolesForUser(@u));
                    Session["ClientCulture"]=DropDownList1.SelectedValue;
                    string[] a = Roles.GetRolesForUser(@u);
                    

                    Session["username"] = @u;
                    if ((Roles.IsUserInRole("Administrators"))== true)
                    {
                        Response.Redirect("~/Tenanat/tenantpage.aspx?name=" + @u);
                    
                    }
                  else  if  ((Roles.IsUserInRole("Manager"))== true)
                    {
                        Response.Redirect("~/manager/managerpage.aspx?name=" + @u);
                    }
                    else
                    {
                        //Label1.Text = Convert.ToString(Roles.GetAllRoles());
                        Response.Redirect("~/public/staffpage.aspx?name=" + @u);

                    }
                }
                else {
                    Label1.Text = "Login Unsuccessfull";
                }
            }
        }
        protected override void InitializeCulture()
        {

            if (Request.Form["DropDownList1"] != null)
            {

                string selectedLanguage = Request.Form["DropDownList1"];
                UICulture = selectedLanguage;
                Culture = selectedLanguage;

                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(selectedLanguage);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(selectedLanguage);
                Session["ClientCulture"] = selectedLanguage;
            }
            base.InitializeCulture();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Request.Form["DropDownList1"] != null)
            {

                string selectedLanguage = Request.Form["DropDownList1"];
                UICulture = selectedLanguage;
                Culture = selectedLanguage;

                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(selectedLanguage);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(selectedLanguage);

            }
            base.InitializeCulture();
        }

        protected void DropDownList1_TextChanged(object sender, EventArgs e)
        {
            if (Request.Form["DropDownList1"] != null)
            {

                string selectedLanguage = Request.Form["DropDownList1"];
                UICulture = selectedLanguage;
                Culture = selectedLanguage;

                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(selectedLanguage);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(selectedLanguage);

            }
            base.InitializeCulture();
        }
    }
}