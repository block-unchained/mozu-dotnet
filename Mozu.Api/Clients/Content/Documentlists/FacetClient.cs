
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

namespace Mozu.Api.Clients.Content.Documentlists
{
	/// <summary>
	/// Use the facets subresource to allow a merchant to add information for product indexing and searching.
	/// </summary>
	public partial class FacetClient 	{
		
		/// <summary>
		/// Retrieves the properties of facets that aid in indexing and searching.
		/// </summary>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <param name="propertyName">The property name associated with the facets to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.Content.Facet"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetFacets( documentListName,  propertyName);
		///   var facetClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.Content.Facet>> GetFacetsClient(string documentListName, string propertyName)
		{
			var url = Mozu.Api.Urls.Content.Documentlists.FacetUrl.GetFacetsUrl(documentListName, propertyName);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.Content.Facet>>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


