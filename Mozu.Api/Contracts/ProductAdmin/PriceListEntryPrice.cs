
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	Mozu.ProductAdmin.Contracts.PriceListEntryPrice ApiType DOCUMENT_HERE 
		///
		public class PriceListEntryPrice
		{
			///
			///Mozu.ProductAdmin.Contracts.PriceListEntryPrice listPrice ApiTypeMember DOCUMENT_HERE 
			///
			public decimal? ListPrice { get; set; }

			///
			///Mozu.ProductAdmin.Contracts.PriceListEntryPrice listPriceMode ApiTypeMember DOCUMENT_HERE 
			///
			public string ListPriceMode { get; set; }

			///
			///Mozu.ProductAdmin.Contracts.PriceListEntryPrice minQty ApiTypeMember DOCUMENT_HERE 
			///
			public int MinQty { get; set; }

			///
			///The set sale price for a product consisting of a price with a discount already applied.
			///
			public decimal? SalePrice { get; set; }

			///
			///Mozu.ProductAdmin.Contracts.PriceListEntryPrice salePriceMode ApiTypeMember DOCUMENT_HERE 
			///
			public string SalePriceMode { get; set; }

		}

}