using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SodaPop.DL
{
    public class Category
    {
            public int CategoryID { get; set; }

            public string CategoryName { get; set; }
            public Int32 ProductID     { get; set; }

        //public Map Image

        public void CategoryModel()
        {

        }

        public void CategoryModel(int cid, string cn, Int32 pid)
        {
            this.CategoryID = cid;
            this.CategoryName = cn;
            this.ProductID = pid;
            
        }

    }
}