
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

namespace Mozu.Api.Resources.Commerce
{
	/// <summary>
	/// Use the Carts resource to manage storefront shopping carts as items are added and removed. Each time a shopper's cart is modified, the Carts resource updates the estimated total with any applicable discounts.
	/// </summary>
	public partial class CartResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public CartResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public CartResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new CartResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// Retrieves the cart specified in the request.
		/// </summary>
		/// <param name="cartId">Identifier of the cart to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cart = new Cart();
		///   var cart = await cart.GetCartAsync( cartId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> GetCartAsync(string cartId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> response;
			var client = Mozu.Api.Clients.Commerce.CartClient.GetCartClient( cartId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Retrieves a cart's contents for the current shopper. If the shopper does not have an active cart on the site, the service creates one.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cart = new Cart();
		///   var cart = await cart.GetOrCreateCartAsync( responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> GetOrCreateCartAsync(string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> response;
			var client = Mozu.Api.Clients.Commerce.CartClient.GetOrCreateCartClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Retrieves summary information associated with the cart of the current shopper, including the number of items, the current total, and whether the cart has expired. All anonymous idle carts that do not proceed to checkout expire after 14 days.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.CartSummary"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cart = new Cart();
		///   var cartSummary = await cart.GetCartSummaryAsync( responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.CartSummary> GetCartSummaryAsync(string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartSummary> response;
			var client = Mozu.Api.Clients.Commerce.CartClient.GetCartSummaryClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Retrieves summary information associated with the cart of user specified in the request, including the number of items in the cart, the current total, and whether the cart has expired. All anonymous idle carts that do not proceed to checkout expire after 14 days.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="userId">Unique identifier of the user whose cart details you want to retrieve.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.CartSummary"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cart = new Cart();
		///   var cartSummary = await cart.GetUserCartSummaryAsync( userId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.CartSummary> GetUserCartSummaryAsync(string userId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartSummary> response;
			var client = Mozu.Api.Clients.Commerce.CartClient.GetUserCartSummaryClient( userId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Retrieves the cart of the user specified in the request.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="userId">Unique identifier of the user whose cart you want to retrieve.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cart = new Cart();
		///   var cart = await cart.GetUserCartAsync( userId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> GetUserCartAsync(string userId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> response;
			var client = Mozu.Api.Clients.Commerce.CartClient.GetUserCartClient( userId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Update the current shopper's cart.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="cart">All of the properties of the cart to update. The product code is required.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cart = new Cart();
		///   var cart = await cart.UpdateCartAsync( cart,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> UpdateCartAsync(Mozu.Api.Contracts.CommerceRuntime.Carts.Cart cart, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> response;
			var client = Mozu.Api.Clients.Commerce.CartClient.UpdateCartClient( cart,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Deletes the cart specified in the request.
		/// </summary>
		/// <param name="cartId">Identifier of the cart to delete.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var cart = new Cart();
		///   await cart.DeleteCartAsync( cartId);
		/// </code>
		/// </example>
		public virtual async Task DeleteCartAsync(string cartId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.CartClient.DeleteCartClient( cartId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


		/// <summary>
		/// Deletes the cart of the currently active shopper.
		/// </summary>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var cart = new Cart();
		///   await cart.DeleteCurrentCartAsync();
		/// </code>
		/// </example>
		public virtual async Task DeleteCurrentCartAsync(CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.CartClient.DeleteCurrentCartClient();
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


	}

}


