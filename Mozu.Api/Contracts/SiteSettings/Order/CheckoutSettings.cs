
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.SiteSettings.Order
{
		///
		///	Settings used when checking out an active order.
		///
		public class CheckoutSettings
		{
			public CustomerCheckoutSettings CustomerCheckoutSettings { get; set; }

			public OrderProcessingSettings OrderProcessingSettings { get; set; }

			public PaymentSettings PaymentSettings { get; set; }

		}

}