
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

namespace Mozu.Api.Clients.Commerce.Catalog.Admin
{
	/// <summary>
	/// The Search resource manages all settings and options for providing product search on your site.
	/// </summary>
	public partial class SearchClient 	{
		
		/// <summary>
		/// Retrieves the details of the specified search tuning rule.
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="searchTuningRuleCode">The unique identifier of the search tuning rule.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetSearchTuningRule( searchTuningRuleCode,  responseFields);
		///   var searchTuningRuleClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule> GetSearchTuningRuleClient(string searchTuningRuleCode, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.SearchUrl.GetSearchTuningRuleUrl(searchTuningRuleCode, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// admin-search Get GetSearchTuningRules description DOCUMENT_HERE 
		/// </summary>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query: eq=equals, ne=not equals, gt=greater than, lt = less than or equals, gt = greater than or equals, lt = less than or equals, sw = starts with, or cont = contains. Optional.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The amount is divided and displayed on the `pageCount `amount of pages. The default is 20 and maximum value is 200 per page.</param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a `pageSize `of 25, to get the 51st through the 75th items, use `startIndex=50`.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetSearchTuningRules( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		///   var searchTuningRuleCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleCollection> GetSearchTuningRulesClient(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.SearchUrl.GetSearchTuningRulesUrl(startIndex, pageSize, sortBy, filter, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// admin-search Get GetSearchTuningRuleSortFields description DOCUMENT_HERE 
		/// </summary>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetSearchTuningRuleSortFields();
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> GetSearchTuningRuleSortFieldsClient()
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.SearchUrl.GetSearchTuningRuleSortFieldsUrl();
			const string verb = "GET";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Get site search settings
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.SearchSettings"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetSettings( responseFields);
		///   var searchSettingsClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.SearchSettings> GetSettingsClient(string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.SearchUrl.GetSettingsUrl(responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.SearchSettings>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// admin-search Post AddSearchTuningRule description DOCUMENT_HERE 
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="searchTuningRuleIn">Mozu.ProductAdmin.Contracts.Search.SearchTuningRule ApiType DOCUMENT_HERE </param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddSearchTuningRule( searchTuningRuleIn,  responseFields);
		///   var searchTuningRuleClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule> AddSearchTuningRuleClient(Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule searchTuningRuleIn, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.SearchUrl.AddSearchTuningRuleUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule>(searchTuningRuleIn);
			return mozuClient;

		}

		/// <summary>
		/// admin-search Post UpdateSearchTuningRuleSortFields description DOCUMENT_HERE 
		/// </summary>
		/// <param name="searchTuningRuleSortFieldsIn">Mozu.ProductAdmin.Contracts.Search.SearchTuningRuleSortFields ApiType DOCUMENT_HERE </param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateSearchTuningRuleSortFields( searchTuningRuleSortFieldsIn);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient UpdateSearchTuningRuleSortFieldsClient(Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleSortFields searchTuningRuleSortFieldsIn)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.SearchUrl.UpdateSearchTuningRuleSortFieldsUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleSortFields>(searchTuningRuleSortFieldsIn);
			return mozuClient;

		}

		/// <summary>
		/// admin-search Put UpdateSearchTuningRule description DOCUMENT_HERE 
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="searchTuningRuleCode">The unique identifier of the search tuning rule.</param>
		/// <param name="searchTuningRuleIn">Mozu.ProductAdmin.Contracts.Search.SearchTuningRule ApiType DOCUMENT_HERE </param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateSearchTuningRule( searchTuningRuleIn,  searchTuningRuleCode,  responseFields);
		///   var searchTuningRuleClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule> UpdateSearchTuningRuleClient(Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule searchTuningRuleIn, string searchTuningRuleCode, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.SearchUrl.UpdateSearchTuningRuleUrl(searchTuningRuleCode, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule>(searchTuningRuleIn);
			return mozuClient;

		}

		/// <summary>
		/// Adds or Updates (Upsert) the Search Settings for a specific site
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="settings">The settings to control product search and indexing behavior.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.SearchSettings"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateSettings( settings,  responseFields);
		///   var searchSettingsClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.SearchSettings> UpdateSettingsClient(Mozu.Api.Contracts.ProductAdmin.SearchSettings settings, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.SearchUrl.UpdateSettingsUrl(responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.SearchSettings>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.SearchSettings>(settings);
			return mozuClient;

		}

		/// <summary>
		/// Deletes the specified search tuning rule.
		/// </summary>
		/// <param name="searchTuningRuleCode">The unique identifier of the search tuning rule.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteSearchTuningRule( searchTuningRuleCode);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteSearchTuningRuleClient(string searchTuningRuleCode)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.SearchUrl.DeleteSearchTuningRuleUrl(searchTuningRuleCode);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


