
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
	/// 
	/// </summary>
	public partial class PriceListResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public PriceListResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public PriceListResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new PriceListResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.PriceListCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelist = new PriceList();
		///   var priceListCollection = await pricelist.GetPriceListsAsync( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.PriceListCollection> GetPriceListsAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.PriceListCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PriceListClient.GetPriceListsClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="priceListCode"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.PriceList"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelist = new PriceList();
		///   var priceList = await pricelist.GetPriceListAsync( priceListCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.PriceList> GetPriceListAsync(string priceListCode, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.PriceList> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PriceListClient.GetPriceListClient( priceListCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="priceList"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.PriceList"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelist = new PriceList();
		///   var priceList = await pricelist.AddPriceListAsync( priceList,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.PriceList> AddPriceListAsync(Mozu.Api.Contracts.ProductAdmin.PriceList priceList, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.PriceList> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PriceListClient.AddPriceListClient( priceList,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="invalidateCache"></param>
		/// <param name="publishEvents"></param>
		/// <param name="priceListEntriesIn"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelist = new PriceList();
		///   await pricelist.BulkAddPriceListEntriesAsync( priceListEntriesIn,  publishEvents,  invalidateCache);
		/// </code>
		/// </example>
		public virtual async Task BulkAddPriceListEntriesAsync(List<Mozu.Api.Contracts.ProductAdmin.PriceListEntry> priceListEntriesIn, bool? publishEvents =  null, bool? invalidateCache =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PriceListClient.BulkAddPriceListEntriesClient( priceListEntriesIn,  publishEvents,  invalidateCache);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="invalidateCache"></param>
		/// <param name="publishEvents"></param>
		/// <param name="priceListEntriesIn"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelist = new PriceList();
		///   await pricelist.BulkDeletePriceListEntriesAsync( priceListEntriesIn,  publishEvents,  invalidateCache);
		/// </code>
		/// </example>
		public virtual async Task BulkDeletePriceListEntriesAsync(List<Mozu.Api.Contracts.ProductAdmin.PriceListEntry> priceListEntriesIn, bool? publishEvents =  null, bool? invalidateCache =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PriceListClient.BulkDeletePriceListEntriesClient( priceListEntriesIn,  publishEvents,  invalidateCache);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="invalidateCache"></param>
		/// <param name="publishEvents"></param>
		/// <param name="priceListEntriesIn"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelist = new PriceList();
		///   await pricelist.BulkUpdatePriceListEntriesAsync( priceListEntriesIn,  publishEvents,  invalidateCache);
		/// </code>
		/// </example>
		public virtual async Task BulkUpdatePriceListEntriesAsync(List<Mozu.Api.Contracts.ProductAdmin.PriceListEntry> priceListEntriesIn, bool? publishEvents =  null, bool? invalidateCache =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PriceListClient.BulkUpdatePriceListEntriesClient( priceListEntriesIn,  publishEvents,  invalidateCache);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="priceListCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="priceList"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.PriceList"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelist = new PriceList();
		///   var priceList = await pricelist.UpdatePriceListAsync( priceList,  priceListCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.PriceList> UpdatePriceListAsync(Mozu.Api.Contracts.ProductAdmin.PriceList priceList, string priceListCode, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.PriceList> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PriceListClient.UpdatePriceListClient( priceList,  priceListCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="cascadeDeleteEntries"></param>
		/// <param name="priceListCode"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelist = new PriceList();
		///   await pricelist.DeletePriceListAsync( priceListCode,  cascadeDeleteEntries);
		/// </code>
		/// </example>
		public virtual async Task DeletePriceListAsync(string priceListCode, bool? cascadeDeleteEntries =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PriceListClient.DeletePriceListClient( priceListCode,  cascadeDeleteEntries);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


	}

}


