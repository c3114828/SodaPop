using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SodaPop.DL
{
    public class CartModel
    {

        public Int32 CartID { get; set; }

        public Int32 Quantity { get; set; }

        public CartModel()
        {

        }

        public CartModel(Int32 cid, Int32 q)
        {
            this.CartID = cid;
            this.Quantity = q;
        }
    }
}