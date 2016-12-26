using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Net.Mail;
using System.Web.Security;
using System.Threading;
using System.Globalization;

namespace LabManager1
{/// <summary>
/// Manage and Creating Staffs Details
/// </summary>
    public partial class Managerpage : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        private MembershipCreateStatus Status;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            string cultures=Session["ClientCulture"].ToString();
           // gvbind();
            if (!Roles.RoleExists("Manager")) {
                Roles.CreateRole("Manager");
            }
            if (Roles.IsUserInRole("Manager"))
            {
                if (!Page.IsPostBack) { 
                    lbUserName.Text = Request.QueryString["name"];
                   gvbind();}
                if (!Roles.RoleExists("Employee"))
                {
                    Roles.CreateRole("Employee");
                }

            }
            else
            {
                Response.Redirect("~/Login.aspx");
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
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            gvbind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int userid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            Label lblID = (Label)row.FindControl("LblID");

       //     TextBox textName = (TextBox)row.FindControl("TxtEName");
            TextBox textadd = (TextBox)row.FindControl("txteaddr");
            TextBox textEmail = (TextBox)row.FindControl("Txtemail");
            // TextBox textc = (TextBox)row.Cells[2].Controls[0];
            //TextBox textadd = (TextBox)row.FindControl("txtadd");
            //TextBox textc = (TextBox)row.FindControl("txtc");
            GridView1.EditIndex = -1;
            con.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM detail", conn);
            SqlCommand cmd = new SqlCommand("update aspnet_Employee set EEmail='" + textEmail.Text + "',EAddress='" + textadd.Text + "'where EID='" + userid + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            gvbind();
        }

        private void gvbind()
        {
            int results=0;
            con.Open();
            string name = Request.QueryString["name"];
            Session["name"] = name;
           SqlCommand cmd = new SqlCommand("SELECT mRID FROM aspnet_manager where MName='" + name + "'", con);
            SqlDataReader myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
              results = Convert.ToInt32(myReader.GetValue(0).ToString());
            }
            int @mrid = results;
           // int @mrid = cmd.ExecuteNonQuery();
            cmd.Dispose();
            myReader.Close();

            SqlDataAdapter da = new SqlDataAdapter("Select EID, EName,EAddress,EEmail from aspnet_Employee where RID='"+@mrid+"'", con);
            
            DataSet ds = new DataSet();
            da.Fill(ds);
            // con.Close();
            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            else
            {
                ds.Tables[0].Rows.Add(ds.Tables[0].NewRow());
                GridView1.DataSource = ds;
                GridView1.DataBind();
                int columncount = GridView1.Rows[0].Cells.Count;
                GridView1.Rows[0].Cells.Clear();
                GridView1.Rows[0].Cells.Add(new TableCell());
                GridView1.Rows[0].Cells[0].ColumnSpan = columncount;
                GridView1.Rows[0].Cells[0].Text = "No Records Found";
            }

            con.Close();


        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
         //   int userid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            int @id =Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            Label lbUserName = (Label)GridView1.Rows[e.RowIndex].FindControl("EName");
            SqlCommand cmd = new SqlCommand("Delete from aspnet_Employee where EID=@id", con);
            con.Open();
            cmd.Parameters.Add("@id", SqlDbType.Int, 32).Value = @id;
            cmd.ExecuteNonQuery();
            con.Close();
            gvbind();
            LblResult.Text = lbUserName + "Deleted Successfully";
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            gvbind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("AddNew"))
            {
                
                if (IsValid)
                {
                    int results = 0;
                    // int results;
                    string name = Request.QueryString["name"];
                    Session["name"] = name;
                    con.Open();
                    SqlCommand cmdR = new SqlCommand("SELECT mRID FROM aspnet_manager where MName='" + name + "'", con);
                    SqlDataReader myReader = cmdR.ExecuteReader();
                    while (myReader.Read())
                    {
                        results = Convert.ToInt32(myReader.GetValue(0).ToString());
                    }
                    int mrid = results;
                    // int @mrid = cmd.ExecuteNonQuery();
                    cmdR.Dispose();
                    myReader.Close();
                    con.Close();

                    GridViewRow row = (GridViewRow)GridView1.FooterRow;
                    // Label lblID = (Label)row.FindControl("LblID");

                    TextBox textName = (TextBox)row.FindControl("TxtFEName");
                    TextBox textadd = (TextBox)row.FindControl("TxtFAddress");
                    TextBox textEmail = (TextBox)row.FindControl("Txtemail");
                    String Name = textName.Text;
                    string email = textEmail.Text;
                    con.Open();
                    var password = passwordgen();
                    MembershipCreateStatus UserCreateStatus;
                    MembershipUser uu = Membership.CreateUser(Name, password, email, "1", "1", true, out UserCreateStatus);
                    if ((UserCreateStatus==MembershipCreateStatus.DuplicateEmail)==true)
                    {
                        Status = MembershipCreateStatus.DuplicateEmail;
                        LblResult.Text = Status.ToString();

                    }
                    if ((UserCreateStatus == MembershipCreateStatus.InvalidPassword)==true)
                    {
                        Status = MembershipCreateStatus.InvalidPassword;
                        LblResult.Text = Status.ToString();

                    }
                    else
                    {
            
                        SqlCommand cmd =
                        new SqlCommand(
                        "insert into aspnet_Employee(EName,EAddress,EEmail,RID) values('" + textName.Text + "','" +
                        textadd.Text + "','" + textEmail.Text + "', @mrid)", con);
                        cmd.Parameters.Add("@mrid", SqlDbType.Int).Value = mrid;
                        int result = cmd.ExecuteNonQuery();
                        cmd.Dispose();

                        con.Close();
                        if (result == 1)
                        {
                            gvbind();

                            SendMailEmployee(Name,password,email);
                            LblResult.ForeColor = Color.Green;
                            LblResult.Text = textName.Text + " Details inserted successfully";
                            Roles.AddUserToRole(Name, "Employee");

                        }
                        else
                        {
                            LblResult.ForeColor = Color.Red;
                            LblResult.Text = textName.Text + " Details not inserted";
                        }
                    }
                }
            }
        }
        protected string passwordgen()
        {
            string allowedChars = "";
            allowedChars = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,";
            allowedChars += "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,";
            allowedChars += "1,2,3,4,5,6,7,8,9,0";
            allowedChars += "!,@,#,$,%,&,?";
            char[] sep = { ',' };
            string[] arr = allowedChars.Split(sep);
            string passwordString = "";
            string temp = "";
            Random rand = new Random();
            for (int i = 0; i < 9; i++)
            {
                temp = arr[rand.Next(0, arr.Length)];
                passwordString += temp;
            }
            return passwordString;
           // txtpassword.Text = passwordString;
        }
        public void SendMailEmployee(string name, string password,string email)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("priyankas@labchannel.net");
            mail.Sender = new MailAddress(email);
            mail.To.Add(email);
            mail.IsBodyHtml = true;
            mail.Subject = "Email Sent";
            mail.Body = "You have Successfully registered.Yours Username is "+ name +" and your password is "+ password +" ."  ;

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
               // txtEmail.Text = ex.Message;
            }
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Email has been sent')", true);

        }

       
    }
}