using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginPage.Pages
    {
    public partial class LoginPage : System.Web.UI.Page
        {
        protected void Page_Load ( object sender, EventArgs e )
            {

            }

        protected void btnLogin_Click ( object sender, EventArgs e )
            {
            if (txtUserName.Value.Trim() != string.Empty
                && txtPass.Value.Trim() != string.Empty)
                {
                if (txtUserName.Value.Trim().ToLower() == "ipbses"
                 && txtPass.Value.Trim() == "123")
                    {
                    System.Web.Security.FormsAuthentication
                        .RedirectFromLoginPage("ID=20", false);
                    }
                else
                    {
                    lblLoginMSG.InnerHtml = "Incorrect Username And/Or Passphrase; Please Try Again";
                    }
                }
            else
                {
                lblLoginMSG.InnerHtml = "Please Fill All the required Fileds";
                }
            }
        }
    }