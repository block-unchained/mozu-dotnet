
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

namespace Mozu.Api.Clients.Platform
{
	/// <summary>
	/// Use the tenants resource to manage information about a  tenant.
	/// </summary>
	public partial class TenantClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="tenantId">Unique identifier of the development or production tenant for which to generate the user authentication ticket.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Tenant.Tenant"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetTenant( tenantId,  responseFields);
		///   var tenantClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Tenant.Tenant> GetTenantClient(int tenantId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.TenantUrl.GetTenantUrl(tenantId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Tenant.Tenant>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


