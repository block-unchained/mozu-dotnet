
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

using Mozu.Api.Contracts.PaymentService;

namespace Mozu.Api.Contracts.SiteSettings.Order
{
		///
		///	Properties of a payment gateway defined for the site.
		///
		public class Gateway
		{
			public bool AreGatewayCredentialFieldsSet { get; set; }

			public GatewayAccount GatewayAccount { get; set; }

			public GatewayDefinition GatewayDefinition { get; set; }

			public List<string> SupportedCards { get; set; }

		}

}