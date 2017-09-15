
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
using System.Threading;

namespace Mozu.Api.Resources.Commerce.Catalog.Admin.Products
{
	/// <summary>
	/// Use the product variations sub-resource to manage the variations of a product based on its attributes. For example, a t-shirt product could be offered in six variations: Small Black, Medium Black, Large Black, Small White, Medium White, and Large White.
	/// </summary>
	public partial class ProductVariationResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		private readonly DataViewMode _dataViewMode;
		
		public ProductVariationResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
			_dataViewMode = DataViewMode.Live;
		}

		public ProductVariationResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new ProductVariationResource(_apiContext.CloneWith(contextModification), _dataViewMode);
		}

		public ProductVariationResource(IApiContext apiContext, DataViewMode dataViewMode) 
		{
			_apiContext = apiContext;
			_dataViewMode = dataViewMode;
		}
				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="productCode"></param>
		/// <param name="variationKey"></param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariationDeltaPrice = await productvariation.GetProductVariationLocalizedDeltaPricesAsync(_dataViewMode,  productCode,  variationKey);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice>> GetProductVariationLocalizedDeltaPricesAsync(string productCode, string variationKey, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.GetProductVariationLocalizedDeltaPricesClient(_dataViewMode,  productCode,  variationKey);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="currencyCode"></param>
		/// <param name="productCode"></param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="variationKey"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariationDeltaPrice = await productvariation.GetProductVariationLocalizedDeltaPriceAsync(_dataViewMode,  productCode,  variationKey,  currencyCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice> GetProductVariationLocalizedDeltaPriceAsync(string productCode, string variationKey, string currencyCode, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.GetProductVariationLocalizedDeltaPriceClient(_dataViewMode,  productCode,  variationKey,  currencyCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="productCode"></param>
		/// <param name="variationKey"></param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariationFixedPrice = await productvariation.GetProductVariationLocalizedPricesAsync(_dataViewMode,  productCode,  variationKey);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice>> GetProductVariationLocalizedPricesAsync(string productCode, string variationKey, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.GetProductVariationLocalizedPricesClient(_dataViewMode,  productCode,  variationKey);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="currencyCode"></param>
		/// <param name="productCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="variationKey"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariationFixedPrice = await productvariation.GetProductVariationLocalizedPriceAsync(_dataViewMode,  productCode,  variationKey,  currencyCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice> GetProductVariationLocalizedPriceAsync(string productCode, string variationKey, string currencyCode, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.GetProductVariationLocalizedPriceClient(_dataViewMode,  productCode,  variationKey,  currencyCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Retrieves the details of a product variation based on the supplied product code and variation key.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="variationKey">System-generated key that represents the attribute values that uniquely identify a specific product variation.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariation"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariation = await productvariation.GetProductVariationAsync(_dataViewMode,  productCode,  variationKey,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductVariation> GetProductVariationAsync(string productCode, string variationKey, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariation> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.GetProductVariationClient(_dataViewMode,  productCode,  variationKey,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Retrieves a list of the product variations configured for the specified product code.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationPagedCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariationPagedCollection = await productvariation.GetProductVariationsAsync(_dataViewMode,  productCode,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductVariationPagedCollection> GetProductVariationsAsync(string productCode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationPagedCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.GetProductVariationsClient(_dataViewMode,  productCode,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="productCode"></param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="variationKey"></param>
		/// <param name="localizedDeltaPrice"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariationDeltaPrice = await productvariation.AddProductVariationLocalizedDeltaPriceAsync(_dataViewMode,  localizedDeltaPrice,  productCode,  variationKey,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice> AddProductVariationLocalizedDeltaPriceAsync(Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice localizedDeltaPrice, string productCode, string variationKey, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.AddProductVariationLocalizedDeltaPriceClient(_dataViewMode,  localizedDeltaPrice,  productCode,  variationKey,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="productCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="variationKey"></param>
		/// <param name="localizedPrice"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariationFixedPrice = await productvariation.AddProductVariationLocalizedPriceAsync(_dataViewMode,  localizedPrice,  productCode,  variationKey,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice> AddProductVariationLocalizedPriceAsync(Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice localizedPrice, string productCode, string variationKey, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.AddProductVariationLocalizedPriceClient(_dataViewMode,  localizedPrice,  productCode,  variationKey,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="productCode"></param>
		/// <param name="variationKey"></param>
		/// <param name="localizedDeltaPrice"></param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariationDeltaPrice = await productvariation.UpdateProductVariationLocalizedDeltaPricesAsync(_dataViewMode,  localizedDeltaPrice,  productCode,  variationKey);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice>> UpdateProductVariationLocalizedDeltaPricesAsync(List<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice> localizedDeltaPrice, string productCode, string variationKey, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.UpdateProductVariationLocalizedDeltaPricesClient(_dataViewMode,  localizedDeltaPrice,  productCode,  variationKey);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="currencyCode"></param>
		/// <param name="productCode"></param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="variationKey"></param>
		/// <param name="localizedDeltaPrice"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariationDeltaPrice = await productvariation.UpdateProductVariationLocalizedDeltaPriceAsync(_dataViewMode,  localizedDeltaPrice,  productCode,  variationKey,  currencyCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice> UpdateProductVariationLocalizedDeltaPriceAsync(Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice localizedDeltaPrice, string productCode, string variationKey, string currencyCode, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.UpdateProductVariationLocalizedDeltaPriceClient(_dataViewMode,  localizedDeltaPrice,  productCode,  variationKey,  currencyCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="productCode"></param>
		/// <param name="variationKey"></param>
		/// <param name="localizedPrice"></param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariationFixedPrice = await productvariation.UpdateProductVariationLocalizedPricesAsync(_dataViewMode,  localizedPrice,  productCode,  variationKey);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice>> UpdateProductVariationLocalizedPricesAsync(List<Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice> localizedPrice, string productCode, string variationKey, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.UpdateProductVariationLocalizedPricesClient(_dataViewMode,  localizedPrice,  productCode,  variationKey);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="currencyCode"></param>
		/// <param name="productCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="variationKey"></param>
		/// <param name="localizedPrice"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariationFixedPrice = await productvariation.UpdateProductVariationLocalizedPriceAsync(_dataViewMode,  localizedPrice,  productCode,  variationKey,  currencyCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice> UpdateProductVariationLocalizedPriceAsync(Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice localizedPrice, string productCode, string variationKey, string currencyCode, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationFixedPrice> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.UpdateProductVariationLocalizedPriceClient(_dataViewMode,  localizedPrice,  productCode,  variationKey,  currencyCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Modifies the details of a variation, based on the supplied variation key, for the specified product code.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="variationKey">System-generated key that represents the attribute values that uniquely identify a specific product variation.</param>
		/// <param name="productVariation">Wrapper for the properties of the specified product variation.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariation"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariation = await productvariation.UpdateProductVariationAsync(_dataViewMode,  productVariation,  productCode,  variationKey,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductVariation> UpdateProductVariationAsync(Mozu.Api.Contracts.ProductAdmin.ProductVariation productVariation, string productCode, string variationKey, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariation> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.UpdateProductVariationClient(_dataViewMode,  productVariation,  productCode,  variationKey,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Modifies the collection of variations for the specified product code. Because this PUT replaces the existing resource, supply all information necessary to maintain for the product variation.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields"></param>
		/// <param name="productVariations">Wrapper for the collection of variations configured for the specified product code.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariationCollection = await productvariation.UpdateProductVariationsAsync(_dataViewMode,  productVariations,  productCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductVariationCollection> UpdateProductVariationsAsync(Mozu.Api.Contracts.ProductAdmin.ProductVariationCollection productVariations, string productCode, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.UpdateProductVariationsClient(_dataViewMode,  productVariations,  productCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Deletes a variation, based on the supplied variation key, for the specified product code.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="variationKey">System-generated key that represents the attribute values that uniquely identify a specific product variation.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   await productvariation.DeleteProductVariationAsync(_dataViewMode,  productCode,  variationKey);
		/// </code>
		/// </example>
		public virtual async Task DeleteProductVariationAsync(string productCode, string variationKey, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.DeleteProductVariationClient(_dataViewMode,  productCode,  variationKey);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="currencyCode"></param>
		/// <param name="productCode"></param>
		/// <param name="variationKey"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   await productvariation.DeleteProductVariationLocalizedDeltaPriceAsync(_dataViewMode,  productCode,  variationKey,  currencyCode);
		/// </code>
		/// </example>
		public virtual async Task DeleteProductVariationLocalizedDeltaPriceAsync(string productCode, string variationKey, string currencyCode, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.DeleteProductVariationLocalizedDeltaPriceClient(_dataViewMode,  productCode,  variationKey,  currencyCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="currencyCode"></param>
		/// <param name="productCode"></param>
		/// <param name="variationKey"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   await productvariation.DeleteProductVariationLocalizedPriceAsync(_dataViewMode,  productCode,  variationKey,  currencyCode);
		/// </code>
		/// </example>
		public virtual async Task DeleteProductVariationLocalizedPriceAsync(string productCode, string variationKey, string currencyCode, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.DeleteProductVariationLocalizedPriceClient(_dataViewMode,  productCode,  variationKey,  currencyCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


	}

}


