using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SodaPop.DL
{
    public class Customer
    {

        public Int32 CustomerID { get; set; }
        public String CustomerEmailAddress { get; set; }
        public String CustomerPassword { get; set; }
        public String CustomerFirstName { get; set; }
        public String CustomerLastName { get; set; }

        public String CustomerStreetNumber { get; set; }
        public String CustomerStreetName { get; set; }
        public String CustomerCity { get; set; }
        public String CustomerState { get; set; }
        public string CustomerPostCode { get; set; }

        public String BillingStreetNumber { get; set; }
        public String BillingStreetName { get; set; }
        public String BillingCity { get; set; }
        public String BillingState { get; set; }
        public String BillingPostCode { get; set; }

        // Foreign Keys
        public Int32 CartID { get; set; }
        public Int32 OrderID { get; set; }


        public Customer()
        {


        }

        public Customer(Int32 cid, String ea, String pw,String fn, String ln, String csn, String cstn, String csc, String css, String cspc, String bsn, String bstn, String bc, String bs, String bpc, Int32 fkcid, Int32 oid  )
        {
            this.CustomerID = cid;
            this.CustomerEmailAddress = ea;
            this.CustomerPassword = pw;
            this.CustomerFirstName = fn;
            this.CustomerLastName = ln;
            this.CustomerStreetName = cstn;
            this.CustomerStreetNumber = csn;
            this.CustomerCity = csc;
            this.CustomerState = css;
            this.CustomerPostCode = cspc;
            this.BillingStreetNumber = bstn;
            this.BillingState = bs;
            this.BillingState = bstn;
            this.BillingCity = bc;
            this.BillingPostCode = bpc;

            this.CartID = fkcid;
            this.OrderID = oid;

        }

    }
}