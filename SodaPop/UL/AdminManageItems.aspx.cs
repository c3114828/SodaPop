using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SodaPop.UL
{
    public partial class AdminManageItems : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Request.IsSecureConnection)
            {
                string url =
                    ConfigurationManager.AppSettings["SecurePath"] +
                    "UL/AdminManageItems.aspx";
                Response.Redirect(url);
            }
        }
        protected void InsertButton_Click(object sender, EventArgs e)
        {
            int productID = Convert.ToInt32(ProductIDTxtBx.Text);
            string Description = DescriptionTxtBxText;
            string name = NameTxtBx.Text;
            decimal price = Convert.ToDecimal(PriceTxtBx.Text);
            string imageString = imageTxtBx.Text;
            BL.insertProduct(productID, name, imageString, price, Description);
            Response.Redirect(ConfigurationManager.AppSettings["securePath"] + "UL/AdminManageItems.aspx");
        }
    }
}