
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

namespace Mozu.Api.Urls.Commerce.Returns
{
	public partial class OrderNoteUrl 
	{

		/// <summary>
        /// Get Resource Url for GetReturnNotes
        /// </summary>
        /// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetReturnNotesUrl(string returnId)
		{
			var url = "/api/commerce/returns/{returnId}/notes";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "returnId", returnId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetReturnNote
        /// </summary>
        /// <param name="noteId">Unique identifier of a particular note to retrieve.</param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetReturnNoteUrl(string returnId, string noteId, string responseFields =  null)
		{
			var url = "/api/commerce/returns/{returnId}/notes/{noteId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "noteId", noteId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "returnId", returnId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for CreateReturnNote
        /// </summary>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreateReturnNoteUrl(string returnId, string responseFields =  null)
		{
			var url = "/api/commerce/returns/{returnId}/notes?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "returnId", returnId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateReturnNote
        /// </summary>
        /// <param name="noteId">Unique identifier of a particular note to retrieve.</param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateReturnNoteUrl(string returnId, string noteId, string responseFields =  null)
		{
			var url = "/api/commerce/returns/{returnId}/notes/{noteId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "noteId", noteId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "returnId", returnId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteReturnNote
        /// </summary>
        /// <param name="noteId">Unique identifier of a particular note to retrieve.</param>
        /// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteReturnNoteUrl(string returnId, string noteId)
		{
			var url = "/api/commerce/returns/{returnId}/notes/{noteId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "noteId", noteId);
			mozuUrl.FormatUrl( "returnId", returnId);
			return mozuUrl;
		}

		
	}
}

