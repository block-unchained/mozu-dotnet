
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


namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	The localized product content in the language specified by the LocaleCode.
		///
		public class ProductLocalizedContent
		{
			public string LocaleCode { get; set; }

			public string ProductFullDescription { get; set; }

			public List<ProductLocalizedImage> ProductImages { get; set; }

			public string ProductName { get; set; }

			public string ProductShortDescription { get; set; }

		}

}