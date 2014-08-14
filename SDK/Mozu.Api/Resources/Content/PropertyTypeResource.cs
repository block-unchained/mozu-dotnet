
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

namespace Mozu.Api.Resources.Content
{
	/// <summary>
	/// Use the property types subresource to manage content properties.
	/// </summary>
	public partial class PropertyTypeResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		private readonly DataViewMode _dataViewMode;
		
		public PropertyTypeResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
			_dataViewMode = DataViewMode.Live;
		}
		public PropertyTypeResource(IApiContext apiContext, DataViewMode dataViewMode) 
		{
			_apiContext = apiContext;
			_dataViewMode = dataViewMode;
		}
				
		/// <summary>
		/// 
		/// </summary>
		/// <param name="pageSize"></param>
		/// <param name="responseFields"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.PropertyTypeCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var propertytype = new PropertyType();
		///   var propertyTypeCollection = propertytype.GetPropertyTypes(_dataViewMode,  pageSize,  startIndex,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Content.PropertyTypeCollection GetPropertyTypes(int? pageSize =  null, int? startIndex =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.PropertyTypeCollection> response;
			var client = Mozu.Api.Clients.Content.PropertyTypeClient.GetPropertyTypesClient(_dataViewMode,  pageSize,  startIndex,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Content.PropertyTypeCollection> GetPropertyTypesAsync(int? pageSize =  null, int? startIndex =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.PropertyTypeCollection> response;
			var client = Mozu.Api.Clients.Content.PropertyTypeClient.GetPropertyTypesClient(_dataViewMode,  pageSize,  startIndex,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="propertyTypeName"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.PropertyType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var propertytype = new PropertyType();
		///   var propertyType = propertytype.GetPropertyType(_dataViewMode,  propertyTypeName,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Content.PropertyType GetPropertyType(string propertyTypeName, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.PropertyType> response;
			var client = Mozu.Api.Clients.Content.PropertyTypeClient.GetPropertyTypeClient(_dataViewMode,  propertyTypeName,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Content.PropertyType> GetPropertyTypeAsync(string propertyTypeName, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.PropertyType> response;
			var client = Mozu.Api.Clients.Content.PropertyTypeClient.GetPropertyTypeClient(_dataViewMode,  propertyTypeName,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


