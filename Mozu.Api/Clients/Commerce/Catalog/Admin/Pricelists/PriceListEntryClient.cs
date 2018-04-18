
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

namespace Mozu.Api.Clients.Commerce.Catalog.Admin.Pricelists
{
	/// <summary>
	/// 
	/// </summary>
	public partial class PriceListEntryClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="currencyCode"></param>
		/// <param name="priceListCode"></param>
		/// <param name="productCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="startDate"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.PriceListEntry"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPriceListEntry( priceListCode,  productCode,  currencyCode,  startDate,  responseFields);
		///   var priceListEntryClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.PriceListEntry> GetPriceListEntryClient(string priceListCode, string productCode, string currencyCode, DateTime? startDate =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Pricelists.PriceListEntryUrl.GetPriceListEntryUrl(priceListCode, productCode, currencyCode, startDate, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.PriceListEntry>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="priceListCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.PriceListEntryCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPriceListEntries( priceListCode,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		///   var priceListEntryCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.PriceListEntryCollection> GetPriceListEntriesClient(string priceListCode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Pricelists.PriceListEntryUrl.GetPriceListEntriesUrl(priceListCode, startIndex, pageSize, sortBy, filter, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.PriceListEntryCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="priceListCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="priceListEntryIn"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.PriceListEntry"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddPriceListEntry( priceListEntryIn,  priceListCode,  responseFields);
		///   var priceListEntryClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.PriceListEntry> AddPriceListEntryClient(Mozu.Api.Contracts.ProductAdmin.PriceListEntry priceListEntryIn, string priceListCode, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Pricelists.PriceListEntryUrl.AddPriceListEntryUrl(priceListCode, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.PriceListEntry>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.PriceListEntry>(priceListEntryIn);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="currencyCode"></param>
		/// <param name="priceListCode"></param>
		/// <param name="productCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="startDate"></param>
		/// <param name="priceListEntryIn"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.PriceListEntry"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdatePriceListEntry( priceListEntryIn,  priceListCode,  productCode,  currencyCode,  startDate,  responseFields);
		///   var priceListEntryClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.PriceListEntry> UpdatePriceListEntryClient(Mozu.Api.Contracts.ProductAdmin.PriceListEntry priceListEntryIn, string priceListCode, string productCode, string currencyCode, DateTime? startDate =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Pricelists.PriceListEntryUrl.UpdatePriceListEntryUrl(priceListCode, productCode, currencyCode, startDate, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.PriceListEntry>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.PriceListEntry>(priceListEntryIn);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="currencyCode"></param>
		/// <param name="priceListCode"></param>
		/// <param name="productCode"></param>
		/// <param name="startDate"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeletePriceListEntry( priceListCode,  productCode,  currencyCode,  startDate);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeletePriceListEntryClient(string priceListCode, string productCode, string currencyCode, DateTime? startDate =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Pricelists.PriceListEntryUrl.DeletePriceListEntryUrl(priceListCode, productCode, currencyCode, startDate);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


