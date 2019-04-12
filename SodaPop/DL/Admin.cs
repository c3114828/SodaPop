using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SodaPop.DL
{
    public class Admin
    {

        public Int32 AdminID { get; set; }
        public String AdminFirstName { get; set; }

        public String AdminLastName { get; set; }
        public String AdminEmail { get; set; }
        public String AdminPassword { get; set; }

        
        public Admin()
        {

        }

        public Admin(Int32 aid, String afn, String aln, String ae, String ap)
        {
            this.AdminID = aid;
            this.AdminFirstName = afn;
            this.AdminLastName = aln;
            this.AdminEmail = ae;
            this.AdminPassword = ap;
        }
    }
}