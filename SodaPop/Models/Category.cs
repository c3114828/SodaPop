using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SodaPop.Models
{
    public class Category
    {
            public int CategoryID { get; set; }

            public string CategoryName { get; set; }


        //public Map Image

        public void CategoryModel()
        {

        }

        public void CategoryModel(int cid, string cn)
        {
            this.CategoryID = cid;
            this.CategoryName = cn;
            
        }

    }
}