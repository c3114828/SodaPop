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
           
            if (Session["email"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            if (!IsPostBack)
            {
                try
                {
                    DataSet ds = BL.getData();

                    Repeater1.DataSource = BL.getData();
                    Repeater1.DataBind();
                }
                catch (Exception ex)
                {
                    errorlbl.Text = "Cannot Display products  : " + ex.Message;
                }
            }
            //else
            //{

            //    Products cocaCola = new Products(001, "Cola", "375ml Coca Cola Can", 1, "3.00", "Coca Cola", "~/IMG/soda-bottle.png");
            //    List<Products> sodaProducts = new List<Products>();
            //    sodaProducts.Add(cocaCola);

            //    Session["CocaCola"] = sodaProducts;
            //}
            // Use to get gridview of products


            //public List<Products> GetProducts()
            //{
            //    return (List<Products>)Session["Products"];

            //}.



        }
        protected void searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                //Display data via search bar text
                Repeater1.DataSource = BL.search(searchBar.Text);
                Repeater1.DataBind();
            }
            catch (Exception ex)
            {errorlbl.Text = "Error try to seach products : " + ex.Message;}
        }
        protected void btn_showAll(object sender, EventArgs e)
        {
            try
            {
                Repeater1.DataSource = BL.getData();
                Repeater1.DataBind();
            }
            catch (Exception ex)
            {errorlbl.Text = "Error : " + ex.Message;}
        }
        protected void Repeater1_ItemCommand1(object source, RepeaterCommandEventArgs e)
        {
            try
            {
                if (!Request.IsSecureConnection)
                {
                    if (e.CommandName == "Add")
                    {
                        //Not logged in
                        if (Session["UserID"] == null)
                        {errorlbl.Text = "Please Sign-in to purchase products";}
                        else
                        {Response.Redirect(ConfigurationManager.AppSettings["SecurePath"] + "UL/ShoppingCart.aspx?id=" + e.CommandArgument.ToString());}
                    }
                    else
                    {Response.Redirect("ProductDetails.aspx?id=" + e.CommandArgument.ToString());}
                }
            }
            catch (Exception ex)
            {errorlbl.Text = "Error : " + ex.Message;}


        }
    }
    
}