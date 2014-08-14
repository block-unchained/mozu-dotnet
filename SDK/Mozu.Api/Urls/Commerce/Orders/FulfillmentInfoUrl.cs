
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
	public partial class FulfillmentInfoUrl 
	{

		/// <summary>
        /// Get Resource Url for GetFulfillmentInfo
        /// </summary>
        /// <param name="draft">If true, retrieve the draft version of the order's fulfillment information, which might include uncommitted changes.</param>
        /// <param name="orderId">Unique identifier of the order.</param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetFulfillmentInfoUrl(string orderId, bool? draft =  null, string responseFields =  null)
		{
			var url = "/api/commerce/orders/{orderId}/fulfillmentinfo?draft={draft}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "draft", draft);
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

						/// <summary>
        /// Get Resource Url for SetFulFillmentInfo
        /// </summary>
        /// <param name="orderId">Unique identifier of the order.</param>
        /// <param name="responseFields"></param>
        /// <param name="updateMode">Specifies whether to set the fulfillment information by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal," "ApplyToDraft," or "ApplyAndCommit."</param>
        /// <param name="version">System-supplied integer that represents the current version of the order, which prevents users from unintentionally overriding changes to the order. When a user performs an operation for a defined order, the system validates that the version of the updated order matches the version of the order on the server. After the operation completes successfully, the system increments the version number by one.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl SetFulFillmentInfoUrl(string orderId, string updateMode =  null, string version =  null, string responseFields =  null)
		{
			var url = "/api/commerce/orders/{orderId}/fulfillmentinfo?updatemode={updateMode}&version={version}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "updateMode", updateMode);
			mozuUrl.FormatUrl( "version", version);
			return mozuUrl;
		}

				
	}
}

