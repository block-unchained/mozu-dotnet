
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

namespace Mozu.Api.Clients.Commerce.Carts
{
	/// <summary>
	/// Use the Cart Extended Properties subresource to store an arbitrary number of cart extended properties such as tracking strings, marketing sources, affiliates, sales personnel/data, and so on, on a per cart basis. Each cart may have none, one, or more than one entry in the extended properties collection, and all values in the extended properties collection are represented as strings. When you create an order from a cart, all extended properties are retained from the cart and copied to the order. Refer to the subresource for more information about order extended properties.
	/// </summary>
	public partial class ExtendedPropertyClient 	{
		
		/// <summary>
		/// Retrieves a list of cart extended properties specified in the request.
		/// </summary>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetExtendedProperties();
		///   var extendedPropertyClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>> GetExtendedPropertiesClient()
		{
			var url = Mozu.Api.Urls.Commerce.Carts.ExtendedPropertyUrl.GetExtendedPropertiesUrl();
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Adds one or more specified extended properties to the carts extended properties collection.
		/// </summary>
		/// <param name="extendedProperties">Mozu.CommerceRuntime.Contracts.Commerce.ExtendedProperty ApiType DOCUMENT_HERE </param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddExtendedProperties( extendedProperties);
		///   var extendedPropertyClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>> AddExtendedPropertiesClient(List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty> extendedProperties)
		{
			var url = Mozu.Api.Urls.Commerce.Carts.ExtendedPropertyUrl.AddExtendedPropertiesUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>>(extendedProperties);
			return mozuClient;

		}

		/// <summary>
		/// Updates one or more details of the extended property specified in the request.
		/// </summary>
		/// <param name="key">Key used for metadata defined for objects, including extensible attributes, custom attributes associated with a shipping provider, and search synonyms definitions. This content may be user-defined depending on the object and usage.</param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="upsert">Any set of key value pairs to be stored in the extended properties of a cart.</param>
		/// <param name="extendedProperty">Mozu.CommerceRuntime.Contracts.Commerce.ExtendedProperty ApiType DOCUMENT_HERE </param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateExtendedProperty( extendedProperty,  key,  upsert,  responseFields);
		///   var extendedPropertyClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty> UpdateExtendedPropertyClient(Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty extendedProperty, string key, bool? upsert =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Carts.ExtendedPropertyUrl.UpdateExtendedPropertyUrl(key, upsert, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>(extendedProperty);
			return mozuClient;

		}

		/// <summary>
		/// Updates one or more details of the extended properties specified in the request.
		/// </summary>
		/// <param name="upsert">Any set of key value pairs to be stored in the extended properties of a cart.</param>
		/// <param name="extendedProperties">Mozu.CommerceRuntime.Contracts.Commerce.ExtendedProperty ApiType DOCUMENT_HERE </param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateExtendedProperties( extendedProperties,  upsert);
		///   var extendedPropertyClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>> UpdateExtendedPropertiesClient(List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty> extendedProperties, bool? upsert =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Carts.ExtendedPropertyUrl.UpdateExtendedPropertiesUrl(upsert);
			const string verb = "PUT";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>>(extendedProperties);
			return mozuClient;

		}

		/// <summary>
		/// Deletes the extended properties cart extended properties collection.
		/// </summary>
		/// <param name="keys"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteExtendedProperties( keys);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteExtendedPropertiesClient(List<string> keys)
		{
			var url = Mozu.Api.Urls.Commerce.Carts.ExtendedPropertyUrl.DeleteExtendedPropertiesUrl();
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody(keys);
			return mozuClient;

		}

		/// <summary>
		/// Deletes a specific extended property from the cart extended property collection.
		/// </summary>
		/// <param name="key"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteExtendedProperty( key);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteExtendedPropertyClient(string key)
		{
			var url = Mozu.Api.Urls.Commerce.Carts.ExtendedPropertyUrl.DeleteExtendedPropertyUrl(key);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


