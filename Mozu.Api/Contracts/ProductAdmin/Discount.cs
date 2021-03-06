
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

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	Name of the discount added and applied to a shopping cart and order for a shopper's purchase. 
		///
		public class Discount
		{
			public decimal? Amount { get; set; }

			public string AmountType { get; set; }

			public AuditInfo AuditInfo { get; set; }

			///
			///Signifies that the discount is not referenced and can be hard deleted
			///
			public bool CanBeDeleted { get; set; }

			///
			///canBeStackedUpon ApiType DOCUMENT_HERE 
			///
			public bool? CanBeStackedUpon { get; set; }

			///
			///List of conditions that must be met for the discount to apply.
			///
			public DiscountCondition Conditions { get; set; }

			public DiscountLocalizedContent Content { get; set; }

			public int? CurrentRedemptionCount { get; set; }

			///
			///True if the discount should not apply to orders with multiple shipments. For more information, refer to the topic on [multiple shipments](https://www.mozu.com/docs/Guides/orders/multi-ship.htm#effect_on_discounts).
			///
			public bool? DoesNotApplyToMultiShipToOrders { get; set; }

			///
			///Determines whether or not a discount applies to a items with a sale price. Applicable on order and line item discounts. For line items, when this is true, the discount will be disqualified. For order level discounts, when true, the discount will not be applied to those items have a sale price.
			///
			public bool? DoesNotApplyToProductsWithSalePrice { get; set; }

			///
			///If true, this discount does not apply to a line item product with a defined sale price. The default is false, which applies the discount to products with and without defined sale prices.
			///
			public bool? DoesNotApplyToSalePrice { get; set; }

			public bool HasPurchaseConditions { get; set; }

			public int? Id { get; set; }

			///
			///Products receiving a price from a price list specified here or a child of a specified price list can be discounted.
			///
			public List<string> IncludedPriceLists { get; set; }

			///
			///This field is read-only and specifies whether the discount condition is one product or category, and matches the discount target.
			///
			public bool? IsBxGx { get; set; }

			///
			///Maximum impact this discount can apply on a single order. Must be either null or greater than zero.
			///
			public decimal? MaximumDiscountImpactPerOrder { get; set; }

			///
			///Maximum impact this discount can apply on a single line item. Must be either null or greater than zero.
			///
			public decimal? MaximumDiscountImpactPerRedemption { get; set; }

			///
			///Maximum number of redemptions allowed per order. If null, defaults to unlimited.
			///
			public int? MaximumRedemptionsPerOrder { get; set; }

			///
			///The maximum number of times an individual shopper can redeem the discount.
			///
			public int? MaximumUsesPerUser { get; set; }

			///
			///preventLineItemShippingDiscounts ApiType DOCUMENT_HERE 
			///
			public bool? PreventLineItemShippingDiscounts { get; set; }

			///
			///preventOrderProductDiscounts ApiType DOCUMENT_HERE 
			///
			public bool? PreventOrderProductDiscounts { get; set; }

			///
			///preventOrderShippingDiscounts ApiType DOCUMENT_HERE 
			///
			public bool? PreventOrderShippingDiscounts { get; set; }

			public string PurchaseRequirementType { get; set; }

			public string Scope { get; set; }

			///
			///stackingLayer ApiType DOCUMENT_HERE 
			///
			public int? StackingLayer { get; set; }

			public string Status { get; set; }

			public DiscountTarget Target { get; set; }

			///
			///thresholdMessage ApiType DOCUMENT_HERE 
			///
			public ThresholdMessage ThresholdMessage { get; set; }

		}

}