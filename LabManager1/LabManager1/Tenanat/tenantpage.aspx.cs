using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BusinessLogic;
using System.DataAccess;


namespace LabManager1
{
    public partial class TenantPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Gridview1.Visible = false;
            }
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
            int n = obj.Balinsert1(ResName,ResAddr,ManagerName,ManagerAddr,ManagerEmail,DateOfBirth);
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
            Gridview1.Visible = true;
            //DataTable dt = new DataTable();
            //dt.Columns.AddRange(new DataColumn[3]{
            //               new DataColumn("EmployeeName",typeof(string)),
            //               new DataColumn("EmployeeAddr",typeof(string))  ,                           
            //               new DataColumn("EmployeeEmail",typeof(string)),
            //});
            //dt.Rows.Add("Jake",  "aaa@gmail.com");
            //dt.Rows.Add("John",  "bbb@gmail.com");
            //dt.Rows.Add("Micheal", "ccc@gmail.com");
          //Gridview1.DataSource = dt;
         //Gridview1.DataBind();


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
    }
}