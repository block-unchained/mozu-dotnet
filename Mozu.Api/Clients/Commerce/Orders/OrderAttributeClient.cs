
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

namespace Mozu.Api.Clients.Commerce.Orders
{
	/// <summary>
	/// Use the Order Attributes resource to define how an order attribute definition applies to a specific order.
	/// </summary>
	public partial class OrderAttributeClient 	{
		
		/// <summary>
		/// Retrieves a list of the attributes defined for the order specified in the request.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order for which to retrieve a list of defined attributes.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetOrderAttributes( orderId);
		///   var orderAttributeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute>> GetOrderAttributesClient(string orderId)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.OrderAttributeUrl.GetOrderAttributesUrl(orderId);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute>>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Applies a list of attributes to the order specified in the request and defines a value for each attribute in the request body.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order for which to assign the attributes.</param>
		/// <param name="orderAttributes">The list of attributes to associate with the order, and the properties of each attribute to define for the order.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateOrderAttributes( orderAttributes,  orderId);
		///   var orderAttributeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute>> CreateOrderAttributesClient(List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute> orderAttributes, string orderId)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.OrderAttributeUrl.CreateOrderAttributesUrl(orderId);
			const string verb = "POST";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute>>(orderAttributes);
			return mozuClient;

		}

		/// <summary>
		/// Updates one or more properties of an attribute defined for the order specified in the request.
		/// </summary>
		/// <param name="orderId">Identifier of the order for which to update attributes.</param>
		/// <param name="removeMissing">If true, the operation removes missing properties so that the updated order attributes will not show properties with a null value.</param>
		/// <param name="orderAttributes">List of order attributes to update, including the properties of each defined attribute in the list.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateOrderAttributes( orderAttributes,  orderId,  removeMissing);
		///   var orderAttributeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute>> UpdateOrderAttributesClient(List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute> orderAttributes, string orderId, bool? removeMissing =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.OrderAttributeUrl.UpdateOrderAttributesUrl(orderId, removeMissing);
			const string verb = "PUT";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute>>(orderAttributes);
			return mozuClient;

		}


	}

}


