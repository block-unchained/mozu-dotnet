
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.ProductRuntime
{
		///
		///	Properties of a component product in a product bundle. A product bundle can represent either a collection of multiple products sold as a single entity, or a collection of the same product sold as a package. For example, a 10-pack of socks.
		///
		public class BundledProduct
		{
			///
			///Localizable product content defined for the product bundle. System-supplied and read only.
			///
			public ProductContent Content { get; set; }

			///
			///When the goodsType is DigitalCredit this value is populated to indicate the value of the credit. This is used to create store credit in the fulfillment of gift cards.
			///
			public decimal? CreditValue { get; set; }

			///
			///This is the goods type of the product. Possible values are â€œPhysical,â€ and â€œDigitalCreditâ€. This comes from the productType of the product. Products are defaulted to a Physical goodsType. Gift cards have a goodsType of DigitalCredit.
			///
			public string GoodsType { get; set; }

			///
			///This contains the inventory information about bundled products. If it manages stock, it specifies what the out of stock behavior is.
			///
			public ProductInventoryInfo InventoryInfo { get; set; }

			///
			///If true, the component product of the bundle should not ship in a package with the rest of the product bundle, and should ship in a package by itself. System-supplied and read only.
			///
			public bool? IsPackagedStandAlone { get; set; }

			///
			///Dimensions of the packaged product.
			///
			public PackageMeasurements Measurements { get; set; }

			///
			///BundledProducts result from a static bundle or are dynamically added as a result of the shopper selecting products as extras. When the bundled item is dynamic, it includes the attribute's fully qualified name of the extra that it came from. When optionAttributeFQN is null, the bundled item was statically defined, when not null, the item came from an extra selection.
			///
			public string OptionAttributeFQN { get; set; }

			///
			///Properties of a value associated with a product option attribute.
			///
			public object OptionValue { get; set; }

			///
			///Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.
			///
			public string ProductCode { get; set; }

			public string ProductType { get; set; }

			///
			///The quantity of the component product in the product bundle. System-supplied and read only.
			///
			public int Quantity { get; set; }

		}

}