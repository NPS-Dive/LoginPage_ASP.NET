using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginPage.Pages
    {
    public partial class MainPage : System.Web.UI.Page
        {
        protected void Page_Load ( object sender, EventArgs e )
            {
                if(User.Identity.IsAuthenticated==true)
                {
                Response.Write(User.Identity.Name);
                }
            else
                {
                Response.Redirect("LoginPage.aspx",true);
                return;
                }
            }

        protected void btnLogout_Click ( object sender, EventArgs e )
            {
            System.Web.Security.FormsAuthentication.SignOut();
            Response.Redirect("LoginPage.aspx", true);
            return;
            }
        }
    }