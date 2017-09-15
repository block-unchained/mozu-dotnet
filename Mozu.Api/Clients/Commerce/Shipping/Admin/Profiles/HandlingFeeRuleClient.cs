
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

namespace Mozu.Api.Clients.Commerce.Shipping.Admin.Profiles
{
	/// <summary>
	/// 
	/// </summary>
	public partial class HandlingFeeRuleClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <param name="profilecode"></param>
		/// <param name="responseFields"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ShippingAdmin.Profile.HandlingFeeRule"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetProductHandlingFeeRule(dataViewMode,  profilecode,  id,  responseFields);
		///   var handlingFeeRuleClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ShippingAdmin.Profile.HandlingFeeRule> GetProductHandlingFeeRuleClient(DataViewMode dataViewMode, string profilecode, string id, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Shipping.Admin.Profiles.HandlingFeeRuleUrl.GetProductHandlingFeeRuleUrl(profilecode, id, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ShippingAdmin.Profile.HandlingFeeRule>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="profilecode"></param>
		/// <param name="responseFields"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ShippingAdmin.Profile.HandlingFeeRuleCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetProductHandlingFeeRules(dataViewMode,  profilecode,  responseFields);
		///   var handlingFeeRuleCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ShippingAdmin.Profile.HandlingFeeRuleCollection> GetProductHandlingFeeRulesClient(DataViewMode dataViewMode, string profilecode, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Shipping.Admin.Profiles.HandlingFeeRuleUrl.GetProductHandlingFeeRulesUrl(profilecode, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ShippingAdmin.Profile.HandlingFeeRuleCollection>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="profilecode"></param>
		/// <param name="responseFields"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="rule"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ShippingAdmin.Profile.HandlingFeeRule"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateProductHandlingFeeRule( rule,  profilecode,  responseFields);
		///   var handlingFeeRuleClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ShippingAdmin.Profile.HandlingFeeRule> CreateProductHandlingFeeRuleClient(Mozu.Api.Contracts.ShippingAdmin.Profile.HandlingFeeRule rule, string profilecode, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Shipping.Admin.Profiles.HandlingFeeRuleUrl.CreateProductHandlingFeeRuleUrl(profilecode, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ShippingAdmin.Profile.HandlingFeeRule>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ShippingAdmin.Profile.HandlingFeeRule>(rule);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <param name="profilecode"></param>
		/// <param name="responseFields"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="rule"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ShippingAdmin.Profile.HandlingFeeRule"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateProductHandlingFeeRule(dataViewMode,  rule,  profilecode,  id,  responseFields);
		///   var handlingFeeRuleClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ShippingAdmin.Profile.HandlingFeeRule> UpdateProductHandlingFeeRuleClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ShippingAdmin.Profile.HandlingFeeRule rule, string profilecode, string id, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Shipping.Admin.Profiles.HandlingFeeRuleUrl.UpdateProductHandlingFeeRuleUrl(profilecode, id, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ShippingAdmin.Profile.HandlingFeeRule>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ShippingAdmin.Profile.HandlingFeeRule>(rule)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <param name="profilecode"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteProductHandlingFeeRule(dataViewMode,  profilecode,  id);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteProductHandlingFeeRuleClient(DataViewMode dataViewMode, string profilecode, string id)
		{
			var url = Mozu.Api.Urls.Commerce.Shipping.Admin.Profiles.HandlingFeeRuleUrl.DeleteProductHandlingFeeRuleUrl(profilecode, id);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}


	}

}


