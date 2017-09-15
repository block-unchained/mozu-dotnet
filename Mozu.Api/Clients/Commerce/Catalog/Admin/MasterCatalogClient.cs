
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

namespace Mozu.Api.Clients.Commerce.Catalog.Admin
{
	/// <summary>
	/// Use the Master Catalog resource to view details of the master catalogs associated with a tenant and to manage the product publishing mode for each master catalog.
	/// </summary>
	public partial class MasterCatalogClient 	{
		
		/// <summary>
		/// Retrieve the details of all master catalog associated with a tenant.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.MasterCatalogCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetMasterCatalogs( responseFields);
		///   var masterCatalogCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.MasterCatalogCollection> GetMasterCatalogsClient(string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.MasterCatalogUrl.GetMasterCatalogsUrl(responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.MasterCatalogCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieve the details of the master catalog specified in the request.
		/// </summary>
		/// <param name="masterCatalogId">The unique identifier of the master catalog associated with the entity.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.MasterCatalog"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetMasterCatalog( masterCatalogId,  responseFields);
		///   var masterCatalogClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.MasterCatalog> GetMasterCatalogClient(int masterCatalogId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.MasterCatalogUrl.GetMasterCatalogUrl(masterCatalogId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.MasterCatalog>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Updates the product publishing mode for the master catalog specified in the request.
		/// </summary>
		/// <param name="masterCatalogId"></param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="masterCatalog">Properties of the master catalog to update, which consists of the product publishing mode. Possible values are "Pending" which saves product updates in draft mode until they are published, and "Live" which publishes all product changes immediately.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.MasterCatalog"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateMasterCatalog( masterCatalog,  masterCatalogId,  responseFields);
		///   var masterCatalogClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.MasterCatalog> UpdateMasterCatalogClient(Mozu.Api.Contracts.ProductAdmin.MasterCatalog masterCatalog, int masterCatalogId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.MasterCatalogUrl.UpdateMasterCatalogUrl(masterCatalogId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.MasterCatalog>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.MasterCatalog>(masterCatalog);
			return mozuClient;

		}


	}

}


