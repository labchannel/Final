using LabManager1.StaffSvcRefronsvr;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabManager1
{
    public partial class gettingservice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            if (!(TextBox1.Text == "")) {
                clientcall();
            }

        }
        protected void clientcall() {
            // Create a binding using Transport and a certificate.
           /* BasicHttpsBinding b = new BasicHttpsBinding();
            b.Security.Mode = SecurityMode.Transport;
            b.Security.Transport.ClientCredentialType = 
                HttpClientCredentialType.Certificate;

            // Create an EndPointAddress.
            EndpointAddress ea = new EndpointAddress(
                "https://localhost:64706/API/StaffService.svc");*/

            // Create the client.

            StaffServiceClient client = new StaffServiceClient();
            // Set the certificate for the client.
           /* client.ClientCredentials.ClientCertificate.SetCertificate(
                StoreLocation.LocalMachine,
                StoreName.My,
                X509FindType.FindBySubjectName,
                "localhost");*/
           

            //    StaffServiceClient client = new StaffServiceClient();
            int i = Convert.ToInt32(TextBox1.Text);
            // Use the 'client' variable to call operations on the service.
            GridView1.DataSource = client.StaffDetails(i).StaffSet;
            GridView1.DataBind();
            // Always close the client.
            client.Close();
        }
    }
}