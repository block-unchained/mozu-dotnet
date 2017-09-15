
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
using Mozu.Api.Contracts.CommerceRuntime.Products;
using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.CommerceRuntime.Wishlists
{
		///
		///	Properties of an item in a shopper wish list.
		///
		public class WishlistItem
		{
			public decimal? AdjustedLineItemSubtotal { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///Shopper-entered comments for an item in a wish list.
			///
			public string Comments { get; set; }

			public JObject Data { get; set; }

			///
			///The subtotal of the wishlist item including any applied discount calculations. This property value is not calculated at this time and is reserved for future functionality.
			///
			public decimal? DiscountedTotal { get; set; }

			///
			///Estimated amount of discounts applied to the item in the wish list, which is system-supplied and read-only.  This property value is not calculated at this time and is reserved for future functionality.
			///
			public decimal? DiscountTotal { get; set; }

			///
			///The extended total of an item in a wish list. This property value is not calculated at this time and is reserved for future functionality.
			///
			public decimal? ExtendedTotal { get; set; }

			///
			///The fee total of an item in a wish list. This property value is not calculated at this time and is reserved for future functionality.
			///
			public decimal? FeeTotal { get; set; }

			public decimal? HandlingAmount { get; set; }

			///
			///Unique identifier of an item in a shopper wish list.
			///
			public string Id { get; set; }

			///
			///If true, the item in the wish list is a recurring purchase, such as a subscription. This property is reserved for future use and is system-supplied and read only.
			///
			public bool? IsRecurring { get; set; }

			///
			///If true, the item in a wish list is subject to sales tax.
			///
			public bool? IsTaxable { get; set; }

			///
			///The total sales tax of the item in the wish list. This property value is not calculated at this time, and is reserved for future functionality.
			///
			public decimal? ItemTaxTotal { get; set; }

			public int? LineId { get; set; }

			///
			///Language used for the entity. Currently, only "en-US" is supported.
			///
			public string LocaleCode { get; set; }

			///
			///User-defined string that indicates the priority of an item in a wish list. Possible values are Lowest, Low, Medium, High, and Highest.
			///
			public string PriorityType { get; set; }

			///
			///The properties of the product associated with an item in a wish list.
			///
			public Product Product { get; set; }

			///
			///List of product discounts that apply to the item in the wishlist.
			///
			public AppliedLineItemProductDiscount ProductDiscount { get; set; }

			///
			///Array of product discounts applicable to an item in a wish list. This property is not used at this time and is reserved for future functionality.
			///
			public List<AppliedLineItemProductDiscount> ProductDiscounts { get; set; }

			///
			///The status of the item that indicates whether an item in a wish list can be purchased. Possible values are "Purchasable" which indicates the item can be purchased, "NotPurchasable" which indicates the item is out of stock or otherwise unavailable, or "Missing" which indicates the item has been deleted from the catalog since it was added to the wish list.
			///
			public string PurchasableStatusType { get; set; }

			///
			///The quantity of an item in a shopper wish list.
			///
			public int Quantity { get; set; }

			public decimal? ShippingAmountBeforeDiscountsAndAdjustments { get; set; }

			///
			///Array of shipping discounts applicable for an item in a wish list. This property is not used at this time and is reserved for future functionality.
			///
			public List<AppliedLineItemShippingDiscount> ShippingDiscounts { get; set; }

			///
			///The total amount of tax levied against shipping charges for an item in a wish list. This property is not calculated at this time and is reserved for future functionality.
			///
			public decimal? ShippingTaxTotal { get; set; }

			///
			///The total amount of shipping for an item in a wish list. This property is not calculated at this time and is reserved for future functionality.
			///
			public decimal? ShippingTotal { get; set; }

			///
			///The subtotal of an item in a wish list. This property is not calculated at this time and is reserved for future functionality.
			///
			public decimal? Subtotal { get; set; }

			///
			///The taxable total of an item in a wish list. This property is not calculated at this time and is reserved for future functionality.
			///
			public decimal? TaxableTotal { get; set; }

			public JObject TaxData { get; set; }

			///
			///The total of an item in a wish list. This property is not calculated at this time and is reserved for future functionality.
			///
			public decimal? Total { get; set; }

			public decimal? TotalWithoutWeightedShippingAndHandling { get; set; }

			public decimal? TotalWithWeightedShippingAndHandling { get; set; }

			///
			///The unit price of an item in a wish list. This property is not calculated at this time and is reserved for future functionality.
			///
			public CommerceUnitPrice UnitPrice { get; set; }

			public decimal? WeightedOrderAdjustment { get; set; }

			public decimal? WeightedOrderDiscount { get; set; }

			public decimal? WeightedOrderDuty { get; set; }

			public decimal? WeightedOrderHandlingAdjustment { get; set; }

			public decimal? WeightedOrderHandlingFee { get; set; }

			public decimal? WeightedOrderHandlingFeeDiscount { get; set; }

			public decimal? WeightedOrderHandlingFeeTax { get; set; }

			public decimal? WeightedOrderShipping { get; set; }

			public decimal? WeightedOrderShippingDiscount { get; set; }

			public decimal? WeightedOrderShippingManualAdjustment { get; set; }

			public decimal? WeightedOrderShippingTax { get; set; }

			public decimal? WeightedOrderTax { get; set; }

		}

}