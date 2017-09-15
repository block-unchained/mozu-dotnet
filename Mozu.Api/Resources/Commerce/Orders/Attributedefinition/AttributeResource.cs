
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

namespace Mozu.Api.Resources.Commerce.Orders.Attributedefinition
{
	/// <summary>
	/// Use the Order Attribute Definition resource to manage the attributes that uniquely describe orders, such as the associated shopping season or "How did you hear about us?". Merchants can display order attributes on the order summary, the order confirmation page, invoices, or packing slips.
	/// </summary>
	public partial class AttributeResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public AttributeResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public AttributeResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new AttributeResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// Retrieves a list of order attributes according to any filter criteria or sort options.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Core.Extensible.AttributeCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attribute = new Attribute();
		///   var attributeCollection = await attribute.GetAttributesAsync( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Core.Extensible.AttributeCollection> GetAttributesAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Core.Extensible.AttributeCollection> response;
			var client = Mozu.Api.Clients.Commerce.Orders.Attributedefinition.AttributeClient.GetAttributesClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Returns the list of vocabulary values defined for the order attribute specified in the request.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.Core.Extensible.AttributeVocabularyValue"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var attribute = new Attribute();
		///   var attributeVocabularyValue = await attribute.GetAttributeVocabularyValuesAsync( attributeFQN);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.Core.Extensible.AttributeVocabularyValue>> GetAttributeVocabularyValuesAsync(string attributeFQN, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.Core.Extensible.AttributeVocabularyValue>> response;
			var client = Mozu.Api.Clients.Commerce.Orders.Attributedefinition.AttributeClient.GetAttributeVocabularyValuesClient( attributeFQN);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Retrieves the details of the order attribute specified in the request.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Core.Extensible.Attribute"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attribute = new Attribute();
		///   var attribute = await attribute.GetAttributeAsync( attributeFQN,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Core.Extensible.Attribute> GetAttributeAsync(string attributeFQN, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Core.Extensible.Attribute> response;
			var client = Mozu.Api.Clients.Commerce.Orders.Attributedefinition.AttributeClient.GetAttributeClient( attributeFQN,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Creates a new attribute to describe one aspect of an order.
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="attribute">The properties of the order attribute to create.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Core.Extensible.Attribute"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attribute = new Attribute();
		///   var attribute = await attribute.CreateAttributeAsync( attribute,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Core.Extensible.Attribute> CreateAttributeAsync(Mozu.Api.Contracts.Core.Extensible.Attribute attribute, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Core.Extensible.Attribute> response;
			var client = Mozu.Api.Clients.Commerce.Orders.Attributedefinition.AttributeClient.CreateAttributeClient( attribute,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Updates one or more properties of an order attribute.
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="responseFields"></param>
		/// <param name="attribute">The properties of the order attribute to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Core.Extensible.Attribute"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attribute = new Attribute();
		///   var attribute = await attribute.UpdateAttributeAsync( attribute,  attributeFQN,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Core.Extensible.Attribute> UpdateAttributeAsync(Mozu.Api.Contracts.Core.Extensible.Attribute attribute, string attributeFQN, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Core.Extensible.Attribute> response;
			var client = Mozu.Api.Clients.Commerce.Orders.Attributedefinition.AttributeClient.UpdateAttributeClient( attribute,  attributeFQN,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


	}

}


