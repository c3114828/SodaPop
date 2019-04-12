using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SodaPop.Models
{
    public class Category
    {
            public int CategoryID { get; set; }

            public string BuildingLabel { get; set; }

            public string BuildingName { get; set; }

            public int RoomQty { get; set; }

            //public Map Image

            //public BuildingModel()
            //{

            //}

            //public BuildingModel(int bid, string bl, string bn, int rq)
            //{
            //    this.BuildingID = bid;
            //    this.BuildingLabel = bl;
            //    this.BuildingName = bn;
            //    this.RoomQty = rq;
            //}
        
    }
}