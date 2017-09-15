
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

namespace Mozu.Api.Resources.Platform.Entitylists
{
	/// <summary>
	/// 
	/// </summary>
	public partial class EntityContainerResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public EntityContainerResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public EntityContainerResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new EntityContainerResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="entityListFullName"></param>
		/// <param name="id"></param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.MZDB.EntityContainer"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var entitycontainer = new EntityContainer();
		///   var entityContainer = await entitycontainer.GetEntityContainerAsync( entityListFullName,  id,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.MZDB.EntityContainer> GetEntityContainerAsync(string entityListFullName, string id, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.MZDB.EntityContainer> response;
			var client = Mozu.Api.Clients.Platform.Entitylists.EntityContainerClient.GetEntityContainerClient( entityListFullName,  id,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="entityListFullName"></param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize"></param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.MZDB.EntityContainerCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var entitycontainer = new EntityContainer();
		///   var entityContainerCollection = await entitycontainer.GetEntityContainersAsync( entityListFullName,  pageSize,  startIndex,  filter,  sortBy,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.MZDB.EntityContainerCollection> GetEntityContainersAsync(string entityListFullName, int? pageSize =  null, int? startIndex =  null, string filter =  null, string sortBy =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.MZDB.EntityContainerCollection> response;
			var client = Mozu.Api.Clients.Platform.Entitylists.EntityContainerClient.GetEntityContainersClient( entityListFullName,  pageSize,  startIndex,  filter,  sortBy,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


	}

}


