
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
		///	Properties of an inventory definition that defines the level of inventory for a specific product at a given location.
		///
		public class LocationInventory
		{
			///
			///The unique, user-defined code that identifies a location. This location can be the location where the order was entered, location for newly in-stock products, and where products are returned.
			///
			public string LocationCode { get; set; }

			///
			///The unique, user-defined  product code of a product, used throughout Mozu to reference and associate to a product.
			///
			public string ProductCode { get; set; }

			///
			///Mozu.ProductRuntime.Contracts.LocationInventory softStockAvailable ApiTypeMember DOCUMENT_HERE 
			///
			public int? SoftStockAvailable { get; set; }

			///
			///The stock level for the associated product currently available, at specified locations, and based on the number of pending product reservations as applicable. System-supplied and read only.
			///
			public int? StockAvailable { get; set; }

		}

}