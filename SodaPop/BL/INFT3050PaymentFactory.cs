using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace SodaPop.BL
{
    public class INFT3050PaymentFactory
    { /// <summary>
      /// Create a payment system. 
      /// </summary>
      /// <returns></returns>
        public static IPaymentSystem Create() { return new INFT3050PaymentSystem(); }

    }
}