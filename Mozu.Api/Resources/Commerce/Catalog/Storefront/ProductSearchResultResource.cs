
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

namespace Mozu.Api.Resources.Commerce.Catalog.Storefront
{
	/// <summary>
	/// Use the Product Search resource to provide dynamic search results to shoppers as they browse and search for products on the web storefront, and to suggest possible search terms as the shopper enters text.
	/// </summary>
	public partial class ProductSearchResultResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public ProductSearchResultResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public ProductSearchResultResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new ProductSearchResultResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="query"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.ProductSearchRandomAccessCursor"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productsearchresult = new ProductSearchResult();
		///   var productSearchRandomAccessCursor = await productsearchresult.GetRandomAccessCursorAsync( query,  filter,  pageSize,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductRuntime.ProductSearchRandomAccessCursor> GetRandomAccessCursorAsync(string query =  null, string filter =  null, int? pageSize =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.ProductSearchRandomAccessCursor> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductSearchResultClient.GetRandomAccessCursorClient( query,  filter,  pageSize,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Searches the categories displayed on the web storefront for products or product options that the shopper types in a search query.
		/// </summary>
		/// <param name="cursorMark"></param>
		/// <param name="enableSearchTuningRules"></param>
		/// <param name="facet">Individually list the facet fields you want to display in a web storefront product search.</param>
		/// <param name="facetFieldRangeQuery">Display a range facet not specified in a template in a web storefront product search by listing the facet field and the range to display.</param>
		/// <param name="facetHierDepth">If filtering using category facets in a hierarchy, the number of category hierarchy levels to return for the facet. This option is only available for category facets.</param>
		/// <param name="facetHierPrefix">If filtering using category facets in a hierarchy, the parent categories you want to skip in the storefront product search. This parameter is only available for category facets.</param>
		/// <param name="facetHierValue">If filtering using category facets in a hierarchy, the category in the hierarchy to begin faceting on. This parameter is only available for category facets.</param>
		/// <param name="facetPageSize">The number of facet values to return for one or more facets.</param>
		/// <param name="facetPrefix"></param>
		/// <param name="facetSettings">Settings reserved for future facet search functionality on a web storefront product search.</param>
		/// <param name="facetStartIndex">When paging through multiple facets, the startIndex value for each facet.</param>
		/// <param name="facetTemplate">The facet template to use on the storefront. A template displays all facets associated with the template on the web storefront product search. Currently, only category-level facet templates are available.</param>
		/// <param name="facetTemplateExclude"></param>
		/// <param name="facetTemplateSubset">Display a subset of the facets defined in the template specified in facetTemplate parameter.</param>
		/// <param name="facetValueFilter">The facet values to apply to the filter.</param>
		/// <param name="facetValueSort"></param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. You can filter product search results by any of its properties, including product code, type, category, and name. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=categoryId+eq+12"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="query">The terms to search on.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="responseOptions"></param>
		/// <param name="searchSettings"></param>
		/// <param name="searchTuningRuleCode"></param>
		/// <param name="searchTuningRuleContext"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.ProductSearchResult"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productsearchresult = new ProductSearchResult();
		///   var productSearchResult = await productsearchresult.SearchAsync( query,  filter,  facetTemplate,  facetTemplateSubset,  facet,  facetFieldRangeQuery,  facetHierPrefix,  facetHierValue,  facetHierDepth,  facetStartIndex,  facetPageSize,  facetSettings,  facetValueFilter,  sortBy,  pageSize,  startIndex,  searchSettings,  enableSearchTuningRules,  searchTuningRuleContext,  searchTuningRuleCode,  facetTemplateExclude,  facetPrefix,  responseOptions,  cursorMark,  facetValueSort,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductRuntime.ProductSearchResult> SearchAsync(string query =  null, string filter =  null, string facetTemplate =  null, string facetTemplateSubset =  null, string facet =  null, string facetFieldRangeQuery =  null, string facetHierPrefix =  null, string facetHierValue =  null, string facetHierDepth =  null, string facetStartIndex =  null, string facetPageSize =  null, string facetSettings =  null, string facetValueFilter =  null, string sortBy =  null, int? pageSize =  null, int? startIndex =  null, string searchSettings =  null, bool? enableSearchTuningRules =  null, string searchTuningRuleContext =  null, string searchTuningRuleCode =  null, string facetTemplateExclude =  null, string facetPrefix =  null, string responseOptions =  null, string cursorMark =  null, string facetValueSort =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.ProductSearchResult> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductSearchResultClient.SearchClient( query,  filter,  facetTemplate,  facetTemplateSubset,  facet,  facetFieldRangeQuery,  facetHierPrefix,  facetHierValue,  facetHierDepth,  facetStartIndex,  facetPageSize,  facetSettings,  facetValueFilter,  sortBy,  pageSize,  startIndex,  searchSettings,  enableSearchTuningRules,  searchTuningRuleContext,  searchTuningRuleCode,  facetTemplateExclude,  facetPrefix,  responseOptions,  cursorMark,  facetValueSort,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Suggests possible search terms as the shopper enters search text.
		/// </summary>
		/// <param name="groups"></param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="query"></param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.SearchSuggestionResult"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productsearchresult = new ProductSearchResult();
		///   var searchSuggestionResult = await productsearchresult.SuggestAsync( query,  groups,  pageSize,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductRuntime.SearchSuggestionResult> SuggestAsync(string query =  null, string groups =  null, int? pageSize =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.SearchSuggestionResult> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductSearchResultClient.SuggestClient( query,  groups,  pageSize,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


	}

}


