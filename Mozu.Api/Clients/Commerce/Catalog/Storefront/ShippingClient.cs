
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

namespace Mozu.Api.Clients.Commerce.Catalog.Storefront
{
	/// <summary>
	/// Use the Storefront Shipping resource to retrieve shipping rate information from the website.
	/// </summary>
	public partial class ShippingClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="includeRawResponse"></param>
		/// <param name="rateRequestGroupList"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ShippingRuntime.RatesResponseGroup"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetMultiRates( rateRequestGroupList,  includeRawResponse);
		///   var ratesResponseGroupClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ShippingRuntime.RatesResponseGroup>> GetMultiRatesClient(List<Mozu.Api.Contracts.ShippingRuntime.RateRequestGroup> rateRequestGroupList, bool? includeRawResponse =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Storefront.ShippingUrl.GetMultiRatesUrl(includeRawResponse);
			const string verb = "POST";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ShippingRuntime.RatesResponseGroup>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.ShippingRuntime.RateRequestGroup>>(rateRequestGroupList);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="includeRawResponse"></param>
		/// <param name="responseFields"></param>
		/// <param name="rateRequest">Properties of the shipping rate request sent on behalf of the storefront website.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ShippingRuntime.RatesResponse"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetRates( rateRequest,  includeRawResponse,  responseFields);
		///   var ratesResponseClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ShippingRuntime.RatesResponse> GetRatesClient(Mozu.Api.Contracts.ShippingRuntime.RateRequest rateRequest, bool? includeRawResponse =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Storefront.ShippingUrl.GetRatesUrl(includeRawResponse, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ShippingRuntime.RatesResponse>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ShippingRuntime.RateRequest>(rateRequest);
			return mozuClient;

		}


	}

}


