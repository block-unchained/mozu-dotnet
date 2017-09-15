
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Newtonsoft.Json.Linq;

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.PricingRuntime
{
		///
		///	Properties of the tax context applicable for line items in an order.
		///
		public class ItemTaxContext
		{
			///
			///Unique identifier of the line item in the order.
			///
			public string Id { get; set; }

			public string ProductCode { get; set; }

			///
			///Quantity of the line item in the order.
			///
			public int Quantity { get; set; }

			///
			///Amount of tax applied to shipping costs for the line item in the order.
			///
			public decimal ShippingTax { get; set; }

			///
			///The total tax amount applied to the line item in the order, minus any shipping taxes.
			///
			public decimal Tax { get; set; }

			public JObject TaxData { get; set; }

		}

}