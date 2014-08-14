
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Urls.Commerce.Settings
{
	public partial class LocationUsageUrl 
	{

		/// <summary>
        /// Get Resource Url for GetLocationUsages
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetLocationUsagesUrl()
		{
			var url = "/api/commerce/settings/locationUsages/";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetLocationUsage
        /// </summary>
        /// <param name="code">Code that identifies the location usage type, which is "DS" for direct ship, "SP" for in-store pickup, or "storeFinder" for store finder.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetLocationUsageUrl(string code)
		{
			var url = "/api/commerce/settings/locationUsages/{code}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "code", code);
			return mozuUrl;
		}

						/// <summary>
        /// Get Resource Url for UpdateLocationUsage
        /// </summary>
        /// <param name="code">Code that identifies the location usage type, which is "DS" for direct ship, "SP" for in-store pickup, or "storeFinder" for store finder.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateLocationUsageUrl(string code)
		{
			var url = "/api/commerce/settings/locationUsages/{code}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "code", code);
			return mozuUrl;
		}

				
	}
}

