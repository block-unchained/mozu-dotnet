
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

namespace Mozu.Api.Resources.Commerce.Orders
{
	/// <summary>
	/// Use the Order Attributes resource to define how an order attribute definition applies to a specific order.
	/// </summary>
	public partial class OrderAttributeResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public OrderAttributeResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public OrderAttributeResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new OrderAttributeResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// Retrieves a list of the attributes defined for the order specified in the request.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order for which to retrieve a list of defined attributes.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var orderattribute = new OrderAttribute();
		///   var orderAttribute = await orderattribute.GetOrderAttributesAsync( orderId);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute>> GetOrderAttributesAsync(string orderId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute>> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderAttributeClient.GetOrderAttributesClient( orderId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Applies a list of attributes to the order specified in the request and defines a value for each attribute in the request body.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order for which to assign the attributes.</param>
		/// <param name="orderAttributes">The list of attributes to associate with the order, and the properties of each attribute to define for the order.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var orderattribute = new OrderAttribute();
		///   var orderAttribute = await orderattribute.CreateOrderAttributesAsync( orderAttributes,  orderId);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute>> CreateOrderAttributesAsync(List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute> orderAttributes, string orderId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute>> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderAttributeClient.CreateOrderAttributesClient( orderAttributes,  orderId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Updates one or more properties of an attribute defined for the order specified in the request.
		/// </summary>
		/// <param name="orderId">Identifier of the order for which to update attributes.</param>
		/// <param name="removeMissing">If true, the operation removes missing properties so that the updated order attributes will not show properties with a null value.</param>
		/// <param name="orderAttributes">List of order attributes to update, including the properties of each defined attribute in the list.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var orderattribute = new OrderAttribute();
		///   var orderAttribute = await orderattribute.UpdateOrderAttributesAsync( orderAttributes,  orderId,  removeMissing);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute>> UpdateOrderAttributesAsync(List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute> orderAttributes, string orderId, bool? removeMissing =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute>> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderAttributeClient.UpdateOrderAttributesClient( orderAttributes,  orderId,  removeMissing);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


	}

}


