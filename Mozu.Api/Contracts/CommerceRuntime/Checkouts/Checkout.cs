
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
using Newtonsoft.Json.Linq;

using Mozu.Api.Contracts.CommerceRuntime.Commerce;
using Mozu.Api.Contracts.CommerceRuntime.Discounts;
using Mozu.Api.Contracts.CommerceRuntime.Fulfillment;
using Mozu.Api.Contracts.CommerceRuntime.Orders;
using Mozu.Api.Contracts.CommerceRuntime.Payments;
using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.CommerceRuntime.Checkouts
{
		public class Checkout
		{
			public bool? AcceptsMarketing { get; set; }

			public decimal AmountRemainingForPayment { get; set; }

			public List<OrderAttribute> Attributes { get; set; }

			public AuditInfo AuditInfo { get; set; }

			public List<string> AvailableActions { get; set; }

			public string ChannelCode { get; set; }

			public List<string> CouponCodes { get; set; }

			public string CurrencyCode { get; set; }

			public int? CustomerAccountId { get; set; }

			public string CustomerInteractionType { get; set; }

			public string CustomerTaxId { get; set; }

			public JObject Data { get; set; }

			public List<Destination> Destinations { get; set; }

			public decimal? DutyTotal { get; set; }

			public string Email { get; set; }

			public List<ExtendedProperty> ExtendedProperties { get; set; }

			public decimal FeeTotal { get; set; }

			public List<CheckoutGrouping> Groupings { get; set; }

			public decimal HandlingSubTotal { get; set; }

			public decimal HandlingTaxTotal { get; set; }

			public decimal HandlingTotal { get; set; }

			public string Id { get; set; }

			public List<InvalidCoupon> InvalidCoupons { get; set; }

			public string IpAddress { get; set; }

			public bool? IsTaxExempt { get; set; }

			public decimal ItemLevelHandlingDiscountTotal { get; set; }

			public decimal ItemLevelProductDiscountTotal { get; set; }

			public decimal ItemLevelShippingDiscountTotal { get; set; }

			public List<OrderItem> Items { get; set; }

			public decimal ItemTaxTotal { get; set; }

			public decimal ItemTotal { get; set; }

			public string LocationCode { get; set; }

			public List<OrderNote> Notes { get; set; }

			public int? Number { get; set; }

			public List<AppliedDiscount> OrderDiscounts { get; set; }

			public decimal OrderLevelHandlingDiscountTotal { get; set; }

			public decimal OrderLevelProductDiscountTotal { get; set; }

			public decimal OrderLevelShippingDiscountTotal { get; set; }

			public string OriginalCartId { get; set; }

			public List<Payment> Payments { get; set; }

			public string PriceListCode { get; set; }

			public decimal ShippingSubTotal { get; set; }

			public decimal ShippingTaxTotal { get; set; }

			public decimal ShippingTotal { get; set; }

			public ShopperNotes ShopperNotes { get; set; }

			public int SiteId { get; set; }

			public string SourceDevice { get; set; }

			public DateTime? SubmittedDate { get; set; }

			public decimal SubTotal { get; set; }

			public JObject TaxData { get; set; }

			public int TenantId { get; set; }

			public decimal Total { get; set; }

			public string Type { get; set; }

			public string VisitId { get; set; }

			public string WebSessionId { get; set; }

		}

}