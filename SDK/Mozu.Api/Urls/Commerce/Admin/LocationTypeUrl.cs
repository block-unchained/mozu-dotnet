
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

namespace Mozu.Api.Urls.Commerce.Admin
{
	public partial class LocationTypeUrl 
	{

		/// <summary>
        /// Get Resource Url for GetLocationTypes
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetLocationTypesUrl()
		{
			var url = "/api/commerce/admin/locationtypes/";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetLocationType
        /// </summary>
        /// <param name="locationTypeCode">The user-defined code that identifies the location type.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetLocationTypeUrl(string locationTypeCode)
		{
			var url = "/api/commerce/admin/locationtypes/{locationTypeCode}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "locationTypeCode", locationTypeCode);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for AddLocationType
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddLocationTypeUrl()
		{
			var url = "/api/commerce/admin/locationtypes/";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateLocationType
        /// </summary>
        /// <param name="locationTypeCode">The user-defined code that identifies the location type.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateLocationTypeUrl(string locationTypeCode)
		{
			var url = "/api/commerce/admin/locationtypes/{locationTypeCode}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "locationTypeCode", locationTypeCode);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteLocationType
        /// </summary>
        /// <param name="locationTypeCode">User-defined code used to identify the location type.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteLocationTypeUrl(string locationTypeCode)
		{
			var url = "/api/commerce/admin/locationtypes/{locationTypeCode}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "locationTypeCode", locationTypeCode);
			return mozuUrl;
		}

		
	}
}

