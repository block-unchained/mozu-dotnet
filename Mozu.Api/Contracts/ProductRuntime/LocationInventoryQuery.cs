
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
		///	Properties for the product location inventory provided for queries to locate products by their location.
		///
		public class LocationInventoryQuery
		{
			///
			///List of location codes to associate with the location usage. At this time, you can only specify one location code in the request for the direct ship location usage type.
			///
			public List<string> LocationCodes { get; set; }

			///
			///List of product codes of associated products, used for pending product changes to publish or delete and returned in a product inventory location query.
			///
			public List<string> ProductCodes { get; set; }

		}

}