using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.ApiServices.DrinkShopping.RequestModels
{
    public class BaseShoppingItem
    {
        public int DrinkId { get; set; }

        public int Quantity { get; set; }

        public string DrinkName { get; set; }
    }
}
