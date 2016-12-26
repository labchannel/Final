using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using System.DataAccess;
using System.Web.Security;
using System.Net.Mail;

namespace LabManager
{
    public partial class TenantRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Roles.RoleExists("Administrators"))
            {
                Roles.CreateRole("Administrators");
            }

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string Name = TextBoxUN.Text;
            int MN = Convert.ToInt32(TxtMbl.Text);
            string Email = txtEmail.Text;
            string pwd = txtpwd.Text;
            string cwd = txtconfirmPWD.Text;
            string Gender = ddlGender.Text;
            string Addr = TextBoxAddr.Text;
            string Street = TxtStrt.Text;
            string city = TxtCity.Text;
            string state = TxtState.Text;
            int pin = Convert.ToInt32(TeXtZipCode.Text);
            MembershipCreateStatus UserCreateStatus;


            //var guid = Guid.NewGuid();
            MembershipUser uu = Membership.CreateUser(Name, pwd, Email, "1", "1", true, out UserCreateStatus);
            Roles.AddUserToRole(Name, "Administrators");
            var currentUser = Membership.GetUser(Name);

            //var membershipUser = Membership.GetUser();
            var userID = (Guid)currentUser.ProviderUserKey;
            BAL obj = new BAL();
            int n = obj.insert(userID, Gender, Addr, Street, city, state, pin, MN);
            try
            {
                if (n > 0)
                {

                    UserCreateStatus = MembershipCreateStatus.Success;

                    Label1.Text = "Registration Successfull";
                    sendmail(Email);
                    //  Response.Write("Registration Successfull");




                }
                else
                {
                    UserCreateStatus = MembershipCreateStatus.UserRejected;
                    Label1.Text = "Already Exist";
                }
            }
            catch (Exception ex)
            {

                UserCreateStatus = MembershipCreateStatus.ProviderError;
                Label1.Text = "Already Exist";
            }

        }

        public void sendmail(String email)
        {
           
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("priyankas@labchannel.net");
            mail.Sender = new MailAddress(email);
            mail.To.Add(txtEmail.Text);
            mail.IsBodyHtml = true;
            mail.Subject = "Email Sent";
            mail.Body = "You have Successfully registered.";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("priyankas@labchannel.net", "Employee$100");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;

            smtp.Timeout = 30000;
            try
            {

                smtp.Send(mail);
            }
            catch (SmtpException ex)
            {
                txtEmail.Text = ex.Message;
            }
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Email has been sent')", true);
        }
    }
    }