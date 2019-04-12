using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SodaPop.Models
{
    public class Product { 
    
        public Int32 ProductID              { get; set; }
        public String ProductName           { get; set;}

        public String ProductDescription    { get; set; }

        public Int32 ProductQuantity          { get; set; }
        public Double ProductPrice          { get; set; }
        public String ProductBrand          { get; set; }
        public String ProductImage          { get; set; }

    public Product()
        {

        }


        public Product(int pid, String pn, String pd, int pq, double pp, String pb, String pi)
        {
            this.ProductID = pid;
            this.ProductName = pn;
            this.ProductDescription = pd;
            this.ProductQuantity = pq;
            this.ProductPrice = pp;
            this.ProductBrand = pb;
            this.ProductImage = pi;
        }
    }
}