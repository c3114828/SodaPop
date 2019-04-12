using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SodaPop.DL
{
    public class Order
    {
        public Int32 OrderID            { get; set; }
        public DateTime OrderDate       { get; set; }
        public Int32 OrderQuantity      { get; set; }
        public Decimal OrderTotalPrice  { get; set; }

        public Int32 ProductID          { get; set; }
        public Int32 CustomerID         { get; set; }


        public Order()
        {

        }

        public Order(Int32 oid, DateTime od, Int32 oq, Decimal otp, Int32 cid, Int32 pid )
        {
            this.OrderID = oid;
            this.OrderDate = od;
            this.OrderQuantity = oq;
            this.OrderTotalPrice = otp;
            this.ProductID = pid;
            this.CustomerID = cid;
        }

    }
}