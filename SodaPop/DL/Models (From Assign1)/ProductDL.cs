using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace SodaPop.DL
{
    [DataObject(true)]
    public class Product { 
    
        public Int32 ProductID              { get; set; }
        public String ProductName           { get; set;}

        public String ProductDescription    { get; set; }

        public Int32 ProductQuantity        { get; set; }
        public Double ProductPrice          { get; set; }
        public String ProductBrand          { get; set; }
        public string image                  { get; set; }
        //byte[] ProductImage                 { get; set; }
        //public Int32 OrderID                { get; set; }

 


        public Product()
        {

        }


        //public Product(int pid, String pn, String pd, int pq, double pp, String pb, byte[] pi, Int32 oid)
        //{
        //    this.ProductID = pid;
        //    this.ProductName = pn;
        //    this.ProductDescription = pd;
        //    this.ProductQuantity = pq;
        //    this.ProductPrice = pp;
        //    this.ProductBrand = pb;
        //    this.ProductImage = pi;
        //    this.OrderID = oid;
        //}
        public ProductData()
        {
            //p_product.Add(new Product() { productID = 1, ProductName = "Can Coke No Sugar", Brand = "The Coca-Cola Company", image = "IMG/nosugarCoke.PNG", productPrice = 3.00, productDescription = "330ml can of no suga coca-cola" });
            //p_product.Add(new Product() { productID = 2, ProductName = "Can Coke Original", Brand = "The Coca-Cola Company", image = "IMG/originalCoke.PNG", productPrice = 3.00, productDescription = "330ml can of original coca-cola" });
            //p_product.Add(new Product() { productID = 3, ProductName = "Can Sprite", ProductBrand = "The Coca-Cola Company", image = "IMG/spriteCan.png", productPrice = 3.00, productDescription = "330ml can of Sprite lemonade." });
            //p_product.Add(new Product() { productID = 4, ProductName = "Can Mountain Dew", ProductBrand = "PepsiCo", image = "IMG/mountainDewCan.png", ProductPrice = 4.00, ProductDescription = "330ml can of mountain dew" });
            //p_product.Add(new Product() { productID = 5, ProductName = "Can Of Pepsi Cola", ProductBrand = "PepsiCo", image = "IMG/PepsiCan.png", price = 4.00, ProductDescription = "330ml can of pepsi cola" });
            //p_product.Add(new Product() { productID = 6, ProductName = "Can Of 7up Lemonade", ProductBrand = "PepsiCo", image = "IMG/7up.png", price = 4.00, ProductDescription = "330ml can of 7up cola" });

        }
        //displays list of products
        public List<Product> Products
        {
            get { return p_product; }
        }
        //returns product row based on prodcut ID
        [DataObjectMethod(DataObjectMethodType.Select)]
        public Product GetProduct(int id)
        {
            foreach (Product p in p_product)
            {
                if (p.productID == id)
                    return p;

            }
            return null;
        }
        //returns all products
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Product> GetProducts()
        {
            return p_product;
        }

        private List<Product> p_product = new List<Product>();


    }
}