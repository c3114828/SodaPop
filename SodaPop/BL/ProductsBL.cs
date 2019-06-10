using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.ComponentModel;
using System.Data;
using SodaPop.DAL;

namespace SodaPop.BL
{
    [DataObject(true)]
    public class ProductsBL
    {
        public DataSet getProductDetails(int ProductID)
        {
            ProductsDAL DAL = new ProductsDAL();
            return DAL.getProductDetails(ProductID);
        }
        public void updateProduct(int productID, string Name, string Brand, string imagefile, decimal price, string shortDescription, string longDescription)
        {
            ProductsDAL DAL = new ProductsDAL();
            DAL.productUpdate(productID, Name, Brand, imagefile, price, shortDescription, longDescription);
        }
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void deleteProduct(int productID)
        {
            ProductsDAL DAL = new ProductsDAL();
            DAL.productDelete(productID);
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<DL.Product> getAllProducts()
        {
            ProductsDAL DAL = new ProductsDAL();
            return DAL.getAllProductsDetails();
        }
        public DataSet getData()
        {
            ProductsDAL DAL = new ProductsDAL();
            return DAL.getData();
        }
        public int getQuantity(int ProductID)
        {
            ProductsDAL DAL = new ProductsDAL();
            return DAL.getQuantity(ProductID);
        }

        public DataTable displayCart()
        {
            ProductsDAL DAL = new ProductsDAL();
            return DAL.displayCart();
        }
        public void addToCart(int ProductID, DataTable dt)
        {
            ProductsDAL DAL = new ProductsDAL();
            DAL.addToCart(ProductID, dt);
        }
        public void removeCart()
        {
            ProductsDAL DAL = new ProductsDAL();
            DAL.removeCart();

        }
        public void createOrderID()////
        {
            ProductsDAL Dal = new ProductsDAL();
            Dal.createInvoiceID();
        }
        public string getSumTotal()
        {
            ProductsDAL DAL = new ProductsDAL();
            return DAL.getSumTotal();
        }

    }
}