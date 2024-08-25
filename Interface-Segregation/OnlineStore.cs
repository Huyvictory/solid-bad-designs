using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface_Segregation.Interfaces;

namespace Interface_Segregation
{
    public class OnlineStore : IOnlineStore
    {
        public Order Checkout(ICart cart, CheckoutInfo checkoutInfo)
        {
            if (checkoutInfo == null)
            {
                throw new InvalidOperationException("checkoutInfo is null");
            }

            if (cart.GetCartItems().Count == 0)
            {
                throw new InvalidOperationException("cart is empty");
            }

            return new Order() { Id = 999 };
        }
    }
}