using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SodaPop.Views
{
    public partial class purchaseHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] != null)
            {
                this.Session["OrderID"] = "2";
                // fill in grid view below
                //DataTable dt = (DataTable)Session["Order"];
                //orderHistoryGrd.DataSource = "YourDataSource";
                //orderHistoryGrd.DataBind();
            }
        }

       
    }
}