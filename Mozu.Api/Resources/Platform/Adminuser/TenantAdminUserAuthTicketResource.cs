
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

namespace Mozu.Api.Resources.Platform.Adminuser
{
	/// <summary>
	/// Use the Admin User authentication tickets resource to generate and refresh authentication tickets that enable Mozu administrator or developer account users to access development or production tenants.
	/// </summary>
	public partial class TenantAdminUserAuthTicketResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public TenantAdminUserAuthTicketResource() 
		{
			_apiContext = null;
		}
		 public TenantAdminUserAuthTicketResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public TenantAdminUserAuthTicketResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new TenantAdminUserAuthTicketResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="tenantId">Unique identifier of the development or production tenant for which to generate the user authentication ticket.</param>
		/// <param name="userAuthInfo">The user authentication information required to generate the user authentication ticket, which consists of a user name and password.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.AdminUser.TenantAdminUserAuthTicket"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var tenantadminuserauthticket = new TenantAdminUserAuthTicket();
		///   var tenantAdminUserAuthTicket = await tenantadminuserauthticket.CreateUserAuthTicketAsync( userAuthInfo,  tenantId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.AdminUser.TenantAdminUserAuthTicket> CreateUserAuthTicketAsync(Mozu.Api.Contracts.Core.UserAuthInfo userAuthInfo, int? tenantId =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.AdminUser.TenantAdminUserAuthTicket> response;
			var client = Mozu.Api.Clients.Platform.Adminuser.TenantAdminUserAuthTicketClient.CreateUserAuthTicketClient( userAuthInfo,  tenantId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="tenantId"></param>
		/// <param name="existingAuthTicket">Properties of the authentication ticket to refresh. The refresh token is required to complete this request.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.AdminUser.TenantAdminUserAuthTicket"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var tenantadminuserauthticket = new TenantAdminUserAuthTicket();
		///   var tenantAdminUserAuthTicket = await tenantadminuserauthticket.RefreshAuthTicketAsync( existingAuthTicket,  tenantId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.AdminUser.TenantAdminUserAuthTicket> RefreshAuthTicketAsync(Mozu.Api.Contracts.AdminUser.TenantAdminUserAuthTicket existingAuthTicket, int? tenantId =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.AdminUser.TenantAdminUserAuthTicket> response;
			var client = Mozu.Api.Clients.Platform.Adminuser.TenantAdminUserAuthTicketClient.RefreshAuthTicketClient( existingAuthTicket,  tenantId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="refreshToken">Refresh token string associated with the user authentication ticket.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var tenantadminuserauthticket = new TenantAdminUserAuthTicket();
		///   await tenantadminuserauthticket.DeleteUserAuthTicketAsync( refreshToken);
		/// </code>
		/// </example>
		public virtual async Task DeleteUserAuthTicketAsync(string refreshToken, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Platform.Adminuser.TenantAdminUserAuthTicketClient.DeleteUserAuthTicketClient( refreshToken);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


	}

}


