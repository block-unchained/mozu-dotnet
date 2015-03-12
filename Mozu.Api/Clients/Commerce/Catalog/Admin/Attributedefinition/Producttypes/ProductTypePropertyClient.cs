
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

namespace Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes
{
	/// <summary>
	/// Use the Properties subresource to define how property product attributes are used for a specific product type. Product attribute definitions are unique for each associated product type.
	/// </summary>
	public partial class ProductTypePropertyClient 	{
		
		/// <summary>
		/// Retrieves a list of product property attributes defined for a product type.
		/// </summary>
		/// <param name="productTypeId">Identifier of the product type.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeInProductType"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetProperties(dataViewMode,  productTypeId);
		///   var attributeInProductTypeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType>> GetPropertiesClient(DataViewMode dataViewMode, int productTypeId)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypePropertyUrl.GetPropertiesUrl(productTypeId);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves a product property attribute definition for the specified product type.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="productTypeId">Identifier of the product type.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeInProductType"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetProperty(dataViewMode,  productTypeId,  attributeFQN,  responseFields);
		///   var attributeInProductTypeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> GetPropertyClient(DataViewMode dataViewMode, int productTypeId, string attributeFQN, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypePropertyUrl.GetPropertyUrl(productTypeId, attributeFQN, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Assigns a property attribute to the specified product type, according to the information defined in the request.
		/// </summary>
		/// <param name="productTypeId">Identifier of the product type.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="attributeInProductType">Properties of an attribute definition associated with a specific product type. When an attribute is applied to a product type, each product of that type maintains the same set of attributes.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeInProductType"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddProperty(dataViewMode,  attributeInProductType,  productTypeId,  responseFields);
		///   var attributeInProductTypeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> AddPropertyClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.AttributeInProductType attributeInProductType, int productTypeId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypePropertyUrl.AddPropertyUrl(productTypeId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType>(attributeInProductType)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Updates the definition of a property attribute for the specified product type.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="productTypeId">Identifier of the product type.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="attributeInProductType">Properties of an attribute definition associated with a specific product type. When an attribute is applied to a product type, each product of that type maintains the same set of attributes.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeInProductType"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateProperty(dataViewMode,  attributeInProductType,  productTypeId,  attributeFQN,  responseFields);
		///   var attributeInProductTypeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> UpdatePropertyClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.AttributeInProductType attributeInProductType, int productTypeId, string attributeFQN, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypePropertyUrl.UpdatePropertyUrl(productTypeId, attributeFQN, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType>(attributeInProductType)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Removes a property attribute previously defined for the specified product type.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="productTypeId">Identifier of the product type.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteProperty(dataViewMode,  productTypeId,  attributeFQN);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeletePropertyClient(DataViewMode dataViewMode, int productTypeId, string attributeFQN)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypePropertyUrl.DeletePropertyUrl(productTypeId, attributeFQN);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}


	}

}

