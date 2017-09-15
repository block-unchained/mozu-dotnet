
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

namespace Mozu.Api.Resources.Commerce.Checkouts
{
	/// <summary>
	/// 
	/// </summary>
	public partial class PaymentResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public PaymentResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public PaymentResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new PaymentResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="checkoutId"></param>
		/// <param name="paymentId"></param>
		/// <param name="responseFields"></param>
		/// <param name="action"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var payment = new Payment();
		///   var checkout = await payment.PerformPaymentActionAsync( action,  checkoutId,  paymentId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout> PerformPaymentActionAsync(Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction action, string checkoutId, string paymentId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout> response;
			var client = Mozu.Api.Clients.Commerce.Checkouts.PaymentClient.PerformPaymentActionClient( action,  checkoutId,  paymentId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="checkoutId"></param>
		/// <param name="responseFields"></param>
		/// <param name="action"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var payment = new Payment();
		///   var checkout = await payment.CreatePaymentActionAsync( action,  checkoutId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout> CreatePaymentActionAsync(Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction action, string checkoutId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Checkouts.Checkout> response;
			var client = Mozu.Api.Clients.Commerce.Checkouts.PaymentClient.CreatePaymentActionClient( action,  checkoutId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


	}

}


