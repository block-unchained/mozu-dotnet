
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
	/// Temporarily hold a product from inventory while a shopper is filling out payment information. Create a product reservation when a shopper proceeds to check out and then release the reservation when the order process is complete.
	/// </summary>
	public partial class ProductReservationResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		private readonly DataViewMode _dataViewMode;
		
		public ProductReservationResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
			_dataViewMode = DataViewMode.Live;
		}

		public ProductReservationResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new ProductReservationResource(_apiContext.CloneWith(contextModification), _dataViewMode);
		}

		public ProductReservationResource(IApiContext apiContext, DataViewMode dataViewMode) 
		{
			_apiContext = apiContext;
			_dataViewMode = dataViewMode;
		}
				

		/// <summary>
		/// Retrieves a list of product reservations according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductReservationCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productreservation = new ProductReservation();
		///   var productReservationCollection = await productreservation.GetProductReservationsAsync(_dataViewMode,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductReservationCollection> GetProductReservationsAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductReservationCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductReservationClient.GetProductReservationsClient(_dataViewMode,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Retrieves the details of a product reservation.
		/// </summary>
		/// <param name="productReservationId">Unique identifier of the product reservation.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductReservation"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productreservation = new ProductReservation();
		///   var productReservation = await productreservation.GetProductReservationAsync(_dataViewMode,  productReservationId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductReservation> GetProductReservationAsync(int productReservationId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductReservation> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductReservationClient.GetProductReservationClient(_dataViewMode,  productReservationId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Creates a new product reservation for a product. This action places a hold on the product inventory for the quantity specified during the ordering process.
		/// </summary>
		/// <param name="skipInventoryCheck">If true, skip the process to validate inventory when creating this product reservation.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="productReservations">Details of the product reservations to add.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductReservation"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var productreservation = new ProductReservation();
		///   var productReservation = await productreservation.AddProductReservationsAsync(_dataViewMode,  productReservations,  skipInventoryCheck);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.ProductReservation>> AddProductReservationsAsync(List<Mozu.Api.Contracts.ProductAdmin.ProductReservation> productReservations, bool? skipInventoryCheck =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductReservation>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductReservationClient.AddProductReservationsClient(_dataViewMode,  productReservations,  skipInventoryCheck);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Commits a product reservation to decrement the product's inventory by the quantity specified then release the reservation once the order process completed successfully.
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="productReservations">List of unique identifiers of the reservations to commit.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var productreservation = new ProductReservation();
		///   await productreservation.CommitReservationsAsync(_dataViewMode,  productReservations);
		/// </code>
		/// </example>
		public virtual async Task CommitReservationsAsync(List<Mozu.Api.Contracts.ProductAdmin.ProductReservation> productReservations, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductReservationClient.CommitReservationsClient(_dataViewMode,  productReservations);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


		/// <summary>
		/// Updates an existing product reservation for a product.
		/// </summary>
		/// <param name="skipInventoryCheck">If true, skip the inventory validation process when updating this product reservation.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="productReservations">Properties of the product reservations to update.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductReservation"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var productreservation = new ProductReservation();
		///   var productReservation = await productreservation.UpdateProductReservationsAsync(_dataViewMode,  productReservations,  skipInventoryCheck);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.ProductReservation>> UpdateProductReservationsAsync(List<Mozu.Api.Contracts.ProductAdmin.ProductReservation> productReservations, bool? skipInventoryCheck =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductReservation>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductReservationClient.UpdateProductReservationsClient(_dataViewMode,  productReservations,  skipInventoryCheck);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Deletes a product reservation. For example, delete a reservation when an order is not processed to return the product quantity back to inventory.
		/// </summary>
		/// <param name="productReservationId">Unique identifier of the reservation.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var productreservation = new ProductReservation();
		///   await productreservation.DeleteProductReservationAsync(_dataViewMode,  productReservationId);
		/// </code>
		/// </example>
		public virtual async Task DeleteProductReservationAsync(int productReservationId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductReservationClient.DeleteProductReservationClient(_dataViewMode,  productReservationId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


	}

}


