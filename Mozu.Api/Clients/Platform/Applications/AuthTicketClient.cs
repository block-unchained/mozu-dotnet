
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
using Mozu.Api.Security;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Threading;

namespace Mozu.Api.Clients.Platform.Applications
{
	/// <summary>
	/// Use this resource to manage authentication tickets for your applications.
	/// </summary>
	public partial class AuthTicketClient 	{
		
		/// <summary>
		/// Generate an authentication ticket for an application.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="appAuthInfo">Authentication information required to generate an authentication ticket includes the application id and the shared secret.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.AppDev.AuthTicket"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AuthenticateApp( appAuthInfo,  responseFields);
		///   var authTicketClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.AppDev.AuthTicket> AuthenticateAppClient(Mozu.Api.Contracts.AppDev.AppAuthInfo appAuthInfo, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.Applications.AuthTicketUrl.AuthenticateAppUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.AppDev.AuthTicket>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.AppDev.AppAuthInfo>(appAuthInfo);
			return mozuClient;

		}

		/// <summary>
		/// Refreshes the application's authentication ticket and generates a new access token by providing the refresh token string.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="authTicketRequest">The refresh token string required to update the application authentication ticket.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.AppDev.AuthTicket"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=RefreshAppAuthTicket( authTicketRequest,  responseFields);
		///   var authTicketClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.AppDev.AuthTicket> RefreshAppAuthTicketClient(Mozu.Api.Contracts.AppDev.AuthTicketRequest authTicketRequest, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.Applications.AuthTicketUrl.RefreshAppAuthTicketUrl(responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.AppDev.AuthTicket>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.AppDev.AuthTicketRequest>(authTicketRequest);
			return mozuClient;

		}

		/// <summary>
		/// Deletes an authentication for an application based on the specified refresh token.
		/// </summary>
		/// <param name="refreshToken">The refresh token string from the application's authentication ticket.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteAppAuthTicket( refreshToken);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteAppAuthTicketClient(string refreshToken)
		{
			var url = Mozu.Api.Urls.Platform.Applications.AuthTicketUrl.DeleteAppAuthTicketUrl(refreshToken);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


