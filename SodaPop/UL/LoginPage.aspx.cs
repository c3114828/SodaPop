using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SodaPop.UL
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void logInBtn_Click1(object sender, EventArgs e)
        {
            Session["Email"] = emailTxtBx.Text;
            Response.Redirect("~/UL/MyAccountPage.aspx");

        }
    }
}