
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
		///	The properties of a product, referenced and used by carts, orders, wish lists, and returns.
		///
		public class Product
		{
			public List<Discount> ApplicableDiscounts { get; set; }

			public AuditInfo AuditInfo { get; set; }

			public string BaseProductCode { get; set; }

			///
			///Properties of a collection of component products that make up a single product bundle with its own product code. Tenants can define product bundles for any product type that supports the Bundle product usage.
			///
			public List<BundledProduct> BundledProducts { get; set; }

			public ProductLocalizedContent Content { get; set; }

			public List<ProductExtra> Extras { get; set; }

			///
			///List of supported types of fulfillment for the product or variation. The types include direct ship, in-store pickup, or both.
			///
			public List<string> FulfillmentTypesSupported { get; set; }

			public bool HasConfigurableOptions { get; set; }

			public bool HasStandAloneOptions { get; set; }

			public ProductInventoryInfo InventoryInfo { get; set; }

			public bool? IsPackagedStandAlone { get; set; }

			public bool? IsRecurring { get; set; }

			public bool? IsTaxable { get; set; }

			public bool? IsValidForProductType { get; set; }

			public bool IsVariation { get; set; }

			public int? MasterCatalogId { get; set; }

			public List<ProductOption> Options { get; set; }

			public Measurement PackageHeight { get; set; }

			public Measurement PackageLength { get; set; }

			public Measurement PackageWeight { get; set; }

			public Measurement PackageWidth { get; set; }

			public ProductPrice Price { get; set; }

			///
			///Properties that describe the behavior the system uses when determining the price of products.
			///
			public ProductPricingBehaviorInfo PricingBehavior { get; set; }

			public string ProductCode { get; set; }

			public List<ProductInCatalogInfo> ProductInCatalogs { get; set; }

			public int? ProductSequence { get; set; }

			public int? ProductTypeId { get; set; }

			///
			///The usage type that applies to this product, which is Standard (a single product without configurable options), Configurable (a product that includes configurable option attributes), Bundle (a collection of products sold as a single entity), or Component (an invididual product that represents a component in a bundle).
			///
			public string ProductUsage { get; set; }

			public List<ProductProperty> Properties { get; set; }

			public ProductPublishingInfo PublishingInfo { get; set; }

			public ProductLocalizedSEOContent SeoContent { get; set; }

			public int? ShippingClassId { get; set; }

			public string StandAlonePackageType { get; set; }

			///
			///Supplier-defined properties assigned for the product.
			///
			public ProductSupplierInfo SupplierInfo { get; set; }

			public string Upc { get; set; }

			public string VariationKey { get; set; }

			public List<ProductVariationOption> VariationOptions { get; set; }

		}

}