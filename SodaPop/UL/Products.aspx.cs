using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SodaPop.UL
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Re-directs to login page if there is no user logged in
            if (Session["email"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            else
            {

                Products cocaCola = new Products(001, "Cola", "375ml Coca Cola Can", 1, "3.00", "Coca Cola", "~/IMG/soda-bottle.png");
                // Pants image sourced from - https://thegenericclothingstore.weebly.com/uploads/6/3/9/9/6399250/s974624006995353717_p5_i1_w640.jpeg
                List<Products> sodaProducts = new List<Products>();
                sodaProducts.Add(cocaCola);
                
                Session["CocaCola"] = sodaProducts;
            }
            // Use to get gridview of products


            //public List<Products> GetProducts()
            //{
            //    return (List<Products>)Session["Products"];

            //}

        }
    }
    
}