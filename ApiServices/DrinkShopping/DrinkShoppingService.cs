using Checkout.ApiServices.DrinkShopping.RequestModels;
using Checkout.ApiServices.DrinkShopping.ResponseModels;
using Checkout.ApiServices.SharedModels;
using Checkout.Utilities;
using System;

namespace Checkout.ApiServices.DrinkShopping
{
    public class DrinkShoppingService
    {
        public HttpResponse<ShoppingItem> CreateShoppingItem(ShoppingItemCreate requestModel)
        {
            return new ApiHttpClient().PostRequest<ShoppingItem>(string.Format(ApiUrls.DrinkShoppingPost, requestModel.DrinkId), AppSettings.SecretKey, requestModel);
        }

        public HttpResponse<OkResponse> UpdateShoppingItem(ShoppingItemUpdate requestModel)
        {
            var updateDrinkShoppingUri = string.Format(ApiUrls.DrinkShoppingPut, requestModel.DrinkId);
            return new ApiHttpClient().PutRequest<OkResponse>(updateDrinkShoppingUri, AppSettings.SecretKey, requestModel);
        }

        public HttpResponse<OkResponse> EmptyShopping()
        {
            var emptyShoppingUri = ApiUrls.DrinkShoppingEmpty;
            return new ApiHttpClient().DeleteRequest<OkResponse>(emptyShoppingUri, AppSettings.SecretKey);
        }

        public HttpResponse<OkResponse> DeleteShoppingItem(int shoppingItemId)
        {
            var deleteShoppingItemUri = string.Format(ApiUrls.DrinkShoppingDelete, shoppingItemId);
            return new ApiHttpClient().DeleteRequest<OkResponse>(deleteShoppingItemUri, AppSettings.SecretKey);
        }

        public HttpResponse<ShoppingItem> GetShoppingItem(string shoppingItemName)
        {
            var getShoppingItemUri = string.Format(ApiUrls.DrinkShoppingSearch, shoppingItemName);
            return new ApiHttpClient().GetRequest<ShoppingItem>(getShoppingItemUri, AppSettings.SecretKey);
        }

        public HttpResponse<ShoppingItemList> GetShoppingItemList(ShoppingItemGetList request)
        {
            var getShoppingItemListUri = ApiUrls.DrinkShoppingGetList;
            if (request.PageSize.HasValue)
            {
                getShoppingItemListUri = UrlHelper.AddParameterToUrl(getShoppingItemListUri, "pagesize", request.PageSize.ToString());
            }

            if (!string.IsNullOrEmpty(request.PageNumber))
            {
                getShoppingItemListUri = UrlHelper.AddParameterToUrl(getShoppingItemListUri, "pagenumber", request.PageNumber.ToString());
            }

            return new ApiHttpClient().GetRequest<ShoppingItemList>(getShoppingItemListUri, AppSettings.SecretKey);
        }
    }
}
