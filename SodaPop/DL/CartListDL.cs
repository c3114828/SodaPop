using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SodaPop.DL
{
    private List<Cart> cartList;
    public class CartListDL
    {

        public CartListDL()
        {
            CartListDL = new List<CartListDL>();
        }

        public int Count
        {
            get { return cartList.Count; }
        }

        public static CartListDL GetCart()
        {
            CartListDL cart = (CartListDL)HttpContext.Current.Session["Cart"];
            if (cart == null)
                HttpContext.Current.Session["Cart"] = new CartListDL();
            return (CartListDL)HttpContext.Current.Session["Cart"];
            
        }

        public void AddItem(Product Product, int Quantity)
        {
            Cart c = new Cart(Product, Quantity);
            cartList.Add(c);
        }
        public void RemoveAt(int Index)
        {
            cartList.RemoveAt(Index);
        }
        public void clearCart()
        {
            cartList.Clear();
        }

    }
}