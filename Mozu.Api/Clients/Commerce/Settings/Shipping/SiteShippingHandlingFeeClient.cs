
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

namespace Mozu.Api.Clients.Commerce.Settings.Shipping
{
	/// <summary>
	/// Use the Order Handling Fee subresource to configure any shipping and handling fees to apply to orders for this site.
	/// </summary>
	public partial class SiteShippingHandlingFeeClient 	{
		
		/// <summary>
		/// Retrieves the details of the order handling fee configured for the site.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.SiteSettings.Shipping.SiteShippingHandlingFee"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetOrderHandlingFee( responseFields);
		///   var siteShippingHandlingFeeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.SiteSettings.Shipping.SiteShippingHandlingFee> GetOrderHandlingFeeClient(string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.Shipping.SiteShippingHandlingFeeUrl.GetOrderHandlingFeeUrl(responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.SiteSettings.Shipping.SiteShippingHandlingFee>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Creates a new order handling fee for the site.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="orderHandlingFee">Properties of the order handling fee to assess for order shipment.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.SiteSettings.Shipping.SiteShippingHandlingFee"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateOrderHandlingFee( orderHandlingFee,  responseFields);
		///   var siteShippingHandlingFeeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.SiteSettings.Shipping.SiteShippingHandlingFee> CreateOrderHandlingFeeClient(Mozu.Api.Contracts.SiteSettings.Shipping.SiteShippingHandlingFee orderHandlingFee, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.Shipping.SiteShippingHandlingFeeUrl.CreateOrderHandlingFeeUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.SiteSettings.Shipping.SiteShippingHandlingFee>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.SiteSettings.Shipping.SiteShippingHandlingFee>(orderHandlingFee);
			return mozuClient;

		}

		/// <summary>
		/// Updates the order handling fee amount for the site.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="orderHandlingFee">The combined price for all items in the order, including all selected options but excluding any discounts.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.SiteSettings.Shipping.SiteShippingHandlingFee"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateOrderHandlingFee( orderHandlingFee,  responseFields);
		///   var siteShippingHandlingFeeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.SiteSettings.Shipping.SiteShippingHandlingFee> UpdateOrderHandlingFeeClient(Mozu.Api.Contracts.SiteSettings.Shipping.SiteShippingHandlingFee orderHandlingFee, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.Shipping.SiteShippingHandlingFeeUrl.UpdateOrderHandlingFeeUrl(responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.SiteSettings.Shipping.SiteShippingHandlingFee>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.SiteSettings.Shipping.SiteShippingHandlingFee>(orderHandlingFee);
			return mozuClient;

		}


	}

}


