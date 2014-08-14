
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Urls.Commerce.Catalog.Storefront
{
	public partial class ProductUrl 
	{

		/// <summary>
        /// Get Resource Url for GetProducts
        /// </summary>
        /// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
        /// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
        /// <param name="responseFields"></param>
        /// <param name="sortBy"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetProductsUrl(string filter =  null, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/storefront/products/?filter={filter}&startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetProductInventory
        /// </summary>
        /// <param name="locationCodes">Array of location codes for which to retrieve product inventory information.</param>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetProductInventoryUrl(string productCode, string locationCodes =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/storefront/products/{productCode}/locationinventory?locationCodes={locationCodes}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "locationCodes", locationCodes);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetProduct
        /// </summary>
        /// <param name="allowInactive">If true, returns an inactive product as part of the query.</param>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <param name="responseFields"></param>
        /// <param name="skipInventoryCheck">If true, skip the inventory validation process for the specified product.</param>
        /// <param name="variationProductCode">Merchant-created code associated with a specific product variation. Variation product codes maintain an association with the base product code.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetProductUrl(string productCode, string variationProductCode =  null, bool? allowInactive =  null, bool? skipInventoryCheck =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/storefront/products/{productCode}?variationProductCode={variationProductCode}&allowInactive={allowInactive}&skipInventoryCheck={skipInventoryCheck}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "allowInactive", allowInactive);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "skipInventoryCheck", skipInventoryCheck);
			mozuUrl.FormatUrl( "variationProductCode", variationProductCode);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for ConfiguredProduct
        /// </summary>
        /// <param name="includeOptionDetails">If true, the response returns details about the product. If false, returns a product summary such as the product name, price, and sale price.</param>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <param name="responseFields"></param>
        /// <param name="skipInventoryCheck">If true, skip the inventory validation process for the specified product.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl ConfiguredProductUrl(string productCode, bool? includeOptionDetails =  null, bool? skipInventoryCheck =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/storefront/products/{productCode}/configure?includeOptionDetails={includeOptionDetails}&skipInventoryCheck={skipInventoryCheck}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "includeOptionDetails", includeOptionDetails);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "skipInventoryCheck", skipInventoryCheck);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for ValidateProduct
        /// </summary>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <param name="responseFields"></param>
        /// <param name="skipInventoryCheck">If true, skip the inventory validation process for the specified product.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl ValidateProductUrl(string productCode, bool? skipInventoryCheck =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/storefront/products/{productCode}/validate?skipInventoryCheck={skipInventoryCheck}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "skipInventoryCheck", skipInventoryCheck);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for ValidateDiscounts
        /// </summary>
        /// <param name="allowInactive"></param>
        /// <param name="customerAccountId"></param>
        /// <param name="productCode"></param>
        /// <param name="responseFields"></param>
        /// <param name="skipInventoryCheck"></param>
        /// <param name="variationProductCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl ValidateDiscountsUrl(string productCode, string variationProductCode =  null, int? customerAccountId =  null, bool? allowInactive =  null, bool? skipInventoryCheck =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/storefront/products/{productCode}/validateDiscounts?variationProductCode={variationProductCode}&customerAccountId={customerAccountId}&allowInactive={allowInactive}&skipInventoryCheck={skipInventoryCheck}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "allowInactive", allowInactive);
			mozuUrl.FormatUrl( "customerAccountId", customerAccountId);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "skipInventoryCheck", skipInventoryCheck);
			mozuUrl.FormatUrl( "variationProductCode", variationProductCode);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetProductInventories
        /// </summary>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetProductInventoriesUrl(string responseFields =  null)
		{
			var url = "/api/commerce/catalog/storefront/products/locationinventory?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

						
	}
}

