
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

namespace Mozu.Api.Clients.Commerce.Catalog.Admin.Products
{
	/// <summary>
	/// Use the Options resource to configure the option attributes and vocabulary values for an individual product associated with the product type that uses the option attribute. Options are used to generate variations of a product.
	/// </summary>
	public partial class ProductOptionClient 	{
		
		/// <summary>
		/// Retrieves a list of all option attributes configured for the product specified in the request.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductOption"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetOptions(dataViewMode,  productCode);
		///   var productOptionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductOption>> GetOptionsClient(DataViewMode dataViewMode, string productCode)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductOptionUrl.GetOptionsUrl(productCode);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductOption>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the details of an option attribute configuration for the specified product.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductOption"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetOption(dataViewMode,  productCode,  attributeFQN,  responseFields);
		///   var productOptionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductOption> GetOptionClient(DataViewMode dataViewMode, string productCode, string attributeFQN, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductOptionUrl.GetOptionUrl(productCode, attributeFQN, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductOption>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Configures an option attribute for the product specified in the request.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields"></param>
		/// <param name="productOption">Properties of the option attribute to define for the product.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductOption"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddOption(dataViewMode,  productOption,  productCode,  responseFields);
		///   var productOptionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductOption> AddOptionClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.ProductOption productOption, string productCode, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductOptionUrl.AddOptionUrl(productCode, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductOption>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.ProductOption>(productOption)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Updates one or more properties of an option attribute configured for a product.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields"></param>
		/// <param name="productOption">Properties of the product option attribute configuration to update.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductOption"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateOption(dataViewMode,  productOption,  productCode,  attributeFQN,  responseFields);
		///   var productOptionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductOption> UpdateOptionClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.ProductOption productOption, string productCode, string attributeFQN, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductOptionUrl.UpdateOptionUrl(productCode, attributeFQN, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductOption>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.ProductOption>(productOption)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Deletes the configuration of an option attribute for the product specified in the request.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteOption(dataViewMode,  productCode,  attributeFQN);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteOptionClient(DataViewMode dataViewMode, string productCode, string attributeFQN)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductOptionUrl.DeleteOptionUrl(productCode, attributeFQN);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}


	}

}


