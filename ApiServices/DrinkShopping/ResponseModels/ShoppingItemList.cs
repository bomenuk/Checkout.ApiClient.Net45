using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkout.ApiServices.DrinkShopping.RequestModels;

namespace Checkout.ApiServices.DrinkShopping.ResponseModels
{
    public class ShoppingItemList
    {
        public int Count { get; set; }
        public List<ShoppingItem> Data { get; set; }
    }
}
