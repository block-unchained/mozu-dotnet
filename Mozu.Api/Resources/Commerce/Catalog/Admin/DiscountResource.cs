
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

namespace Mozu.Api.Resources.Commerce.Catalog.Admin
{
	/// <summary>
	/// Define and manage discounts to apply to products, product categories, or orders. The discounts can be a specified amount off the price, percentage off the price, or for free shipping. Create a coupon code that shoppers can use to redeem the discount.
	/// </summary>
	public partial class DiscountResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		private readonly DataViewMode _dataViewMode;
		
		public DiscountResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
			_dataViewMode = DataViewMode.Live;
		}

		public DiscountResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new DiscountResource(_apiContext.CloneWith(contextModification), _dataViewMode);
		}

		public DiscountResource(IApiContext apiContext, DataViewMode dataViewMode) 
		{
			_apiContext = apiContext;
			_dataViewMode = dataViewMode;
		}
				

		/// <summary>
		/// Retrieves a list of discounts according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.DiscountCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var discount = new Discount();
		///   var discountCollection = await discount.GetDiscountsAsync(_dataViewMode,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.DiscountCollection> GetDiscountsAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.DiscountClient.GetDiscountsClient(_dataViewMode,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Retrieves the localized content specified for the specified discount.
		/// </summary>
		/// <param name="discountId">Unique identifier of the discount. System-supplied and read-only.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var discount = new Discount();
		///   var discountLocalizedContent = await discount.GetDiscountContentAsync(_dataViewMode,  discountId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent> GetDiscountContentAsync(int discountId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.DiscountClient.GetDiscountContentClient(_dataViewMode,  discountId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Retrieves the details of a single discount.
		/// </summary>
		/// <param name="discountId">Unique identifier of the discount. System-supplied and read-only.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Discount"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var discount = new Discount();
		///   var discount = await discount.GetDiscountAsync(_dataViewMode,  discountId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Discount> GetDiscountAsync(int discountId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Discount> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.DiscountClient.GetDiscountClient(_dataViewMode,  discountId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Generates a random code for a coupon.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// string
		/// </returns>
		/// <example>
		/// <code>
		///   var discount = new Discount();
		///   var string = await discount.GenerateRandomCouponAsync( responseFields);
		/// </code>
		/// </example>
		public virtual async Task<string> GenerateRandomCouponAsync(string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<string> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.DiscountClient.GenerateRandomCouponClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Creates a new discount or coupon to apply to a product, category, order, or shipping.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="discount">Properties of the discount to create. You must specify the discount name, amount type, start date, and target.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Discount"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var discount = new Discount();
		///   var discount = await discount.CreateDiscountAsync( discount,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Discount> CreateDiscountAsync(Mozu.Api.Contracts.ProductAdmin.Discount discount, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Discount> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.DiscountClient.CreateDiscountClient( discount,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Updates the localizable content for the specified discount or rename the discount without modifying its other properties.
		/// </summary>
		/// <param name="discountId">Unique identifier of the discount. System-supplied and read-only.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="content">The discount content to update, including the discount name.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var discount = new Discount();
		///   var discountLocalizedContent = await discount.UpdateDiscountContentAsync( content,  discountId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent> UpdateDiscountContentAsync(Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent content, int discountId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.DiscountClient.UpdateDiscountContentClient( content,  discountId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Updates one or more properties of a defined discount.
		/// </summary>
		/// <param name="discountId">Unique identifier of the discount to update.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="discount">Properties of the discount to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Discount"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var discount = new Discount();
		///   var discount = await discount.UpdateDiscountAsync( discount,  discountId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Discount> UpdateDiscountAsync(Mozu.Api.Contracts.ProductAdmin.Discount discount, int discountId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Discount> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.DiscountClient.UpdateDiscountClient( discount,  discountId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Deletes a discount specified by its discount ID.
		/// </summary>
		/// <param name="discountId">Unique identifier of the discount. System-supplied and read-only.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var discount = new Discount();
		///   await discount.DeleteDiscountAsync( discountId);
		/// </code>
		/// </example>
		public virtual async Task DeleteDiscountAsync(int discountId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.DiscountClient.DeleteDiscountClient( discountId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


	}

}


