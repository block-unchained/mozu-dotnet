
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

namespace Mozu.Api.Resources.Commerce
{
	/// <summary>
	/// Use the Customer In-Stock Notification Subscription resource to manage the subscriptions customer accounts use to send product notifications. This resource can send a notification when a product in a catalog returns to a site's active inventory after it is out of stock, or when a new product becomes available for the first time.
	/// </summary>
	public partial class InStockNotificationSubscriptionResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public InStockNotificationSubscriptionResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public InStockNotificationSubscriptionResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new InStockNotificationSubscriptionResource(_apiContext.CloneWith(contextModification));
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
		/// <see cref="Mozu.Api.Contracts.Customer.InStockNotificationSubscriptionCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var instocknotificationsubscription = new InStockNotificationSubscription();
		///   var inStockNotificationSubscriptionCollection = await instocknotificationsubscription.GetInStockNotificationSubscriptionsAsync( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.InStockNotificationSubscriptionCollection> GetInStockNotificationSubscriptionsAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Customer.InStockNotificationSubscriptionCollection> response;
			var client = Mozu.Api.Clients.Commerce.InStockNotificationSubscriptionClient.GetInStockNotificationSubscriptionsClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="id">Unique identifier of the in-stock notification subscription to retrieve.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.InStockNotificationSubscription"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var instocknotificationsubscription = new InStockNotificationSubscription();
		///   var inStockNotificationSubscription = await instocknotificationsubscription.GetInStockNotificationSubscriptionAsync( id,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.InStockNotificationSubscription> GetInStockNotificationSubscriptionAsync(int id, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Customer.InStockNotificationSubscription> response;
			var client = Mozu.Api.Clients.Commerce.InStockNotificationSubscriptionClient.GetInStockNotificationSubscriptionClient( id,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="inStockNotificationSubscription">Properties of a subscription that sends the customer a notification when a product is available in a site's active stock.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.InStockNotificationSubscription"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var instocknotificationsubscription = new InStockNotificationSubscription();
		///   var inStockNotificationSubscription = await instocknotificationsubscription.AddInStockNotificationSubscriptionAsync( inStockNotificationSubscription,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.InStockNotificationSubscription> AddInStockNotificationSubscriptionAsync(Mozu.Api.Contracts.Customer.InStockNotificationSubscription inStockNotificationSubscription, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Customer.InStockNotificationSubscription> response;
			var client = Mozu.Api.Clients.Commerce.InStockNotificationSubscriptionClient.AddInStockNotificationSubscriptionClient( inStockNotificationSubscription,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="id">Unique identifier of the customer in-stock notification subscription to delete.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var instocknotificationsubscription = new InStockNotificationSubscription();
		///   await instocknotificationsubscription.DeleteInStockNotificationSubscriptionAsync( id);
		/// </code>
		/// </example>
		public virtual async Task DeleteInStockNotificationSubscriptionAsync(int id, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.InStockNotificationSubscriptionClient.DeleteInStockNotificationSubscriptionClient( id);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


	}

}


