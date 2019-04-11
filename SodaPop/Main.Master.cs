using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SodaPop
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["Email"] != null)
            {
                loggedInLbl.Text = Session["Email"].ToString();

            }

            //Create session that realises if its logged in or not and change the label to reflect that
            //Session["LoggedIn"];
                //if (Session["LoggedIn"] != null)
                //{
                //loggedInLbl.Text = "Log In";
                ////loggedInLbl.
                //}
        }
    }
}