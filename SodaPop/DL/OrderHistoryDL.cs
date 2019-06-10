using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Web;

namespace SodaPop.DL
{
    public class OrderHistory
    { //instantion

        public int OrderID { get; set; }
        public DateTime Date { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public double Total { get; set; }
    }
}