using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SodaPop.UL
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Email"] = emailTxtBx.Text;
            Session["Password"] = passwordTxtBx.Text;
            Response.Redirect("~/UL/Registered.aspx");
        }
    }
}