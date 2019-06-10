using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SodaPop.DL
{
    public class CartDL
    {

        public Cart() { }
        //Used to add a product to the cart list and the set the values

        public Cart(Product Product, int quantity)
        {// Constructor
            this.Product = Product;
            this.Quantity = quantity;
        }
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public void AddQuantity (int quantity)
        {
            this.Quantity += quantity;
        }
    }
}