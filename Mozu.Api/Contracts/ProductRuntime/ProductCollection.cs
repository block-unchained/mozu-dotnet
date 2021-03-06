
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
		///	The container for a set of products.
		///
		public class ProductCollection
		{
			public List<Product> Items { get; set; }

			///
			///This parameter is associated with deep paging. If you started a deep paged request by specifying ,  returns an encoded value for the . In your most immediate subsequent request, set  to the same value you received for  to continue paging. When  is null, you've reached the end of paged results.
			///
			public string NextCursorMark { get; set; }

			public int PageCount { get; set; }

			public int PageSize { get; set; }

			public int StartIndex { get; set; }

			public int TotalCount { get; set; }

		}

}