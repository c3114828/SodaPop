using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SodaPop.DL
{
    public class ShoppingCart
    {//declaration for shopping cart.
        public string Product { get; set; }
        public int Quantity { get; set; }
        public string Price { get; set; }        
        public string Total { get; set; }
    }
}