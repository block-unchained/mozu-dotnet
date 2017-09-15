
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

namespace Mozu.Api.Clients.Platform.Entitylists
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ListViewClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="entityId"></param>
		/// <param name="entityListFullName"></param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="viewName"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{JObject}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetViewEntity( entityListFullName,  viewName,  entityId,  responseFields);
		///   var jsonClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<JObject> GetViewEntityClient(string entityListFullName, string viewName, string entityId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.Entitylists.ListViewUrl.GetViewEntityUrl(entityListFullName, viewName, entityId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<JObject>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="entityListFullName"></param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize"></param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="startIndex"></param>
		/// <param name="viewName"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.MZDB.EntityCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetViewEntities( entityListFullName,  viewName,  pageSize,  startIndex,  filter,  responseFields);
		///   var entityCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.MZDB.EntityCollection> GetViewEntitiesClient(string entityListFullName, string viewName, int? pageSize =  null, int? startIndex =  null, string filter =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.Entitylists.ListViewUrl.GetViewEntitiesUrl(entityListFullName, viewName, pageSize, startIndex, filter, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.MZDB.EntityCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="entityId"></param>
		/// <param name="entityListFullName"></param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="viewName"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.MZDB.EntityContainer"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetViewEntityContainer( entityListFullName,  viewName,  entityId,  responseFields);
		///   var entityContainerClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.MZDB.EntityContainer> GetViewEntityContainerClient(string entityListFullName, string viewName, string entityId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.Entitylists.ListViewUrl.GetViewEntityContainerUrl(entityListFullName, viewName, entityId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.MZDB.EntityContainer>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="entityListFullName"></param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize"></param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="startIndex"></param>
		/// <param name="viewName"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.MZDB.EntityContainerCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetViewEntityContainers( entityListFullName,  viewName,  pageSize,  startIndex,  filter,  responseFields);
		///   var entityContainerCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.MZDB.EntityContainerCollection> GetViewEntityContainersClient(string entityListFullName, string viewName, int? pageSize =  null, int? startIndex =  null, string filter =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.Entitylists.ListViewUrl.GetViewEntityContainersUrl(entityListFullName, viewName, pageSize, startIndex, filter, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.MZDB.EntityContainerCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="entityListFullName"></param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="viewName"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.MZDB.ListView"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetEntityListView( entityListFullName,  viewName,  responseFields);
		///   var listViewClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.MZDB.ListView> GetEntityListViewClient(string entityListFullName, string viewName, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.Entitylists.ListViewUrl.GetEntityListViewUrl(entityListFullName, viewName, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.MZDB.ListView>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="entityListFullName"></param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.MZDB.ListViewCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetEntityListViews( entityListFullName,  responseFields);
		///   var listViewCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.MZDB.ListViewCollection> GetEntityListViewsClient(string entityListFullName, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.Entitylists.ListViewUrl.GetEntityListViewsUrl(entityListFullName, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.MZDB.ListViewCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="entityListFullName"></param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="listView"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.MZDB.ListView"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateEntityListView( listView,  entityListFullName,  responseFields);
		///   var listViewClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.MZDB.ListView> CreateEntityListViewClient(Mozu.Api.Contracts.MZDB.ListView listView, string entityListFullName, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.Entitylists.ListViewUrl.CreateEntityListViewUrl(entityListFullName, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.MZDB.ListView>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.MZDB.ListView>(listView);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="entityListFullName"></param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="viewName"></param>
		/// <param name="listView"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.MZDB.ListView"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateEntityListView( listView,  entityListFullName,  viewName,  responseFields);
		///   var listViewClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.MZDB.ListView> UpdateEntityListViewClient(Mozu.Api.Contracts.MZDB.ListView listView, string entityListFullName, string viewName, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.Entitylists.ListViewUrl.UpdateEntityListViewUrl(entityListFullName, viewName, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.MZDB.ListView>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.MZDB.ListView>(listView);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="entityListFullName"></param>
		/// <param name="viewName"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteEntityListView( entityListFullName,  viewName);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteEntityListViewClient(string entityListFullName, string viewName)
		{
			var url = Mozu.Api.Urls.Platform.Entitylists.ListViewUrl.DeleteEntityListViewUrl(entityListFullName, viewName);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


