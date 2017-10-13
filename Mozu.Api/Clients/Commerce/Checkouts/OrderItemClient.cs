
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

namespace Mozu.Api.Clients.Commerce.Checkouts
{
	/// <summary>
	/// 
	/// </summary>
	public partial class OrderItemClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="checkoutId"></param>
		/// <param name="itemId"></param>
		/// <param name="quantity"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=SplitItem( checkoutId,  itemId,  quantity,  responseFields);
		///   var checkoutClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout> SplitItemClient(string checkoutId, string itemId, int? quantity =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Checkouts.OrderItemUrl.SplitItemUrl(checkoutId, itemId, quantity, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="checkoutId"></param>
		/// <param name="responseFields"></param>
		/// <param name="itemsForDestination"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=BulkUpdateItemDestinations( itemsForDestination,  checkoutId,  responseFields);
		///   var checkoutClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout> BulkUpdateItemDestinationsClient(List<Mozu.Api.Contracts.CommerceRuntime.Checkouts.ItemsForDestination> itemsForDestination, string checkoutId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Checkouts.OrderItemUrl.BulkUpdateItemDestinationsUrl(checkoutId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.CommerceRuntime.Checkouts.ItemsForDestination>>(itemsForDestination);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="checkoutId"></param>
		/// <param name="destinationId"></param>
		/// <param name="itemId"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateItemDestination( checkoutId,  itemId,  destinationId,  responseFields);
		///   var checkoutClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout> UpdateItemDestinationClient(string checkoutId, string itemId, string destinationId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Checkouts.OrderItemUrl.UpdateItemDestinationUrl(checkoutId, itemId, destinationId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}

