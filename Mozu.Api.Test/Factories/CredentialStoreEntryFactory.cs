//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#region Usings Setup

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using Mozu.Api;
using Mozu.Api.Security;
using Mozu.Api.Test.Helpers;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using System.Threading;


#endregion

namespace Mozu.Api.Test.Factories
{
	/// <summary>
	/// The CredentialStore resource allows you to encrypt and store sensitive data on your tenant. You can then decrypt and access that data using an Arc.js application, as described in the Arc.js [Programming Patterns](https://www.mozu.com/docs/developer/arcjs-guides/programming-patterns.htm#securely_store_and_access_sensitive_data) topic.
	/// </summary>
	public partial class CredentialStoreEntryFactory : BaseDataFactory
	{

		/// <summary> 
		/// Encrypts and stores data contained in the  JSON object. You can decrypt and access the secured data using an Arc.js application, as described in the Arc.js [Programming Patterns](https://www.mozu.com/docs/developer/arcjs-guides/programming-patterns.htm#securely_store_and_access_sensitive_data) topic.
		/// <example> 
		///  <code> 
		/// var result = CredentialStoreEntryFactory.StoreCredentials(handler : handler,  credentials :  credentials,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<void/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static void StoreCredentials(ServiceClientMessageHandler handler, 
 		Mozu.Api.Contracts.InstalledApplications.CredentialStoreEntry credentials, 
		 HttpStatusCode expectedCode = HttpStatusCode.NoContent, HttpStatusCode successCode = HttpStatusCode.NoContent)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Platform.Extensions.CredentialStoreEntryClient.StoreCredentialsClient(
				 credentials :  credentials		);
			try
			{
				apiClient.WithContext(handler.ApiContext).ExecuteAsync(default(CancellationToken)).Wait();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
			}
			var noResponse = ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  

	}

}


