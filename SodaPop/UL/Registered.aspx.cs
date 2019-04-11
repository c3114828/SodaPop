using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SodaPop.UL
{
    public partial class Registered : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /** Session Variables **/


            //Once a user is logged in or registered the login link on the top right changes to the users email address
            if (Session["Email"] != null)
            {
                emailLbl.Text = Session["Email"].ToString();

            }
        }
    }
}