
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

namespace Mozu.Api.Urls.Commerce.Orders
{
	public partial class DigitalPackageUrl 
	{

		/// <summary>
        /// Get Resource Url for GetAvailableDigitalPackageFulfillmentActions
        /// </summary>
        /// <param name="digitalPackageId"></param>
        /// <param name="orderId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetAvailableDigitalPackageFulfillmentActionsUrl(string orderId, string digitalPackageId)
		{
			var url = "/api/commerce/orders/{orderId}/digitalpackages/{digitalPackageId}/actions";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "digitalPackageId", digitalPackageId);
			mozuUrl.FormatUrl( "orderId", orderId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetDigitalPackage
        /// </summary>
        /// <param name="digitalPackageId"></param>
        /// <param name="orderId"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetDigitalPackageUrl(string orderId, string digitalPackageId, string responseFields =  null)
		{
			var url = "/api/commerce/orders/{orderId}/digitalpackages/{digitalPackageId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "digitalPackageId", digitalPackageId);
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for CreateDigitalPackage
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreateDigitalPackageUrl(string orderId, string responseFields =  null)
		{
			var url = "/api/commerce/orders/{orderId}/digitalpackages?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateDigitalPackage
        /// </summary>
        /// <param name="digitalPackageId"></param>
        /// <param name="orderId"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateDigitalPackageUrl(string orderId, string digitalPackageId, string responseFields =  null)
		{
			var url = "/api/commerce/orders/{orderId}/digitalpackages/{digitalPackageId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "digitalPackageId", digitalPackageId);
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteDigitalPackage
        /// </summary>
        /// <param name="digitalPackageId"></param>
        /// <param name="orderId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteDigitalPackageUrl(string orderId, string digitalPackageId)
		{
			var url = "/api/commerce/orders/{orderId}/digitalpackages/{digitalPackageId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "digitalPackageId", digitalPackageId);
			mozuUrl.FormatUrl( "orderId", orderId);
			return mozuUrl;
		}

		
	}
}

