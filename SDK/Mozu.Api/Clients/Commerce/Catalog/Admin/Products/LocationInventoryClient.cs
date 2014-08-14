
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Mozu.Api.Security;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Mozu.Api.Clients.Commerce.Catalog.Admin.Products
{
	/// <summary>
	/// Use the Product Location Inventory resource to manage the levels of active product inventory to maintain across defined locations at the product level.
	/// </summary>
	public partial class LocationInventoryClient 	{
		
		/// <summary>
		/// Retrieves all locations for which a product has inventory defined and displays the inventory definition properties of each location.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.LocationInventoryCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetLocationInventories( productCode,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		///   var locationInventoryCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.LocationInventoryCollection> GetLocationInventoriesClient(string productCode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.LocationInventoryUrl.GetLocationInventoriesUrl(productCode, startIndex, pageSize, sortBy, filter, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.LocationInventoryCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the details of the inventory of the product in the location specified in the request.
		/// </summary>
		/// <param name="locationCode">User-defined code that identifies the location.</param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.LocationInventory"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetLocationInventory( productCode,  locationCode,  responseFields);
		///   var locationInventoryClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.LocationInventory> GetLocationInventoryClient(string productCode, string locationCode, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.LocationInventoryUrl.GetLocationInventoryUrl(productCode, locationCode, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.LocationInventory>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Creates a new location inventory definition for the product code specified in the request.
		/// </summary>
		/// <param name="performUpserts"></param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="locationInventoryList">Array list of the location inventory definitions associated with the product code specified in the request. For each location, you must define the locationCode value and the stockOnHand value. All other properties in the array are system-supplied and read only.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.LocationInventory"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddLocationInventory(dataViewMode,  locationInventoryList,  productCode,  performUpserts);
		///   var locationInventoryClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>> AddLocationInventoryClient(DataViewMode dataViewMode, List<Mozu.Api.Contracts.ProductAdmin.LocationInventory> locationInventoryList, string productCode, bool? performUpserts =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.LocationInventoryUrl.AddLocationInventoryUrl(productCode, performUpserts);
			const string verb = "POST";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>>(locationInventoryList)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Updates the current level of stock at each location associated with the product code specified in the request.
		/// </summary>
		/// <param name="productCode">The product code of the product for which to update active stock on hand inventory at a specified location.</param>
		/// <param name="locationInventoryAdjustments">Properties of the inventory adjustments to perform for the specified location.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.LocationInventory"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateLocationInventory(dataViewMode,  locationInventoryAdjustments,  productCode);
		///   var locationInventoryClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>> UpdateLocationInventoryClient(DataViewMode dataViewMode, List<Mozu.Api.Contracts.ProductAdmin.LocationInventoryAdjustment> locationInventoryAdjustments, string productCode)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.LocationInventoryUrl.UpdateLocationInventoryUrl(productCode);
			const string verb = "PUT";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.ProductAdmin.LocationInventoryAdjustment>>(locationInventoryAdjustments)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Deletes the location inventory definition for the product code specified in the request.
		/// </summary>
		/// <param name="locationCode">The code that identifies the location for which to delete product inventory.</param>
		/// <param name="productCode">The product code for which to delete a location's inventory.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteLocationInventory(dataViewMode,  productCode,  locationCode);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteLocationInventoryClient(DataViewMode dataViewMode, string productCode, string locationCode)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.LocationInventoryUrl.DeleteLocationInventoryUrl(productCode, locationCode);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}


	}

}


