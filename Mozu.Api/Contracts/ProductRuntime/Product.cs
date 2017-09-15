
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


namespace Mozu.Api.Contracts.ProductRuntime
{
		///
		///	Properties of the product that appears on a designated storefront.
		///
		public class Product
		{
			///
			///List of shipping discounts that can be applied to the product.
			///
			public List<Discount> AvailableShippingDiscounts { get; set; }

			///
			///Properties of a collection of component products that make up a single product bundle with its own product code.
			///
			public List<BundledProduct> BundledProducts { get; set; }

			public DateTime? CatalogEndDate { get; set; }

			public DateTime? CatalogStartDate { get; set; }

			///
			///List of categories associated with the product.
			///
			public List<Category> Categories { get; set; }

			///
			///Complex type that contains content for a language specified by LocaleCode.
			///
			public ProductContent Content { get; set; }

			///
			///Date and time when the entity was created, represented in UTC Date/Time.
			///
			public DateTime CreateDate { get; set; }

			public DateTime? DateFirstAvailableInCatalog { get; set; }

			public int? DaysAvailableInCatalog { get; set; }

			///
			///The list of fulfillment types the product supports.
			///
			public List<string> FulfillmentTypesSupported { get; set; }

			public string GoodsType { get; set; }

			///
			///Array of active inventory level information associated with the product.
			///
			public ProductInventoryInfo InventoryInfo { get; set; }

			///
			///If true, the product is marked as available for sale. Setting a product to IsActive = false will prevent it from being shown on the customer facing storefront.
			///
			public bool? IsActive { get; set; }

			///
			///If true, this product cannot ship in a package with other products and must ship in a package by itself.
			///
			public bool? IsPackagedStandAlone { get; set; }

			///
			///If true, the product can be purchased or fulfilled at regular intervals such as a monthly billing cycle or a digital or physical subscription.
			///
			public bool IsRecurring { get; set; }

			///
			///If true, the entity is subject to tax based on the relevant tax rate.
			///
			public bool IsTaxable { get; set; }

			///
			///Dimensions of the packaged product.
			///
			public PackageMeasurements Measurements { get; set; }

			///
			///The manufacturer part number defined for the product.
			///
			public string MfgPartNumber { get; set; }

			///
			///The list of manufacturer part numbers defined for the product.
			///
			public List<string> MfgPartNumbers { get; set; }

			///
			///The list of options set up in product admin.
			///
			public List<ProductOption> Options { get; set; }

			///
			///Unit price that the tenant intends to sell the product if no sale price is set.
			///
			public ProductPrice Price { get; set; }

			///
			///For products with options that vary the cost of the product, the range between lowest and highest possible price of the product based on the current selection of options.
			///
			public ProductPriceRange PriceRange { get; set; }

			///
			///Describes the behavior the system uses when determining the price of the product.
			///
			public ProductPricingBehaviorInfo PricingBehavior { get; set; }

			///
			///Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.
			///
			public string ProductCode { get; set; }

			///
			///Integer that represents the sequential order of the product.
			///
			public int? ProductSequence { get; set; }

			///
			///A product type is like a product template that can be reused.
			///
			public string ProductType { get; set; }

			public int? ProductTypeId { get; set; }

			///
			///The usage type that applies to this product, which is Standard (a single product without configurable options), Configurable (a product that includes configurable option attributes), Bundle (a collection of products sold as a single entity), or Component (an invididual product that represents a component in a bundle).
			///
			public string ProductUsage { get; set; }

			///
			///The list of product property attributes defined for the product.
			///
			public List<ProductProperty> Properties { get; set; }

			///
			///The publishing state of the product definition in the master catalog, which is "New", "Draft", or "Live".
			///
			public string PublishState { get; set; }

			///
			///The current state of the configured product determines whether or not the product is eligible for purchase. Products with options are only purchasable if the shopper has selected all required options. If the product is not ready for purchase, a message lists missing options that are required.
			///
			public ProductPurchasableState PurchasableState { get; set; }

			///
			///The universal product code associated with the product. The UPC of a product is unique across all sales channels.
			///
			public string Upc { get; set; }

			///
			///The list of universal product codes defined for the product.
			///
			public List<string> UpCs { get; set; }

			public DateTime UpdateDate { get; set; }

			public List<string> ValidPriceLists { get; set; }

			///
			///Product code that represents the product variation selected based on the option values the shopper entered.
			///
			public string VariationProductCode { get; set; }

			public List<VariationSummary> Variations { get; set; }

			public List<ProductVolumePrice> VolumePriceBands { get; set; }

			public ProductPriceRange VolumePriceRange { get; set; }

		}

}